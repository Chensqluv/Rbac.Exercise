using Rbac.Application.Admins.Dto;
using Rbac.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Application.Admins
{
    public interface IAdminService : IBaseService<Admin, AdminDto>
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        ResultDto Register(AdminDto dto);
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        TokenDto Login(LoginDto dto);

        Tuple<List<AdminListDto>, int> Page(int Pindex = 1, int Psize = 2);
    }
}
