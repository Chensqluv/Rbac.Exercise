using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application.Roles;
using Rbac.Application.Roles.Dto;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : BaseController<IRoleService, Role, RoleDto>
    {
        private readonly IRoleService role;

        public RoleController(IRoleService role) : base(role)
        {
            this.role = role;
        }

        [HttpPost]
        public int SavePermission(PerDto per)
        {
            return role.SavePermission(per);
        }
        [HttpGet]
        public List<MenuRoleDto> GetByRoleId(int roleId)
        {
            return role.GetByRoleId(roleId);
        }
    }
}
