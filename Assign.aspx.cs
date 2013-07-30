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
        if(!IsPostBack)
        {
        
        Label1.Text = Session["username"].ToString();
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();

        if (Convert.ToInt16(Session["categ"]) == 1)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 1 and categorise<>1 ";
            DropDownList1.Items.Add(new ListItem("NWS", "1"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 2)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 2 and categorise<>1";
            DropDownList1.Items.Add(new ListItem("DB", "2"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 3)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 3 and categorise<>1";
            DropDownList1.Items.Add(new ListItem("HCI", "3"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 4)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 1 or catego= 2 or catego=4 and categorise<>1";
            DropDownList1.Items.Add(new ListItem("NWS", "1"));
            DropDownList1.Items.Add(new ListItem("DB", "2"));
            DropDownList1.Items.Add(new ListItem("NWS_DB", "4"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 5)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 2 or catego= 3 or catego= 5 and categorise<>1 ";
            DropDownList1.Items.Add(new ListItem("HCI", "3"));
            DropDownList1.Items.Add(new ListItem("DB", "2"));
            DropDownList1.Items.Add(new ListItem("DB_HCI", "5"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 6)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 1 or catego= 3 catego= 6 and categorise<>1";
            DropDownList1.Items.Add(new ListItem("HCI", "3"));
            DropDownList1.Items.Add(new ListItem("NWS", "1"));
            DropDownList1.Items.Add(new ListItem("NWS_HCI", "6"));
        }
        else if (Convert.ToInt16(Session["categ"]) == 7)
        {
            select = "select username,usrid,categorise,catego,belogntoteach from userinfo where catego= 1 or catego= 2 or catego= 3 or catego=4 or catego= 5 or catego=6 or catego=7 and categorise<>1";
            DropDownList1.Items.Add(new ListItem("NWS", "1"));
            DropDownList1.Items.Add(new ListItem("HCI", "3"));
            DropDownList1.Items.Add(new ListItem("DB", "2"));
            DropDownList1.Items.Add(new ListItem("NWS_DB", "4"));
            DropDownList1.Items.Add(new ListItem("DB_HCI", "5"));
            DropDownList1.Items.Add(new ListItem("NWS_HCI", "6"));
            DropDownList1.Items.Add(new ListItem("NWS_HCI_DB", "7"));
        }
        else
            Response.Write("no users");
        

        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataAdapter adap = new SqlDataAdapter(seletive);
        DataSet ds = new DataSet();
        adap.Fill(ds);
        ListBox1.DataSource = ds;
        ListBox1.DataBind();

        }
       

      
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Response.Write("<script language=javascript>alert('here 1111');</script>");
       
        t1.Visible = true;
        string name1 = "";
        string value="";
        for (int i = 0; i <( ListBox1.Items.Count); i++)  
         {  
             if (ListBox1.Items[i].Selected)  
            {
                name1 = ListBox1.Items[i].Text;
                value = ListBox1.Items[i].Value;
            }  
        }

        Label2.Text = name1;
        name.Text = value;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "update userinfo set categorise=3 ,catego='" + DropDownList1.SelectedValue + "',belogntoteach='" + Convert.ToInt16(Session["userid"]) + "' where usrid='" + ListBox1.SelectedValue + "'";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
    }
}
