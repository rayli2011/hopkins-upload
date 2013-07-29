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
        string select = "select username,password,Email,usrid,categorise,categ,TAid from userinfo where username= '" + username.Text + "'AND password='" + passwrod.Text + "'";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        if (reader.Read())
        {
        
            Session["userid"] = reader[3];
            Session["name"] = reader[0];
          
            if (reader[4].ToString() == "2")
            {
               
                Response.Redirect("studentover.aspx");
            }
            else if (reader[4].ToString() == "1")
            {
                Session["categ"] = reader[5].ToString();
                Session["TAid"] = reader[6];
                Session["userid"] = reader[3];
                Response.Redirect("teacher.aspx");
              
            }
            else if (reader[4].ToString() == "3")
            {
                Response.Redirect("assistant.aspx");
            }
            else if (reader[4].ToString() == "0")
            {
                Response.Redirect("admin.aspx");
            }

        }
        else
        {
            Response.Write("it is no user");
        }

        con.Close();
    }
}
