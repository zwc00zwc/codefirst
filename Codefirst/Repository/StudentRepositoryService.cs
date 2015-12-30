using Codefirst.Database;
using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Codefirst.Repository
{
    public class StudentRepositoryService : Repositorybase<Student>, IStudentRepository
    {
        public StudentRepositoryService(DbContext _dbcontext):base(_dbcontext)
        {

        }
    }
}