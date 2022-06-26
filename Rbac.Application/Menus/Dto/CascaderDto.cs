using System;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.Application
{
    public class CascaderDto
    {
        public int value { get; set; }
        public string label { get; set; }
        public List<CascaderDto> children { get; set; } = new List<CascaderDto>();
    }
}
