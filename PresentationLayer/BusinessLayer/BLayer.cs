using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BLayer
    {
        public readonly Repository repository;

        public BLayer()
        {
            this.repository = new Repository();
        }

        public List<Car> getAllCars()
        {
            return this.repository.GetAllCars();
        }

        public bool insertCar(Car car)
        {
            if (this.repository.InsertCar(car)>0)
            {
                return true;
            }
            return false;
        }


    }
}
