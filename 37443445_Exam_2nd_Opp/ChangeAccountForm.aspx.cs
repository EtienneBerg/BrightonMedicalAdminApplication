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
    public partial class ChangeAccountForm : System.Web.UI.Page
    {
        SqlDataAdapter adapter;         //declare sqldata operators
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;
        public static string connstring = Default.connectionstring;     //global connectionstring
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_error.Visible = false;
            lbl_newPassword.Visible = false;
            btn_password.Visible = false;
            txtbx_password.Visible = false;


        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("DashboardForm.aspx");        //redirect to next page
        }

        protected void btn_change_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }


                conn = new SqlConnection(connstring);
                conn.Open();
                string name = txtbx_name.Text;
                string surname = txtbx_surname.Text;
                string number = txtbx_number.Text;
                string email = txtbx_email.Text;
                string allergy = txtbx_allergies.Text;
                string emergencyc = txtbx_emergencyContact.Text;

                string sql = "UPDATE PersonalInfo SET Name = @name, Surname = @surname, Number = @number, Email = @email, Allergies = @allergies, EmergencyContact = @emergencycontact WHERE UserName = '" + username + "'";     //update statement
                cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@name", txtbx_name.Text);
                cmd.Parameters.AddWithValue("@surname", txtbx_surname.Text);
                cmd.Parameters.AddWithValue("@number", txtbx_number.Text);
                cmd.Parameters.AddWithValue("@email", txtbx_email.Text);
                cmd.Parameters.AddWithValue("@allergies", txtbx_allergies.Text);
                cmd.Parameters.AddWithValue("@emergencycontact", txtbx_emergencyContact.Text);

                cmd.ExecuteNonQuery();
                
                conn.Close();
                btn_change.Visible = false;
                btn_cancel.Text = "Return to Dashboard";

            }
            catch (Exception er)
            {
                lbl_error.Visible = true;
                lbl_error.Text = er.Message;
            }
        }

        protected void ckbx_password_CheckedChanged(object sender, EventArgs e)         //conditiions for checkbox
        {
            if (ckbx_password.Checked == true)
            {
                lbl_newPassword.Visible = true;
                txtbx_password.Visible = true;
                btn_password.Visible = true;
            }
            else
            {
                lbl_newPassword.Visible = false;
                txtbx_password.Visible = false;
                btn_password.Visible = false;
            }
        }


        protected void btn_password_Click(object sender, EventArgs e)
        {
            try//exception handling
            {
                string username = "";
                if (Request.Cookies["UserName"] != null)            //retrieve data from cookie
                {
                    username = Request.Cookies["UserName"].Value;
                }


                conn = new SqlConnection(connstring);
                conn.Open();


                string sql = "UPDATE Account SET Password = @pssword WHERE UserName = '" + username + "'";     //update statement
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@pssword", txtbx_password.Text);

                cmd.ExecuteNonQuery();

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