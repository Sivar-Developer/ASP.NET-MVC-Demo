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

            people.Add(new PersonModel { FirstName = "Sarkawt", LastName = "Anyting", Age = 43 });
            people.Add(new PersonModel { FirstName = "Savan", LastName = "Sarkawt", Age = 15 });
            people.Add(new PersonModel { FirstName = "Balen", LastName = "Dlzar", Age = 23 });

            return View(people);
        }
    }
}