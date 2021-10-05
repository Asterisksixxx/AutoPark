using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoPark.Data;
using AutoPark.Models;
using AutoPark.Service;

namespace AutoPark.Controllers
{
    
    public class AutoController : Controller
    {
        private readonly IAutoService _autoService;
        public IActionResult Index()
        {
            return View();
        }

        public AutoController(IAutoService autoService)
        {
            _autoService = autoService;
        }

        public IActionResult Details(Guid IDCars)
        {
            return View(_autoService.Get(IDCars));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Auto cars)
        {
            _autoService.Create(cars);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Edit(Guid IDCars)
        {
            return View(_autoService.Get(IDCars));
        }

        [HttpPost]
        public IActionResult Edit(Auto cars)
        {
            _autoService.Edit(cars);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid cars)
        {
            _autoService.Delete(cars);
            return RedirectToAction("Index");
        }
    }
}
