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
        }
    }
}