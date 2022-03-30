using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Blog.BLL.Extensions;
using Blog.BLL.Handlers;
using Blog.BLL.Helpers;
using Blog.BLL.IRepository;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;
using Blog.DAL.Domains;
using Microsoft.AspNetCore.Hosting;
using X.PagedList;

namespace Blog.WEB.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PostController(IPostRepository postRepository, IHostingEnvironment hostingEnvironment)
        {
            _postRepository = postRepository;
            _hostingEnvironment = hostingEnvironment;
        }

        private async Task<string> ProcessUploadFile(PostModel model)
        {

            string uniqueFileName = null;
            if (model.PhotoPath != null)
            {

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.PhotoPath.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var memoryStream = new MemoryStream())
                {
                    await model.PhotoPath.CopyToAsync(memoryStream);
                    using (var img = Image.FromStream(memoryStream))
                    {
                        var image = PhotoSizeConverter.ScaleImage(img, 1200, 628);
                        image.Save(filePath);
                    }
                }
            }

            return uniqueFileName;
        }

        [LoggedInUserFilter]
        public IActionResult Add()
        {
            var model = new PostModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            model.FileName = await ProcessUploadFile(model);

            var user = HttpContext.Session.GetObjectFromJson<User>("User");

            await _postRepository.AddPost(model, user);

            return RedirectToAction("Posts", "Post");
        }

        [LoggedInUserFilter]
        public async Task<IActionResult> Update(Guid ID)
        {
            Post post = await _postRepository.GetPost(ID);
            PostModel model = new PostModel()
            {
                Id = post.Id,
                Title = post.Title,
                FileName = post.PhotoPath,
                Description = post.Description
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(PostModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.PhotoPath != null)
                {
                    string filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                        "Images", model.FileName);
                    System.IO.File.Delete(filePath);

                    model.FileName = await ProcessUploadFile(model);
                }

                await _postRepository.UpdatePost(model);

                return RedirectToAction("Posts", "Post");
            }

            return View(model);
        }

        [LoggedInUserFilter]
        public async Task<OperationResultViewModel> Delete(Guid ID)
        {
            var result = new OperationResultViewModel(true);
            result = await _postRepository.DeletePost(ID);
            result.UrlAction = Url.Action("Posts", "Post");

            return result;
        }

        [LoggedInUserFilter]
        public async Task<IActionResult> Posts(int? page)
        {
            var model = new PostViewModel();

            var user = HttpContext.Session.GetObjectFromJson<User>("User");
            var userId = user.Id;
            model.Posts = await _postRepository.GetPostByUserID(userId);

            var pageNumber = page ?? 1;
            var onePageOfPosts = model.Posts.ToPagedListAsync(pageNumber, 9);
            ViewBag.OnePageOfPosts = onePageOfPosts;

            return View();
        }

        public async Task<IActionResult> Details(Guid ID)
        {
            var post = await _postRepository.GetPost(ID);

            var model = new PostModel()
            {
                Id = post.Id,
                Title = post.Title,
                FileName = post.PhotoPath,
                Description = post.Description,
                DateCreated = post.DateCreated,
                AuthorFullName = $"{post.User.FirstName} {post.User.LastName}"
            };
            return View(model);
        }
    }
}
