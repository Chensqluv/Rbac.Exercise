using System;

namespace Rbac.Entity
{
    public class BaseClass
    {
        public int CreateId { get; set; }

        public DateTime CreateTime { get; set; }
        
        public bool IsDelete { get; set; }
    }
}
