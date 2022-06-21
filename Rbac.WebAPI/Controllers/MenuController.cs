using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        public MenuController(IMenuService service)
        {
            Service = service;
        }

        public IMenuService Service { get; }

        /// <summary>
        /// 获取菜单信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<MenuDto> GetAll()
        {
            return Service.GetAll();
        }
        /// <summary>
        /// 获取菜单下拉框信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CascaderDto> GetList()
        {
            return Service.GetList();
        }
        /// <summary>
        /// 添加菜单信息
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddMenu(Menu menu)
        {
            return Service.AddMenu(menu);
        }
        /// <summary>
        /// 删除菜单信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        public int DeleteMenu(int id)
        {
            return Service.DeleteMenu(id);
        }
        /// <summary>
        /// 修改菜单信息
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        [HttpPut]
        public int UpdateMenu(Menu menu)
        {
            return Service.UpdateMenu(menu);
        }
        /// <summary>
        /// 根据id获取单个菜单信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Menu Back(int id)
        {
            return Service.Back(id);
        }
    }
}
