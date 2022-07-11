using AutoMapper;
using Rbac.Application.Roles.Dto;
using Rbac.Entity;
using Rbac.Repository;
using Rbac.Repository.MenuRoles;
using Rbac.Repository.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Application.Roles
{
    public class RoleService : BaseService<Role, RoleDto>, IRoleService
    {
        private readonly IRoleRepository roleRepository;
        private readonly IMrRespository mrRespository;
        private readonly IMapper mapper;

        public RoleService(IRoleRepository roleRepository, IMrRespository mrRespository, IMapper mapper) : base(roleRepository, mapper)
        {
            this.roleRepository = roleRepository;
            this.mrRespository = mrRespository;
            this.mapper = mapper;
        }

        public List<MenuRoleDto> GetByRoleId(int roleId)
        {
            return mapper.Map<List<MenuRoleDto>>(mrRespository.GetQuery().Where(x => x.RoleId == roleId).ToList());
        }

        public int SavePermission(PerDto per)
        {
            mrRespository.Delete(m=>m.RoleId==per.RoleId);

            var ids = per.MenuId.Select(m => new MenuRole { MenuId = m, RoleId = per.RoleId }).ToList();

            return mrRespository.BulkCreate(ids);
        }
    }

}
