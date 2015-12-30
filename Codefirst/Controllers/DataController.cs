using Codefirst.Context;
using Codefirst.IService;
using Codefirst.Models;
using Codefirst.Repository;
using Codefirst.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Codefirst.Controllers
{
    public class DataController : Controller
    {
        IStudent stuBll = new StudentService();
        // GET: Data
        public ActionResult Index()
        {
            List<Student> list = new List<Student>();
            list = stuBll.GetAll().ToList();
            ViewBag.list = list;
            return View();
        }

        public ActionResult Index1()
        {
            List<Student> list = new List<Student>();
            //list = stuBll.GetAll().ToList();
            ViewBag.list = list;
            return View();
        }

        public ActionResult Index2(int id)
        {
            stuBll.DelById(id);
            return View();
        }
    }
}