using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class TA : System.Web.UI.Page
{
    public string uid;
    Class1 cs = new Class1();

    protected void Page_Load(object sender, EventArgs e)
    {
          
          uid = Session["userid"].ToString();
          string name = Session["name"].ToString();
          SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
          con.Open();
          string select = "select title,abstract,filename,uploaddate,category,version,username,uploadpersonid, uploadid from uploadinfo,userinfo where uploadid= '" + Session["uid"].ToString()+ "'and usrid=uploadpersonid";
          SqlCommand seletive = new SqlCommand(select, con);
          SqlDataReader reader = seletive.ExecuteReader();
          if (reader.Read())
          {

              title.Text = reader[0].ToString();
              abs.Text = reader[1].ToString();
              uploader.Text = reader[6].ToString();
              date.Text = reader[3].ToString();
              Session["lerid"] = reader[7].ToString();
          }
          con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int score=0;

        for (int i = 0; i < RadioButtonList1.Items.Count; i++)
        {
            if (RadioButtonList1.Items[i].Selected == true)
            {
                score =Convert.ToInt16(RadioButtonList1.Items[i].Value);
            }

        }
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = " insert into score(uploadingid,uploaderid,scoringid,score,comments,scoredate) values('" + Session["uid"].ToString() + "','" + Session["lerid"].ToString() + "','" + Session["scoreing"].ToString() + "','" + score + "','" + TextBox2.Text + "','" + DateTime.Today + "') ";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        cs.writelog(Session["name"].ToString() + " grade article id " + Session["uid"].ToString());
        con.Close();
        Response.Redirect("about.aspx");
    }
}