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
        public List<Car> InsertCar()
        {
            List<Car> results = new List<Car>();

            using (SqlConnection sqlConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = SqlConnection;
                sqlCommand.CommandText = "SELECT * FORM Cars";

                SqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while(sqlDataReader.Read())
                {
                    Car c = new Car();
                    c.Id = sqlDataReader.GetInt32(0);
                    c.Model = sqlDataReader.GetString(1);
                    c.ProductionYear = sqlDataReader.GetInt32(2);

                    results.Add(s);
                }
            }
            return results;
        }

        public int GetAllCars(Car c)
        {
            using (SqlConnection sqlConnection=new SqlConnection(Constants.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = SqlConnection;
                sqlCommand.CommandText =
                    string.Format("INSERT INTO Cars VAULUES ('{0}', {2})", c.Model, c.ProductionYear);

                sqlConnection.Open();

                return sqlCommand.ExecuteNonQuery();
            }
        }
    }
}
