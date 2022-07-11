using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Application.Admins.Dto
{
    public class AdminDto
    {
        ///<summary>
        ///管理员Id
        ///</summary>
        public long AdminId { get; set; }

        ///<summary>
        ///用户名
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        ///密码
        ///</summary>
        public string Password { get; set; }

        ///<summary>
        ///邮箱
        ///</summary>
        public string Email { get; set; }
        ///<summary>
        ///末次登录时间
        ///</summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }

    public class AdminListDto
    {
        ///<summary>
        ///管理员Id
        ///</summary>
        public long AdminId { get; set; }

        ///<summary>
        ///用户名
        ///</summary>
        public string UserName { get; set; }

        ///<summary>
        ///邮箱
        ///</summary>
        public string Email { get; set; }

        ///<summary>
        ///邮箱
        ///</summary>
        public bool IsLock { get; set; }
        ///<summary>
        ///末次登录时间
        ///</summary>
        public DateTime? LastLoginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string CreateTime { get; set; }
    }
}
