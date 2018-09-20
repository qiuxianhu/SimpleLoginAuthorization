// ===================================================================
// 工厂(DBFactory)项目
//====================================================================
// qiuxianhu Copyright 
// 文件： DALFactory.cs
// 项目名称：工程项目管理
// 引用实体(Entity)和产品规则(IDAL)项目，System.Configuration程序集
// 在 App.config/web.config 文件
/*
<appSettings>
	<add key="DALURL" value="DAL"/>
</appSettings>
*/
// ===================================================================
using System.Reflection;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// 数据层工厂
    /// </summary>
    public class DALFactory
    {
        /// <summary>
        /// 通过反射机制，实例化接口对象
        /// </summary>
        private static readonly string _path = System.Configuration.ConfigurationManager.AppSettings["DALURL"];
        private static readonly Assembly _Assembly = Assembly.Load(DALFactory._path);
        /// <summary>
        /// 通过反射机制，实例化Account_permission接口对象
        /// </summary>
        ///<returns>Account_permission接口对象/returns>
        public static IAccount_permissionDAL Account_permissionDALInstance()
        {
            return (IAccount_permissionDAL)_Assembly.CreateInstance(DALFactory._path + ".Account_permissionDAL");
        }
    }
}