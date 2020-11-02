using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace MortgageCalculator2
{
    public partial class Calculate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            princ.Focus();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string principal = "" + princ.Text + "";
            string duration = "" + LoanDur.Text + "";
            string rate = "" + InterestRate.Text + "";
            string otherDuration = "" + otherBox.Text + "";

            // use the function to calculate the monthly payment
            string output = MortgageHelper.ValidateMortgage(principal, duration, rate, otherDuration);
            result.Text = output;

            IDataHelper io = new IOHelper();
            io.WriteMortgage(output);
        }

        

        protected void LoanDur_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pressedButton = sender as RadioButtonList;
            var selected = pressedButton.SelectedItem;
            
            if (selected.Value == "Other")
            {
                otherBox.Enabled = true;
                otherBox.Focus();
            }
            else
            {
                otherBox.Enabled = false;
                otherBox.Text = String.Empty;
            }
        }
    }
}