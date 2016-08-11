using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ccis_2645_3
{
    public partial class technicians2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                lblErrorMessage.Text = "";
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

            dsData = clsDatabase.TechnicianByID();
            if (dsData != null)
            {
                lblErrorMessage.Text = "Error retrieving Product list";
            }
            else if (dsData.Tables.Count <1)
            {
                lblErrorMessage.Text = "Error retrieving Product list";
                dsData.Dispose();
            }
            else
            {
                ddTechnician.DataSource = dsData.Tables[0];
                ddTechnician.DataTextField = "ProductDesc";
                ddTechnician.DataValueField = "ProductID";
                ddTechnician.DataBind();

                dsData.Dispose();
            }
        }

  


        protected void btnMM_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Default.aspx");
        }




        protected void txtHR_TextChanged(object sender, EventArgs e)
        {

            if (txtHourlyRate.Text.Trim().Length > 0)
                System.Web.HttpContext.Current.Response.Write("must be larger then 0 ");
        }



        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Technicians.aspx");
        }

        protected void btnEnter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter First Name ");
            }
            if (String.IsNullOrWhiteSpace(txtLastName.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Last Name ");
            }
            if (String.IsNullOrWhiteSpace(txtPhone.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Phone Number ");
            }
            if (String.IsNullOrWhiteSpace(txtHourlyRate.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Hourly Rate ");

             clsDatabase.InsertTechnician(txtLastName.Text, txtLastName.Text, txtMiddleInitial.Text, txtEmail.Text, txtDepartment.Text, txtPhone.Text, Convert.ToDecimal(txtHourlyRate.Text));
                            
            }
        }

        protected void txtPh_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim().Length > 11)
            System.Web.HttpContext.Current.Response.Write("10 digits or less ");
            
            }

        protected void txtPh_TextChanged1(object sender, EventArgs e)
        {
            if (txtPhone.Text.Trim().Length > 11)
                System.Web.HttpContext.Current.Response.Write("10 digits or less ");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        
            {
                if (String.IsNullOrWhiteSpace(txtFirstName.Text))
                {
                    System.Web.HttpContext.Current.Response.Write("Please Enter First Name ");
                }
                if (String.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    System.Web.HttpContext.Current.Response.Write("Please Enter Last Name ");
                }
                if (String.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    System.Web.HttpContext.Current.Response.Write("Please Enter Phone Number ");
                }
                if (String.IsNullOrWhiteSpace(txtHourlyRate.Text))
                {
                    System.Web.HttpContext.Current.Response.Write("Please Enter Hourly Rate ");

                    clsDatabase.InsertTechnician(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text, txtEmail.Text, txtDepartment.Text, txtPhone.Text, Convert.ToDecimal(txtHourlyRate.Text));

                }  
        } 
        }
    
}