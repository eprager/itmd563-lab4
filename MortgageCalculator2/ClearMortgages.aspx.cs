﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MortgageCalculator2
{
    public partial class ClearMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void clear_Click(object sender, EventArgs e)
        {
            //IDataHelper io = new IOHelper();
            IDataHelper io = new IOHelper_Database();
            Output.Text = io.ClearMortgages();
        }
    }
}