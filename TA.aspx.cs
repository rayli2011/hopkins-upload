﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class TA : System.Web.UI.Page
{
    public string uid;

    protected void Page_Load(object sender, EventArgs e)
    {
          uid = Session["userid"].ToString();
          string name = Session["name"].ToString();
          SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
          con.Open();
          string select = "select title,abstract,filename,uploaddate,category,version,username,uploadpersonid, uploadid from uploadinfo,userinfo where uploadid= '" + Session["uid"].ToString()+ "'and usrid=uploadpersonid";
          SqlCommand seletive = new SqlCommand(select, con);
          SqlDataReader reader = seletive.ExecuteReader();
          if (reader.Read())
          {

              title.Text = reader[0].ToString();
              abs.Text = reader[1].ToString();
              uploader.Text = reader[6].ToString();
              date.Text = reader[3].ToString();
              Session["lerid"] = reader[7].ToString();
          }
          con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = " insert into score(uploadingid,uploaderid,scoringid,score,comments,scoredate) values('" + Session["uid"].ToString() + "','" + Session["lerid"].ToString() + "','" + Session["scoreing"].ToString() + "','" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTime.Today + "') ";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        con.Close();
        Response.Redirect("about.aspx");
    }
}