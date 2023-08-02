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
    public partial class Default : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
       
        public static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BrightonMedical.mdf;Integrated Security=True";//connectionstring global declare

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;      //set error label to invisible
            DisplayAvailableAppointments();
        }

        public void DisplayAvailableAppointments()
        {
            try//exception handling
            {
                conn = new SqlConnection(connectionstring);
                conn.Open();


                adapter = new SqlDataAdapter();

                string sql = "SELECT * FROM TimeSlot WHERE Slot NOT IN (SELECT Time FROM Appointment WHERE Date = @Today)"; //Anyone should be able to view available appointments
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string timeslt = reader["Slot"].ToString();
                    lstbx_times.Items.Add(timeslt);
                }

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LogInForm.aspx"); //button operations for redirections

        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUpForm.aspx"); //button operations for redirections

        }



    }

       

    
}