using System;

namespace SimpleLoginAuthorization.DB
{
    /// <summary>
    /// 实体类公共接口，用来记录表操作的痕迹
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// 创建人
        /// </summary>
        string CreateUserName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        string UpdateUserName { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        DateTime UpdateTime { get; set; }
    }
}