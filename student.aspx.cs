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
    Class1 cs = new Class1();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        modify.Visible = false;
        userid = Convert.ToInt32(Session["userid"]);
        username = Session["name"].ToString();
        upid = Convert.ToInt32(Session["upid"]);
    
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        
        string select = "select AVG(score),count(score) from score where uploadingid='" + upid + "' and confirmed=1 ";
       
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader=seletive.ExecuteReader();
        //object result = seletive.ExecuteScalar();
        reader.Read();
        if (reader[0].Equals(DBNull.Value)) 
        {
            score.Text = "this article has not been grade yet, you can modify it or upload new file";
            modify.Visible = true;
        }
            //update the students, if no score can modify, if less than 3 people score,show processing.
        else if (Convert.ToInt16(reader[1]) ==1)
        {
            score.Text = "this article is been processing it will come soon for you score." +Convert.ToInt16(reader[1]);
        }
        else
            score.Text = reader[0].ToString();
        con.Close();
 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        //string select ="select * from uploadinfo where uploadpersonid='"+userid+"' and uploaddate in( select max(uploaddate) from uploadinfo where uploadpersonid='"+userid+"') " ;
        string select = "select * from uploadinfo where uploadid='" + Convert.ToInt32(Session["upid"])+"' ";
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
        cs.writelog(" " + username + " has modified his " +title+" version "+version);
        Response.Redirect("modify.aspx");


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["username"] = username;
        Session["userid"] = userid;
        //Session["studentstatus"] = "1";
        cs.writelog(" " + username + " has submitt a new paper " );
        Response.Redirect("newload.aspx");
    }
}
