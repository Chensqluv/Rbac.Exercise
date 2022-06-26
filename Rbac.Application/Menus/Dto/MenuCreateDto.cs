using System;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.Application
{
    public class MenuDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string LinkUrl { get; set; }
        public List<MenuDto> children { get; set; } = new List<MenuDto>();
    }
}
