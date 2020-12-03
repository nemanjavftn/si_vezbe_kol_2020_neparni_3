using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CarRepositorium
    {
        public int InsertCar(Car c)
        {
            using (SqlConnection dataConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = string.Format("INSERT Into Cars VALUES ('{0}', {1})", c.Model, c.ProductionYear);
                dataConnection.Open();

                return command.ExecuteNonQuery();
            }

        }
        public List<Car> GetAllCars()
        {
            List<Car> listOfCars = new List<Car>();
            using (SqlConnection dataConnection = new SqlConnection(Constants.connectionString))
            {
                SqlCommand command = new SqlCommand();
                command.Connection = dataConnection;
                command.CommandText = "SELECT * FROM  Vets";
                dataConnection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    Car c = new Car();
                    c.Id = dataReader.GetInt32(0);
                    c.Model = dataReader.GetString(1);
                    c.ProductionYear = dataReader.GetInt32(2);
                    listOfCars.Add(c);

                }



            }
            return listOfCars;
        }
        
    }
}
