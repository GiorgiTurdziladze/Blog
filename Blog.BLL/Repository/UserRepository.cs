using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blog.BLL.Helpers;
using Blog.BLL.IRepository;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;
using Blog.DAL.DbContext;
using Blog.DAL.Domains;
using Microsoft.EntityFrameworkCore;

namespace Blog.BLL.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly MainDbContext _context;

        public UserRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<User> GetUser(Guid ID)
        {
            return await _context.Users.FindAsync(ID);
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(n => n.Email == email);
        }

        public async Task<OperationResultViewModel> AddUser(UserRegisterViewModel addUser)
        {
            var result = new OperationResultViewModel(true);
            var user = await GetUserByEmail(addUser.Email);

            if (user != null)
            {
                result.SetError("This Email is already taken");
                return result;
            }

            var newUser = new User()
            {
                FirstName = addUser.FirstName,
                LastName = addUser.LastName,
                Email = addUser.Email,
                Password = Md5Hash.CalculateMd5Hash(addUser.Password)
            };

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
            return result;
        }

        public async Task<OperationResultViewModel> LogIn(UserModel logInUser)
        {
            var result = new OperationResultViewModel(true);
            var password = Md5Hash.CalculateMd5Hash(logInUser.Password);

            var user = await _context.Users.FirstOrDefaultAsync(n => 
                       n.Email == logInUser.Email && n.Password == password);

            if (user ==null)
            {
                result.SetError("Wrong Email or Password");
            }

            result.Data = user;
            return result;
        }
    }
}
