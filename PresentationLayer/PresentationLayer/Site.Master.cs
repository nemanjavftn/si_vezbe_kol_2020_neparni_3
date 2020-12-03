﻿using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class SiteMaster : MasterPage
    {
        public readonly BLayer blayer;
        public SiteMaster()
        {
            this.blayer = new BLayer();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Dodaj_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            car.Model = TextBoxModel.Text;
            car.ProductionYear = Convert.ToInt32 (TextBoxYear.Text);
            this.blayer.insertCar(car);
        }
    }
}