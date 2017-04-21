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
            if (!IsPostBack)
            {
                double[] hours = new double[0];
                ViewState.Add("Hours", hours);
            }

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] hours = (double[])ViewState["Hours"];

            Array.Resize(ref hours, hours.Length + 1);

            int newestItem = hours.GetUpperBound(0);
            hours[newestItem] = double.Parse(hoursTextbox.Text);

            ViewState["Hours"] = hours;
            resultLabel.Text = string.Format("Total Hours: {0}<br/>" +
                                              "Most Hours: {1}<br/>" +
                                              "Least Hours: {2}<br/>" +
                                              "Average Hours: {3}<br/>",
                                              hours.Sum(), 
                                              hours.Max(),
                                              hours.Min(),
                                              hours.Average());
                                              
        }
 
    }
}