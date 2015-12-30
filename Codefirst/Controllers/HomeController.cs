using Codefirst.Context;
using Codefirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirst.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            StudentContext sc = new StudentContext();
            Student s = new Student();
            s.UserName = "李四";
            s.FirstName = "李";
            s.Password = "123456";
            s.Email = "3333333@qq.com";
            s.LastName = "四";
            s.Age = 17;
            sc.Students.Add(s);
            sc.SaveChanges();
            return View();
        }
	}
}