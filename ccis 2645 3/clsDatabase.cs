using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace ccis_2645_3
{
    public class clsDatabase
    {
        //***** AcquireConnection()
        private static SqlConnection AcquireConnection()
        {
            SqlConnection cnSQL = null;
            Boolean blnErrorOccurred = false;

            if (ConfigurationManager.ConnectionStrings["ServiceCenter"] != null)
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings["ServiceCenter"].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }
        //#2//***** TechnicianList()
        public static DataSet TechnicianList()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                return null;
            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspGetTechnicianList";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;


                dsSQL = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    intRetCode = daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }
        //HELP
        //#1//***** TechnicianByID()
        public static DataSet TechnicianByID(int iTechID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode = 0;
            DataSet dsData = new DataSet();
            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;

            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspGetTechnicianByID";

                cmdSQL.Parameters.Add(new SqlParameter("@TechnicianID", SqlDbType.Int));
                cmdSQL.Parameters["@TechnicianID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@TechnicianID"].Value = iTechID;


                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsData);
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsData;
            }
        }
        // # 3 //***** InsertTechnician()                        
        public static Int32 InsertTechnician(string strLName, string strFName, string strMInit, string strEMail, string strDept, string strPhone, decimal decHRate)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode = 0;
            Int32 intNewID = 0;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;

            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspInsertTechnician";

                cmdSQL.Parameters.Add(new SqlParameter("@LName", SqlDbType.NVarChar, 30));
                cmdSQL.Parameters["@LName"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@LName"].Value = strLName;

                cmdSQL.Parameters.Add(new SqlParameter("@FName", SqlDbType.NVarChar, 30));
                cmdSQL.Parameters["@FName"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@FName"].Value = strFName;

                cmdSQL.Parameters.Add(new SqlParameter("@MInit", SqlDbType.NChar, 1));
                cmdSQL.Parameters["@MInit"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@MInit"].Value = strMInit;


                //if (strMInit.Trim().Length == 0)
                //{
                //    cmdSQL.Parameters["@MInit"].Value = DBNull.Value;
                //}

                cmdSQL.Parameters.Add(new SqlParameter("@EMail", SqlDbType.NVarChar, 50));
                cmdSQL.Parameters["@EMail"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EMail"].Value = strEMail;

                if (strEMail.Trim().Length == 0)
                {
                    cmdSQL.Parameters["@Email"].Value = DBNull.Value;
                }

                cmdSQL.Parameters.Add(new SqlParameter("@Dept", SqlDbType.NVarChar, 25));
                cmdSQL.Parameters["@Dept"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@Dept"].Value = strDept;

                if (strDept.Trim().Length == 0)
                {
                    cmdSQL.Parameters["@Dept"].Value = DBNull.Value;
                }

                cmdSQL.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 10));
                cmdSQL.Parameters["@Phone"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@Phone"].Value = strPhone;

                cmdSQL.Parameters.Add(new SqlParameter("@HRate", SqlDbType.Money));
                cmdSQL.Parameters["@HRate"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@HRate"].Value = decHRate;

                cmdSQL.Parameters.Add(new SqlParameter("@NewTechnicianID", SqlDbType.Int));
                cmdSQL.Parameters["@NewTechnicianID"].Direction = ParameterDirection.Output;

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                try
                {
                    intRetCode = cmdSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                }
                finally
                {
                    cnSQL.Close();
                    cnSQL.Dispose();
                }

                if (!blnErrorOccurred)
                {
                    intNewID = Convert.ToInt32(cmdSQL.Parameters["@NewTechnicianID"].Value);
                }
                cmdSQL.Parameters.Clear();
                cmdSQL.Dispose();

            }

            if (blnErrorOccurred)
            {
                return -1;
            }
            else
            {
                return intNewID;
            }
        }
        //#4   //***** DeleteTechnician()
        public static Int32 DeleteTechnician(string strTechnicianID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode = 0;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspDeleteTechnician";

                cmdSQL.Parameters.Add(new SqlParameter("@TechnicianID", SqlDbType.Int));
                cmdSQL.Parameters["@TechnicianID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@TechnicianID"].Value = strTechnicianID;



                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                try
                {
                 intRetCode = cmdSQL.ExecuteNonQuery();
                 }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        // # 5 //*****UpdateTechnician()
        public static Int32 UpdateTechnician(string strLName, string strFName, string strMInit, string strEMail, string strDept, string strPhone, decimal decHRate, string iTechID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Int32 intRetCode = 0;
            Int32 intNewID = 0;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;

            }
            else
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "uspUpdateTechnician";

                cmdSQL.Parameters.Add(new SqlParameter("@TechnicianID", SqlDbType.Int));
                cmdSQL.Parameters["@TechnicianID"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@TechnicianID"].Value = iTechID;

                cmdSQL.Parameters.Add(new SqlParameter("@LName", SqlDbType.NVarChar, 30));
                cmdSQL.Parameters["@LName"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@LName"].Value = strLName;

                cmdSQL.Parameters.Add(new SqlParameter("@FName", SqlDbType.NVarChar, 30));
                cmdSQL.Parameters["@FName"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@FName"].Value = strFName;

                cmdSQL.Parameters.Add(new SqlParameter("@MInit", SqlDbType.NChar, 1));
                cmdSQL.Parameters["@MInit"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@MInit"].Value = strMInit;
                if (String.IsNullOrWhiteSpace(strMInit))
                {
                    cmdSQL.Parameters["@MInit"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@MInit"].Value = strMInit;
                }
 
                cmdSQL.Parameters.Add(new SqlParameter("@EMail", SqlDbType.NVarChar, 50));
                cmdSQL.Parameters["@EMail"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@EMail"].Value = strEMail;

                if (String.IsNullOrWhiteSpace(strEMail))
                {
                    cmdSQL.Parameters["@EMail"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@EMail"].Value = strEMail;
                }

                cmdSQL.Parameters.Add(new SqlParameter("@Dept", SqlDbType.NVarChar, 25));
                cmdSQL.Parameters["@Dept"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@Dept"].Value = strDept;

                if (String.IsNullOrWhiteSpace(strDept))
                {
                    cmdSQL.Parameters["@Dept"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@Dept"].Value = strDept;
                }

                cmdSQL.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar, 10));
                cmdSQL.Parameters["@Phone"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@Phone"].Value = strPhone;

                cmdSQL.Parameters.Add(new SqlParameter("@HRate", SqlDbType.Money));
                cmdSQL.Parameters["@HRate"].Direction = ParameterDirection.Input;
                cmdSQL.Parameters["@HRate"].Value = decHRate;


                if (strMInit.Trim().Length < 1)
                {
                    cmdSQL.Parameters["@MInit"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@MInit"].Value = strMInit;
                }

                if (strEMail.Trim().Length < 1)
                {
                    cmdSQL.Parameters["@EMail"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@EMail"].Value = strEMail;
                }

                if (strDept.Trim().Length < 1)
                {
                    cmdSQL.Parameters["@Dept"].Value = DBNull.Value;
                }
                else
                {
                    cmdSQL.Parameters["@Dept"].Value = strDept;
                }

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;



                try
                {
                    intRetCode = cmdSQL.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                }
                finally
                {
                    cnSQL.Close();
                    cnSQL.Dispose();
                }


                if (!blnErrorOccurred)
                {
                    intNewID = Convert.ToInt32(cmdSQL.Parameters["@NewTechnicianID"].Value);
                }
                cmdSQL.Parameters.Clear();
                cmdSQL.Dispose();

            }

            if (blnErrorOccurred)
            {
                return -1;
            }
            else
            {
                return intNewID;
            }
        }
    }
} 
  



    