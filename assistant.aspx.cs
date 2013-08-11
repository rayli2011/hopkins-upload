using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class assistant : System.Web.UI.Page
{
    public int uid;
    Class1 cs = new Class1();
    public string useid;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "score")
        {
            useid = Session["userid"].ToString();
            uid = Convert.ToInt16(e.CommandArgument);
            Session["uid"] = uid;
            Session["scoreing"] = useid;
            Response.Redirect("TA.aspx");
        }

    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        string  username= Session["name"].ToString();
      
        //Session["studentstatus"] = "1";

        Session["userid"] = uid;
        Session["name"] = username;
        cs.writelog(" " + username + " has submitt a new paper ");
        Response.Redirect("newload.aspx");
    }
}