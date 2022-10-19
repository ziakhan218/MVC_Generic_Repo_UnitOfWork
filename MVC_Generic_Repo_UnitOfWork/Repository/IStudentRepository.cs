using MVC_Generic_Repo_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Generic_Repo_UnitOfWork.Repository
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentById(int studentId);
        int AddStudent(Student studentIdEntity);
        int UpdateStudent(Student studentIdEntity);
        void DeleteStudent(int studentId);
    }
}
