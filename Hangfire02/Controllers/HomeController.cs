using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Hangfire;
using Hangfire02.Models;

namespace Hangfire02.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();

        public ActionResult Index()
        {

            BackgroundJob.Schedule(() => InsertEmps(), TimeSpan.FromMinutes(1));
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void InsertEmps()
        {
            for (int i = 0; i < 10; i++)
            {
                ApplicationDbContext.Emps.Add(new Emp()
                {
                    Name = "Samer"
                });
                ApplicationDbContext.SaveChanges();
            }
        }
    }
}