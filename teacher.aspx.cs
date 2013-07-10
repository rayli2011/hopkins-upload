using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class teacher : System.Web.UI.Page
{
    public int uid;
    public string useid;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
    {
        if (e.CommandName == "grademe")
        {
            useid = Session["userid"].ToString(); 
            uid = Convert.ToInt16(e.CommandArgument);
            Session["uid"] = uid;
            Session["scoreing"] = useid;
            Response.Redirect("Faculty.aspx");
        }

    }
}