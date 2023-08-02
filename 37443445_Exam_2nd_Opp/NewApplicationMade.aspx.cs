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
    public partial class NewApplicationMade : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public int highestid = 0;
        public static string connstring = Default.connectionstring;     //global connectionstring

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            displayTimeListBox();
            displayProcedureListBox();
            Calendar1.SelectedDate = DateTime.Today;

        }

        public void displayTimeListBox()
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();


                adapter = new SqlDataAdapter();

                string sql = "SELECT  Slot FROM TimeSlot";      //show all  TimeSlots
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string timeS = reader["Slot"].ToString();
                    lstbx_time.Items.Add(timeS);
                }

                conn.Close();

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }

        }
        public void displayProcedureListBox()
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();


                adapter = new SqlDataAdapter();

                string sql = "SELECT  ProcedureName FROM [Procedure]";      //show all  Procedures
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string pname = reader["ProcedureName"].ToString();
                    lstbx_procedure.Items.Add(pname);
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

        public int IdNum()
        {
            try//exception handling
            {       
                conn = new SqlConnection(connstring);   //selects the first available id num for PK
                conn.Open();
                string sql = "SELECT Id FROM Appointment";
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();

                while (reader.Read())       //reader function
                {
                    int currentid = Convert.ToInt32(reader.GetValue(0));
                    if (currentid >= highestid)
                    {
                        highestid = currentid;
                    }
                }
                conn.Close();
                return highestid + 1;

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
                return highestid;
            }
        }

        protected void btn_confirm_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                DateTime selecteddate = Calendar1.SelectedDate;
                string time = lstbx_time.SelectedValue.ToString();
                TimeSpan timeValue;
                TimeSpan.TryParse(time, out timeValue);
                int num = IdNum();

                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }
                string procname = lstbx_procedure.SelectedValue.ToString();


                conn = new SqlConnection(connstring);
                conn.Open();

                string sql = "INSERT INTO Appointment([Id],[Username], [Date], [Time], [Procedure]) VALUES (@id,@name,@date,@time,@procedure)"; //insert statement

                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", num);
                cmd.Parameters.AddWithValue("@name", username);
                cmd.Parameters.AddWithValue("@date", selecteddate);
                cmd.Parameters.AddWithValue("@time", timeValue);
                cmd.Parameters.AddWithValue("@procedure", procname);

                cmd.ExecuteNonQuery();

                conn.Close();
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