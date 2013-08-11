using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class teacher : System.Web.UI.Page
{
    public int uid;
    public string useid;
    public string username;
    public int catego ;
    Class1 cs = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        useid = Session["userid"].ToString();
        Session["uid"] = uid;
        Session["scoreing"] = useid;
        username = Session["name"].ToString();
        catego = Convert.ToInt16(Session["categ"]);
        string select="";
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();

        if (Convert.ToInt16(Session["categ"]) == 1)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 1 and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'))  and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";

        }
        else if (Convert.ToInt16(Session["categ"]) == 2)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 2 and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "')) and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";
        }
        else if (Convert.ToInt16(Session["categ"]) == 3)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 3 and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'))  and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";
        }
        else if (Convert.ToInt16(Session["categ"]) == 4)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 2 or category = 4) and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "')) and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";

        }
        else if (Convert.ToInt16(Session["categ"]) == 5)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 3 or category = 2 or category = 5) and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "')) and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";
        }
        else if (Convert.ToInt16(Session["categ"]) == 6)
        {
            //select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 3 or category = 6) and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "') and uploadid not in (select uploadid from assign where assignfromid='" + useid + "') )";
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 3 or category = 6) and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "')) and uploadid not in (select uploadid from assign where assignfromid='" + useid + "') ";
        }
        else if (Convert.ToInt16(Session["categ"]) == 7)
        {
            select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 2 or category = 3 or category = 4 or category = 5 or category = 6 or category = 7) and uploadid not in (select uploadingid from score where scoringid='" + useid + "' or scoringid in (select usrid from userinfo where belogntoteach='" + useid + "')) and uploadid not in (select uploadid from assign where assignfromid='" + useid + "')";
        }

        else
            Response.Write("no user");
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataAdapter adap = new SqlDataAdapter(seletive);
        DataSet ds = new DataSet();
        adap.Fill(ds);
       
        DataList1.DataSource = ds;
        DataList1.DataBind();
    }


    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {

        if (e.CommandName == "grademe")
        {
            useid = Session["userid"].ToString(); 
            uid = Convert.ToInt16(e.CommandArgument);
            Session["uid"] = uid;
            Session["scoreing"] = useid;
            Session["name"] = username;
            cs.writelog(" " + username + " has review all the article ");
            Response.Redirect("Faculty.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        catego = Convert.ToInt16(Session["categ"]);
        Session["catego"] = catego;
        Session["username"] = username;
        Session["userid"] = useid;
        Response.Redirect("Assign.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        catego = Convert.ToInt16(Session["categ"]);
        Session["catego"] = catego;
        Session["username"] = username;
        Session["userid"] = useid;
        Response.Redirect("confirm.aspx");
    }
}