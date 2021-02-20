using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Models;

namespace TPU_Univer.ViewModels
{
    public class CarListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }
        public string currCategory { get; set; }
    }
}
