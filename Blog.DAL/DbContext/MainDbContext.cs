using System;
using System.Collections.Generic;
using System.Text;
using Blog.DAL.Domains;
using Microsoft.EntityFrameworkCore;

namespace Blog.DAL.DbContext
{
    public class MainDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
