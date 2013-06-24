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
}