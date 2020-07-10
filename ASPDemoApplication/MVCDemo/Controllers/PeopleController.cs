using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Alex", LastName = "Elzinga", Age = 25 });
            people.Add(new PersonModel { FirstName = "Bobby", LastName = "Elzinga", Age = 49 });
            people.Add(new PersonModel { FirstName = "John", LastName = "Doe", Age = 36 });

            return View(people);
        }
    }
}