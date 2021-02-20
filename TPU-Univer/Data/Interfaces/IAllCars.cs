using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPU_Univer.Data.Models;

namespace TPU_Univer.Data.Interfaces
{
   public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> getFavCars { get;}
        Car getObjectCar(int carId);


    }
}
