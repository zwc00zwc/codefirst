using Codefirst.Database;
using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst.IService
{
    public interface IStudent
    {
        IQueryable<Student> GetAll();

        Student GetById(int id);

        void DelById(int id);
    }
}