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
    public partial class LogInForm : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        public static string connstring = Default.connectionstring;     //global connectionstring

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {       //exception handling
                conn = new SqlConnection(connstring);     //declare connectionstring
                conn.Open();
                adapter = new SqlDataAdapter();

                string name = txtbx_userName.Text;      //set inpu variables
                string password = txtbx_password.Text;
                Boolean Correct = false;


                HttpCookie cookie = new HttpCookie("UserName");     //create new cookie to save username
                cookie.Value = name;
                Response.Cookies.Add(cookie);

                string sql = "SELECT COUNT(*) FROM Account WHERE Username = @name AND Password = @password";     //check if the username and password match
                cmd = new SqlCommand(sql, conn);
                //adapter.SelectCommand = cmd;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@Password", password);
                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    Correct = true;      //username and password match
                    Response.Redirect("DashboardForm.aspx");        //redirect to next page
                }
                else
                {
                    Correct = false;//username and password do not match
                    lbl_error.Text = "Invalid Password or Username Combination";
                    lbl_error.Visible = true;
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
            Response.Redirect("Default.aspx"); //button operations for redirections
        }
    }
}