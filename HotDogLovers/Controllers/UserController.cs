using HotDogLovers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotDogLovers.Controllers
{
    public class UserController : Controller
    {
        // GET: User
      public ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            UserViewModel vm = new UserViewModel();
            vm.Dogs = getDogs();
            return View();
        }


        private List<string> getDogs()
        {
            List<String> dogs = new List<String>();
            dogs.Add("All Beef");
            dogs.Add("Turkey");
            dogs.Add("Chicago Style");
            dogs.Add("Bratwurst");

            return dogs;
        }
    }
}
