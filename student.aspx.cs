using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class students : System.Web.UI.Page
{
    public String username;
    public int userid;
    public int version;
    public int upid;
    public String title;
    public String abs;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        modify.Visible = false;
        userid = Convert.ToInt32(Session["userid"]);
        username = Session["name"].ToString();
        upid = Convert.ToInt32(Session["upid"]);
    
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        
        string select = "select AVG(score) from score where uploadingid='" + upid + "' ";
       
        SqlCommand seletive = new SqlCommand(select, con);
       
        object result = seletive.ExecuteScalar();
        if (result.Equals(DBNull.Value)) 
        {
            score.Text = "this article has not been grade yet, you can modify it or upload new file";
            modify.Visible = true;
        }
        else
            score.Text = result.ToString();

        //if (reader.Read())
        //{
        //    version =Convert.ToInt16(reader[7]);
        //    upid = Convert.ToInt16(reader[0]);
        //    title = reader[1].ToString();
        //    abs = reader[2].ToString();
        //    //vs.Text = version.ToString();

        //}

        con.Close();
 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select ="select * from uploadinfo where uploadpersonid='"+userid+"' and uploaddate in( select max(uploaddate) from uploadinfo where uploadpersonid='"+userid+"') " ;
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        if (reader.Read())
        {
            version = Convert.ToInt16(reader[7]);
            upid = Convert.ToInt16(reader[0]);
            title = reader[1].ToString();
            abs = reader[2].ToString();
            //vs.Text = version.ToString();

        }
        Session["username"] = username;
        Session["userid"] = userid;
        //Session["studentstatus"] = "2";
        Session["uploadid"]=upid;
        Session["verson"] = version;
        Session["title"] = title;
        Session["abstract"] = abs;
        Response.Redirect("modify.aspx");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["username"] = username;
        Session["userid"] = userid;
        //Session["studentstatus"] = "1";
        Response.Redirect("newload.aspx");
    }
}
