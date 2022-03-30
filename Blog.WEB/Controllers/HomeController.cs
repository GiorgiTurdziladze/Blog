using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blog.BLL.IRepository;
using Blog.BLL.ViewModels;
using X.PagedList;

namespace Blog.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository _postRepository;

        public HomeController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<IActionResult> Index(int? page)
        {
            var model = new PostViewModel();

            model.Posts = await _postRepository.GetAllPosts();

            var pageNumber = page ?? 1;
            var onePageOfPosts = model.Posts.ToPagedList(pageNumber, 5);
            ViewBag.OnePageOfPosts = onePageOfPosts;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
