using System;
using System.Net;
using System.Net.Mail;

namespace dotnetcore_SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            sendEmail();
        }

        public static void sendEmail()
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("varun.poosala595@gmail.com");
                message.To.Add(new MailAddress("archer.murali@gmail.com"));
                message.Subject = "Sample mail";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "<html><body><h2>Welcome to my world</h2></body></html>";
                smtp.Port = 465;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("varun.poosala595@gmail.com", "Ggku2sys24");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                Console.WriteLine("successfully sent");
            }
            catch (Exception ex)
            {
                 Console.WriteLine("Failed" + ex);
            }
        }

    }
}
