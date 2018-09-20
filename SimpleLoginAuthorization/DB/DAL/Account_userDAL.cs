using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// 数据访问层account_user
    /// </summary>
    public partial class Account_userDAL : IAccount_userDAL
    {
        #region 构造函数
        /// <summary>
        /// 数据层实例化
        /// </summary>
        public Account_userDAL()
        {
        }
        #endregion

        #region -----------实现接口方法-----------

        #region 添加
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="account_user">Account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Insert(Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userInsert";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Direction = ParameterDirection.Output;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
			account_user.ID = param[0].Value== DBNull.Value ? 0 : Convert.ToInt32(param[0].Value);
#else
            string SQL = @"INSERT INTO `account_user`
        	(
        		`PetName`,
        		`RealName`,
        		`LoginAccount`,
        		`LoginPassword`,
        		`LoginTime`,
        		`LoginIP`,
        		`Status`,
        		`Phone`,
        		`Email`,
        		`GroupText`,
        		`RoleText`,
        		`Department`,
        		`Hash`,
        		`IsLimitLogin`,
        		`CreateTime`,
        		`CreateUserName`,
        		`UpdateTime`,
        		`UpdateUserName`
        	) 
        	VALUES
        	(
        		?PetName,
        		?RealName,
        		?LoginAccount,
        		?LoginPassword,
        		?LoginTime,
        		?LoginIP,
        		?Status,
        		?Phone,
        		?Email,
        		?GroupText,
        		?RoleText,
        		?Department,
        		?Hash,
        		?IsLimitLogin,
        		?CreateTime,
        		?CreateUserName,
        		?UpdateTime,
        		?UpdateUserName
        	);";
            SQL += "SELECT LAST_INSERT_ID();";
            SqlParameter[] param = {
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            if (account_user.PetName == null)
            {
                param[0].Value = DBNull.Value;
            }
            else
            {
                param[0].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginIP;
            }
            param[6].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[7].Value = DBNull.Value;
            }
            else
            {
                param[7].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Hash;
            }
            param[13].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[14].Value = DBNull.Value;
            }
            else
            {
                param[14].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateUserName;
            }
            object @object = SqlHelper.ExecuteScalar(Conn.SqlConn, CommandType.Text, SQL, param);//返回自增ID
            if (@object != null)
            {
                account_user.ID = Convert.ToInt32(@object);
                errorCode = 1;
            }
            else
            {
                errorCode = 0;//数据库执行失败
            }
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_user">Account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Insert(DbTransaction sp, Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userInsert";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Direction = ParameterDirection.Output;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
			account_user.ID = param[0].Value== DBNull.Value ? 0 : Convert.ToInt32(param[0].Value);
#else
            string SQL = @"INSERT INTO `account_user`
        	(
        		`PetName`,
        		`RealName`,
        		`LoginAccount`,
        		`LoginPassword`,
        		`LoginTime`,
        		`LoginIP`,
        		`Status`,
        		`Phone`,
        		`Email`,
        		`GroupText`,
        		`RoleText`,
        		`Department`,
        		`Hash`,
        		`IsLimitLogin`,
        		`CreateTime`,
        		`CreateUserName`,
        		`UpdateTime`,
        		`UpdateUserName`
        	) 
        	VALUES
        	(
        		?PetName,
        		?RealName,
        		?LoginAccount,
        		?LoginPassword,
        		?LoginTime,
        		?LoginIP,
        		?Status,
        		?Phone,
        		?Email,
        		?GroupText,
        		?RoleText,
        		?Department,
        		?Hash,
        		?IsLimitLogin,
        		?CreateTime,
        		?CreateUserName,
        		?UpdateTime,
        		?UpdateUserName
        	);";
            SQL += "SELECT LAST_INSERT_ID();";
            SqlParameter[] param = {
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            if (account_user.PetName == null)
            {
                param[0].Value = DBNull.Value;
            }
            else
            {
                param[0].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginIP;
            }
            param[6].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[7].Value = DBNull.Value;
            }
            else
            {
                param[7].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Hash;
            }
            param[13].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[14].Value = DBNull.Value;
            }
            else
            {
                param[14].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateUserName;
            }
            object @object = SqlHelper.ExecuteScalar(sp, CommandType.Text, SQL, param);//返回自增ID
            if (@object != null)
            {
                account_user.ID = Convert.ToInt32(@object);
                errorCode = 1;
            }
            else
            {
                errorCode = 0;//数据库执行失败
            }
#endif
            return errorCode;
        }

        /// <summary>
        /// 向数据库中插入一条新记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_user">Account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Insert(DbConnection con, Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userInsert";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Direction = ParameterDirection.Output;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
			account_user.ID = param[0].Value== DBNull.Value ? 0 : Convert.ToInt32(param[0].Value);
#else
            string SQL = @"INSERT INTO `account_user`
        	(
        		`PetName`,
        		`RealName`,
        		`LoginAccount`,
        		`LoginPassword`,
        		`LoginTime`,
        		`LoginIP`,
        		`Status`,
        		`Phone`,
        		`Email`,
        		`GroupText`,
        		`RoleText`,
        		`Department`,
        		`Hash`,
        		`IsLimitLogin`,
        		`CreateTime`,
        		`CreateUserName`,
        		`UpdateTime`,
        		`UpdateUserName`
        	) 
        	VALUES
        	(
        		?PetName,
        		?RealName,
        		?LoginAccount,
        		?LoginPassword,
        		?LoginTime,
        		?LoginIP,
        		?Status,
        		?Phone,
        		?Email,
        		?GroupText,
        		?RoleText,
        		?Department,
        		?Hash,
        		?IsLimitLogin,
        		?CreateTime,
        		?CreateUserName,
        		?UpdateTime,
        		?UpdateUserName
        	);";
            SQL += "SELECT LAST_INSERT_ID();";
            SqlParameter[] param = {
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            if (account_user.PetName == null)
            {
                param[0].Value = DBNull.Value;
            }
            else
            {
                param[0].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginIP;
            }
            param[6].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[7].Value = DBNull.Value;
            }
            else
            {
                param[7].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Hash;
            }
            param[13].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[14].Value = DBNull.Value;
            }
            else
            {
                param[14].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateUserName;
            }
            object @object = SqlHelper.ExecuteScalar(con, CommandType.Text, SQL, param);//返回自增ID
            if (@object != null)
            {
                account_user.ID = Convert.ToInt32(@object);
                errorCode = 1;
            }
            else
            {
                errorCode = 0;//数据库执行失败
            }
