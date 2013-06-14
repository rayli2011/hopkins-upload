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
        sid = Convert.ToInt16(Session["userid"].ToString());
        Session["userid"] = sid;
        Session["studentstates"] = "1";
    }
}