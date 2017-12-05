using System.Net;
using System.Net.Mail;

namespace RingCentralDataIntegration
{
    class SmtpHandler
    {
        internal static void SendMessage(string subject, string body)
        {
            var email = new MailMessage("donotreply@springmobile.com", "david.kirschman@springmobile.com") //"reporting@springmobile.com"
            {
                Subject = subject,
                Body = body
            };

            using (var client = new SmtpClient())
            {
                client.Port = 25;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Host = "";
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("",
                    "");

                client.Send(email);
            }
        }
    }
}
