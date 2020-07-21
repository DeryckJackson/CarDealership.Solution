using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpPost("/cars")]
    public ActionResult Create(string model, int price, int miles)
    {
      Car myCar = new Car(model, price, miles);
      return RedirectToAction("Index");
    }
  }
}