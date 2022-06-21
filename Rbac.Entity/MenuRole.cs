using System;

namespace Rbac.Entity
{
    /// <summary>
    /// 菜单和角色的中间表
    /// </summary>
    public class MenuRole
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
    }
}
