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
    public partial class DeleteForm : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string connstring = Default.connectionstring;     //global connectionstring
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            displayAppointmentListBox();


        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashboardForm.aspx");        //redirect to next page
        }

        public void displayAppointmentListBox()
        {
            try//exception handling
            {
                lstbx_appointment.Items.Clear();
                conn = new SqlConnection(connstring);
                conn.Open();

                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }

                adapter = new SqlDataAdapter();

                string sql = "SELECT * FROM Appointment WHERE UserName = '" + username+"'";      //show all  Appointments
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime apptDate = (DateTime)reader["Date"];
                    string date = apptDate.ToString("dd-MM-yyyy");
                    string time = reader["Time"].ToString();
                    string proc = reader["Procedure"].ToString();
                    string trow = date + " " + time + " " + proc;
                    lstbx_appointment.Items.Add(trow);
                }


                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }

        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string delete_query = "DELETE FROM [Appointment] WHERE Id ='" + lstbx_appointment.SelectedIndex + "'";     //delete statement
                SqlCommand cmd = new SqlCommand(delete_query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();
                conn.Close();


                displayAppointmentListBox();
                

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }
    }
}