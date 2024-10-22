using MimeKit;


namespace SmtpClient
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var message = new MimeMessage();

			message.From.Add(MailboxAddress.Parse("from@sample.com"));


			message.To.Add(MailboxAddress.Parse($"to@sample.com"));


			message.Subject = "Hello";
			message.Body = new TextPart("plain")
			{
				Text = "Hello World"
			};

			var client = new MailKit.Net.Smtp.SmtpClient();

			client.Connect("localhost", 25, false);


			client.Authenticate("user1@ulaq.io", "password1");



			client.Send(message);


			client.Disconnect(true);

			//using (System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient("127.0.0.1", 587))
			//{




			//	MailMessage mail = new MailMessage();

			//	NetworkCredential basicAuthInfo = new NetworkCredential("user1@example.com", "password1");
			//	smtpClient.Credentials = basicAuthInfo;
			//	smtpClient.EnableSsl = false;
			//	smtpClient.UseDefaultCredentials = false;

			//	mail.Body = "Test Body";
			//	mail.Subject = "Test Subject";

			//	//standart değil
			//	mail.Headers.Add("MailId", Guid.NewGuid().ToString());


			//	mail.Attachments.Add(new Attachment(new MemoryStream(Encoding.UTF8.GetBytes("Ertugrul Kara Test Dosyası")), "DosyaTest.file", "application/pdf"));

			//	mail.From = new MailAddress("ertugrulkra@smtp.demo", "smtp.demo");
			//	mail.To.Add(new MailAddress("ertugrulkra@smtp.demo"));

			//	smtpClient.SendMailAsync(mail).GetAwaiter().GetResult();
			//	//smtpClient.Send(mail);
			//}
		}
	}
}
