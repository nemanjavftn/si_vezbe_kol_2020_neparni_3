using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CarBusiness
    {
        private readonly Cars cars;

        public CarBusiness()
        {
            this.cars = new Cars();
        }

        public List<Car> GetAllCars()
        {
            return this.cars.GetAllCars();
        }

        public bool InsertCars(Car c)
        {
            if (this.cars.InsertCars(c) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