#endif
            return errorCode;
        }
        #endregion

        #region 更新
        /// <summary>
        /// 向数据表Account_user更新一条记录
        /// </summary>
        /// <param name="account_user">account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Update(Account_user account_user)
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdate";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Value = account_user.ID;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET
    		`PetName` = ?PetName,
    		`RealName` = ?RealName,
    		`LoginAccount` = ?LoginAccount,
    		`LoginPassword` = ?LoginPassword,
    		`LoginTime` = ?LoginTime,
    		`LoginIP` = ?LoginIP,
    		`Status` = ?Status,
    		`Phone` = ?Phone,
    		`Email` = ?Email,
    		`GroupText` = ?GroupText,
    		`RoleText` = ?RoleText,
    		`Department` = ?Department,
    		`Hash` = ?Hash,
    		`IsLimitLogin` = ?IsLimitLogin,
    		`CreateTime` = ?CreateTime,
    		`CreateUserName` = ?CreateUserName,
    		`UpdateTime` = ?UpdateTime,
    		`UpdateUserName` = ?UpdateUserName
            WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int),
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            param[0].Value = account_user.ID;
            if (account_user.PetName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
            param[7].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
            param[14].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_user">account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Update(DbTransaction sp, Account_user account_user)
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdate";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Value = account_user.ID;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET
    		`PetName` = ?PetName,
    		`RealName` = ?RealName,
    		`LoginAccount` = ?LoginAccount,
    		`LoginPassword` = ?LoginPassword,
    		`LoginTime` = ?LoginTime,
    		`LoginIP` = ?LoginIP,
    		`Status` = ?Status,
    		`Phone` = ?Phone,
    		`Email` = ?Email,
    		`GroupText` = ?GroupText,
    		`RoleText` = ?RoleText,
    		`Department` = ?Department,
    		`Hash` = ?Hash,
    		`IsLimitLogin` = ?IsLimitLogin,
    		`CreateTime` = ?CreateTime,
    		`CreateUserName` = ?CreateUserName,
    		`UpdateTime` = ?UpdateTime,
    		`UpdateUserName` = ?UpdateUserName
            WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int),
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            param[0].Value = account_user.ID;
            if (account_user.PetName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
            param[7].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
            param[14].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_user">account_user实体对象</param>
#if SP
		/// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Update(DbConnection con, Account_user account_user)
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdate";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_PetName", SqlDbType.VarChar,50),
			    new SqlParameter("_RealName", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginAccount", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginPassword", SqlDbType.VarChar,50),
			    new SqlParameter("_LoginTime", SqlDbType.DateTime),
			    new SqlParameter("_LoginIP", SqlDbType.VarChar,50),
			    new SqlParameter("_Status", SqlDbType.Int),
			    new SqlParameter("_Phone", SqlDbType.VarChar,50),
			    new SqlParameter("_Email", SqlDbType.VarChar,50),
			    new SqlParameter("_GroupText", SqlDbType.VarChar,1000),
			    new SqlParameter("_RoleText", SqlDbType.VarChar,1000),
			    new SqlParameter("_Department", SqlDbType.VarChar,50),
			    new SqlParameter("_Hash", SqlDbType.VarChar,50),
			    new SqlParameter("_IsLimitLogin", SqlDbType.Int),
			    new SqlParameter("_CreateTime", SqlDbType.DateTime),
			    new SqlParameter("_CreateUserName", SqlDbType.VarChar,64),
			    new SqlParameter("_UpdateTime", SqlDbType.DateTime),
			    new SqlParameter("_UpdateUserName", SqlDbType.VarChar,64)
			};
			param[0].Value = account_user.ID;
			if( account_user.PetName == null )
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
			if( account_user.RealName == null )
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
			if( account_user.LoginAccount == null )
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
			if( account_user.LoginPassword == null )
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
			if( account_user.LoginTime == new DateTime(1900,1,1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.LoginIP == null )
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
			param[7].Value = account_user.Status;
			if( account_user.Phone == null )
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
			if( account_user.Email == null )
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
			if( account_user.GroupText == null )
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
			if( account_user.RoleText == null )
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
			if( account_user.Department == null )
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
			if( account_user.Hash == null )
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
			param[14].Value = account_user.IsLimitLogin;
			if( account_user.CreateTime == new DateTime(1900,1,1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.CreateUserName == null )
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
			if( account_user.UpdateTime == new DateTime(1900,1,1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
			if( account_user.UpdateUserName == null )
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
			errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET
    		`PetName` = ?PetName,
    		`RealName` = ?RealName,
    		`LoginAccount` = ?LoginAccount,
    		`LoginPassword` = ?LoginPassword,
    		`LoginTime` = ?LoginTime,
    		`LoginIP` = ?LoginIP,
    		`Status` = ?Status,
    		`Phone` = ?Phone,
    		`Email` = ?Email,
    		`GroupText` = ?GroupText,
    		`RoleText` = ?RoleText,
    		`Department` = ?Department,
    		`Hash` = ?Hash,
    		`IsLimitLogin` = ?IsLimitLogin,
    		`CreateTime` = ?CreateTime,
    		`CreateUserName` = ?CreateUserName,
    		`UpdateTime` = ?UpdateTime,
    		`UpdateUserName` = ?UpdateUserName
            WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int),
                new SqlParameter("?PetName", SqlDbType.VarChar,50),
                new SqlParameter("?RealName", SqlDbType.VarChar,50),
                new SqlParameter("?LoginAccount", SqlDbType.VarChar,50),
                new SqlParameter("?LoginPassword", SqlDbType.VarChar,50),
                new SqlParameter("?LoginTime", SqlDbType.DateTime),
                new SqlParameter("?LoginIP", SqlDbType.VarChar,50),
                new SqlParameter("?Status", SqlDbType.Int),
                new SqlParameter("?Phone", SqlDbType.VarChar,50),
                new SqlParameter("?Email", SqlDbType.VarChar,50),
                new SqlParameter("?GroupText", SqlDbType.VarChar,1000),
                new SqlParameter("?RoleText", SqlDbType.VarChar,1000),
                new SqlParameter("?Department", SqlDbType.VarChar,50),
                new SqlParameter("?Hash", SqlDbType.VarChar,50),
                new SqlParameter("?IsLimitLogin", SqlDbType.Int),
                new SqlParameter("?CreateTime", SqlDbType.DateTime),
                new SqlParameter("?CreateUserName", SqlDbType.VarChar,64),
                new SqlParameter("?UpdateTime", SqlDbType.DateTime),
                new SqlParameter("?UpdateUserName", SqlDbType.VarChar,64)
            };
            param[0].Value = account_user.ID;
            if (account_user.PetName == null)
            {
                param[1].Value = DBNull.Value;
            }
            else
            {
                param[1].Value = account_user.PetName;
            }
            if (account_user.RealName == null)
            {
                param[2].Value = DBNull.Value;
            }
            else
            {
                param[2].Value = account_user.RealName;
            }
            if (account_user.LoginAccount == null)
            {
                param[3].Value = DBNull.Value;
            }
            else
            {
                param[3].Value = account_user.LoginAccount;
            }
            if (account_user.LoginPassword == null)
            {
                param[4].Value = DBNull.Value;
            }
            else
            {
                param[4].Value = account_user.LoginPassword;
            }
            if (account_user.LoginTime == new DateTime(1900, 1, 1))
            {
                param[5].Value = DBNull.Value;
            }
            else
            {
                param[5].Value = account_user.LoginTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.LoginIP == null)
            {
                param[6].Value = DBNull.Value;
            }
            else
            {
                param[6].Value = account_user.LoginIP;
            }
            param[7].Value = account_user.Status;
            if (account_user.Phone == null)
            {
                param[8].Value = DBNull.Value;
            }
            else
            {
                param[8].Value = account_user.Phone;
            }
            if (account_user.Email == null)
            {
                param[9].Value = DBNull.Value;
            }
            else
            {
                param[9].Value = account_user.Email;
            }
            if (account_user.GroupText == null)
            {
                param[10].Value = DBNull.Value;
            }
            else
            {
                param[10].Value = account_user.GroupText;
            }
            if (account_user.RoleText == null)
            {
                param[11].Value = DBNull.Value;
            }
            else
            {
                param[11].Value = account_user.RoleText;
            }
            if (account_user.Department == null)
            {
                param[12].Value = DBNull.Value;
            }
            else
            {
                param[12].Value = account_user.Department;
            }
            if (account_user.Hash == null)
            {
                param[13].Value = DBNull.Value;
            }
            else
            {
                param[13].Value = account_user.Hash;
            }
            param[14].Value = account_user.IsLimitLogin;
            if (account_user.CreateTime == new DateTime(1900, 1, 1))
            {
                param[15].Value = DBNull.Value;
            }
            else
            {
                param[15].Value = account_user.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.CreateUserName == null)
            {
                param[16].Value = DBNull.Value;
            }
            else
            {
                param[16].Value = account_user.CreateUserName;
            }
            if (account_user.UpdateTime == new DateTime(1900, 1, 1))
            {
                param[17].Value = DBNull.Value;
            }
            else
            {
                param[17].Value = account_user.UpdateTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            if (account_user.UpdateUserName == null)
            {
                param[18].Value = DBNull.Value;
            }
            else
            {
                param[18].Value = account_user.UpdateUserName;
            }
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新一条记录
        /// </summary>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Update(string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByID";
            SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_ColumnValue", SqlDbType.Text)
			};
            param[0].Value = iD;
            param[1].Value = columnValue;
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter param = new SqlParameter("?ID", SqlDbType.Int);
            param.Value = iD;
            List<DbParameter> paramList = new List<DbParameter>(parameters.Length + 1);
            paramList.AddRange(parameters);
            paramList.Add(param);
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, string.Format(SQL, columnValue), paramList.ToArray());
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新一条记录
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
        public int Update(DbTransaction sp, string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByID";
            SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_ColumnValue", SqlDbType.Text)
			};
            param[0].Value = iD;
            param[1].Value = columnValue;
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter param = new SqlParameter("?ID", SqlDbType.Int);
            param.Value = iD;
            List<DbParameter> paramList = new List<DbParameter>(parameters.Length + 1);
            paramList.AddRange(parameters);
            paramList.Add(param);
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, string.Format(SQL, columnValue), paramList.ToArray());
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新一条记录
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
        public int Update(DbConnection con, string columnValue, int iD
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByID";
            SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int),
			    new SqlParameter("_ColumnValue", SqlDbType.Text)
			};
            param[0].Value = iD;
            param[1].Value = columnValue;
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter param = new SqlParameter("?ID", SqlDbType.Int);
            param.Value = iD;
            List<DbParameter> paramList = new List<DbParameter>(parameters.Length + 1);
            paramList.AddRange(parameters);
            paramList.Add(param);
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, string.Format(SQL, columnValue), paramList.ToArray());
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新记录
        /// </summary>
        /// <param name="columnValue">UPDATE语句里SET内容</param>
        /// <param name="where">UPDATE语句里WHERE内容</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">UPDATE语句里SET内容和WHERE内容的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int UpdateWhere(string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByWhere";
            SqlParameter[] param = {
			    new SqlParameter("_ColumnValue", SqlDbType.Text),
			    new SqlParameter("_Where", SqlDbType.Text)
			};
            param[0].Value = columnValue;
            param[1].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE {1};";
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, string.Format(SQL, columnValue, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新记录
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
        public int UpdateWhere(DbTransaction sp, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByWhere";
            SqlParameter[] param = {
			    new SqlParameter("_ColumnValue", SqlDbType.Text),
			    new SqlParameter("_Where", SqlDbType.Text)
			};
            param[0].Value = columnValue;
            param[1].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE {1};";
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, string.Format(SQL, columnValue, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        /// <summary>
        /// 向数据表Account_user更新记录
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
        public int UpdateWhere(DbConnection con, string columnValue, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
            const string SQL_COMMAND = "account_userUpdateColumnByWhere";
            SqlParameter[] param = {
			    new SqlParameter("_ColumnValue", SqlDbType.Text),
			    new SqlParameter("_Where", SqlDbType.Text)
			};
            param[0].Value = columnValue;
            param[1].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"UPDATE `account_user` SET {0} WHERE {1};";
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, string.Format(SQL, columnValue, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(int iD)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = iD;
			errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = iD;
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="account_user">account_user实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
	            new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = account_user.ID;
			errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = account_user.ID;
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(DbTransaction sp, int iD)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
				new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = iD;
			errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = iD;
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="account_user">account_user实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(DbTransaction sp, Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
				new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = account_user.ID;
			errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = account_user.ID;
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="ID">iD</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(DbConnection con, int iD)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
				new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = iD;
			errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = iD;
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中的一条记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="account_user">account_user实体对象</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int Delete(DbConnection con, Account_user account_user)
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDelete";
			SqlParameter[] param = {
				new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = account_user.ID;
			errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE  
    		`ID` = ?ID
    		;";
            SqlParameter[] param = {
                new SqlParameter("?ID", SqlDbType.Int)
            };
            param[0].Value = account_user.ID;
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, SQL, param);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中符合条件的记录
        /// </summary>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int DeleteWhere(string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDeleteByWhere";
			SqlParameter[] param = {
				new SqlParameter("_Where", SqlDbType.Text)
			};
			param[0].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
			errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE {0};";
            errorCode = SqlHelper.ExecuteNonQuery(Conn.SqlConn, CommandType.Text, string.Format(SQL, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中符合条件的记录
        /// </summary>
        /// <param name="sp">事务对象</param>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int DeleteWhere(DbTransaction sp, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDeleteByWhere";
			SqlParameter[] param = {
				new SqlParameter("_Where", SqlDbType.Text)
			};
			param[0].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
			errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE {0};";
            errorCode = SqlHelper.ExecuteNonQuery(sp, CommandType.Text, string.Format(SQL, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        /// <summary>
        /// 删除数据表Account_user中符合条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">删除的条件</param>
#if SP
        /// <returns>-1表示没有执行数据库操作；=0表示执行数据库操作成功；其他值表示执行数据库操作失败</returns>
#else
        /// <param name="parameters">DELETE语句里WHERE条件的参数值</param>
        /// <returns>-1表示没有执行数据库操作；>0表示执行数据库操作成功；=0表示执行数据库操作失败</returns>
#endif
        public int DeleteWhere(DbConnection con, string where
#if !SP
            , params DbParameter[] parameters
#endif
        )
        {
            int errorCode = -1;
#if SP
			const string SQL_COMMAND = "account_userDeleteByWhere";
			SqlParameter[] param = {
				new SqlParameter("_Where", SqlDbType.Text)
			};
			param[0].Value = string.IsNullOrEmpty(where) ? "1=2" : where;
			errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
#else
            const string SQL = @"DELETE FROM `account_user` WHERE {0};";
            errorCode = SqlHelper.ExecuteNonQuery(con, CommandType.Text, string.Format(SQL, string.IsNullOrWhiteSpace(where) ? "1=2" : where), parameters);
#endif
            return errorCode;
        }
        #endregion

        #region 实体对象
        /// <summary>
        /// 得到account_user实体对象
        /// </summary>
        /// <param name="row">row</param>
        /// <returns>account_user实体对象</returns>
        public Account_user Select(DataRow row)
        {
            Account_user obj = new Account_user();
            if (row != null)
            {
                obj.ID = row["ID"] == DBNull.Value ? 0 : Convert.ToInt32(row["ID"]);
                obj.PetName = row["PetName"] == DBNull.Value ? String.Empty : row["PetName"].ToString();
                obj.RealName = row["RealName"] == DBNull.Value ? String.Empty : row["RealName"].ToString();
                obj.LoginAccount = row["LoginAccount"] == DBNull.Value ? String.Empty : row["LoginAccount"].ToString();
                obj.LoginPassword = row["LoginPassword"] == DBNull.Value ? String.Empty : row["LoginPassword"].ToString();
                obj.LoginTime = row["LoginTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(row["LoginTime"]);
                obj.LoginIP = row["LoginIP"] == DBNull.Value ? String.Empty : row["LoginIP"].ToString();
                obj.Status = row["Status"] == DBNull.Value ? 0 : Convert.ToInt32(row["Status"]);
                obj.Phone = row["Phone"] == DBNull.Value ? String.Empty : row["Phone"].ToString();
                obj.Email = row["Email"] == DBNull.Value ? String.Empty : row["Email"].ToString();
                obj.GroupText = row["GroupText"] == DBNull.Value ? String.Empty : row["GroupText"].ToString();
                obj.RoleText = row["RoleText"] == DBNull.Value ? String.Empty : row["RoleText"].ToString();
                obj.Department = row["Department"] == DBNull.Value ? String.Empty : row["Department"].ToString();
                obj.Hash = row["Hash"] == DBNull.Value ? String.Empty : row["Hash"].ToString();
                obj.IsLimitLogin = row["IsLimitLogin"] == DBNull.Value ? 0 : Convert.ToInt32(row["IsLimitLogin"]);
                obj.CreateTime = row["CreateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(row["CreateTime"]);
                obj.CreateUserName = row["CreateUserName"] == DBNull.Value ? String.Empty : row["CreateUserName"].ToString();
                obj.UpdateTime = row["UpdateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(row["UpdateTime"]);
                obj.UpdateUserName = row["UpdateUserName"] == DBNull.Value ? String.Empty : row["UpdateUserName"].ToString();
            }
            else
            {
                return null;
            }
            return obj;
        }

        /// <summary>
        /// 得到account_user实体对象
        /// </summary>
        /// <param name="dr">dr</param>
        /// <returns>account_user实体对象</returns>
        public Account_user Select(IDataReader dr)
        {
            Account_user obj = new Account_user();
            obj.ID = dr["ID"] == DBNull.Value ? 0 : Convert.ToInt32(dr["ID"]);
            obj.PetName = dr["PetName"] == DBNull.Value ? String.Empty : dr["PetName"].ToString();
            obj.RealName = dr["RealName"] == DBNull.Value ? String.Empty : dr["RealName"].ToString();
            obj.LoginAccount = dr["LoginAccount"] == DBNull.Value ? String.Empty : dr["LoginAccount"].ToString();
            obj.LoginPassword = dr["LoginPassword"] == DBNull.Value ? String.Empty : dr["LoginPassword"].ToString();
            obj.LoginTime = dr["LoginTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(dr["LoginTime"]);
            obj.LoginIP = dr["LoginIP"] == DBNull.Value ? String.Empty : dr["LoginIP"].ToString();
            obj.Status = dr["Status"] == DBNull.Value ? 0 : Convert.ToInt32(dr["Status"]);
            obj.Phone = dr["Phone"] == DBNull.Value ? String.Empty : dr["Phone"].ToString();
            obj.Email = dr["Email"] == DBNull.Value ? String.Empty : dr["Email"].ToString();
            obj.GroupText = dr["GroupText"] == DBNull.Value ? String.Empty : dr["GroupText"].ToString();
            obj.RoleText = dr["RoleText"] == DBNull.Value ? String.Empty : dr["RoleText"].ToString();
            obj.Department = dr["Department"] == DBNull.Value ? String.Empty : dr["Department"].ToString();
            obj.Hash = dr["Hash"] == DBNull.Value ? String.Empty : dr["Hash"].ToString();
            obj.IsLimitLogin = dr["IsLimitLogin"] == DBNull.Value ? 0 : Convert.ToInt32(dr["IsLimitLogin"]);
            obj.CreateTime = dr["CreateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(dr["CreateTime"]);
            obj.CreateUserName = dr["CreateUserName"] == DBNull.Value ? String.Empty : dr["CreateUserName"].ToString();
            obj.UpdateTime = dr["UpdateTime"] == DBNull.Value ? new DateTime(1900, 1, 1) : Convert.ToDateTime(dr["UpdateTime"]);
            obj.UpdateUserName = dr["UpdateUserName"] == DBNull.Value ? String.Empty : dr["UpdateUserName"].ToString();
            return obj;
        }
        /// <summary>
        /// 根据ID,返回一个account_user实体对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <returns>Account_user实体对象</returns>
        public Account_user Get(int iD)
        {
            return this.Get(iD, false, false);
        }
        /// <summary>
		/// 根据ID,返回一个account_user实体对象
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
		/// <returns>Account_user实体对象</returns>
		public Account_user Get(DbConnection con, int iD)
        {
            return this.Get(con, iD, false, false);
        }
        /// <summary>
        /// 根据ID,返回一个account_user实体对象
        /// </summary>
        /// <param name="iD">iD</param>
        /// <param name="bParentTable">将account_user对象设置与父表关联</param>
        /// <param name="bChildrenTable">将account_user对象设置与子表关联</param>
        /// <returns>account_user实体对象</returns>
        public Account_user Get(int iD, bool bParentTable, bool bChildrenTable)
        {
            Account_user obj = null;
#if SP
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = iD;
			const string SQL_COMMAND = "account_userSelect";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
            		obj = this.Select(dr);
				}
			}
#else
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append("`ID` = '").Append(iD).Append("'");
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    obj = this.Select(dr);
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                this.Get(obj, bParentTable, bChildrenTable);
            }
            return obj;
        }
        /// <summary>
		/// 根据ID,返回一个account_user实体对象
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="iD">iD</param>
		/// <param name="bParentTable">将account_user对象设置与父表关联</param>
		/// <param name="bChildrenTable">将account_user对象设置与子表关联</param>
		/// <returns>account_user实体对象</returns>
		public Account_user Get(DbConnection con, int iD, bool bParentTable, bool bChildrenTable)
        {
            Account_user obj = null;
#if SP
			SqlParameter[] param = {
			    new SqlParameter("_ID", SqlDbType.Int)
			};
			param[0].Value = iD;
			const string SQL_COMMAND = "account_userSelect";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
            		obj = this.Select(dr);
				}
			}
#else
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append("`ID` = '").Append(iD).Append("'");
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    obj = this.Select(dr);
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                this.Get(con, obj, bParentTable, bChildrenTable);
            }
            return obj;
        }
        /// <summary>
        /// 将account_user实体对象设置与父表和子表关联
        /// </summary>
        /// <param name="obj">account_user实体对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        public void Get(Account_user obj, bool bParentTable, bool bChildrenTable)
        {
            if (obj == null)
                return;
            //关联的主表
            if (bParentTable)
            {
            }
            //关联的子表集合
            if (bChildrenTable)
            {
            }
        }
        /// <summary>
		/// 将account_user实体对象设置与父表和子表关联
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="obj">account_user实体对象</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
		/// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		public void Get(DbConnection con, Account_user obj, bool bParentTable, bool bChildrenTable)
        {
            if (obj == null)
                return;
            //关联的主表
            if (bParentTable)
            {
            }
            //关联的子表集合
            if (bChildrenTable)
            {
            }
        }
        #endregion

        #region 父表
        #endregion

        #region 子表
        #endregion

        #region 查询
        /// <summary>
        /// 得到数据表Account_user所有记录
        /// </summary>
        /// <returns>结果集</returns>
        public List<Account_user> Select()
        {
            return this.Select("");
        }
        /// <summary>
		/// 得到数据表Account_user所有记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con)
        {
            return this.Select(con, "");
        }
        /// <summary>
        /// 得到数据表Account_user所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(string sortField)
        {
            return this.Select(sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user所有记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(DbConnection con, string sortField)
        {
            return this.Select(con, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user所有记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(bool bParentTable, bool bChildrenTable)
        {
            return this.Select("", bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user所有记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(con, "", bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user所有记录
        /// </summary>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
#if SP
			const string SQL_COMMAND = "account_userSelectAll";
			SqlParameter paramSortField = new SqlParameter("_SortField", SqlDbType.Text);
			paramSortField.Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, paramSortField))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user`");
            if (!String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user所有记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
#if SP
			const string SQL_COMMAND = "account_userSelectAll";
			SqlParameter paramSortField = new SqlParameter("_SortField", SqlDbType.Text);
			paramSortField.Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, paramSortField))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user`");
            if (!String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(string where, string sortField)
        {
            return this.Select(where, sortField, false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(Expression<Func<Account_user, bool>> expression, string sortField)
        {
            return this.Select(expression, sortField, false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, string where, string sortField)
        {
            return this.Select(con, where, sortField, false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, Expression<Func<Account_user, bool>> expression, string sortField)
        {
            return this.Select(con, expression, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int topCount, string where, string sortField)
        {
            return this.Select(topCount, where, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(int topCount, Expression<Func<Account_user, bool>> expression, string sortField)
        {
            return this.Select(topCount, expression, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int topCount, string where, string sortField)
        {
            return this.Select(con, topCount, where, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int topCount, Expression<Func<Account_user, bool>> expression, string sortField)
        {
            return this.Select(con, topCount, expression, sortField, false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
#if SP
			SqlParameter[] param = {
				new SqlParameter("_TopCount", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = topCount;
			param[1].Value = where;
            param[2].Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;
			const string SQL_COMMAND = "account_userSelectByTop";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" LIMIT 0,").Append(topCount);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT 0,").Append(topCount);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(int topCount, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" LIMIT 0,").Append(topCount);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT 0,").Append(topCount);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int topCount, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
#if SP
			SqlParameter[] param={
				new SqlParameter("_TopCount", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = topCount;
			param[1].Value = where;
            param[2].Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;
			const string SQL_COMMAND = "account_userSelectByTop";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" LIMIT 0,").Append(topCount);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT 0,").Append(topCount);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的头几条记录
        /// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="topCount">查询头几条记录</param>
        /// <param name="expression">查询条件</param>
        /// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int topCount, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" LIMIT 0,").Append(topCount);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT 0,").Append(topCount);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的记录
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
#if SP
			SqlParameter[] param = {
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = where;
            param[1].Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;
			const string SQL_COMMAND = "account_userSelectByParams";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(DbConnection con, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
#if SP
			SqlParameter[] param = {
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = where;
            param[1].Value = String.IsNullOrWhiteSpace(sortField) ? "" : sortField;;
			const string SQL_COMMAND = "account_userSelectByParams";
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            StringBuilder sb = new StringBuilder();
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where);
            }
            else
            {
                sb.Append("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField);
            }
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
        /// 得到数据表Account_user满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <returns>结果集</returns>
        /// public List< Account_user > Select(string foreignFieldName, int foreignFieldValue)
        /// {
        ///     return this.Select(foreignFieldName, foreignFieldValue, " ID ASC ",false, false);
        /// }

        /// <summary>
        /// 得到数据表Account_user满足外键字段查询条件的记录
        /// </summary>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(string foreignFieldName, int foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(string.Format("`{0}`='{1}'", foreignFieldName, foreignFieldValue), sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user满足外键字段查询条件的记录
        /// </summary>
        /// <param name="con">连接对象</param>
        /// <param name="foreignFieldName">外键字段名称</param>
        /// <param name="foreignFieldValue">外键字段值</param>
		/// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(DbConnection con, string foreignFieldName, int foreignFieldValue, string sortField, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(con, string.Format("`{0}`='{1}'", foreignFieldName, foreignFieldValue), sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的记录数
        /// </summary>
        /// <param name="where">查询条件</param>
        /// <param name="recordCount">记录数</param>
        public void Select(string where, out int recordCount)
        {
#if SP
			const string SQL_COMMAND = "account_userCountByWhere";
			SqlParameter[] param = {
			    new SqlParameter("_Where", SqlDbType.Text),
			    new SqlParameter("_RecordCount", SqlDbType.Int)
			};
			param[0].Value = String.IsNullOrWhiteSpace(where) ? " 1=1 " : where;
			param[1].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param);
			recordCount = Convert.ToInt32(param[1].Value);
#else
            string SQL_COMMAND = new StringBuilder("SELECT COUNT(0) FROM `account_user` WHERE ").Append(String.IsNullOrWhiteSpace(where) ? " 1=1 " : where).ToString();
            recordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(Conn.SqlConn, CommandType.Text, SQL_COMMAND));
#endif
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录数
		/// </summary>
		/// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public void Select(Expression<Func<Account_user, bool>> expression, out int recordCount)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            string SQL_COMMAND = new StringBuilder("SELECT COUNT(0) FROM `account_user` WHERE ").Append(String.IsNullOrWhiteSpace(where) ? " 1=1 " : where).ToString();
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            recordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(Conn.SqlConn, CommandType.Text, SQL_COMMAND, paramList.ToArray()));
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="where">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public void Select(DbConnection con, string where, out int recordCount)
        {
#if SP
			const string SQL_COMMAND = "account_userCountByWhere";
			SqlParameter[] param = {
			    new SqlParameter("_Where", SqlDbType.Text),
			    new SqlParameter("_RecordCount", SqlDbType.Int)
			};
			param[0].Value = String.IsNullOrWhiteSpace(where) ? " 1=1 " : where;
			param[1].Direction = ParameterDirection.Output;
			SqlHelper.ExecuteNonQuery(con, CommandType.StoredProcedure, SQL_COMMAND, param);
			recordCount = Convert.ToInt32(param[1].Value);
#else
            string SQL_COMMAND = new StringBuilder("SELECT COUNT(0) FROM `account_user` WHERE ").Append(String.IsNullOrWhiteSpace(where) ? " 1=1 " : where).ToString();
            recordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(con, CommandType.Text, SQL_COMMAND));
#endif
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的记录数
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="expression">查询条件</param>
		/// <param name="recordCount">记录数</param>
		public void Select(DbConnection con, Expression<Func<Account_user, bool>> expression, out int recordCount)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            string SQL_COMMAND = new StringBuilder("SELECT COUNT(0) FROM `account_user` WHERE ").Append(String.IsNullOrWhiteSpace(where) ? " 1=1 " : where).ToString();
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            recordCount = Convert.ToInt32(SqlHelper.ExecuteScalar(con, CommandType.Text, SQL_COMMAND, paramList.ToArray()));
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int pageSize, int pageIndex)
        {
            return this.Select(pageSize, pageIndex, " 1=1 ");
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex)
        {
            return this.Select(con, pageSize, pageIndex, " 1=1 ");
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int pageSize, int pageIndex, string where)
        {
            return this.Select(pageSize, pageIndex, where, "", false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression)
        {
            return this.Select(pageSize, pageIndex, expression, "", false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, string where)
        {
            return this.Select(con, pageSize, pageIndex, where, "", false, false);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression)
        {
            return this.Select(con, pageSize, pageIndex, expression, "", false, false);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(pageSize, pageIndex, " 1=1 ", bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(con, pageSize, pageIndex, " 1=1 ", bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(pageSize, pageIndex, where, "", bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(pageSize, pageIndex, expression, "", bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, string where, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(con, pageSize, pageIndex, where, "", bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, bool bParentTable, bool bChildrenTable)
        {
            return this.Select(con, pageSize, pageIndex, expression, "", bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件的分页记录
        /// </summary>
        /// <param name="pageSize">每页显示记录数</param>
        /// <param name="pageIndex">当前显示第几页</param>
        /// <param name="where">查询条件</param>
        /// <param name="sortField">排序字段</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sortField = " `ID` ASC ";
            }
#if SP
			const string SQL_COMMAND = "account_userSelectByPagerParams";
			SqlParameter[] param = {
				new SqlParameter("_PageSize", SqlDbType.Int),
				new SqlParameter("_PageIndex", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = pageSize;
			param[1].Value = pageIndex;
			param[2].Value = where;
			param[3].Value = sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            int before = pageSize * (pageIndex - 1);
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT ").Append(before).Append(",").Append(pageSize);
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="expression">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sortField = " `ID` ASC ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            int before = pageSize * (pageIndex - 1);
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT ").Append(before).Append(",").Append(pageSize);
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable)
        {
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sortField = " `ID` ASC ";
            }
#if SP
			const string SQL_COMMAND = "account_userSelectByPagerParams";
			SqlParameter[] param = {
				new SqlParameter("_PageSize", SqlDbType.Int),
				new SqlParameter("_PageIndex", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = pageSize;
			param[1].Value = pageIndex;
			param[2].Value = where;
			param[3].Value = sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
			}
#else
            int before = pageSize * (pageIndex - 1);
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT ").Append(before).Append(",").Append(pageSize);
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
#endif
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable)
        {
            WherePart wherePart = new WhereBuilder('`').ToSql<Account_user>(expression);
            string where = wherePart.Sql;
            List<Account_user> list = new List<Account_user>();
            if (String.IsNullOrWhiteSpace(where))
            {
                where = " 1=1 ";
            }
            if (String.IsNullOrWhiteSpace(sortField))
            {
                sortField = " `ID` ASC ";
            }
            List<SqlParameter> paramList = new List<SqlParameter>(wherePart.Parameters.Count);
            foreach (KeyValuePair<string, object> pair in wherePart.Parameters)
            {
                paramList.Add(new SqlParameter("@" + pair.Key, pair.Value));
            }
            int before = pageSize * (pageIndex - 1);
            StringBuilder sb = new StringBuilder("SELECT `ID`,`PetName`,`RealName`,`LoginAccount`,`LoginPassword`,`LoginTime`,`LoginIP`,`Status`,`Phone`,`Email`,`GroupText`,`RoleText`,`Department`,`Hash`,`IsLimitLogin`,`CreateTime`,`CreateUserName`,`UpdateTime`,`UpdateUserName` FROM `account_user` WHERE ").Append(where).Append(" ORDER BY ").Append(sortField).Append(" LIMIT ").Append(before).Append(",").Append(pageSize);
            string SQL_COMMAND = sb.ToString();
            sb.Clear();
            sb = null;
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.Text, SQL_COMMAND, paramList.ToArray()))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, string where, string sortField, out int recordCount)
        {
            return this.Select(pageSize, pageIndex, where, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, out int recordCount)
        {
            return this.Select(pageSize, pageIndex, expression, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, out int recordCount)
        {
            return this.Select(con, pageSize, pageIndex, where, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, out int recordCount)
        {
            return this.Select(con, pageSize, pageIndex, expression, sortField, false, false, out recordCount);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="where">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            recordCount = 0;
#if SP
			List< Account_user > list = new List< Account_user >();
			const string SQL_COMMAND = "account_userSelectByPagerParamsCount";
			SqlParameter[] param = {
				new SqlParameter("_PageSize", SqlDbType.Int),
				new SqlParameter("_PageIndex", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = pageSize;
			param[1].Value = pageIndex;
			param[2].Value = String.IsNullOrWhiteSpace(where) ? " 1=1 " : where;
			param[3].Value = String.IsNullOrWhiteSpace(sortField) ? " `ID` ASC " : sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn_ReadOnly, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
                if (dr.NextResult())
                {
                    if (dr.Read())
                    {
                        recordCount = dr.GetInt32(0);
                    }
                }
			}
            if( bParentTable || bChildrenTable ) {
    			foreach (Account_user obj in list)
    			{
    				this.Get(obj, bParentTable, bChildrenTable);
    			}
            }
            list.TrimExcess();
			return list;
#else
            this.Select(where, out recordCount);
            return this.Select(pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable);
#endif
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
		/// </summary>
		/// <param name="pageSize">每页显示记录数</param>
		/// <param name="pageIndex">当前显示第几页</param>
		/// <param name="expression">查询条件</param>
		/// <param name="sortField">排序字段</param>
		/// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="recordCount">返回查询记录数</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            recordCount = 0;
            this.Select(expression, out recordCount);
            return this.Select(pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
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
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, string where, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            recordCount = 0;
#if SP
			List< Account_user > list = new List< Account_user >();
			const string SQL_COMMAND = "account_userSelectByPagerParamsCount";
			SqlParameter[] param = {
				new SqlParameter("_PageSize", SqlDbType.Int),
				new SqlParameter("_PageIndex", SqlDbType.Int),
				new SqlParameter("_Where", SqlDbType.Text),
				new SqlParameter("_SortField", SqlDbType.Text)
			};
			param[0].Value = pageSize;
			param[1].Value = pageIndex;
			param[2].Value = String.IsNullOrWhiteSpace(where) ? " 1=1 " : where;
			param[3].Value = String.IsNullOrWhiteSpace(sortField) ? " `ID` ASC " : sortField;
			using(SqlDataReader dr = SqlHelper.ExecuteReader(con, CommandType.StoredProcedure, SQL_COMMAND, param))
			{
				while(dr.Read())
				{
					list.Add(this.Select(dr));
				}
                if (dr.NextResult())
                {
                    if (dr.Read())
                    {
                        recordCount = dr.GetInt32(0);
                    }
                }
			}
            if( bParentTable || bChildrenTable ) {
    			foreach (Account_user obj in list)
    			{
    				this.Get(con, obj, bParentTable, bChildrenTable);
    			}
            }
            list.TrimExcess();
			return list;
#else
            this.Select(con, where, out recordCount);
            return this.Select(con, pageSize, pageIndex, where, sortField, bParentTable, bChildrenTable);
#endif
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件的分页记录
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
		public List<Account_user> Select(DbConnection con, int pageSize, int pageIndex, Expression<Func<Account_user, bool>> expression, string sortField, bool bParentTable, bool bChildrenTable, out int recordCount)
        {
            recordCount = 0;
            this.Select(con, expression, out recordCount);
            return this.Select(con, pageSize, pageIndex, expression, sortField, bParentTable, bChildrenTable);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件记录
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(CommandType commandType, string commandText, params DbParameter[] param)
        {
            return this.Select(false, false, commandType, commandText, param);
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="commandType">命令类型</param>
		/// <param name="commandText">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, CommandType commandType, string commandText, params DbParameter[] param)
        {
            return this.Select(con, false, false, commandType, commandText, param);
        }
        /// <summary>
        /// 得到数据表Account_user满足查询条件记录
        /// </summary>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
        /// <param name="commandType">命令类型</param>
        /// <param name="commandText">SQL命令</param>
        /// <param name="param">命令参数数组</param>
        /// <returns>结果集</returns>
        public List<Account_user> Select(bool bParentTable, bool bChildrenTable, CommandType commandType, string commandText, params DbParameter[] param)
        {
            List<Account_user> list = new List<Account_user>();
            using (SqlDataReader dr = SqlHelper.ExecuteReader(Conn.SqlConn, commandType, commandText, param))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        /// <summary>
		/// 得到数据表Account_user满足查询条件记录
		/// </summary>
		/// <param name="con">连接对象</param>
        /// <param name="bParentTable">是/否设置与父表对象关联</param>
        /// <param name="bChildrenTable">是/否设置与子表对象关联</param>
		/// <param name="commandType">命令类型</param>
		/// <param name="commandText">SQL命令</param>
		/// <param name="param">命令参数数组</param>
		/// <returns>结果集</returns>
		public List<Account_user> Select(DbConnection con, bool bParentTable, bool bChildrenTable, CommandType commandType, string commandText, params DbParameter[] param)
        {
            List<Account_user> list = new List<Account_user>();
            using (SqlDataReader dr = SqlHelper.ExecuteReader(con, commandType, commandText, param))
            {
                while (dr.Read())
                {
                    list.Add(this.Select(dr));
                }
            }
            if (bParentTable || bChildrenTable)
            {
                foreach (Account_user obj in list)
                {
                    this.Get(con, obj, bParentTable, bChildrenTable);
                }
            }
            list.TrimExcess();
            return list;
        }
        #endregion

        #endregion
    }
}