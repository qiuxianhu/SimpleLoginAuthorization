using System;
using System.Web.Mvc;

namespace SimpleLoginAuthorization.Common
{
    public class JsonManager
    {
        /// <summary>
        /// 创建一个失败的json实体
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="msg">错误提示</param>
        /// <returns></returns>
        public static JsonResult GetError(int code, string msg)
        {
            return GetError(code, msg, (string)null);
        }
        /// <summary>
        /// 创建一个失败的json实体
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="error">错误信息</param>
        /// <param name="msg">错误提示</param>
        /// <returns></returns>
        public static JsonResult GetError(int code, string msg, string error)
        {
            return GetError(code, msg, error == null ? null : new string[1] { error });
        }
        /// <summary>
        /// 创建一个失败的json实体
        /// </summary>
        /// <param name="code">错误码</param>
        /// <param name="error">错误信息</param>
        /// <param name="msg">错误提示</param>
        /// <returns></returns>
        public static JsonResult GetError(int code, string msg, string[] error)
        {
            return Get(new JsonModel()
            {
                Code = code,
                Data = null,
                Error = error,
                Success = false,
                Message = msg
            });
        }
        public static JsonResult Get(JsonModel jsonModel)
        {
            if (jsonModel == null)
            {
                throw new ArgumentNullException("jsonModel");
            }
            return new JsonResult()
            {
                Data = jsonModel,
                MaxJsonLength = int.MaxValue,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}