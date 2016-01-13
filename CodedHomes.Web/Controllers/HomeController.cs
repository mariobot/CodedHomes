using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodedHomes.Data;
using CodedHomes.Models;

namespace CodedHomes.Web.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context = new DataContext();         
        private ApplicationUnit _unit = new ApplicationUnit();

        public ActionResult Index()
        {
	  //IQueryable<Home> _listHomes = this._unit.Homes.GetAll();

	  var _listHomes = "";

	  return View();	  

	  // Use this for test the application and the correct use of DataAcces Loyic
	  //ApplicationUnit appUnit = new ApplicationUnit();
	  //appUnit.Homes.Add(House1());
	  //appUnit.SaveChanges();

	  // Use this for test the application and the correct use of DataAcces Loyic
	  //ApplicationUnit appUnit = new ApplicationUnit();
	  //appUnit.Homes.Add(House2());
	  //appUnit.SaveChanges();
        }

        public ActionResult About()
        {
	  ViewBag.Message = "Your app description page.";

	  return View();
        }

        public ActionResult Contact()
        {
	  ViewBag.Message = "Your contact page.";

	  return View();
        }
    }
}
