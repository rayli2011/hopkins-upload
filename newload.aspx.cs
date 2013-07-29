using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

public partial class TA : System.Web.UI.Page
{
    
    string filename;
    public int state ;
    public int uid;
    string url;
    public string username;
    public int version;

    protected void Page_Load(object sender, EventArgs e)
    {
        //state = Convert.ToInt16(Session["studentstates"].ToString());
        uid = Convert.ToInt16(Session["userid"].ToString());
        username = (Session["name"].ToString());
        DropDownList1.Visible = true;
    }
    protected void UploadButton_Click(object sender, EventArgs e)
    {  
       
        string selective;
        int uploadid = Convert.ToInt32(Session["userid"].ToString());
      
       
            filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath(".\\Upload\\") + filename);
            url = "~/Upload/" + filename;

            
       
        string select1 = "insert into uploadinfo (uploadpersonid,title,abstract,filename,uploaddate,category,url,version)values('" + uploadid + "','" + title.Text + "','" + T1.Value + "','" + filename + "','" + DateTime.Today + "','" + DropDownList1.SelectedValue + "','" + url + "','" + version + "')";

            selective = select1;
            version = 1;
    

        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
       
        SqlCommand seletive = new SqlCommand(selective, con);
        SqlDataReader reader = seletive.ExecuteReader();
        con.Close();
        Session["name"] = username;
        Response.Redirect("about.aspx");
    }
}