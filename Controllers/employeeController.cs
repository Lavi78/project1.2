using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using project1._2.Models;


namespace project1._2.Controllers
{
    public class employeeController : Controller
    {
        Applicationdbcontext dbcontext = new Applicationdbcontext();
        // GET: science
        public ActionResult Index()
        {
            List<employee> employees= dbcontext.employees.ToList();
            
            return View(employees);
        }
    }
}