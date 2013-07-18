using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

public partial class Faculty : System.Web.UI.Page
{
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        id = Convert.ToInt16(Session["uid"]);

         
            SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
            con.Open();
            string select = "select title,abstract,filename,uploaddate,category,version,username,uploadpersonid from uploadinfo,userinfo where uploadid= '" + id + "'and usrid=uploadpersonid";
            SqlCommand seletive = new SqlCommand(select, con);
            SqlDataReader reader = seletive.ExecuteReader();
            if (reader.Read())
            {

                title.Text = reader[0].ToString();
                at.Text = reader[1].ToString();
                uploader.Text = reader[6].ToString();
                times.Text = reader[3].ToString();
                Session["lerid"] = reader[7].ToString();
            }
            con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = " insert into score(uploadingid,uploaderid,scoringid,score,comments,scoredate) values('" + id + "','" + Session["lerid"].ToString() + "','" + Session["scoreing"].ToString() + "','" + score.Text + "','" + comments.Text + "','" + DateTime.Today + "') ";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        con.Close();
        Response.Redirect("about.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SendEmail(tinfo.Text, body.Text, "rayli2011@gmail.com","rayli2011", "towson123", "smtp.gmail.com");
        SqlConnection con = new SqlConnection("Data Source=FENG-PC;Initial Catalog= files;Trusted_Connection=True");
        con.Open();
        string select = " insert into assign(assignfromid,assignto,assigndate,uploadid) values('" + Convert.ToInt16(Session["scoreing"]) + "', '" + email.Text + "','" + DateTime.Today + "','" + id+"') ";
        SqlCommand seletive = new SqlCommand(select, con);
        SqlDataReader reader = seletive.ExecuteReader();

        con.Close();
        Response.Redirect("about.aspx");

    }

    public void SendEmail(string mailSubject, string mailBody, string users, string username, string password,string host)
    {
        try
        {

            MailAddress ma= new MailAddress(users,"ray");
      
          
            //Preparing the mailMessage
            MailMessage mail = new MailMessage();
            mail.Subject = mailSubject;
            mail.From = ma;
            mail.To.Add(email.Text);
            mail.Body = mailBody+"please login to score those articles";
            mail.IsBodyHtml = true;

            //Preparing the smtp client to send the mailMessage 

            SmtpClient smtp = new SmtpClient(host);

            smtp.Credentials = new System.Net.NetworkCredential
                 (username, password);
            smtp.EnableSsl = true;
            smtp.Port = 587;

            //Sending message using smtp client 
            smtp.Send(mail);
            Label1.Text="Your Message has been sent successfully";
        }
        catch (Exception ex)
        {
            Label1.Text="Message Delivery Fails"+ex.Message;

        }
    }

}