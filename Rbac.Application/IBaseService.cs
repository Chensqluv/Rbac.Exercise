using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbac.Application
{
    public interface IBaseService<TEntity, TDto>
        where TEntity : class, new()
        where TDto : class, new()
    {
        int Create(TDto dto);
        int Update(TDto dto);
        int Delete(int id);
        TDto Find(int id);
        List<TDto> GetList();
    }
}
