﻿using MyShop.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyShop.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var service = new CustomerService();

            var customers = service.GetCustomers();

            ViewState["Customers"] = customers;
        }
    }
}