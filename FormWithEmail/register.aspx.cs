using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormWithEmail
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string message = txtMessage.Text;

            // Call the method to send the email
            SendEmail(name, email, message);
        }
        private void SendEmail(string name, string email, string message)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, // Use 465 for SSL or 587 for TLS
                    Credentials = new NetworkCredential("deepakmaurya0590@gmail.com", "newucqasbiqgnvqt"),
                    EnableSsl = true, // Enable SSL or TLS
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("deepakmaurya0590@gmail.com"),
                    Subject = "Form Submission",
                    Body = $"Name: {name}<br/>Email: {email}<br/>Message: {message}",
                    IsBodyHtml = true,
                };
                mailMessage.To.Add("satyaprakash9919346535@gmail.com");

                //MailMessage mailMessage = new MailMessage();
                //mailMessage.From = new MailAddress("satyaprakash9919346535@gmail.com","Satya TMT");
                //mailMessage.To.Add("aksa.trainglemind@gmail.com");
                //mailMessage.Subject = "Form Submission";
                //mailMessage.Body = $"Name: {name}<br/>Email: {email}<br/>Message: {message}";
                //mailMessage.IsBodyHtml = true;

                //SmtpClient smtpClient = new SmtpClient("satyaprakash9919346535@gmail.com", 587);
                //smtpClient.Credentials = new NetworkCredential("satyaprakash9919346535@gmail.com", "");
                //smtpClient.EnableSsl = true;

                // Send the email
                smtpClient.Send(mailMessage);   
                Response.Write("Email sent successfully.");
            }
            catch (Exception ex)
            {
                // Handle any errors
                Response.Write("Error sending email: " + ex.Message);
            }
        }
    }
}
