using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Interfaces;
using TPU_Univer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace TPU_Univer.Data.Repository
{
    private readonly  AppDBContent appDBContent;

    public CarRepository(AppDBContent appDBContent)
    {
        this.appDBContent = appDBContent;
    }

    public class CarRepository : IAllCars
    {
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.Car.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.id == carId);


    }
}
