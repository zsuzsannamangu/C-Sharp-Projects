using IntroToMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroToMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\zsuzsi\Documents\Logs\log3.txt", text); //every time someone goes to home/index, it will write "hello" to this file
            //Random rnd = new Random(10);
            //int num = rnd.Next();

            ////ViewBag is a like a bag/dictionary, you can put whatever you want into it, any data type and it will be sent to the View
            //ViewBag.RandomNumber = num;

            //if (num > 20000)
            //{
            //    return View("About");
            //}

            //return Content("hello");
            //return RedirectToAction("Contact"); //returns what is in ActionResult Contact() below

            List<string> names = new List<string>
            {
                "Jesse",
                "Adam",
                "Brett"
            };

            //int number = 5;
            //return View(number);

            return View(names); //we pass names list to the View
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

            Instructor dayTimeInstructor = new Instructor //instantiate a new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }
        
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Smith"
                },
                new Instructor
                {
                    Id = 2,
                    FirstName = "Annie",
                    LastName = "Marrie"
                },
                new Instructor
                {
                    Id = 3,
                    FirstName = "Lili",
                    LastName = "Monday"
                }
            };

            return View(instructors); //passing list of instructors as an argument to the View
        }
    }
}