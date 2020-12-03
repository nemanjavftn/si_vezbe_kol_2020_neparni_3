using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Repository
    {
        public List<Car> InsertCar (Car newCar)
        {
            List<Car> carList = new List<Car>();
            using(SqlConnection sqlConnection=new SqlConnection())
            {

            }
            return carList;
        }
    }
}
