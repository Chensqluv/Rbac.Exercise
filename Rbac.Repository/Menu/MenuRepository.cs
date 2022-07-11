using System;
using Rbac.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Rbac.Repository
{
    public class MenuRepository : IMenuRepository
    {
        public MenuRepository(RbacDbContext context)
        {
            Context = context;
        }

        public RbacDbContext Context { get; }

        public List<Menu> GetAll()
        {
            return Context.Menus.ToList();
        }

        public int AddMenu(Menu menu)
        {
            menu.CreateTime = DateTime.Now;
            Context.Menus.Add(menu);
            return Context.SaveChanges();
        }

        public int DeleteMenu(int id)
        {
            var obj = Context.Menus.Find(id);
            Context.Menus.Remove(obj);
            return Context.SaveChanges();
        }

        public int UpdateMenu(Menu menu)
        {
            Context.Entry(menu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return Context.SaveChanges();
        }
    }

}
