using SimpleLoginAuthorization.Common;
using SimpleLoginAuthorization.DB;
using System;
using System.Collections.Generic;

namespace SimpleLoginAuthorization.BIZ
{

    public static class PermissionBIZ
    {
        public const string USER_PERMISSION_CACHE_SIGNALS = "USER_PERMISSION_CACHE_SIGNALS";
        public const string USER_PERMISSION_CACHE_KEY_ = "USER_PERMISSION_CACHE_KEY_";
        public const string GUID_EMPTY_VALUE = "00000000-0000-0000-0000-000000000000";//Guid只读实例，其值保证均为0
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
                    string groupIDsWhere = string.Format("{0} in ({1})", Account_grouppermissionassign._GROUPID_, StringHelper.Join(",", groupIDs));
                    List<string> guids = Account_grouppermissionassignBLL.Select(groupIDsWhere, null).Select(p => p.PermissionID).ToList();
                    tempPermissionIDs.AddRange(guids);
                }
                //角色
                List<int> roleIDs = GetUserValidRoleList(userId, time).Select(p => p.ID).ToList();
                if (roleIDs.Count > 0)
                {
                    string roleIDsWhere = string.Format("{0} in ({1})", Account_rolepermissionassign._ROLEID_, StringHelper.Join(",", roleIDs));
                    List<string> guids = Account_rolepermissionassignBLL.Select(roleIDsWhere).Select(p => p.PermissionID).ToList();
                    tempPermissionIDs.AddRange(guids);
                }
                //特殊权限
                List<Account_userpermissionassign> teIDs = GetUserValidSpecialPermissionList(userId, time);
                if (teIDs.Count > 0)
                {
                    foreach (Account_userpermissionassign item in teIDs)
                    {
                        switch (item.AssignType)
                        {
                            case 1:
                                tempPermissionIDs.Add(item.PermissionID);
                                break;
                            case 0:
                            case 2:
                                tempPermissionIDs.RemoveAll(p => p == item.PermissionID);
                                break;
                        }
                    }
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
        #endregion
    }

}