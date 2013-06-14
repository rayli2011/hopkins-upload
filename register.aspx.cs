using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();

        String insst = "insert into userinfo( username,password,Email,regdate) values('" + username.Text + "','" + password.Text + "','" + email.Text  + "','" + DateTime.Today+ "')";
        String seleet="select max(usrid) from userinfo";
        if (password.Text == repassword.Text)
        {
            
            SqlCommand insset = new SqlCommand(insst, con);
            SqlCommand sellect = new SqlCommand(seleet, con);
            SqlDataReader reader = insset.ExecuteReader();
            reader.Close();
            int rowid = Convert.ToInt16(sellect.ExecuteScalar());
            Session["userid"] = rowid;
            Session["studentstates"] = "1";
            Session["username"] = username.Text;
            Response.Redirect("newload.aspx");
            con.Close();
        }
        else
            Response.Write("your passward did not match");
            con.Close();
    }
     
}
