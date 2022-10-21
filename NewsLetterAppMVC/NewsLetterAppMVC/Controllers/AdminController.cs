using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            // Replacing the below commented out ADO.NET code with EF syntax

            // First- Instantiate our newsletter Entities class; gives access to dB
            using (NewsletterEntities db = new NewsletterEntities())
            {
                // Creating a variable Signups-- db.SingUps represents all of our records in the dB
                var signups = db.SignUps;

                // Mapping our dataBase objects to the ViewModel
                // instantiate our list : List<SignupVm> signupVms = new List<SignupVm>();
                var signupVms = new List<SignupVm>();
                // Looping through all the signups to map them
                foreach (var signup in signups)
                {
                    // mapping properites
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    // Add it to our list
                    signupVms.Add(signupVm);
                }
                // Passing our List to the View... instead of passing signups we pass signupVms
                return View(signupVms);
            }

            //// Getting information from the datatbase... using ADO.NET
            //// Our Query Insert Statement
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber FROM SignUps";

            //// Creating a List of our Model
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //// Opening connection with "using" statement
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Generate our command and pass on the parameters
            //    SqlCommand command = new SqlCommand(queryString, connection);
            //    // Open our connection
            //    connection.Open();
            //    // Creating a data reader
            //    SqlDataReader reader = command.ExecuteReader();
            //    // Reading the information
            //    while (reader.Read())
            //    {
            //        // Creating a new SignUp
            //        var signup = new NewsletterSignUp();
            //        // Assigning the values coming from dB
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        // Adding this to our List
            //        signups.Add(signup);
            //    }
            //}
            //// Mapping our dataBase objects to the ViewModel
            //// instantiate our list : List<SignupVm> signupVms = new List<SignupVm>();
            //var signupVms = new List<SignupVm>();
            //// Looping through all the signups to map them
            //foreach (var signup in signups)
            //{
            //    // mapping properites
            //    var signupVm = new SignupVm();
            //    signupVm.FirstName = signup.FirstName;
            //    signupVm.LastName = signup.LastName;
            //    signupVm.EmailAddress = signup.EmailAddress;
            //    // Add it to our list
            //    signupVms.Add(signupVm);
            //}

            //// Passing our List to the View... instead of passing signups we pass signupVms
            //return View(signupVms);
        }
    }
}