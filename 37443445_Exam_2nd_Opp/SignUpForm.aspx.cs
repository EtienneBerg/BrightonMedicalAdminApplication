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
    public partial class SignUpForm : System.Web.UI.Page
    {
        SqlConnection conn;  //declare sqldata operators
        SqlCommand cmd;
        SqlDataReader reader;
        public int highestid = 0;
        public static string connstring = Default.connectionstring;     //global connectionstring

        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            lbl_message.Visible = false;
            IdNum();
        }
        public int IdNum()
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                conn.Open();
                string sql = "SELECT Id FROM Account";      //select all
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
                return highestid+1;

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
                return highestid;
            }
        }
        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx"); //button operations for redirections
        }

        protected void btn_signUp_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                conn = new SqlConnection(connstring);
                

                string name = txtbx_userName.Text;
                string password = txtbx_password.Text;
                int num = IdNum();

                string sql = "INSERT INTO Account([Id],[Username],[Password]) VALUES (@id,@name,@psswrd)"; //insert statement

                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", num);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@psswrd", password);
                conn.Open();
                cmd.ExecuteNonQuery();


                
                lbl_message.Visible = true;
                btn_cancel.Text = "To Login";
                conn.Close();
            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;


            }


        }
      
    }
}