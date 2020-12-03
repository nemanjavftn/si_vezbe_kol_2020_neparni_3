using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarRepository
    {
        public List<Car> GetAllCars()
        {
            List<Car> results = new List<Car>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM Cars";

                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Car s = new Car();
                    s.Id = sqlDataReader.GetInt32(0);
                    s.Model = sqlDataReader.GetString(1);
                    s.ProductionYear = sqlDataReader.GetInt32(2);

                    results.Add(s);
                }
            }

            return results;
        }

        public int InsertStudent(Car s)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Students VALUES ('{0}', {1})",
                        s.Model, s.ProductionYear);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
