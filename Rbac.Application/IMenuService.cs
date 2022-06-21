﻿using System;
using Rbac.Entity;
using System.Collections.Generic;

namespace Rbac.Application
{
    public interface IMenuService
    {
        List<MenuDto> GetAll();
        List<CascaderDto> GetList();
        int AddMenu(Menu menu);
        int DeleteMenu(int id);
        int UpdateMenu(Menu menu);
        Menu Back(int id);
    }
}
