using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class admin : System.Web.UI.Page
{
    public string a, b;
    public int userid;
    protected void Page_Load(object sender, EventArgs e){
      
       
        
    }



    public void ray(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        userid = Convert.ToInt16(btn.CommandArgument);

        Label1.Text = userid.ToString();
        T1.Visible = true;
        Button1.Visible = true;
        Session["id"] = userid;
    }

    public void Button1_Click(object sender, EventArgs e)
        
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "update userinfo set categorise='" + FF.SelectedValue + "',categ='" + DD.SelectedValue + "',TAid='" + TextBox1.Text + "' where usrid='" + Convert.ToInt16(Session["id"]) + "'";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        T1.Visible = false;
        Button1.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
 
        Session.Abandon();
        Session.RemoveAll();
        Response.Redirect("Default.aspx");
    
    }
}