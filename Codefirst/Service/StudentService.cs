using Codefirst.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codefirst.Models;
using Codefirst.Database;
using System.Data.Entity;
using Codefirst.Repository;
using Codefirst.Context;

namespace Codefirst.Service
{
    public class StudentService : IStudent
    {
        private IStudentRepository studentrepository;
        private StudentContext dbcontext;
        public StudentService()
        {
            dbcontext = new StudentContext();
            studentrepository = new StudentRepositoryService(dbcontext);
        }
        void IStudent.DelById(int id)
        {
            studentrepository.DelById(c => c.Id == id);
        }

        IQueryable<Student> IStudent.GetAll()
        {
            return studentrepository.GetAll();
        }

        Student IStudent.GetById(int id)
        {
            return studentrepository.Get(c => c.Id == id);
        }
    }
}