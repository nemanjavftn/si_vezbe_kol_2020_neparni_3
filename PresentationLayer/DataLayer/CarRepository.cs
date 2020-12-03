using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class CarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> list = new List<Car>();

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
                    c.id = sqlDataReader.GetInt32(0);
                    c.model = sqlDataReader.GetString(1);
                    c.py = sqlDataReader.GetInt32(2);
                    list.Add(c);
                }
            }

            return list;
        }
        public int InsertCar(Car c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = string.Format("INSERT INTO Cars VALUES ('{0}',{1})",c.model,c.py);

                int result = sqlCommand.ExecuteNonQuery();
                return result;
            }
        }
    }
}
