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
    public partial class ChangeAppointmentForm : System.Web.UI.Page
    {

        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string connstring = Default.connectionstring;     //global connectionstring
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            Calendar1.SelectedDate = DateTime.Today;
            displayListBox();
            DisplayYourAppointments();      //methods
            displayTimeSlots();





        }

        public void DisplayYourAppointments()
        {
            try//exception handling
            {
                lstbx_app.Items.Clear();
                conn = new SqlConnection(connstring);
                conn.Open();

                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }

                adapter = new SqlDataAdapter();

                string sql = "SELECT * FROM Appointment WHERE UserName = '" + username + "'";      //show all  appointments
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime apptDate = (DateTime)reader["Date"];
                    string date = apptDate.ToString("dd-MM-yyyy");
                    string time = reader["Time"].ToString();
                    string proc = reader["Procedure"].ToString();
                    string trow = date + " " + time + " " + proc;
                    lstbx_app.Items.Add(trow);
                }


                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }
        public void displayTimeSlots()
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();


                adapter = new SqlDataAdapter();

                string sql = "SELECT * FROM TimeSlot WHERE Slot NOT IN (SELECT Time FROM Appointment WHERE Date = @Today)"; //view available appointments
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Today", DateTime.Today);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string timeslt = reader["Slot"].ToString();
                    lstbx_time.Items.Add(timeslt);
                }

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }


        }


        

        public void displayListBox()            //display listbox data
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();


                adapter = new SqlDataAdapter();

                string sql = "SELECT  * FROM [Procedure]";      //show all  Procedures
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string proc = reader["ProcedureName"].ToString();
                    lstbx_procedure.Items.Add(proc);
                }


                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }

        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashboardForm.aspx");        //redirect to next page
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                TimeSpan timespan;                                              //change appointment data
                TimeSpan.TryParse(lstbx_time.SelectedValue.ToString(), out timespan);

                DateTime selectedDate = Calendar1.SelectedDate;
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                string sql = "UPDATE Appointment SET Date = '" + formattedDate + "',Time = '" + timespan + "',Procedure = '" + lstbx_procedure.SelectedValue + "'  WHERE Id = '" + lstbx_app.SelectedIndex + "'";     //update statement
                cmd = new SqlCommand(sql, conn);
                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();

                conn.Close();
                DisplayYourAppointments();
                btn_cancel.Text = "Return to Dashboard";


               
            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }
    }
}