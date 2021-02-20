using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Repository
{


    public class CarRepository : IAllCars
    {
        private readonly AppContext appDBContent;
        public CarRepository(AppContext appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);


    }
}
