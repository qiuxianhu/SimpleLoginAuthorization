using System;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
	///
	/// </summary>
	[Serializable]
    public partial class Account_usergroupassign:IEntity
    {
        #region 常量
        ///<summary>
		///
		///</summary>
        public const string _ACCOUNT_USERGROUPASSIGN_ = "account_usergroupassign";
        ///<summary>
        ///
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///用户ID(外键)
        ///</summary>
        public const string _USERID_ = "UserID";
        ///<summary>
        ///组ID(外键)
        ///</summary>
        public const string _GROUPID_ = "GroupID";
        ///<summary>
        ///过期时间
        ///</summary>
        public const string _EXPIREDTIME_ = "ExpiredTime";
        ///<summary>
        ///备注
        ///</summary>
        public const string _REMARK_ = "Remark";
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
        ///
        ///</summary>
        private int _iD;
        ///<summary>
        ///用户ID(外键)
        ///</summary>
        private int _userID;
        ///<summary>
        ///组ID(外键)
        ///</summary>
        private int _groupID;
        ///<summary>
        ///过期时间
        ///</summary>
        private DateTime _expiredTime = new DateTime(1900, 1, 1);
        ///<summary>
        ///备注
        ///</summary>
        private string _remark = "";
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
        public Account_usergroupassign()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public Account_usergroupassign
        (
            int userID,
            int groupID,
            DateTime expiredTime,
            string remark,
            DateTime createTime,
            string createUserName,
            DateTime updateTime,
            string updateUserName
        )
        {
            _userID = userID;
            _groupID = groupID;
            _expiredTime = expiredTime;
            _remark = remark;
            _createTime = createTime;
            _createUserName = createUserName;
            _updateTime = updateTime;
            _updateUserName = updateUserName;

        }
        #endregion

        #region 公共属性

        ///<summary>
        ///
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///用户ID(外键)
        ///</summary>
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        ///<summary>
        ///组ID(外键)
        ///</summary>
        public int GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }

        ///<summary>
        ///过期时间
        ///</summary>
        public DateTime ExpiredTime
        {
            get { return _expiredTime; }
            set { _expiredTime = value; }
        }

        ///<summary>
        ///备注
        ///</summary>
        public string Remark
        {
            get { return _remark; }
            set { _remark = value; }
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
            if (obj is Account_usergroupassign)
            {
                result = (obj as Account_usergroupassign).ID == this.ID;
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