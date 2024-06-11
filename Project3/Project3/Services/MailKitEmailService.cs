using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace Project3.Services
{
    public class MailKitEmailService : IEmailService
    {
        public async Task SendEmailAsync(string fromEmail, string toEmail, string subject, string body)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("", fromEmail));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;
            message.Body = new TextPart("html") { Text = body };

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587, false);
            await client.AuthenticateAsync("doanhainb123@gmail.com", "nzxu abwl lvqe oabi");
            await client.SendAsync(message);
            await client.DisconnectAsync(true);

        }

    }
}
