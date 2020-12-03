using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Xceed.Wpf.Toolkit;

namespace PresentationLayer
{
    public partial class About : Page
    {
        private readonly CarBusiness carBusiness;

        public About()
        {
            this.carBusiness = new CarBusiness();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            FillList();
        }
        public void FillList()
        {
            ListBoxCars.Items.Clear();

            List<Car> list = this.carBusiness.Get();
            foreach (Car c in list)
                ListBoxCars.Items.Add(c.id + ". " + c.model + " " + c.py);
        }
     

        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.model = TextBoxModel.Text;
            c.py = Convert.ToInt32(TextBoxProductYear.Text);

            bool result = this.carBusiness.Insert(c);

            if (result)

                FillList();
            else Console.WriteLine("Neuspesan unos!");
            
        }
    }
}