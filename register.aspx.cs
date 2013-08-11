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

    Class1 cs = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {

        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();

        String insst = "insert into userinfo( username,password,Email,regdate,categorise) values('" + username.Text + "','" + password.Text + "','" + email.Text  + "','" + DateTime.Today+ "','3')";
        String seleet="select max(usrid) from userinfo";
        if (password.Text == repassword.Text)
        {
            
            SqlCommand insset = new SqlCommand(insst, con);
            SqlCommand sellect = new SqlCommand(seleet, con);
            SqlDataReader reader = insset.ExecuteReader();
            reader.Close();
            int rowid = Convert.ToInt16(sellect.ExecuteScalar());
            Session["userid"] = rowid;
     
            Session["name"] = username.Text;
            con.Close();
            cs.writelog(username.Text + " has register for this system on" + DateTime.Now.ToString());
            Response.Redirect("About.aspx");
            
        }
        else

            Response.Write("your passward did not match");
            con.Close();
    }
     
}
