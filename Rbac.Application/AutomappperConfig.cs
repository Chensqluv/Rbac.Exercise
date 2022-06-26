using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Rbac.Application.Admins.Dto;
using Rbac.Application.Roles.Dto;
using Rbac.Entity;

namespace Rbac.Application
{
    public class AutomappperConfig : Profile
    {
        public AutomappperConfig()
        {
            CreateMap<MenuCreateDto,Menu>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<AdminDto, Admin>().ReverseMap();
        }
    }
}
