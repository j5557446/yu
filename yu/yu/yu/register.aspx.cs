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

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool bln_checkok = false;
            ezadonet ezado = new ezadonet();
            ezado.Open();
            ezado.CommandText = "INSERT INTO [dbo].[sys_user]( [mno],[mname],[mpassword]) VALUES (@mno,@mname,@mpassword)";
            ezado.ParametersAdd("@mno", txt_user_no.Text, true);
            ezado.ParametersAdd("@mpassword", txt_password.Text, false);
            ezado.ParametersAdd("@mname", txt_user_name.Text, false);
            ezado.cmd.ExecuteNonQuery();



        }
    }
}