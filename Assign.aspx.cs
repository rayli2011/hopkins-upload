using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Assign : System.Web.UI.Page
{
    public string select;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["username"].ToString();
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();

                if( Convert.ToInt16(Session["categ"])==1)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 1";
                else if( Convert.ToInt16(Session["categ"])==2)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 2";
                else if( Convert.ToInt16(Session["categ"])==3)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 3";
                else if( Convert.ToInt16(Session["categ"])==4)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 1 or catego= 2 ";
                else if( Convert.ToInt16(Session["categ"])==5)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 2 or catego= 3";
                else if( Convert.ToInt16(Session["categ"])==6)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 1 or catego= 3";
                else if( Convert.ToInt16(Session["categ"])==7)
         select = "select username,usrid,categorise,categ,belogntoteach from userinfo where catego= 1 or catego= 2 or catego= 3 ";
                else
         Response.Write("no users");


        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataAdapter adap = new SqlDataAdapter(seletive);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        ListBox1.DataSource = ds;
        ListBox1.DataBind();


       

        con.Close();
    }
        
    }
