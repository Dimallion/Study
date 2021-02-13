using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.ViewModels;

namespace TPU_Univer.Controllers
{
    public class CarsController : Controller {

        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с автомобилями";
            CarListViewModel obj = new CarListViewModel();
            obj.getAllCars = _allCars.Cars;
            obj.currCategory = "Automobiles";
            return View(obj);

        }
    }
}
