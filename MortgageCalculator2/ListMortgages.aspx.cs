using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MortgageCalculator2
{
    public partial class ListMortgages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void list_Click(object sender, EventArgs e)
        {
            IDataHelper io = new IOHelper();
            Mortgages.Text = io.GetAllMortgages();
        }
    }
}