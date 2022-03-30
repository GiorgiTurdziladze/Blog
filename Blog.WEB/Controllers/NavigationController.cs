using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.BLL.Enums;
using Blog.BLL.Extensions;
using Blog.BLL.ViewModels;
using Blog.DAL.Domains;

namespace Blog.WEB.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult GetNavigationPartial()
        {
            var user = HttpContext.Session.GetObjectFromJson<User>("User");
            var type = NavigationMenuEnum.None;
            if (user == null)
            {
                type |= NavigationMenuEnum.Register;
                type |= NavigationMenuEnum.LogIn;
                type |= NavigationMenuEnum.Posts;

            }
            else
            {
                type |= NavigationMenuEnum.LogOut;
                type |= NavigationMenuEnum.Posts;
                type |= NavigationMenuEnum.UserPosts;
            }

            var model = new NavigationMenuModel
            {
                Menu = type
            };
            return PartialView("_NavigationPartial", model);
        }
    }
}
