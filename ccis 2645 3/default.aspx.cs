using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ccis_2645_3
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }



        protected void btnService_Click(object sender, EventArgs e)
        {
            Response.Redirect("./ServiceEventEntry.aspx");
        }

        protected void btnTechnician_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Technicians.aspx");
        }


    }
}