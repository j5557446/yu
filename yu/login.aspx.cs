using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ezClass;
using System.Web.Configuration;

namespace yu
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string str_name = "";
            lbl_message.Text = "";
           
                if (CheckUser1(ref str_name))
                    CheckOK(str_name);
                else
                    CheckFalse();
            
        }
        private void CheckOK(string sUserName)
        {
            lbl_message.Text = sUserName + " 歡迎您!!";

            Session["UserNo"] = txt_user_no.Text;
            Session["UserName"] = sUserName;
            //Response.Redirect("home.aspx");
            //Response.End();
        }

        private void CheckFalse()
        {
            if (lbl_message.Text == "")
                lbl_message.Text = "帳號或密碼輸入錯誤!!";
        }

        private bool CheckUser1(ref string sUserName)
        {
            bool bln_checkok = false;
            ezadonet ezado = new ezadonet();
            ezado.Open();
            ezado.CommandText = "SELECT mname FROM [user] WHERE mno = @mno AND mpassword = @mpassword";
            ezado.ParametersAdd("@mno", txt_user_no.Text, true);
            ezado.ParametersAdd("@mpassword", txt_password.Text, false);
            bln_checkok = ezado.HasRow;
            if (bln_checkok) sUserName = ezado.GetStringValue("mname");
            ezado.Close();
            return bln_checkok;
        }



        private bool CheckUser(ref string sUserName)
        {
            bool bln_checkok = false;
            lbl_message.Text = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT mname FROM [user] WHERE mno = @mno AND mpassword = @mpassword";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@mno", txt_user_no.Text);
                cmd.Parameters.AddWithValue("@mpassword", txt_password.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                bln_checkok = dr.HasRows;
                if (dr.HasRows)
                {
                    dr.Read();
                    sUserName = dr["mname"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                bln_checkok = false;
                lbl_message.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return bln_checkok;
        }
    }
}