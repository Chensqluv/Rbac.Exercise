using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rbac.Entity;

namespace Rbac.Repository.Roles
{
    public class RoleRepository : BaseRepository<Role,int>, IRoleRepository
    {
        public RoleRepository(RbacDbContext db)
        {
            this.db = db;
        }
    }
}
