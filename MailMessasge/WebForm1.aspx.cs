using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailMessasge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage mail = new MailMessage();
                mail.To.Add("SHUBHPR2000@GMAIL.COM,shubhamsharma3k@gmail.com");
                mail.From = new MailAddress("shubhpr2000@gmail.com");
                mail.Subject = "HCL Offer Letter";

                string emailBody = "";

                emailBody += "<p>Hi Shubham,</p>";
                emailBody += "<p>i am programmer</p>";


                mail.Body = emailBody;
                mail.IsBodyHtml = true;

                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com";
                smtp.Credentials = new System.Net.NetworkCredential("shubhpr2000@gmail.com", "bfeliwlsfehxnska");
                smtp.Send(mail);              
            }
            catch(Exception ex)
            {
                Label1.Text = ex.Message;         
            }


        }
    }
}