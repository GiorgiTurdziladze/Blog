using System;
using System.Collections.Generic;
using System.Text;
using Blog.BLL.Models;

namespace Blog.BLL.ViewModels
{
    public class PostViewModel
    {
        public List<PostModel> Posts;

        public PostViewModel()
        {
            Posts = Posts ?? new List<PostModel>();
        }
    }
}
