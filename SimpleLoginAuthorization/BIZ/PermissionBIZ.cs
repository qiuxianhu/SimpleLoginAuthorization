using SimpleLoginAuthorization.Common;
using SimpleLoginAuthorization.DB;
using SimpleLoginAuthorization.DB.BLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLoginAuthorization.BIZ
{

    public static class PermissionBIZ
    {
        public const string USER_PERMISSION_CACHE_SIGNALS = "USER_PERMISSION_CACHE_SIGNALS";
        public const string USER_PERMISSION_CACHE_KEY_ = "USER_PERMISSION_CACHE_KEY_";
        //Guid只读实例，其值保证均为0
        public const string GUID_EMPTY_VALUE = "00000000-0000-0000-0000-000000000000";
        #region Permission
        public static List<Account_permission> GetPermissionAll()
        {
            return Account_permissionBLL.Select();
        }
        public static bool HasPermission(int userID,string[] paths,DateTime time)
        {
            bool flag = true;
            //权限表里面的所有权限
            List<Account_permission> allPermissionList = GetPermissionAll();
            // 当前用户所拥有的所有的权限
            List<Account_permission> list = GetCachePermission(userID, time);
            foreach (var item in paths)
            {
                // 先判断用户访问的资源有没有在权限表定义 如果定义了就验证有没有访问这个资源的权限  没有定义直接放行
                if (allPermissionList.Exists(u => u.Href == item))
                {
                    flag = list.Exists(u => u.Href.ToLower().Equals(item.ToLower(), StringComparison.CurrentCultureIgnoreCase));
                }
            }
            return flag;
        }

        /// <summary>
        /// 从缓存中获取权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        private static List<Account_permission> GetCachePermission(int userId, DateTime time)
        {
            return CacheManager.Container.Get(USER_PERMISSION_CACHE_KEY_ + userId, acq =>
            {
                acq.Monitor(CacheManager.RelativeClockMonitor.When(new TimeSpan(5, 0, 0, 0)));
                acq.Monitor(CacheManager.Signals.When(USER_PERMISSION_CACHE_KEY_ + userId));
                acq.Monitor(CacheManager.Signals.When(USER_PERMISSION_CACHE_SIGNALS));
                List<string> tempPermissionIDs = new List<string>();
                //组
                List<int> groupIDs = GetUserValidGroupList(userId, time).Select(p => p.ID).ToList();
                if (groupIDs.Count > 0)
                {
                    string groupIDsWhere = string.Format("{0} in ({1})", Account_grouppermissionassign._GROUPID_, string.Join(",", groupIDs));
                    List<string> guids = Account_grouppermissionassignBLL.Select(groupIDsWhere, null).Select(p => p.PermissionID).ToList();
                    tempPermissionIDs.AddRange(guids);
                }  
                //去重
                tempPermissionIDs = tempPermissionIDs.Distinct().ToList();
                //取结果
                List<Account_permission> list = TakePermission(tempPermissionIDs);
                tempPermissionIDs.Clear();
                tempPermissionIDs = null;
                List<Account_permission> result = new List<Account_permission>();
                FilterPermission(list, result, p => p.ParentID == GUID_EMPTY_VALUE);
                list = null;
                return result;
            });

        }
        private static List<Account_permission> TakePermission(List<string> tempPermissionIDs)
        {
            if (tempPermissionIDs == null || tempPermissionIDs.Count == 0)
            {
                return new List<Account_permission>(0);
            }
            string where = string.Format("{0} IN ('{1}')", Account_permission._ID_, string.Join("','", tempPermissionIDs));
            return Account_permissionBLL.Select(where, null);
        }
        private static void FilterPermission(List<Account_permission> list, List<Account_permission> result, Func<Account_permission, bool> predicate)
        {
            List<Account_permission> tList = list.Where(predicate).ToList();
            foreach (Account_permission item in tList)
            {
                result.Add(item);
                FilterPermission(list, result, p => p.ParentID == item.ID);
            }
        }
        #endregion

        #region Group
        /// <summary>
        /// 获取用户有效的组列表
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public static List<Account_group> GetUserValidGroupList(int userID, DateTime time)
        {
            string where = string.Format("`{0}`='{1}' AND `{2}`>'{3}'", Account_usergroupassign._USERID_, userID, Account_usergroupassign._EXPIREDTIME_, time.ToString("yyyy-MM-dd HH:mm:ss"));
            List<int> list = Account_usergroupassignBLL.Select(where, null).
                Select(p => p.GroupID).Distinct().ToList();
            if (list.Count == 0)
            {
                return new List<Account_group>(0);
            }
            where = string.Format("`{0}` IN ({1})", Account_group._ID_, String.Join(",", list));
            return Account_groupBLL.Select(where, null);
        }
        #endregion
    }

}