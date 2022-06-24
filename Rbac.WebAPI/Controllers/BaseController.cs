using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rbac.Application;

namespace Rbac.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BaseController<TService, TEnity, TDto> : ControllerBase
        where TService : IBaseService<TEnity, TDto>
        where TEnity : class, new()
        where TDto : class, new()
    {
        private readonly TService role;

        public BaseController(TService role)
        {
            this.role = role;
        }
        [HttpPost]
        public IActionResult Create(TDto dto)
        {
            return Ok(role.Create(dto));
        }

        [HttpPost]
        public IActionResult Update(TDto dto)
        {
            return Ok(role.Update(dto));
        }

        [HttpGet]
        public IActionResult Find(int id)
        {
            return Ok(role.Find(id));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return Ok(role.Delete(id));
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return new JsonResult(role.GetList());
        }
    }
}
