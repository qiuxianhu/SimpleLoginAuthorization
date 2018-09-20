using System;

namespace SimpleLoginAuthorization.DB
{
    [Serializable]
    public partial class Account_permission:IEntity
    {
        #region 常量
        ///<summary>
		///
		///</summary>
        public const string _ACCOUNT_PERMISSION_ = "account_permission";
        ///<summary>
        ///自增ID
        ///</summary>
        public const string _ID_ = "ID";
        ///<summary>
        ///父ID
        ///</summary>
        public const string _PARENTID_ = "ParentID";
        ///<summary>
        ///权限KEY
        ///</summary>
        public const string _PERMISSIONKEY_ = "PermissionKey";
        ///<summary>
        ///权限名称
        ///</summary>
        public const string _NAME_ = "Name";
        ///<summary>
        ///描述
        ///</summary>
        public const string _DESCRIPTION_ = "Description";
        ///<summary>
        ///图标
        ///</summary>
        public const string _ICON_ = "Icon";
        ///<summary>
        ///是否成为导航菜单
        ///</summary>
        public const string _CANMENU_ = "CanMenu";
        ///<summary>
        ///其他数据[Json]
        ///</summary>
        public const string _DATA_ = "Data";
        ///<summary>
        ///导航连接
        ///</summary>
        public const string _HREF_ = "Href";
        ///<summary>
        ///是否可用
        ///</summary>
        public const string _ISENABLE_ = "IsEnable";
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
        ///权限KEY
        ///</summary>
        private string _permissionKey = "";
        ///<summary>
        ///权限名称
        ///</summary>
        private string _name = "";
        ///<summary>
        ///描述
        ///</summary>
        private string _description = "";
        ///<summary>
        ///图标
        ///</summary>
        private string _icon = "";
        ///<summary>
        ///是否成为导航菜单
        ///</summary>
        private int _canMenu;
        ///<summary>
        ///其他数据[Json]
        ///</summary>
        private string _data = "";
        ///<summary>
        ///导航连接
        ///</summary>
        private string _href = "";
        ///<summary>
        ///是否可用
        ///</summary>
        private int _isEnable;
        ///<summary>
        ///排序
        ///</summary>
        private int _sort;
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
        public Account_permission()
        {
        }
        ///<summary>
        ///
        ///</summary>
        public Account_permission
        (
            string parentID,
            string permissionKey,
            string name,
            string description,
            string icon,
            int canMenu,
            string data,
            string href,
            int isEnable,
            int sort,
            string remark,
            DateTime createTime,
            string createUserName,
            DateTime updateTime,
            string updateUserName
        )
        {
            _parentID = parentID;
            _permissionKey = permissionKey;
            _name = name;
            _description = description;
            _icon = icon;
            _canMenu = canMenu;
            _data = data;
            _href = href;
            _isEnable = isEnable;
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
        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        ///<summary>
        ///父ID
        ///</summary>
        public string ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        ///<summary>
        ///权限KEY
        ///</summary>
        public string PermissionKey
        {
            get { return _permissionKey; }
            set { _permissionKey = value; }
        }

        ///<summary>
        ///权限名称
        ///</summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        ///<summary>
        ///描述
        ///</summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        ///<summary>
        ///图标
        ///</summary>
        public string Icon
        {
            get { return _icon; }
            set { _icon = value; }
        }

        ///<summary>
        ///是否成为导航菜单
        ///</summary>
        public int CanMenu
        {
            get { return _canMenu; }
            set { _canMenu = value; }
        }

        ///<summary>
        ///其他数据[Json]
        ///</summary>
        public string Data
        {
            get { return _data; }
            set { _data = value; }
        }

        ///<summary>
        ///导航连接
        ///</summary>
        public string Href
        {
            get { return _href; }
            set { _href = value; }
        }

        ///<summary>
        ///是否可用
        ///</summary>
        public int IsEnable
        {
            get { return _isEnable; }
            set { _isEnable = value; }
        }

        ///<summary>
        ///排序
        ///</summary>
        public int Sort
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
            if (obj is Account_permission)
            {
                result = (obj as Account_permission).ID == this.ID;
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