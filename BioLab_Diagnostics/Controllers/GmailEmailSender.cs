using System.Net;
using System.Net.Mail;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;

public class GmailEmailSender 
{
	private readonly IConfiguration _configuration;

	public GmailEmailSender(IConfiguration configuration)
	{
		_configuration = configuration;
	}

	public void SendMail(string email, string subject, string htmlMessage, Attachment attachment = null)
	{
		var smtpSettings = _configuration.GetSection("SmtpSettings");
		var fromEmail = smtpSettings["FromEmail"];
		var fromEmailPassword = smtpSettings["FromEmailPassword"];

		var smtpClient = new SmtpClient("smtp.gmail.com", 587)
		{
			EnableSsl = true,
			UseDefaultCredentials = false,
			Credentials = new NetworkCredential(fromEmail, fromEmailPassword)
		};

		var message = new MailMessage
		{
			From = new MailAddress(fromEmail),
			Subject = subject,
			Body = htmlMessage,
			IsBodyHtml = true
		};

		message.To.Add(new MailAddress(email));
		if (attachment != null)
		{
			message.Attachments.Add(attachment);
		}
		smtpClient.Send(message);
	}
}

