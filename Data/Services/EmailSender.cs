
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace SA_Auction.Data.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "jeneeliya2@gmail.com";
            var pw = "gsds erno qjon hvng";

            var client = new SmtpClient("smtp.gmail.com", 587) // Corrected SMTP server
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)

            };
            // Creating the email message
            var mailMessage = new MailMessage
            {
                From = new MailAddress(mail),
                Subject = subject,
                Body = message,
                IsBodyHtml = true // Set to true if the email content includes HTML
            };
            mailMessage.To.Add(email);

            // Sending the email
            return client.SendMailAsync(mailMessage);

        }
    }
}
