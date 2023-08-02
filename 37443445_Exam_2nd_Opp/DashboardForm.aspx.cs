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
    public partial class DashboardForm : System.Web.UI.Page
    {
        SqlConnection conn;  //declare sqldata operators
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        public Boolean vis = false;
        public Boolean ne = false;
        public string username = "";
        public static string connstring = Default.connectionstring;     //global connectionstring


        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            lbl_updateAmbulance.Visible = false;
            lbl_updateSMS.Visible = false;
            btn_financialReportForm.Visible = vis;
            DisplayYourAppointments();
            DisplayName();



        }

        public void DisplayName()
        {
            try
            {
                if (ne == false)
                {

                    if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                    {
                        username = Request.Cookies["UserName"].Value;
                        lbl_welcomeUser.Text = "Welcome to Brighton Medical "+username.ToString()+", How can we help you?";
                        lbl_appointment.Text = "Here are youre Appointments "+username.ToString();
                    }
                    ne = true;
                }
            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }

        public void DisplayYourAppointments()
        {
            try//exception handling
            {
                lstbx_appointments.Items.Clear();
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

                while (reader.Read())
                {
                    DateTime apptDate = (DateTime)reader["Date"];
                    string date = apptDate.ToString("dd-MM-yyyy");
                    string time = reader["Time"].ToString();
                    string proc = reader["Procedure"].ToString();
                    string trow = date + " " + time + " " + proc;
                    lstbx_appointments.Items.Add(trow);
                }


                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }

        protected void btn_newAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewApplicationMade.aspx"); //button operations for redirections
        }

        protected void btn_changeAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeAppointmentForm.aspx"); //button operations for redirections
        }

        protected void btn_deleteAppointment_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteForm.aspx"); //button operations for redirections
        }

        protected void btn_financialReportForm_Click(object sender, EventArgs e)
        {
            Response.Redirect("FinancialReportForm.aspx"); //button operations for redirections
        }

        protected void btn_changeAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeAccountForm.aspx"); //button operations for redirections
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void DisplayFinanceBtn()         //display financial report button
        {
            if (ckbx_ambulance.Checked == true)
            {
                btn_financialReportForm.Visible = true;
                lbl_updateAmbulance.Visible = true;

            }
            else
            {
                btn_financialReportForm.Visible = false;
                lbl_updateAmbulance.Visible = true;
            }
        }

        protected void ckbx_ambulance_CheckedChanged(object sender, EventArgs e)
        {
            DisplayFinanceBtn();
        }

        protected void ckbx_SMS_CheckedChanged(object sender, EventArgs e)
        {
            lbl_updateSMS.Visible = true;
            DisplayFinanceBtn();
        }

        protected void btn_logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); //button operations for redirections
        }
    }
}