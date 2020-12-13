using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class _Default : Page
    {

        public partial class _Default : Page
        {
            private CarBusiness cars;
            protected void Page_Load(object sender, EventArgs e)
            {
                this.cars = new CarBusiness();

                List<Cars> students = this.cars.GetAllCars();
                listBoxCars.Items.Clear();

                foreach (Car c in cars)
                {
                    listBoxCars.Items.Add(c.Id + ". " + c.Model + "(" + c.ProductionYear + "));
                }
            }
        }
    }
}