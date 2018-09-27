using SimpleLoginAuthorization.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Security.Principal;
using System.Web;
using System.Web.Security;

namespace SimpleLoginAuthorization.Models
{
    /// <summary>
    /// 登录人用户信息
    /// </summary>
    [Serializable]
    public class User:IIdentity,ISerializable
    {
        #region 构造函数
        /// <summary>
        /// 默认创建用户标识
        /// </summary>
        public User()
        {
            this.IsAuthenticated = false;
        }
        /// <summary>
        /// 通过指定参数创建用户标识
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        public User(int id, string name, string email)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.IsAuthenticated = true;
        }
        /// <summary>
        /// 通过指定参数创建用户标识
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="clientId"></param>
        /// <param name="accountType"></param>
        public User(int id,string name,string email,string clientId,int accountType)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.ClientID = clientId;
            this.AccountType = accountType;
            this.IsAuthenticated = true;
        }
        public User(FormsAuthenticationTicket ticket)
        {
            if (ticket==null)
            {
                throw new ArgumentNullException("ticket");
            }
            User user = this.Desrialize(ticket.UserData);
            if (user==null|| FormsAuthenticationTicketBuilder.TicketVersion!=ticket.Version)
            {
                this.IsAuthenticated = false;
                return;
            }
            this.ID = user.ID;
            this.Name = user.Name;
            this.Email = user.Email;
            this.ClientID = user.ClientID;
            this.AccountType = user.AccountType;
            this.IsAuthenticated = true;
        }
        #endregion 

        #region 属性
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Email { get; set; }
        public string ClientID { get; set; }
        public int AccountType { get; set; }
        #endregion

        #region ISerializable        
        /// <summary>
        /// ISerializable接口函数
        /// </summary>
        /// <param name="info"></param>
        /// <param name="context"></param>
        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ID", this.ID);
            info.AddValue("Name", this.Name);
            info.AddValue("Email", this.Email);
            info.AddValue("ClientID", this.ClientID);
            info.AddValue("AccountType", this.AccountType);
        }
        #endregion

        /// <summary>
        /// 序列化登录人信息
        /// </summary>
        /// <returns></returns>
        public string Serialize()
        {
            return SerializeHelper.Serialize(this);
        }
        /// <summary>
        /// 反序列化登录人信息
        /// </summary>
        /// <param name="userContextData"></param>
        /// <returns></returns>
        public User Desrialize(string userContextData)
        {
            User user = null;
            try
            {
                user = SerializeHelper.Deserialize<User>(userContextData);
            }
            catch
            {
                user = null;
            }
            return user;
        }
        /// <summary>
        /// 授权类型
        /// </summary>
        public string AuthenticationType
        {
            get { return "qiuxianhu"; }
        }        
    }
}