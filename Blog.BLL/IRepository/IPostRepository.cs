using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;
using Blog.DAL.Domains;

namespace Blog.BLL.IRepository
{
    public interface IPostRepository
    {
        Task<Post> GetPost(Guid ID);
        Task<List<PostModel>> GetAllPosts();
        Task<List<PostModel>> GetPostByUserID(Guid userID);

        Task<Post> AddPost(PostModel addPost, User user);
        Task<Post> UpdatePost(PostModel model);
        Task<OperationResultViewModel> DeletePost(Guid ID);
    }
}
