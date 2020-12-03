using DataAccessLayer;
using DataAccessLayer.Models;
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

        public List<Car> GetAllCars()                   //komitovao sam bez referenciranja, posle je htelo da se referencira...
        {
            return this.carRepository.GetAllCars();
        }

        public bool InsertCar(Car s)
        {
            if (this.carRepository.InsertCar(s) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
