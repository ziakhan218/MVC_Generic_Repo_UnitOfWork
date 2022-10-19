using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Generic_Repo_UnitOfWork.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Standard { get; set; }
        public string Subject { get; set; }
        public string Author { get; set; }
    }
}