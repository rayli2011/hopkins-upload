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
        //Session["ves"]=
        //Session["studentstates"] = "1";
    }
    protected void GridViewCommandEventHandler (object sender, GridViewCommandEventArgs e)
    {

    }


  
    protected void ray (object sender, EventArgs e)
    {
       Button btn = (Button)sender;
       int CommandArgument =Convert.ToInt16( btn.CommandArgument);
       Session["upid"] = CommandArgument;
       Response.Redirect("student.aspx");

    }
    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}