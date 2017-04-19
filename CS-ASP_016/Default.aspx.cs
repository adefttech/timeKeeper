using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getDateButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = myCalendar.SelectedDate.ToShortDateString();
        }

        protected void setDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.SelectedDate = DateTime.Parse("06/12/2017");
            myCalendar.VisibleDate = myCalendar.SelectedDate;
            resultLabel.Text = myCalendar.SelectedDate.ToShortDateString();

        }

        protected void showDateButton_Click(object sender, EventArgs e)
        {
            myCalendar.VisibleDate = DateTime.Parse("01/04/1955");
            resultLabel.Text = myCalendar.VisibleDate.ToShortDateString();
        }

        protected void selectedWeekButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Week Of " + myCalendar.SelectedDate.ToShortDateString();
        }
    }
}