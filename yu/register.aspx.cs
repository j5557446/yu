using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ezClass;

namespace yu
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
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
            lbl_message.Text = "註冊失敗 此E-Mail已被註冊!";

            //Session["UserNo"] = txt_user_no.Text;
            //Session["UserName"] = sUserName;
            //Response.Redirect("home.aspx");
            //Response.End();
        }

        private void CheckFalse()
        {
            if (lbl_message.Text == "")
            {


                ezadonet ezado = new ezadonet();
                ezado.Open();
                ezado.CommandText = "INSERT INTO [dbo].[user]( [mno],[mname],[mpassword],[maddress],[mphone]) VALUES (@mno,@mname,@mpassword,@maddress,@mphone)";
                ezado.ParametersAdd("@mno", txt_user_no.Text, true);
                ezado.ParametersAdd("@mpassword", txt_password.Text, false);
                ezado.ParametersAdd("@mname", txt_user_name.Text, false);
                ezado.ParametersAdd("@maddress", txt_user_address.Text, false);
                ezado.ParametersAdd("@mphone", txt_user_phone.Text, false);
                ezado.cmd.ExecuteNonQuery();


                lbl_message.Text = "註冊成功";
            }
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






    }
}