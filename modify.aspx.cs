using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

public partial class modify : System.Web.UI.Page
{
    public int uploadid;
    public int version;
    string filename;
    public string url;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack) 
        {
        uploadid = Convert.ToInt16(Session["uploadid"]);
        //version should +1 as updated!
        version = Convert.ToInt16(Session["verson"])+1;

        TextBox1.Text = Session["title"].ToString();
        t2.Value= Session["abstract"].ToString();
        }

        if (FileUpload1.HasFile)
        {
            filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath(".\\Upload\\") + filename);
            url = "~/Upload/" + filename;


        }


    }
    protected void UploadButton_Click(object sender, EventArgs e)
    {
        int pid =Convert.ToInt16( Session["upid"]);
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "update uploadinfo set title='" + TextBox1.Text + "',abstract='" + t2.Value + "',filename='" + filename + "',uploaddate='" + DateTime.Today + "',url='" + url + "',version ='" + version + "' where uploadid='"+pid+"'";

        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        if (reader.Read())
        {
            Label1.Text = "successfully";
        }
        else
            Label1.Text = "falusre";
        con.Close();

        Response.Redirect("about.aspx");

    }
}