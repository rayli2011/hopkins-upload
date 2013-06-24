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
        userid = Convert.ToInt32(Session["userid"]);
        username = Session["name"].ToString();
    
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select ="select * from uploadinfo where uploadpersonid='"+userid+"' and uploaddate in( select max(uploaddate) from uploadinfo where uploadpersonid='"+userid+"') " ;
       
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        if (reader.Read())
        {
            version =Convert.ToInt16(reader[7]);
            upid = Convert.ToInt16(reader[0]);
            title = reader[1].ToString();
            abs = reader[2].ToString();


        }

        con.Close();
 
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

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
