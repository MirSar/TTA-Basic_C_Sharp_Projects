using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WA_MVCTutorial.Models;

namespace WA_MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //// Log a text everytime someone visits home page before directing them to the page
            //string text = "Greetings!";
            //System.IO.File.WriteAllText(@"C:\Users\mirwa\OneDrive\Documents\2 GitHub\TTA-Basic_C_Sharp_Projects\WA_MVCTutorial\logFiles\log.txt", text);

            //// We can perform some logic
            //Random rnd = new Random(); // for true random number leave () blank
            //var num = rnd.Next();
            //// ViewBag can contain anytype of data that is sent to the view
            //ViewBag.RandomNumber = num;

            //if (num > 900000000)
            //{
            //    //// We can also send it to a different view page
            //    /// This does not change the URL (keeps it at index)
            //    //return View("Contact");

            //    //// We can return content with words or blank
            //    //return Content("we got a big number");

            //    // RedirectToAction("contact") move to the specified mehtod ("contact") in this controller
            //    // So this executes the contact method here and not just go to the contact .cshtml file
            //    // Also this redirects the URL to contact
            //    return RedirectToAction("Contact");

            //}

            //List<string> names = new List<string>
            //{
            //    "Mirwais",
            //    "Jesse",
            //    "Amber",
            //    "Karl"
            //};
            //return view(names);

            User user = new User();
            user.Id = 1;
            user.FirstName = "Ronin";
            user.LastName = "Sar";
            user.Age = 2;
            return View(user); 

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            // We can also throw in an Exception
            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. From the Controller method";

            return View();
        }
    }
}