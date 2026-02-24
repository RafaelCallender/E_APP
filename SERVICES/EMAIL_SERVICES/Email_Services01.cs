using E_APP.SERVICES.FILE_SERVICES.FILE_HELPER;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Reflection;
using System.Text;


namespace E_APP.SERVICES.EMAIL_SERVICES
{
    internal class Email_Services01
    {
        private static File_Helper01 File_H01 = new File_Helper01();

        public Email_Services01()
        {
            GetGmailService();
        }



        private GmailService GetGmailService()
        {
            string[] scopes = { GmailService.Scope.GmailSend };
            UserCredential credential;

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = File_H01.all_embedded_json_files().Trim();

            using var stream = assembly.GetManifestResourceStream(resourceName);
            if (stream == null)
                throw new FileNotFoundException($"Embedded resource not found: {resourceName}");

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.FromStream(stream).Secrets,
                scopes,
                "user",
                CancellationToken.None,
                new FileDataStore("gmail_token", true)
            ).Result;

            return new GmailService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "E_APP Gmail Automation"
            });
        }

        public string SendEmail(string emailAddress)
        {
            GmailService service = new GmailService();
            var message = CreateMessage(
                $"{emailAddress}",
                "Automated Gmail from C#",
                "<h2>Hello 👋</h2><p>This email was sent automatically.</p>");

            service.Users.Messages.Send(message, "me").Execute();
            return "email sent";
        }

        private Message CreateMessage(string to, string subject, string body)
        {
            string email =
                $"To: {to}\r\n" +
                $"Subject: {subject}\r\n" +
                "Content-Type: text/html; charset=utf-8\r\n\r\n" +
                body;

            return new Message
            {
                Raw = Convert.ToBase64String(Encoding.UTF8.GetBytes(email))
                    .Replace("+", "-")
                    .Replace("/", "_")
                    .Replace("=", "")
            };
        }

    }
}
