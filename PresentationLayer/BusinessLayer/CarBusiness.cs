using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
   public class CarBusiness
    {
        private readonly CarRepository carRepository;

        public CarBusiness()
        {
            this.carRepository = new CarRepository();
        }
        public List<Car> Get()
        {
            return this.carRepository.GetAllCars();
        }
        public bool Insert(Car c)
        {
            if (this.carRepository.InsertCar(c) > 0)
                return true;
            return false;
        }
    }
}
