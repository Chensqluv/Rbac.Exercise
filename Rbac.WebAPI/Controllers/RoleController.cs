using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application.Roles;
using Rbac.Application.Roles.Dto;
using Rbac.Entity;

namespace Rbac.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : BaseController<IRoleService, Role, RoleDto>
    {
        public RoleController(IRoleService role) : base(role)
        {
        }
    }
}
