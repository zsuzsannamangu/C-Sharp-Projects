using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost] //when you are doing a post method, you need to post this tag above it to mark it post
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            //we are sending 3 parameters to this method: FirstName, LastName, Email, the 3 inputs of the form
            //IsNullOrEmpty() is built in method, if any of these are empty in the form, we want to return an error page
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml"); //~ means it's the root
                //we will redirect to Error.cshtml View page, which is a built in error page the Shared folder
            }
            else
            {
                //we are mapping the 3 parameters to a new signup object

                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp(); //creates new SignUp object
                    signup.FirstName = firstName; //we map the properties for this object to the parameters that came in
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    db.SignUps.Add(signup); //we add it to the db
                    db.SaveChanges(); //until the SaveChanges() method nothing is saved to the db
                }


                ////save the form content in the database, we'll ADO.NET for this, so first create database with a table in the SQL Server Object Explorer
                //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES
                //                        (@FirstName, @LastName, @EmailAddress)";
                ////the using statement will help close our connection, to prevent memory leaks
                //using (SqlConnection connection = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand(queryString, connection);
                //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                //    command.Parameters["@FirstName"].Value = firstName;
                //    command.Parameters["@LastName"].Value = lastName;
                //    command.Parameters["@EmailAddress"].Value = emailAddress;

                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}

                return View("Success"); //we will now add a Success view page
            }
        }
        
        //public ActionResult Admin()
        //{
        //    //Entity Framework syntax:
        //    //Instantiates the NewsletterEntities object, using a "using" system so the connection is automatically closed when done

        //    using (NewsletterEntities db = new NewsletterEntities()) //initiatates the NewsletterEntities object and passed in our connection string, so now we have access to the database
        //    {
        //        var signups = db.SignUps; //we map our db object to a View model so we don't pass private information to the View
        //                                  //db has a property SignUps, which represents all the records in our db. This property is in Newsletter.Context.cs
        //        var signupVms = new List<SignupVm>(); //we create a new list of ViewModels
        //        foreach (var signup in signups) //we map the ViewModels from the model to the ViewModel
        //        {
        //            var signupVm = new SignupVm();
        //            signupVm.FirstName = signup.FirstName;
        //            signupVm.LastName = signup.LastName;
        //            signupVm.EmailAddress = signup.EmailAddress;
        //            signupVms.Add(signupVm);
        //        }

        //        return View(signupVms); //we pass that list to the View()
        //    }

            //the above does exactly what the code below would do, but the above is using Entity Framework, the code below is using ADO.NET to create dB calls

            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress from Signups";
            //List<NewsletterSignup> signups = new List<NewsletterSignup>(); //initalize it as an empty list

            //using (SqlConnection connection = new SqlConnection(connectionString)) //we open the connection and wrap it in a using statement
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection); //generate our command
            //    connection.Open(); //open connection

            //    SqlDataReader reader = command.ExecuteReader(); //we create a data reader to read the information

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignup(); //we declare a new object
            //        signup.Id = Convert.ToInt32(reader["Id"]); //we are assigning the properties to the incoming values
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.FirstName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup); //we add our newsletter signup to our list
            //    }
            //}
            //a common practice is to map your dB objects to a ViewModel in the controller:
            //var signupVms = new List<SignupVm>(); //we create a list
            //foreach (var signup in signups) //loop through all the signups
            //{
            //    var signupVm = new SignupVm();
            //    signupVm.FirstName = signup.FirstName; //we are mapping properties
            //    signupVm.LastName = signup.LastName;
            //    signupVm.EmailAddress = signup.EmailAddress;
            //    signupVms.Add(signupVm);//we add it to our list
            //}

            //return View(signupVms);
        //}

    }
}