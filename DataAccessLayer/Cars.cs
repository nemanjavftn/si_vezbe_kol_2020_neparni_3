using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Cars
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
                    Car c = new Car();
                    c.Id = sqlDataReader.GetInt32(0);
                    c.Model = sqlDataReader.GetString(1);
                    c.ProductionYear = sqlDataReader.GetInt32(2);
                

                    results.Add(c);
                }
            }

            return results;
        }

        public int InsertCars(Car c)
        {
            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Cars VALUES ('{0}', {1},)",
                        c.Model, c.ProductionYear);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
    }

