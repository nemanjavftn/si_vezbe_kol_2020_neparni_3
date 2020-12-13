using BusinessLayer;
using DataAcessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        private CarBusiness carBusiness;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Model = TextBox1.Text;
            c.ProductionYear = Convert.ToInt32(TextBox2.Text);
            

            if (this.carBusiness.InsertCar(c))
            {
                RefreshData();
              
            }
           
        }
        public void RefreshData()
        {
            this.carBusiness = new CarBusiness();
            List<Car> results = this.carBusiness.GetAllCars();
            listBox.Items.Clear();

            foreach (Car c in results)
            {
                listBox.Items.Add("Model:\t" + c.Model + "\tGodina proizvodnje:\t" + c.ProductionYear);

            }
        }
    }
}