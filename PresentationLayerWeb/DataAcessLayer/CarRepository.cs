using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{
    public class CarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> result = new List<Car>();
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Cars";

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Car c = new Car();
                    c.Id = sqlDataReader.GetInt32(0);
                    c.Model = sqlDataReader.GetString(1);
                    c.ProductionYear = sqlDataReader.GetInt32(2);
                    result.Add(c);
                }
            }

            return result;
        }

        public int InsertCar()
        {
            throw new NotImplementedException();
        }

        public int InsertCar(Car c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Cars VALUES('{0}','{1}')", c.Model, c.ProductionYear);
                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}

