using E_APP.SERVICES.FILE_SERVICES.TEXT_FILES;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace E_APP.SERVICES.EMAIL_SERVICES
{
    internal class Email_Services02
    {
        private static Read_Textfiles Read_T01 = new Read_Textfiles();
        public bool send_email(string input,string input01,string input02,out string input03)
        {
            try
            {
                string fromEmail = Read_T01.admin_path01.Split("\n")[0].Trim();
                string appPassword = Read_T01.admin_path01.Split("\n")[3].Trim();

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(Read_T01.admin_path01.Split("\n")[0].Trim());
                mail.Subject = "Test";
                mail.Body = $"Email: {input}\n" +
                            $"Name: {input01}\n" +
                            $"Message:{input02}\n";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
                smtp.EnableSsl = true;

                smtp.Send(mail);
                input03 = "message sent";
                return true;            
            }
            catch(Exception ex)
            {
                input03 = ex.Message;   
                return false;       

            }
     
        }
    }
}
