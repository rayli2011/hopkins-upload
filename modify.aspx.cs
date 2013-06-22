using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class modify : System.Web.UI.Page
{
    public int uploadid;
    public int version;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        uploadid = Convert.ToInt16(Session["uploadid"]);
        version = Convert.ToInt16(Session["verson"]);
       
        
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = "select * from uploadinfo where uploadid='" + uploadid + "' and version='" + version + "') ";

        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();
        if (reader.Read())
        {
  

        }

        con.Close();
    }
}