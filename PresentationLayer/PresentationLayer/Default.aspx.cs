using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer.Model;
using DataLayer;
using BusinessLayer;

namespace PresentationLayer
{
    public partial class _Default : Page
    {
        private readonly CarBusiness carBusiness = new CarBusiness();
        
        private void InitListBox()
        {
            ListBoxWriteLine.Items.Clear();

            carBusiness.GetAllCars().ToList().ForEach(n => ListBoxWriteLine.Items.Add(n.ToString()));

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            InitListBox();
        }

        protected void Add_Click(object sender, EventArgs e)
        {
            if(int.TryParse(TextBoxProductionYear.Text, out int year ))
            {
                Car car = new Car();
                car.Model = TextBoxModel.Text;
                car.ProductionYear = year;
                if (carBusiness.InsertCar(car) == true)
                {
                    InitListBox();
                    TextBoxProductionYear.Text = "";
                    TextBoxModel.Text = "";
                }
            }
        }
    }
}