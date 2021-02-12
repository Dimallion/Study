using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car
                    {
                        name = "Tesla", shortDesk = "", longDesk = "", price = 45000, img = "", isFavourite = true, available = true, Category = _categoryCars.AllCategories.First()
                    }
            };
        }
}
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }


}
