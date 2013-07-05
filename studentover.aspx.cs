using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class studentover : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int sid;
        string name;
        sid = Convert.ToInt16(Session["userid"].ToString());
        name = Session["name"].ToString();
        Session["userid"] = sid;
        Session["name"] = name;
        Session["studentstates"] = "1";
    }
    protected void GridViewCommandEventHandler (object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "changed")
        {
            int rowIndex = Convert.ToInt32(e.CommandArgument);


            Response.Redirect("www.sina.com");
       
        }
    }


  
    protected void ray (object sender, EventArgs e)
    {
        Button btn = (Button)sender;

      

       int CommandArgument =Convert.ToInt16( btn.CommandArgument); 
        

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}