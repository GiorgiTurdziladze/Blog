using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Blog.BLL.Models;
using Blog.BLL.ViewModels;
using Blog.DAL.Domains;

namespace Blog.BLL.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetUser(Guid ID);
        Task<User> GetUserByEmail(String email);

        Task<OperationResultViewModel> AddUser(UserRegisterViewModel addUser);
        Task<OperationResultViewModel> LogIn(UserModel logInUser);
    }
}
