using MVC_Generic_Repo_UnitOfWork.GenericRepository;
using MVC_Generic_Repo_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Generic_Repo_UnitOfWork.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Book> BookRepository { get; }
        IGenericRepository<Student> StudentRepository { get; }
        void Save();
    }
}