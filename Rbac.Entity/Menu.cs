using System;

namespace Rbac.Entity
{
    /// <summary>
    /// 菜单表
    /// </summary>
    public class Menu : BaseClass
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string LinkUrl { get; set; }
        public int ParentId { get; set; }
    }
}
