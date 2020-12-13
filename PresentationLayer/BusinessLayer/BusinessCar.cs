using DataAccessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessCar
    {
        private readonly CarRepositorium carRepositorium;

        public BusinessCar()
        {
            this.carRepositorium = new CarRepositorium();
        }
        public List<Car> GetAllCars()
        {
            return this.carRepositorium.GetAllCars();
        }

        public bool InsertCar(Car c)
        {
            if (this.carRepositorium.InsertCar(c) > 0)
                return true;

            return false;
        }


    }
}
