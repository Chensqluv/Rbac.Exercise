using System;

namespace Rbac.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Role : BaseClass
    {
        ///<summary>
        ///角色Id
        ///</summary>
        public int RoleId { get; set; }

        ///<summary>
        ///角色名称
        ///</summary>
        public string RoleName { get; set; }
    }
}
