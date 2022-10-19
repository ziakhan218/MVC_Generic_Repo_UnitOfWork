using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Generic_Repo_UnitOfWork.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}