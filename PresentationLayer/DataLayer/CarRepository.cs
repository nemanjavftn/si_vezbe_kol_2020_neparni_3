using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Model;
using System.Data.SqlClient;
namespace DataLayer
{
   public class CarRepository
    {
        private static SqlCommand GetSqlCommand(string query)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(Constant.ConnectionString);
                sqlConnection.Open();
                return new SqlCommand(query, sqlConnection);
            }
            catch
            {
                return new SqlCommand();
            }
        }
        public List<Car> GetAllCars()
        {
            List<Car> list = new List<Car>();
            using(SqlCommand sqlCommand=GetSqlCommand("SELECT * FROM Car"))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    while (sqlDataReader.Read())
                    {
                        Car car = new Car();
                        car.Id = sqlDataReader.GetInt32(0);
                        car.Model = sqlDataReader.GetString(1);
                        car.ProductionYear = sqlDataReader.GetInt32(2);
                        list.Add(car);

                    }
                }
            }
            return list;
        }
        public int InsertCar(Car car)
        {
            string quer = string.Format("INSERT INTO Car values('{0}',{1})", car.Model, car.ProductionYear);
            using(SqlCommand sqlCommand = GetSqlCommand(quer))
            {
                return sqlCommand.ExecuteNonQuery();
            }

        }
    }
}
