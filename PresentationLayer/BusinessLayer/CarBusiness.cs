using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using DataLayer;

namespace BusinessLayer
{
    public class CarBusiness
    {
        private readonly CarRepository carRepository;
        public CarBusiness()
        {
            this.carRepository = new CarRepository();
        }
        public List<Car> GetAllCars()
            => this.carRepository.GetAllCars();

        public bool InsertCar(Car car)
       => this.carRepository.InsertCar(car) >0;
    }
}
