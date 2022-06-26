using System;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.Application
{
    public class MenuCreateDto
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string LinkUrl { get; set; }
        public int ParentId { get; set; }
    }
}
