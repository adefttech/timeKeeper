using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_006
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string workDay = dateTextbox.Text.ToString();
            string hoursWorked = hoursTextbox.Text.ToString();
            string displayMessage = "Sonny, welcome to your time tracker. Today you entered time for the " +
                "following dates." + workDay + " you entered " + hoursWorked + " hours worked.";

            displayLabel.Text = displayMessage;
        }
    }
}