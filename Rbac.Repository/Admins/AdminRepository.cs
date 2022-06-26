using Rbac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Repository.Admins
{
    public class AdminRepository : BaseRepository<Admin, int>, IAdminRepository
    {
        public AdminRepository(RbacDbContext context)
        {
            this.db = context;
        }
    }
}
