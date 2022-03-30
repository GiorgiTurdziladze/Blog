using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.BLL.Enums
{
    [Flags]
    public enum NavigationMenuEnum
    {
        None = 0,
        Posts = 1,
        UserPosts = 2,
        LogIn = 4,
        LogOut = 8,
        Register = 16
    }
}
