using MVC_Generic_Repo_UnitOfWork.GenericRepository;
using MVC_Generic_Repo_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Generic_Repo_UnitOfWork.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context = new AppDbContext();
        public IGenericRepository<Book> bookRepository;
        public IGenericRepository<Student> studentRepository;

        public IGenericRepository<Book> BookRepository
        {
            get
            {

                if (this.bookRepository == null)
                {
                    this.bookRepository = new GenericRepository<Book>(_context);
                }
                return bookRepository;
            }
        }

        public IGenericRepository<Student> StudentRepository
        {
            get
            {

                if (this.studentRepository == null)
                {
                    this.studentRepository = new GenericRepository<Student>(_context);
                }
                return studentRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);

            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}