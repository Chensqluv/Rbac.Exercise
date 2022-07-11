using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application.Admins;
using Rbac.Application.Admins.Dto;
using Rbac.Entity;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// 分页显示数据
        /// </summary>
        /// <param name="Pindex"></param>
        /// <param name="Psize"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Page(int Pindex = 1, int Psize = 2)
        {
            return Ok(admin.Page(Pindex, Psize));
        }
    }
}
