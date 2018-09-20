using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;

namespace SimpleLoginAuthorization.DB
{
    public interface IAccount_permissionDAL
    {
        #region ---------方法定义-----------
        #region 增加
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(Account_permission account_permission);
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(DbTransaction sp, Account_permission account_permission);
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(DbConnection con, Account_permission account_permission);
        #endregion

        #region 更新
        /// <summary>
        /// 向数据表Account_permission更新一条记录
        /// </summary>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(Account_permission account_permission);
        /// <summary>
        /// 向数据表Account_permission更新一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(DbTransaction sp, Account_permission account_permission);
        /// <summary>
        /// 向数据表Account_permission更新一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(DbConnection con, Account_permission account_permission);
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
        int Update(string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_permission更新一条记录
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
        int Update(DbTransaction sp, string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_permission更新一条记录
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
        int Update(DbConnection con, string columnValue, string iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
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
        int UpdateWhere(string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_permission更新记录
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
        int UpdateWhere(DbTransaction sp, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_permission更新记录
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
        int UpdateWhere(DbConnection con, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
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
        int Delete(string iD);
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="account_permission">Account_permission实体</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(Account_permission account_permission);
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbTransaction sp, string iD);
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbConnection con, string iD);
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_permission">account_permission</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbTransaction sp, Account_permission account_permission);
        /// <summary>
        /// 删除数据表Account_permission中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_permission">account_permission</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbConnection con, Account_permission account_permission);
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
        int DeleteWhere(string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
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
        int DeleteWhere(DbTransaction sp, string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
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
        int DeleteWhere(DbConnection con, string where
#if !SP
            , params DbParameter[] parameters
#endif
        );
        #endregion

        #region 实体对象
        /// <summary>
        /// 通过DataRow创建一个account_permission实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>Account_permission实体</returns>
        Account_permission Select(DataRow row);
        /// <summary>
        /// 得到account_permission数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>account_permission数据实体</returns>
        Account_permission Select(IDataReader dr);
        /// <summary>
		/// 得到 account_permission数据实体
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>account_permission数据实体</returns>
		Account_permission Get(string iD);
        /// <summary>
        /// 得到 account_permission数据实体
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <returns>account_permission数据实体</returns>
        Account_permission Get(DbConnection con, string iD);
        /// <summary>
        /// 根据ID,返回一个account_permission对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_permission对象设置与父表关联</param>
        /// <param name="bChildrenTable">将account_permission对象设置与子表关联</param>
        /// <returns>account_permission</returns>
        Account_permission Get(string iD, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 根据ID,返回一个account_permission对象
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_permission对象设置与父表关联</param>
        /// <param name="bChildrenTable">将account_permission对象设置与子表关联</param>
        /// <returns>account_permission</returns>
        Account_permission Get(DbConnection con, string iD, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 将account_permission对象设置与父表和子表关联
        /// </summary>
        /// <param name="obj">account_permission对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        void Get(Account_permission obj, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 将account_permission对象设置与父表和子表关联
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="obj">account_permission对象</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
		/// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		void Get(DbConnection con, Account_permission obj, bool bParentTable, bool bChildrenTable);
        #endregion     

        #region 查询
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <returns>数据实体</returns>
        List<Account_permission> Select();
        /// <summary>
		/// 得到数据表Account_permission所有记录
		/// </summary>
        /// <param name="con">连接对象</param>
		/// <returns>数据实体</returns>
		List<Account_permission> Select(DbConnection con);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(string sortField);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, string sortField);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>数据实体</returns>
        List<Account_permission> Select(bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>数据实体</returns>
        List<Account_permission> Select(DbConnection con, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(string where, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(Expression<Func<Account_permission, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(int topCount, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(int topCount, Expression<Func<Account_permission, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, int topCount, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, int topCount, Expression<Func<Account_permission, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(int topCount, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int topCount, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <returns>结果集</returns>
        /// List< Account_permission> Select(string foreignFieldName, string foreignFieldValue);

        /// <summary>
        /// 得到数据表Account_permission满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(string foreignFieldName, string foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable);
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
        List<Account_permission> Select(DbConnection con, string foreignFieldName, string foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        void Select(string where, out int recordCount);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(Expression<Func<Account_permission, bool>> expression, out int recordCount);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(DbConnection con, string where, out int recordCount);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(DbConnection con, Expression<Func<Account_permission, bool>> expression, out int recordCount);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(int pageSize, int pageIndex);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(int pageSize, int pageIndex, string where);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, out int recordCount);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, out int recordCount);
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
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, out int recordCount);
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
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, out int recordCount);
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
        List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
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
        List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
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
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
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
        List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
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
        List<Account_permission> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable);
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
		List<Account_permission> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_permission, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(CommandType commandType, string sqlCommand, params DbParameter[] param);
        /// <summary>
		/// 得到数据表Account_permission满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="commandType">命令类型</param>
		/// <param name="sqlCommand">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		List<Account_permission> Select(DbConnection con, CommandType commandType, string sqlCommand, params DbParameter[] param);
        /// <summary>
        /// 得到数据表Account_permission满足查询条件记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        List<Account_permission> Select(bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param);
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
		List<Account_permission> Select(DbConnection con, bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param);
        #endregion
        #endregion
    }
}