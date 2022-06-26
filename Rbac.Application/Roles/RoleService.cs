using AutoMapper;
using Rbac.Application.Roles.Dto;
using Rbac.Entity;
using Rbac.Repository;
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
        private readonly IMapper mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper) : base(roleRepository, mapper)
        {
            this.roleRepository = roleRepository;
            this.mapper = mapper;
        }

    }

}
