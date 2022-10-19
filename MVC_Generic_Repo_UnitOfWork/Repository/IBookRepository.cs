using MVC_Generic_Repo_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Generic_Repo_UnitOfWork.Repository
{
    public interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookId);
        void AddBook(Book bookEntity);
        void UpdateBook(Book bookEntity);
        void DeleteBook(int bookId);
        void Save();
    }
}
