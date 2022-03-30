using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.BLL.IRepository;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;
using Blog.DAL.DbContext;
using Blog.DAL.Domains;
using Microsoft.EntityFrameworkCore;

namespace Blog.BLL.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly MainDbContext _context;

        public PostRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<Post> GetPost(Guid ID)
        {
            return await _context.Posts.Include(n => n.User).FirstOrDefaultAsync(n => n.Id == ID);
        }

        public async Task<List<PostModel>> GetAllPosts()
        {
            var posts = await (from n in _context.Posts
                               where n.DateDeleted == null
                               orderby n.DateDeleted descending
                               select new PostModel()
                               {
                                   Id = n.Id,
                                   Title = n.Title,
                                   FileName = n.PhotoPath,
                                   Description = n.Description,
                                   DateCreated = n.DateCreated,
                                   AuthorFullName = $"{n.User.FirstName} {n.User.LastName}"
                               }).ToListAsync();
            return posts;
        }

        public async Task<List<PostModel>> GetPostByUserID(Guid userID)
        {
            var posts = await (from n in _context.Posts
                               where n.DateDeleted == null &&
                               n.UserId == userID
                               orderby n.DateCreated descending
                               select new PostModel()
                               {
                                   Id = n.Id,
                                   Title = n.Title,
                                   FileName = n.PhotoPath,
                                   Description = n.Description,
                                   DateCreated = n.DateCreated,
                                   AuthorFullName = $"{n.User.FirstName} {n.User.LastName}"
                               }).ToListAsync();
            return posts;
        }

        public async Task<Post> AddPost(PostModel addPost, User user)
        {
            var newPost = new Post()
            {

                User = user,
                Title = addPost.Title,
                PhotoPath = addPost.FileName,
                Description = addPost.Description,
                DateCreated = DateTime.Now
            };



            _context.Posts.Attach(newPost);
            await _context.SaveChangesAsync();
            return newPost;
        }

        public async Task<Post> UpdatePost(PostModel model)
        {
            var existingPost = _context.Posts.FirstOrDefault(n => n.Id == model.Id);
            if (existingPost != null)
            {
                existingPost.Title = model.Title;
                existingPost.PhotoPath = model.FileName;
                existingPost.Description = model.Description;
                existingPost.DateCreated = DateTime.Now;

                await _context.SaveChangesAsync();
                return existingPost;
            }

            return null;
        }

        public async Task<OperationResultViewModel> DeletePost(Guid ID)
        {
            var result = new OperationResultViewModel(true);
            var post = _context.Posts.FirstOrDefault(n => n.Id == ID);

            if (post == null)
            {
                result.SetError("Post was not found");
                return result;
            }

            post.DateDeleted = DateTime.Now;
            await _context.SaveChangesAsync();

            return result;
        }
    }
}
