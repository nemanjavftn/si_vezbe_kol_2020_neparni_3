using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class Rent_A_Car : System.Web.UI.Page
    {
        private readonly CarBusiness carBusiness;

        public Rent_A_Car()
        {
            this.carBusiness = new CarBusiness();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FillList();
        }
        public void FillList()
        {
            ListBoxCarss.Items.Clear();

            List<Car> list = this.carBusiness.Get();
            foreach (Car c in list)
                ListBoxCarss.Items.Add(c.id + ". " + c.model + " " + c.py);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.model = TextBox1.Text;
            c.py = Convert.ToInt32(TextBox2.Text);

            bool result = this.carBusiness.Insert(c);

            if (result)

                FillList();
            else Console.WriteLine("Neuspesan unos!");
        }
    }
}