using System;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
	///
	/// </summary>
	[Serializable]
    public partial class Account_user
    {
        #region 常量
        ///<summary>
		///
		///</summary>
        public const string _ACCOUNT_USER_ = "account_user";
        ///<summary>
        ///用户ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///昵称
        ///</summary>
        public const string _PETNAME_ = "PetName";
        ///<summary>
        ///真实姓名
        ///</summary>
        public const string _REALNAME_ = "RealName";
        ///<summary>
        ///登录账户
        ///</summary>
        public const string _LOGINACCOUNT_ = "LoginAccount";
        ///<summary>
        ///登录密码
        ///</summary>
        public const string _LOGINPASSWORD_ = "LoginPassword";
        ///<summary>
        ///最后一次登录时间
        ///</summary>
        public const string _LOGINTIME_ = "LoginTime";
        ///<summary>
        ///最后一次登录IP
        ///</summary>
        public const string _LOGINIP_ = "LoginIP";
        ///<summary>
        ///用户状态[枚举]：正常，冻结，注销.....
        ///</summary>
        public const string _STATUS_ = "Status";
        ///<summary>
        ///手机/座机
        ///</summary>
        public const string _PHONE_ = "Phone";
        ///<summary>
        ///邮箱
        ///</summary>
        public const string _EMAIL_ = "Email";
        ///<summary>
        ///所属组文本(冗余字段,用“,”分割)
        ///</summary>
        public const string _GROUPTEXT_ = "GroupText";
        ///<summary>
        ///所属角色(冗余字段，用“,”分割)
        ///</summary>
        public const string _ROLETEXT_ = "RoleText";
        ///<summary>
        ///所属部门
        ///</summary>
        public const string _DEPARTMENT_ = "Department";
        ///<summary>
        ///用户HasH,可用于找回密码以及清空用户缓存使用
        ///</summary>
        public const string _HASH_ = "Hash";
        ///<summary>
        ///是否限制IP登录【1：限制，0：不限制】
        ///</summary>
        public const string _ISLIMITLOGIN_ = "IsLimitLogin";
        ///<summary>
        ///
        ///</summary>
        public const string _CREATETIME_ = "CreateTime";
        ///<summary>
        ///
        ///</summary>
        public const string _CREATEUSERNAME_ = "CreateUserName";
        ///<summary>
        ///
        ///</summary>
        public const string _UPDATETIME_ = "UpdateTime";
        ///<summary>
        ///
        ///</summary>
        public const string _UPDATEUSERNAME_ = "UpdateUserName";
        #endregion

        #region 变量定义
        ///<summary>
        ///用户ID
        ///</summary>
        private int _iD;
        ///<summary>
        ///昵称
        ///</summary>
        private string _petName = "";
        ///<summary>
        ///真实姓名
        ///</summary>
        private string _realName = "";
        ///<summary>
        ///登录账户
        ///</summary>
        private string _loginAccount = "";
        ///<summary>
        ///登录密码
        ///</summary>
        private string _loginPassword = "";
        ///<summary>
        ///最后一次登录时间
        ///</summary>
        private DateTime _loginTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///最后一次登录IP
        ///</summary>
        private string _loginIP = "";
        ///<summary>
        ///用户状态[枚举]：正常，冻结，注销.....
        ///</summary>
        private int _status;
        ///<summary>
        ///手机/座机
        ///</summary>
        private string _phone = "";
        ///<summary>
        ///邮箱
        ///</summary>
        private string _email = "";
        ///<summary>
        ///所属组文本(冗余字段,用“,”分割)
        ///</summary>
        private string _groupText = "";
        ///<summary>
        ///所属角色(冗余字段，用“,”分割)
        ///</summary>
        private string _roleText = "";
        ///<summary>
        ///所属部门
        ///</summary>
        private string _department = "";
        ///<summary>
        ///用户HasH,可用于找回密码以及清空用户缓存使用
        ///</summary>
        private string _hash = "";
        ///<summary>
        ///是否限制IP登录【1：限制，0：不限制】
        ///</summary>
        private int _isLimitLogin;
        ///<summary>
        ///
        ///</summary>
        private DateTime _createTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///
        ///</summary>
        private string _createUserName = "";
        ///<summary>
        ///
        ///</summary>
        private DateTime _updateTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///
        ///</summary>
        private string _updateUserName = "";


        #endregion

        #region 构造函数
        ///<summary>
        ///
        ///</summary>
        public Account_user()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public Account_user
        (
            string petName,
            string realName,
            string loginAccount,
            string loginPassword,
            DateTime loginTime,
            string loginIP,
            int status,
            string phone,
            string email,
            string groupText,
            string roleText,
            string department,
            string hash,
            int isLimitLogin,
            DateTime createTime,
            string createUserName,
            DateTime updateTime,
            string updateUserName
        )
        {
            _petName = petName;
            _realName = realName;
            _loginAccount = loginAccount;
            _loginPassword = loginPassword;
            _loginTime = loginTime;
            _loginIP = loginIP;
            _status = status;
            _phone = phone;
            _email = email;
            _groupText = groupText;
            _roleText = roleText;
            _department = department;
            _hash = hash;
            _isLimitLogin = isLimitLogin;
            _createTime = createTime;
            _createUserName = createUserName;
            _updateTime = updateTime;
            _updateUserName = updateUserName;

        }
        #endregion

        #region 公共属性

        ///<summary>
        ///用户ID
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///昵称
        ///</summary>
        public string PetName
        {
            get { return _petName; }
            set { _petName = value; }
        }

        ///<summary>
        ///真实姓名
        ///</summary>
        public string RealName
        {
            get { return _realName; }
            set { _realName = value; }
        }

        ///<summary>
        ///登录账户
        ///</summary>
        public string LoginAccount
        {
            get { return _loginAccount; }
            set { _loginAccount = value; }
        }

        ///<summary>
        ///登录密码
        ///</summary>
        public string LoginPassword
        {
            get { return _loginPassword; }
            set { _loginPassword = value; }
        }

        ///<summary>
        ///最后一次登录时间
        ///</summary>
        public DateTime LoginTime
        {
            get { return _loginTime; }
            set { _loginTime = value; }
        }

        ///<summary>
        ///最后一次登录IP
        ///</summary>
        public string LoginIP
        {
            get { return _loginIP; }
            set { _loginIP = value; }
        }

        ///<summary>
        ///用户状态[枚举]：正常，冻结，注销.....
        ///</summary>
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        ///<summary>
        ///手机/座机
        ///</summary>
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        ///<summary>
        ///邮箱
        ///</summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        ///<summary>
        ///所属组文本(冗余字段,用“,”分割)
        ///</summary>
        public string GroupText
        {
            get { return _groupText; }
            set { _groupText = value; }
        }

        ///<summary>
        ///所属角色(冗余字段，用“,”分割)
        ///</summary>
        public string RoleText
        {
            get { return _roleText; }
            set { _roleText = value; }
        }

        ///<summary>
        ///所属部门
        ///</summary>
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        ///<summary>
        ///用户HasH,可用于找回密码以及清空用户缓存使用
        ///</summary>
        public string Hash
        {
            get { return _hash; }
            set { _hash = value; }
        }

        ///<summary>
        ///是否限制IP登录【1：限制，0：不限制】
        ///</summary>
        public int IsLimitLogin
        {
            get { return _isLimitLogin; }
            set { _isLimitLogin = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime CreateTime
        {
            get { return _createTime; }
            set { _createTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string CreateUserName
        {
            get { return _createUserName; }
            set { _createUserName = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public DateTime UpdateTime
        {
            get { return _updateTime; }
            set { _updateTime = value; }
        }

        ///<summary>
        ///
        ///</summary>
        public string UpdateUserName
        {
            get { return _updateUserName; }
            set { _updateUserName = value; }
        }



        #endregion

        #region 重写的方法
        public override bool Equals(object obj)
        {
            bool result = false;
            if (obj is Account_user)
            {
                result = (obj as Account_user).ID == this.ID;
            }
            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion
    }
}