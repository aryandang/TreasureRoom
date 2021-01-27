using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TreasureRoom.Services
{
    public class SendEmailService
    {
        public void SendEmail(string ToEmailAddress, string EmailFullName, string EmailItemType, string EmailRetrieveFullName, string EmailRetrieveEmailAddress, string EmailRetrievePhoneNumber,
                                string EmailQuestion1, string EmailAnswer1, string EmailQuestion2, string EmailAnswer2, string EmailQuestion3, string EmailAnswer3)
        {
            string fromEmailAddress = "treasureroomuk@gmail.com";
            string fromName = "Treasure Room UK";

            var fromAddress = new MailAddress(fromEmailAddress, fromName);
            var toAddress = new MailAddress(ToEmailAddress, EmailFullName);
            string subject = "Potential Owner Identified For The Lost " + EmailItemType + " You Posted About";
            string body = "Dear " + EmailFullName + Environment.NewLine + "We are pleased to inform you that the " +
                          EmailItemType +
                          " you posted about on treasure room has been identified by an individual as theirs."
                          + Environment.NewLine + "The details of this individual:" + Environment.NewLine + "Name: " +
                          EmailRetrieveFullName
                          + Environment.NewLine + "Email Address: " + EmailRetrieveEmailAddress + Environment.NewLine +
                          "Phone Number: "
                          + EmailRetrievePhoneNumber + Environment.NewLine + Environment.NewLine;
            SmtpClient smtpClient = new SmtpClient();
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                message.IsBodyHtml = false;
                smtpClient.Send(message);
            }
        }
    }
}