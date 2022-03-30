using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.BLL.Extensions;
using Blog.BLL.IRepository;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;

namespace Blog.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepository _userRepository;

        public AccountController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Register()
        {
            var model = new UserRegisterViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userRepository.AddUser(model);
            if (!result.Result)
            {
                ViewBag.message = result.Message;
                return View();
            }

            return RedirectToAction("LogIn");
        }

        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(UserModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var result = await _userRepository.LogIn(model);

            if (!result.Result)
            {
                ViewBag.Message = result.Message;

                return View();
            }

            HttpContext.Session.SetObjectAsJson("User", result.Data);

            return RedirectToAction("Posts", "Post");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
