using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    public int uid;
    public string useid;
    public string username;
    public int catego ;
    Class1 cs = new Class1();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            useid = Session["userid"].ToString();
            Session["uid"] = uid;
            Session["scoreing"] = useid;
            username = Session["name"].ToString();
            catego = Convert.ToInt16(Session["categ"]);
            string select = "";
            SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
            con.Open();

            if (Convert.ToInt16(Session["categ"]) == 1)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 1  and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";

            }
            else if (Convert.ToInt16(Session["categ"]) == 2)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 2 and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";
            }
            else if (Convert.ToInt16(Session["categ"]) == 3)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE category = 3 and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";
            }
            else if (Convert.ToInt16(Session["categ"]) == 4)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE ( category = 1 or category = 2 or category = 4) and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";

            }
            else if (Convert.ToInt16(Session["categ"]) == 5)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 3 or category = 2 or category = 5) and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";
            }
            else if (Convert.ToInt16(Session["categ"]) == 6)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 3 or category = 6) and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";
            }
            else if (Convert.ToInt16(Session["categ"]) == 7)
            {
                select = "SELECT uploadid,filename, title, abstract, uploaddate, category, url FROM uploadinfo WHERE (category = 1 or category = 2 or category = 3 or category = 4 or category = 5 or category = 6 or category = 7) and uploadid not in (select uploadingid from score where scoringid='" + useid + "') and uploadid in (select uploadingid from score where scoringid in (select usrid from userinfo where belogntoteach='" + useid + "'and confirmed=0))";
            }

            else
                Response.Write("no users");
            SqlCommand seletive = new SqlCommand(select, con);
            SqlDataAdapter adap = new SqlDataAdapter(seletive);
            DataSet ds = new DataSet();
            adap.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
            if (ds.Tables[0].Rows.Count == 0)
            {
                Label1.Visible = true;
                Label1.Text = "there is no waiting score article.";
            }
            cs.writelog(" " + username + " has confirm the score ");
            con.Close();
        }
    }
    protected void GridViewCommandEventHandler(object sender, GridViewCommandEventArgs e)
    { }
    protected void ray2(object sender, EventArgs e)
    {
        Button btn = (Button)sender;
        int CommandArgument = Convert.ToInt16(btn.CommandArgument);
        Session["upid"] = CommandArgument;
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "update score set confirmed=1 where uploadingid='" + CommandArgument + "'";

        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        if (reader.Read())
        {
            Label1.Visible = true;
            Label1.Text = "successfully";
        }
        else
        {
            Label1.Visible = true;
            Label1.Text = "falusre";
        }
        con.Close();

        cs.writelog("" +username+" has confirm article" + CommandArgument + " " + DateTime.Now.ToString());
        Response.Redirect("about.aspx");

    }
        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }


        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
}