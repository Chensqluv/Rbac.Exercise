using Rbac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Repository.AdminRoles
{
    public class ArRepository : BaseRepository<AdminRole, int>,IArRepository
    {
        public ArRepository(RbacDbContext db)
        {
            this.db = db;
        }
    }
}
