using System;

namespace SimpleLoginAuthorization.DB
{
    partial class Account_permission
    {
        ///<summary>
        ///自增ID
        ///</summary>
        private string _iD = Guid.NewGuid().ToString("D");
        ///<summary>
        ///父ID
        ///</summary>
        private string _parentID = Guid.Empty.ToString("D");
    }
}