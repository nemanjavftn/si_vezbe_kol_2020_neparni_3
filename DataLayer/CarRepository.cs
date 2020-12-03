using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.sqlClient;

namespace DataLayer
{
    public class CarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> listToReturn = new List<Car>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {

                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    SqlCommand.Connection = sqlConnection;
                    sqlCommand.CommandText = "SELECT *FROM Cars";
                    sqlConnection.Open();

                    SqlCommand sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.ExecuteReader())
                    {
                        Car c = new Car();
                        c.Id = sqlDataReader.GetInt32(0);
                        c.Model = sqlDataReader.GetString(1);
                        c.productionYear = sqlDataReader.GetInt32(2);
                        listToReturn.Add(c);
                    }
                }


            }
            return results;



        }
    }
}
    
