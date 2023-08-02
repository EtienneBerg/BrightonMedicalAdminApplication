//37443445
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;            //include libraries

namespace _37443445_Exam_2nd_Opp
{
    public partial class FinancialReportForm : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string connstring = Default.connectionstring;     //global connectionstring

        protected void Page_Load(object sender, EventArgs e)
        {
            ShowFinancialReport();
            lbl_error.Visible = false;
        }
        public void ShowFinancialReport()
        {
            try//exception handling
            {
                lstbx_report.Items.Clear();
                conn = new SqlConnection(connstring);
                conn.Open();

                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }

                adapter = new SqlDataAdapter();

                string sql = "SELECT * FROM Appointment WHERE UserName = '" + username + "'";      //show all  Appointment
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                int fee = 500;
                int totalfee = 0;

                while (reader.Read())
                {
                    DateTime apptDate = (DateTime)reader["Date"];
                    string date = apptDate.ToString("dd-MM-yyyy");
                    string time = reader["Time"].ToString();
                    string proc = reader["Procedure"].ToString();
                    totalfee += fee;
                    string trow = date + " " + time + " " + proc+" R"+fee.ToString();
                    lstbx_report.Items.Add(trow);
                }
                lstbx_report.Items.Add("Total fee for Ambulance Cost of all Procedures = R"+totalfee.ToString());

                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashboardForm.aspx");        //redirect to next page
        }
    }
}