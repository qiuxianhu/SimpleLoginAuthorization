using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq.Expressions;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// 数据层account_usergroupassign接口
    /// </summary>
    public interface IAccount_usergroupassignDAL
    {
        #region ---------方法定义-----------
        #region 增加
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(DbTransaction sp, Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Insert(DbConnection con, Account_usergroupassign account_usergroupassign);
        #endregion

        #region 更新
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
        /// </summary>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(DbTransaction sp, Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(DbConnection con, Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
        /// </summary>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Update(string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
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
        int Update(DbTransaction sp, string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_usergroupassign更新一条记录
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
        int Update(DbConnection con, string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        );
        /// <summary>
        /// 向数据表Account_usergroupassign更新记录
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
        /// 向数据表Account_usergroupassign更新记录
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
        /// 向数据表Account_usergroupassign更新记录
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
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(int iD);
        /// <summary>
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="account_usergroupassign">Account_usergroupassign实体</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbTransaction sp, int iD);
        /// <summary>
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbConnection con, int iD);
        /// <summary>
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_usergroupassign">account_usergroupassign</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbTransaction sp, Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 删除数据表Account_usergroupassign中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_usergroupassign">account_usergroupassign</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        int Delete(DbConnection con, Account_usergroupassign account_usergroupassign);
        /// <summary>
        /// 删除数据表Account_usergroupassign中符合条件的记录
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
        /// 删除数据表Account_usergroupassign中符合条件的记录
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
        /// 删除数据表Account_usergroupassign中符合条件的记录
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
        /// 通过DataRow创建一个account_usergroupassign实体
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>Account_usergroupassign实体</returns>
        Account_usergroupassign Select(DataRow row);
        /// <summary>
        /// 得到account_usergroupassign数据实体
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>account_usergroupassign数据实体</returns>
        Account_usergroupassign Select(IDataReader dr);
        /// <summary>
		/// 得到 account_usergroupassign数据实体
		/// </summary>
		/// <param name="iD">iD</param>
		/// <returns>account_usergroupassign数据实体</returns>
		Account_usergroupassign Get(int iD);
        /// <summary>
        /// 得到 account_usergroupassign数据实体
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <returns>account_usergroupassign数据实体</returns>
        Account_usergroupassign Get(DbConnection con, int iD);
        /// <summary>
        /// 根据ID,返回一个account_usergroupassign对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_usergroupassign对象设置与父表关联</param>
        /// <param name="bChildrenTable">将account_usergroupassign对象设置与子表关联</param>
        /// <returns>account_usergroupassign</returns>
        Account_usergroupassign Get(int iD, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 根据ID,返回一个account_usergroupassign对象
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_usergroupassign对象设置与父表关联</param>
        /// <param name="bChildrenTable">将account_usergroupassign对象设置与子表关联</param>
        /// <returns>account_usergroupassign</returns>
        Account_usergroupassign Get(DbConnection con, int iD, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 将account_usergroupassign对象设置与父表和子表关联
        /// </summary>
        /// <param name="obj">account_usergroupassign对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        void Get(Account_usergroupassign obj, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 将account_usergroupassign对象设置与父表和子表关联
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="obj">account_usergroupassign对象</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
		/// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		void Get(DbConnection con, Account_usergroupassign obj, bool bParentTable, bool bChildrenTable);
        #endregion

        #region 父表
        #endregion

        #region 子表
        #endregion

        #region 查询
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <returns>数据实体</returns>
        List<Account_usergroupassign> Select();
        /// <summary>
		/// 得到数据表Account_usergroupassign所有记录
		/// </summary>
        /// <param name="con">连接对象</param>
		/// <returns>数据实体</returns>
		List<Account_usergroupassign> Select(DbConnection con);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>数据实体</returns>
        List<Account_usergroupassign> Select(bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>数据实体</returns>
        List<Account_usergroupassign> Select(DbConnection con, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(string where, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(Expression<Func<Account_usergroupassign, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, Expression<Func<Account_usergroupassign, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int topCount, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int topCount, Expression<Func<Account_usergroupassign, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int topCount, string where, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int topCount, Expression<Func<Account_usergroupassign, bool>> expression, string sortField);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int topCount, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int topCount, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <returns>结果集</returns>
        /// List< Account_usergroupassign> Select(string foreignFieldName, int foreignFieldValue);

        /// <summary>
        /// 得到数据表Account_usergroupassign满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(string foreignFieldName, int foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足外键字段查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, string foreignFieldName, int foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        void Select(string where, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的记录数
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(Expression<Func<Account_usergroupassign, bool>> expression, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(DbConnection con, string where, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		void Select(DbConnection con, Expression<Func<Account_usergroupassign, bool>> expression, out int recordCount);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, string where);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, string where);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的分页记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex, string where, string sortField, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
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
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
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
        List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_usergroupassign, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(CommandType commandType, string sqlCommand, params DbParameter[] param);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="commandType">命令类型</param>
		/// <param name="sqlCommand">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, CommandType commandType, string sqlCommand, params DbParameter[] param);
        /// <summary>
        /// 得到数据表Account_usergroupassign满足查询条件记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="sqlCommand">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        List<Account_usergroupassign> Select(bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param);
        /// <summary>
		/// 得到数据表Account_usergroupassign满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <param name="commandType">命令类型</param>
		/// <param name="sqlCommand">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		List<Account_usergroupassign> Select(DbConnection con, bool bParentTable, bool bChildrenTable, CommandType commandType, string sqlCommand, params DbParameter[] param);
        #endregion
        #endregion
    }
}