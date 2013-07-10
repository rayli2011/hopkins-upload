using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "select username,password,Email,usrid,categorise,categ from userinfo where Email= '" + username.Text + "'AND password='" + passwrod.Text + "'";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        if (reader.Read())
        {

            Session["userid"] = reader[3];
            Session["name"] = reader[0];
            if (reader[4].ToString() == "S")
            {
               
                Response.Redirect("studentover.aspx");
            }
            else if (reader[4].ToString() == "F")
            {
                Session["categ"] = reader[5].ToString();
                Response.Redirect("teacher.aspx");
              
            }
            else if (reader[4].ToString() == "TA")
            {
                Response.Redirect("TA.aspx");
            }


        }
        else
        {
            Response.Write("it is no user");
        }

        con.Close();
    }
}
