using System;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.Repository
{
    public interface IMenuRepository
    {
        List<Menu> GetAll();

        int AddMenu(Menu menu);

        int DeleteMenu(int id);

        int UpdateMenu(Menu menu);
    }
}
