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
    public partial class Technicians : System.Web.UI.Page
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
                LoadTechs();
            }
        }
        protected void LoadTechs()
        {
            DataSet dsData;
            dsData = clsDatabase.TechnicianList();
            drpTech.Items.Clear();
            drpTech.DataTextField = "TechName";
            drpTech.DataValueField = "TechnicianID";
            drpTech.DataSource = dsData.Tables[0];
            drpTech.DataBind();
        }

        //***********************************************************
        //**Display Technician
        //********************************
        protected void btnMM_Click(object sender, EventArgs e)
        {
            Response.Redirect("./Default.aspx");
        }

        protected void txtHR_TextChanged(object sender, EventArgs e)
        {

            if (txtHR.Text.Trim().Length > 0)
                System.Web.HttpContext.Current.Response.Write("must be larger then 0 ");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Response.Redirect("Technicians.aspx");
        }

        protected void txtPh_TextChanged(object sender, EventArgs e)
        {
            if (txtPh.Text.Trim().Length > 11)
                System.Web.HttpContext.Current.Response.Write("10 digits or less ");

        }

        protected void txtPh_TextChanged1(object sender, EventArgs e)
        {
            if (txtPh.Text.Trim().Length > 11)
                System.Web.HttpContext.Current.Response.Write("10 digits or less ");
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtFN.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter First Name ");
            }
            if (String.IsNullOrWhiteSpace(txtLN.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Last Name ");
            }
            if (String.IsNullOrWhiteSpace(txtPh.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Phone Number ");
            }
            if (String.IsNullOrWhiteSpace(txtHR.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Hourly Rate ");
            }

            clsDatabase.InsertTechnician(txtLN.Text, txtFN.Text, txtMI.Text, txtEM.Text, txtDP.Text, txtPh.Text, Convert.ToDecimal(txtHR.Text));




            //clsDatabase.UpdateTechnician(txtLN.Text, txtFN.Text, txtMI.Text, txtEM.Text, txtDP.Text, txtPh.Text, Convert.ToDecimal(txtHR.Text));

        }

        protected void drpTech_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsData;
            dsData = clsDatabase.TechnicianByID(Convert.ToInt32(drpTech.SelectedValue));
            txtFN.Text = dsData.Tables[0].Rows[0]["FName"].ToString();
            txtMI.Text = dsData.Tables[0].Rows[0]["MInit"].ToString();
            txtLN.Text = dsData.Tables[0].Rows[0]["LName"].ToString();
            txtEM.Text = dsData.Tables[0].Rows[0]["Email"].ToString();
            txtDP.Text = dsData.Tables[0].Rows[0]["Dept"].ToString();
            txtPh.Text = dsData.Tables[0].Rows[0]["Phone"].ToString();
            txtHR.Text = dsData.Tables[0].Rows[0]["Hrate"].ToString();
            Session.Contents["TechID"] = drpTech.SelectedValue;
        }


        protected void btnEnter_Click(object sender, EventArgs e)
        {

            //Int32 intRetValue;
            Boolean blnError = false;

            //lblEM.Text = "";


            if (String.IsNullOrWhiteSpace(txtFN.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter First Name ");
                blnError = true;
            }
            if (String.IsNullOrWhiteSpace(txtLN.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Last Name ");
                blnError = true;
            }
            if (String.IsNullOrWhiteSpace(txtPh.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Phone Number ");
                blnError = true;
            }
            if (String.IsNullOrWhiteSpace(txtHR.Text))
            {
                System.Web.HttpContext.Current.Response.Write("Please Enter Hourly Rate ");
                blnError = true;

            }
            if (blnError)
            {
                lblEM.Text = "Check messages at bottom of page";
            }
            else
            {
                if (Session.Contents["TechID"] != null)
                {
                    clsDatabase.UpdateTechnician(txtLN.Text, txtFN.Text, txtMI.Text, txtEM.Text, txtDP.Text, txtPh.Text, Convert.ToDecimal(txtHR.Text),Session.Contents["TechID"].ToString());
                }
                else
                {
                    clsDatabase.InsertTechnician(txtLN.Text, txtFN.Text, txtMI.Text, txtEM.Text, txtDP.Text, txtPh.Text, Convert.ToDecimal(txtHR.Text));
                }
                LoadTechs();
            }
            
          
                }

        protected void btnNewTech_Click(object sender, EventArgs e)
        {

           
            txtLN.Text = "";
            txtFN.Text = "";
            txtMI.Text = "";
            txtEM.Text = "";
            txtDP.Text = "";
            txtPh.Text = "";
            txtHR.Text = "";
            
            Session.Contents["TechID"] = null;
        }
            
        }
    }

            
            
            


     
    
   

