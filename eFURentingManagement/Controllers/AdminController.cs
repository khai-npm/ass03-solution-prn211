using BusinessObject;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;

namespace eFURentingManagement.Controllers
{
    public class AdminController : Controller
    {
        ICarRepository _carRepository = new CarRepository();
        public IActionResult SearchSubmit(String search)
        {
            var Session = HttpContext.Session;
            Session.SetString("Role", "Admin");
            
            List<CarInformation> list = _carRepository.GetCarByName(search);;
            ViewBag.Model = list;
            if (list.Count == 0) { CarInformation nc = new CarInformation(); nc.CarName = "Car Not Found";
                list.Add(nc);
            }
            return View(nameof(Index),list);
        }
        public IActionResult Index()
        {
            var Session = HttpContext.Session;
            String role = Session.GetString("Role");
            List<CarInformation> CarList = _carRepository.GetCarList();
            ViewBag.Model = CarList;
            if (role == "Admin") { 
            return View(_carRepository.GetCarList());
        } else
            {
                return Redirect("../Login");
            }
        }
    }
}
