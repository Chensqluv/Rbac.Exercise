using System;

namespace Rbac.Entity
{
    /// <summary>
    /// 管理员和角色的中间表
    /// </summary>
    public class AdminRole
    {
        public int Id { get; set; }
        public long AdminId { get; set; }
        public int RoleId { get; set; }
    }
}
