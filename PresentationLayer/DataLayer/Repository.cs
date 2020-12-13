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
        public int InsertCar (Car newCar)
        {
           
            using(SqlConnection sqlConnection=new SqlConnection())
            {
                sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentACarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText= string.Format("INSERT INTO [CARS] VALUES ('{0}','{1}')",newCar.Model,newCar.ProductionYear);
                return sqlCommand.ExecuteNonQuery();
            }
            
        }

        public List<Car> GetAllCars()
        {

            using (SqlConnection sqlConnection = new SqlConnection())
            {
                List<Car> listCars = new List<Car>();
                sqlConnection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RentACarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "SELECT * FROM [Cars]";
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                while (sdr.Read())
                {
                    Car newCars = new Car();
                    newCars.Id = sdr.GetInt32(0);
                    newCars.Model = sdr.GetString(1);
                    newCars.ProductionYear = sdr.GetInt32(2);
                    listCars.Add(newCars);
                }
                return listCars;


            }

        }
    }
}
