using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Application.Admins.Dto
{
    public class TokenDto : ResultDto
    {
        /// <summary>
        /// JWT token
        /// </summary>
        public string Token { get; set; }
    }
}
