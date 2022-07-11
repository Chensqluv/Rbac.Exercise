using Rbac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Repository.MenuRoles
{
    public class MrRespository : BaseRepository<MenuRole, int>,IMrRespository
    {
        public MrRespository(RbacDbContext db)
        {
            this.db = db;
        }
    }
}
