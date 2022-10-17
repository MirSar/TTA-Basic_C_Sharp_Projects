using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            // Instantiate a new Instructor object
            Instructor dayTimeInstructor = new Instructor
            {
                Id =1,
                FirstName = "Mir",
                LastName = "Sar"
            };

            return View(dayTimeInstructor);
        }

        public ActionResult Instructors()
        {
            // Creating a list of Instructors
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Rick",
                    LastName = "Ramen"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName="Nadin",
                    LastName="Souki"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName="Brett",
                    LastName="Calendar"
                }
            };
            // Pass the list as an argument to the View mehtod
            return View(instructors);
        }
    }
}