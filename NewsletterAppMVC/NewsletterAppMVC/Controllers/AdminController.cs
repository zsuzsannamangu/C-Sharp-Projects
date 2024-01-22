using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) //initiatates the NewsletterEntities object and passed in our connection string, so now we have access to the database
            {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList(); //we map our db object to a View model so we don't pass private information to the View
                                                                                 //SignUps will be only those where the Removed property equals to null, so we don't display the name of those that unsubscribed
                                                                                 //db has a property SignUps, which represents all the records in our db. This property is in Newsletter.Context.cs
                //you can also filter with LINQ:
                //var signups = (from c in db.SignUps
                //               where c.Removed == null
                //               select c).ToList();

                var signupVms = new List<SignupVm>(); //we create a new list of ViewModels
                foreach (var signup in signups) //we map the ViewModels from the model to the ViewModel
                {
                    var signupVm = new SignupVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);
                }

                return View(signupVms); //we pass that list to the View()
            }
        }

        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities()) //creates connection to db
            {
                var signup = db.SignUps.Find(Id); //find the wanted record by the Find() method by the given primary key values
                signup.Removed = DateTime.Now; //we change the property Removed, we are assigning it the current date and time
                db.SaveChanges(); //we now have to update the Removed property
            }
            return RedirectToAction("Index");
        }
    }
}