using System;
using Rbac.Entity;
using System.Collections.Generic;
using Rbac.Repository;
using System.Linq;

namespace Rbac.Application
{
    public class MenuService : IMenuService
    {
        public MenuService(IMenuRepository menuRepository)
        {
            Menu = menuRepository;
        }

        public IMenuRepository Menu { get; }

        public List<MenuDto> GetAll()
        {
            var list = Menu.GetAll();

            List<MenuDto> result = new List<MenuDto>();

            var menulist = list.Where(m=>m.ParentId ==0).Select(m=>new MenuDto
            {
                MenuId = m.MenuId,
                MenuName = m.MenuName,
                LinkUrl = m.LinkUrl
            }).ToList();

            GetNodes(menulist);

            return menulist;
        }

        /// <summary>
        /// 递归--终止条件
        /// </summary>
        /// <param name="menus"></param>
        private void GetNodes(List<MenuDto> menus)
        {
            var list = Menu.GetAll();

            foreach (var item in menus)
            {
                var _list = list.Where(s => s.ParentId == item.MenuId).Select(m => new MenuDto
                {
                    MenuId = m.MenuId,
                    MenuName = m.MenuName,
                    LinkUrl = m.LinkUrl
                }).ToList();

                item.children.AddRange(_list);

                GetNodes(_list);
            }
        }

        public List<CascaderDto> GetList()
        {
            var list = Menu.GetAll();

            List<CascaderDto> result = new List<CascaderDto>();

            var menulist = list.Where(m => m.ParentId == 0).Select(m => new CascaderDto
            {
                value = m.MenuId,
                label = m.MenuName,
            }).ToList();

            GetNodesList(menulist);

            return menulist;
        }

        private void GetNodesList(List<CascaderDto> menus)
        {
            var list = Menu.GetAll();

            foreach (var item in menus)
            {
                var _list = list.Where(s => s.ParentId == item.value).Select(m => new CascaderDto
                {
                    value = m.MenuId,
                    label = m.MenuName,
                }).ToList();

                item.children.AddRange(_list);

                GetNodesList(_list);
            }
        }

        public int AddMenu(Menu menu)
        {
            return Menu.AddMenu(menu);
        }

        public int DeleteMenu(int id)
        {
            return Menu.DeleteMenu(id);
        }

        public int UpdateMenu(Menu menu)
        {
            return Menu.UpdateMenu(menu);
        }

        public Menu Back(int id)
        {
            return Menu.Back(id);
        }
    }
}
