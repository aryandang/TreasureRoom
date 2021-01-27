using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TreasureRoom.Services
{
    public class SendEmailService
    {
        public void SendEmail(string ToEmailAddress, string EmailFullName, string EmailRetrievePhoneNumber)
        {
            string fromEmailAddress = "treasureroomuk@gmail.com";
            string fromName = "Treasure Room UK";

            var fromAddress = new MailAddress(fromEmailAddress, fromName);
            var toAddress = new MailAddress(ToEmailAddress, EmailFullName);
            string subject = "Potential Owner Identified For The Lost " + " You Posted About";
            string body = "Dear " + EmailFullName  + "We are pleased to inform you that the " +
                          " you posted about on treasure room has been identified by an individual as theirs."
                           + "The details of this individual:"  + "Name: " +
                          EmailFullName + "Email Address: " + EmailRetrievePhoneNumber +
                          "Phone Number: "
                          + EmailRetrievePhoneNumber;

            SmtpClient smtpClient = new SmtpClient();
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                smtpClient.Send(message);
            }
        }
    }
}