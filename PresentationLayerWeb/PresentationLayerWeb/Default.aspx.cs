using BusinessLayer;
using DataAccessLayer.Models;
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
            this.carBusiness = new CarBusiness();

            List<Car> cars = this.carBusiness.GetAllCars();
            listBoxCars.Items.Clear();

            foreach (Car s in cars)
            {
                listBoxCars.Items.Add(s.Id + ". " + s.Model + ". " + s.ProductionYear);

            }
        }
    }
}
