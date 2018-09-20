using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
	///
	/// </summary>
	[Serializable]
    public partial class Account_group:IEntity
    {
        #region 常量
        ///<summary>
		///
		///</summary>
        public const string _ACCOUNT_GROUP_ = "account_group";
        ///<summary>
        ///自增ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///名称
        ///</summary>
        public const string _NAME_ = "Name";
        ///<summary>
        ///描述
        ///</summary>
        public const string _DESCRIPTION_ = "Description";
        ///<summary>
        ///排序
        ///</summary>
        public const string _SORT_ = "Sort";
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
        ///自增ID
        ///</summary>
        private int _iD;
        ///<summary>
        ///名称
        ///</summary>
        private string _name = "";
        ///<summary>
        ///描述
        ///</summary>
        private string _description = "";
        ///<summary>
        ///排序
        ///</summary>
        private string _sort = "";
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
        public Account_group()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public Account_group
        (
            string name,
            string description,
            string sort,
            string remark,
            DateTime createTime,
            string createUserName,
            DateTime updateTime,
            string updateUserName
        )
        {
            _name = name;
            _description = description;
            _sort = sort;
            _remark = remark;
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
        ///名称
        ///</summary>
        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary>
        ///描述
        ///</summary>
        [Required]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        ///<summary>
        ///排序
        ///</summary>
        [Required]
        public string Sort
        {
            get { return _sort; }
            set { _sort = value; }
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
            if (obj is Account_group)
            {
                result = (obj as Account_group).ID == this.ID;
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