using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application.Admins;
using Rbac.Application.Admins.Dto;
using Rbac.Entity;

namespace Rbac.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : BaseController<IAdminService, Admin, AdminDto>
    {
        private readonly IAdminService admin;

        public AdminController(IAdminService admin) : base(admin)
        {
            this.admin = admin;
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Register(AdminDto dto)
        {
            return Ok(admin.Register(dto));
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginDto dto)
        {
            return Ok(admin.Login(dto));
        }
    }
}
