using MVC_Generic_Repo_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_Generic_Repo_UnitOfWork.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}