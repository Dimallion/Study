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
                        name = "Tesla", shortDesk = "", longDesk = "", price = 45000, img = "~/img/Chun.jpg", isFavourite = true, available = true, Category = _categoryCars.AllCategories.First()
                    },
                new Car
                {
                    name = "Bear", shortDesk = "", longDesk = "", price = 45000, img = "~/img/third.jpg", isFavourite = true, available = true, Category = _categoryCars.AllCategories.First()
                },
                new Car
                {
                    name = "Mountain", shortDesk = "", longDesk = "", price = 45000, img = "~/img/second.jpg", isFavourite = true, available = true, Category = _categoryCars.AllCategories.First()
                },
                new Car
                {
                    name = "Commi", shortDesk = "", longDesk = "", price = 45000, img = "~/img/commi.jpg", isFavourite = true, available = true, Category = _categoryCars.AllCategories.First()
                },
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
