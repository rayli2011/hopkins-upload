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
        
        uploadid = Convert.ToInt16(Session["uploadid"]);
        version = Convert.ToInt16(Session["verson"]);

        TextBox1.Text = Session["title"].ToString();
        t2.Value= Session["abstract"].ToString();
        if (FileUpload1.HasFile)
        {
            filename = Path.GetFileName(FileUpload1.FileName);
            FileUpload1.SaveAs(Server.MapPath(".\\Upload\\") + filename);
            url = "~/Upload/" + filename;


        }

        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "update uploadinfo set (title,abstract,filename,uploaddate,url,version)values('" + TextBox1.Text + "','" + t2.Value + "','" + filename + "','" + DateTime.Today + "','" +  url + "','" + version + "')";

        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        con.Close();
    }
}