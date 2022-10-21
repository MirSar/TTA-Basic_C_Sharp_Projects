using NewsLetterAppMVC.Models;
using NewsLetterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        //// Establishing our Connection to the dB
        //// Protecting it with "private readonly string" datatype
        //private readonly string connectionString = @"Data Source=SBOOKPRO\SQLEXPRESS;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public ActionResult Index()
        {
            return View();
        }

        // Adding a new Method for SignUP
        [HttpPost] // Marking this method as POST
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            // Validating the data entry ... checking for null or empty
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                // Replacing the below commented-out ADO.NET code with EF syntax
                using(NewsletterEntities db = new NewsletterEntities())
                {
                    // We are taking in 3 parameters and mapping them to a new singup object
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    //Add to our dataBase
                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                //// Insert Statement for our query
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) Values
                //                        (@FirstName, @LastName, @EmailAddress)"; // Passing in parameters is safe practice against SQL Injections

                //// Opening an outside connection to dB ...
                //// note: "using" statement will close it once it is used to prevent memory leaks and SQL Injections
                //using (SqlConnection connection= new SqlConnection(connectionString))
                //{
                //    // Defining our SQL command
                //    SqlCommand command = new SqlCommand(queryString, connection); // passing in our queryString and connection
                //    // Adding/Passing in our parameters
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                //    // Adding in the Values
                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;
                //    // Open connection and execute the query and close connection
                //    connection.Open();
                //    // An "insert" is a nonQuery
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}

                return View("Success");
            }
        }

    }
}