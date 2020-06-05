using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace BlindJournalManagmentSystem.Services
{
    public class CustomEmailService
    {
        public void sendEmail(string senderEmail,string senderPassword,string receiverEmail,string subject,string body)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.Port = 25;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            MailMessage mailMessage = new MailMessage(senderEmail, receiverEmail);
            mailMessage.Subject = subject;
            mailMessage.Body = body;

            //smtpClient.Send(mailMessage);
        }
    }
}