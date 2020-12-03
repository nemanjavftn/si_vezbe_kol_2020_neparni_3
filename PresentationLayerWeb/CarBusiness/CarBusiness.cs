using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Models;

namespace CarBusiness
{
    public class CarBusiness
    {
        private readonly CarRepository carRepository;

        public CarBusiness()
        {
            this.carRepository = new CarRepository();
        }

        public List<Car> GetCars();
        {
            return this.carRepository.GetCars();
        }

        public bool InsertCar(Car c)
        {
            if (this.carRepository.InsertCar(c)>0)
            {
            return true;
            }
            return false;
        }
       
    }
}
