using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// 业务逻辑层account_permission
    /// </summary>
    public class Account_permissionBLL
    {
        #region ---------变量定义-----------
        ///<summary>
        ///得到数据工厂
        ///</summary>
        private static readonly IAccount_permissionDAL _dal = DALFactory.Account_permissionDALInstance();
        #endregion

        #region ----------构造函数----------
        /// <summary>
        /// 构造函数
        /// </summary>
        public Account_permissionBLL()
        {
        }
        #endregion

        #region ---------方法定义-----------
        #region 添加
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="account_permission">Account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Insert(Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Insert(account_permission);
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">Account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Insert(DbTransaction sp, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Insert(sp, account_permission);
        }
        /// <summary>
        /// 向数据库中插入一条新记录。带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">Account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Insert(DbConnection con, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Insert(con, account_permission);
        }
        #endregion

        #region 更新
        /// <summary>
        /// 向数据表Account_permission更新一条记录
        /// </summary>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Update(account_permission);
        }
        /// <summary>
        /// 向数据表Account_permission更新一条记录。带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(DbTransaction sp, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Update(sp, account_permission);
        }
        /// <summary>
        /// 向数据表Account_permission更新一条记录。带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(DbConnection con, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Update(con, account_permission);
        }
        /// <summary>
        /// 向数据表Account_permission更新一条记录
        /// </summary>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            return Account_permissionBLL._dal.Update(columnValue, iD
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 向数据表Account_permission更新一条记录，带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(DbTransaction sp, string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            return Account_permissionBLL._dal.Update(sp, columnValue, iD
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 向数据表Account_permission更新一条记录，带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Update(DbConnection con, string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            return Account_permissionBLL._dal.Update(con, columnValue, iD
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 向数据表Account_permission更新记录
        /// </summary>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="where">UPDATE语句里WHERE内容</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容和WHERE内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int UpdateWhere(string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(columnValue) || string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.UpdateWhere(columnValue, where
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 向数据表Account_permission更新记录，带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="where">UPDATE语句里WHERE内容</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容和WHERE内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int UpdateWhere(DbTransaction sp, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(columnValue) || string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.UpdateWhere(sp, columnValue, where
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 向数据表Account_permission更新记录，带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="where">UPDATE语句里WHERE内容</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容和WHERE内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int UpdateWhere(DbConnection con, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(columnValue) || string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.UpdateWhere(con, columnValue, where
#if !SP
                , parameters
#endif
            );
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(string iD)
        {
            return Account_permissionBLL._dal.Delete(iD);
        }
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Delete(account_permission);
        }
        /// <summary>
        /// 删除数据表Account_permission中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(DbTransaction sp, string iD)
        {
            return Account_permissionBLL._dal.Delete(sp, iD);
        }
        /// <summary>
        /// 删除数据表Account_permission中的一条记录,带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(DbConnection con, string iD)
        {
            return Account_permissionBLL._dal.Delete(con, iD);
        }
        /// <summary>
        /// 删除数据表Account_permission中的一条记录,带事务
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(DbTransaction sp, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Delete(sp, account_permission);
        }
        /// <summary>
        /// 删除数据表Account_permission中的一条记录,带事务
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">account_permission实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int Delete(DbConnection con, Account_permission account_permission)
        {
            if (account_permission == null)
                return -1;
            return Account_permissionBLL._dal.Delete(con, account_permission);
        }
        /// <summary>
        /// 删除数据表Account_permission中符合条件的记录
        /// </summary>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int DeleteWhere(string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.DeleteWhere(where
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 删除数据表Account_permission中符合条件的记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int DeleteWhere(DbTransaction sp, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.DeleteWhere(sp, where
#if !SP
                , parameters
#endif
            );
        }
        /// <summary>
        /// 删除数据表Account_permission中符合条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public static int DeleteWhere(DbConnection con, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            if (string.IsNullOrEmpty(where))
                return -1;
            return Account_permissionBLL._dal.DeleteWhere(con, where
#if !SP
                , parameters
#endif
            );
        }
        #endregion

        #region 数据实体
        /// <summary>
        /// 通过DataRow创建一个account_permission实体对象
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>Account_permission实体对象</returns>
        public static Account_permission Select(DataRow row)
        {
            return Account_permissionBLL._dal.Select(row);
        }

        /// <summary>
        /// 通过DataReader创建一个account_permission实体对象
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>account_permission实体对象</returns>
        public static Account_permission Select(IDataReader dr)
        {
            return Account_permissionBLL._dal.Select(dr);
        }
        /// <summary>
        /// 得到account_permission实体对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>account_permission实体对象</returns>
        public static Account_permission Get(string iD)
        {
            return Account_permissionBLL._dal.Get(iD);
        }
        /// <summary>
        /// 得到account_permission实体对象
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <returns>account_permission实体对象</returns>
        public static Account_permission Get(DbConnection con, string iD)
        {
            return Account_permissionBLL._dal.Get(con, iD);
        }
        /// <summary>
        /// 根据ID,返回一个account_permission实体对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_permission实体对象设置是否与父表关联</param>
        /// <param name="bChildrenTable">将account_permission实体对象设置是否与子表关联</param>
        /// <returns>account_permission实体对象</returns>
        public static Account_permission Get(string iD, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Get(iD, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 根据ID,返回一个account_permission实体对象
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_permission实体对象设置是否与父表关联</param>
        /// <param name="bChildrenTable">将account_permission实体对象设置是否与子表关联</param>
        /// <returns>account_permission实体对象</returns>
        public static Account_permission Get(DbConnection con, string iD, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Get(con, iD, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 将account_permission对象设置与父表和子表关联
        /// </summary>
        /// <param name="obj">account_permission实体对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        public static void Get(Account_permission obj, bool bParentTable, bool bChildrenTable)
        {
            Account_permissionBLL._dal.Get(obj, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 将account_permission对象设置与父表和子表关联
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="obj">account_permission实体对象</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
		/// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		public static void Get(DbConnection con, Account_permission obj, bool bParentTable, bool bChildrenTable)
        {
            Account_permissionBLL._dal.Get(con, obj, bParentTable, bChildrenTable);
        }
        #endregion

        #region 父表
        #endregion

        #region 子表
        #endregion

        #region 查询
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select()
        {
            return Account_permissionBLL._dal.Select();
        }
        /// <summary>
		/// 得到数据表Account_permission所有记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con)
        {
            return Account_permissionBLL._dal.Select(con);
        }
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(string sortField)
        {
            return Account_permissionBLL._dal.Select(sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, string sortField)
        {
            return Account_permissionBLL._dal.Select(con, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission所有记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(string where, string sortField)
        {
            return Account_permissionBLL._dal.Select(where, sortField);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(Expression<Func<Account_permission, bool>> expression, string sortField)
        {
            return Account_permissionBLL._dal.Select(expression, sortField);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, string where, string sortField)
        {
            return Account_permissionBLL._dal.Select(con, where, sortField);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, string sortField)
        {
            return Account_permissionBLL._dal.Select(con, expression, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int topCount, string where, string sortField)
        {
            return Account_permissionBLL._dal.Select(topCount, where, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(int topCount, Expression<Func<Account_permission, bool>> expression, string sortField)
        {
            return Account_permissionBLL._dal.Select(topCount, expression, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int topCount, string where, string sortField)
        {
            return Account_permissionBLL._dal.Select(con, topCount, where, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int topCount, Expression<Func<Account_permission, bool>> expression, string sortField)
        {
            return Account_permissionBLL._dal.Select(con, topCount, expression, sortField);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(topCount, where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(int topCount, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(topCount, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, topCount, where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int topCount, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, topCount, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <returns>结果集</returns>
        /// public static List< Account_permission > Select(string foreignFieldName, string foreignFieldValue)
        /// {
        ///     return Account_permissionBLL._dal.Select(foreignFieldName, foreignFieldValue);
        /// }

        /// <summary>
        /// 得到数据表Account_permission满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(string foreignFieldName, string foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(foreignFieldName, foreignFieldValue, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足外键字段查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, string foreignFieldName, string foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, foreignFieldName, foreignFieldValue, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public static void Select(string where, out int recordCount)
        {
            Account_permissionBLL._dal.Select(where, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public static void Select(Expression<Func<Account_permission, bool>> expression, out int recordCount)
        {
            Account_permissionBLL._dal.Select(expression, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public static void Select(DbConnection con, string where, out int recordCount)
        {
            Account_permissionBLL._dal.Select(con, where, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public static void Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, out int recordCount)
        {
            Account_permissionBLL._dal.Select(con, expression, out recordCount);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, string where)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, where);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, expression);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, where);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, expression);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, where, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, expression, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, where, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, expression, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, where, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, expression, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, where, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, expression, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            return Account_permissionBLL._dal.Select(con, pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable, out recordCount);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(CommandType commandType, string sqlCommand, params DbParameter[] param)
        {
            return Account_permissionBLL._dal.Select(commandType, sqlCommand, param);
        }
        /// <summary>
		/// 得到数据表Account_permission满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="commandType">命令类型</param>
		/// <param name="sqlCommand">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		public static List<Account_permission> Select(DbConnection con, CommandType commandType, string sqlCommand, params DbParameter[] param)
        {
            return Account_permissionBLL._dal.Select(con, commandType, sqlCommand, param);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param)
        {
            return Account_permissionBLL._dal.Select(bParentTable, bChildrenTable, commandType, sqlCommand, param);
        }
        /// <summary>
        /// 得到数据表Account_permission满足查询条件记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public static List<Account_permission> Select(DbConnection con, bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param)
        {
            return Account_permissionBLL._dal.Select(con, bParentTable, bChildrenTable, commandType, sqlCommand, param);
        }
        #endregion

        #endregion
    }
}