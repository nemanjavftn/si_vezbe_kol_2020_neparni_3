using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Car
    {
        private int Id;
        private string Model;
        private int ProductionYear;

        public int id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string model
        {
            get { return Model; }
            set { Model = value; }
        }
        public int py
        {
            get { return ProductionYear; }
            set { ProductionYear = value; }
        }
    }
}
