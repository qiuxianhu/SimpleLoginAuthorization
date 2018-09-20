using System;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
	///用户组和权限的多对多中间表
	/// </summary>
	[Serializable]
    public partial class Account_grouppermissionassign
        :


         IEntity
    {
        #region 常量
        ///<summary>
		///
		///</summary>
        public const string _ACCOUNT_GROUPPERMISSIONASSIGN_ = "account_grouppermissionassign";
        ///<summary>
        ///自增ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///用户组ID(外键)
        ///</summary>
        public const string _GROUPID_ = "GroupID";
        ///<summary>
        ///权限ID(外键)
        ///</summary>
        public const string _PERMISSIONID_ = "PermissionID";
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
        ///自增ID
        ///</summary>
        private int _iD;
        ///<summary>
        ///用户组ID(外键)
        ///</summary>
        private int _groupID;
        ///<summary>
        ///权限ID(外键)
        ///</summary>
        private string _permissionID = "";
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
        public Account_grouppermissionassign()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public Account_grouppermissionassign
        (
            int groupID,
            string permissionID,
            DateTime createTime,
            string createUserName,
            DateTime updateTime,
            string updateUserName
        )
        {
            _groupID = groupID;
            _permissionID = permissionID;
            _createTime = createTime;
            _createUserName = createUserName;
            _updateTime = updateTime;
            _updateUserName = updateUserName;

        }
        #endregion

        #region 公共属性

        ///<summary>
        ///自增ID
        ///</summary>
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///用户组ID(外键)
        ///</summary>
        public int GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }

        ///<summary>
        ///权限ID(外键)
        ///</summary>
        public string PermissionID
        {
            get { return _permissionID; }
            set { _permissionID = value; }
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
            if (obj is Account_grouppermissionassign)
            {
                result = (obj as Account_grouppermissionassign).ID == this.ID;
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