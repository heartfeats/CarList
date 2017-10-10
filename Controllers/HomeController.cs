using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Index()
        {
          return View();
        }

        [Route("/car/list")]
        public ActionResult CarList()
        {
          // Car newCar = new Car(Request.Query["new-make"], Request.Query["new-model"], int.Parse(Request.Query["new-year"]), Request.Query["new-color"]);
          // return View(newCar);
          List<Car> allCars = Car.GetAll();
          return View(allCars);
        }

        [HttpPost("/car/create")]
        public ActionResult CreateCar()
        {
          Car newCar = new Car (Request.Form["new-make"], Request.Form["new-model"], int.Parse(Request.Form["new-year"]), Request.Form["new-color"]);
          newCar.Save();
          return View(newCar);
        }

        [HttpPost("/car/list/clear")]
        public ActionResult CarListClear()
        {
            Car.ClearAll();
            return View();
        }

    }
}
