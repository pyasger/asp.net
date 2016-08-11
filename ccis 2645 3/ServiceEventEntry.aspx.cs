using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace ccis_2645_3
{
    public partial class ServiceEventEntry : System.Web.UI.Page
    {

        //************************************************************
        //** Procedure: Page_Load()
        //** Description:
        //**   Processes initial and subsequent page requests
        //************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblEM.Text = "";
                LoadProducts();
            }
        }

        //*****
        //** Procedures
        //*****
        //************************************************************
        //** Procedure: LoadProducts()
        //** Description:
        //**   Populates dropdown list with Product ID and Name
        //************************************************************
        private void LoadProducts()
        {
            DataSet dsData;

            dsData = clsDatabase.GetTechnicians();
            if (dsData != null)
            {
                lblEM.Text = "Error retrieving Product list";
            }
            else if (dsData.Tables.Count <1)
            {
                lblEM.Text = "Error retrieving Product list";
                dsData.Dispose();
            }
            else
            {
                ddC.DataSource = dsData.Tables[0];
                ddC.DataTextField = "ProductDesc";
                ddC.DataValueField = "ProductID";
                ddC.DataBind();

                dsData.Dispose();
            }
        }

        //***********DisplayProduct()
        private void DisplayProduct(String strProdID)
        {
            DataSet dsData;
            
            dsData = clsDatabase.GetProductByID(strProdID);
            if(dsData==null)
            {
                lblEM.Text = "Error retreaving Product";
            }
            {
                else if(dsData.Tables.Count<1)
                {
                    lblEM.Text = "Error retreaving Product";
                    dsData.Dispose();
                }
                else{
                    if(dsData.Tables[0].Rows[0]["ProductDesc"] == DBNull.Value)
                    {
                       












        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./default.aspx");
        }
    }
}