using System;
using System.Net.Mail;

namespace TreasureRoom.Services
{
    public class SendEmailService
    {
        public void SendEmail(string ToEmailAddress, string EmailFullName, string EmailItemType, string EmailRetrieveFullName, string EmailRetrieveEmailAddress, string EmailRetrievePhoneNumber,
                                string EmailQuestion1, string EmailAnswer1, string EmailQuestion2, string EmailAnswer2, string EmailQuestion3, string EmailAnswer3)
        {
            string fromEmailAddress = "treasureroomuk@gmail.com";
            string fromName = "Treasure Room UK";
            string body = null;

            var fromAddress = new MailAddress(fromEmailAddress, fromName);
            var toAddress = new MailAddress(ToEmailAddress, EmailFullName);
            string subject = "Potential Owner Identified For The Lost " + EmailItemType + " You Posted About";
            if (EmailQuestion3 != null)
            {
                body = "Dear " + EmailFullName + "," + Environment.NewLine + Environment.NewLine +
                              "We are pleased to inform you that the " +
                              EmailItemType.ToLower() +
                              " you posted about on treasure room has been identified by an individual as theirs."
                              + Environment.NewLine + Environment.NewLine +
                              "This individual has answered the security questions with the following answers: "
                              + Environment.NewLine + "Question 1: " + EmailQuestion1 + Environment.NewLine +
                              "Their answer:" + EmailAnswer1 + Environment.NewLine +
                              "Question 2: " + EmailQuestion2 + Environment.NewLine + "Their answer: " + EmailAnswer2 +
                              Environment.NewLine + "Question 3: " +
                              EmailQuestion3 + Environment.NewLine + "Their answer: " + EmailAnswer3 + Environment.NewLine +
                              Environment.NewLine +
                              "Based on their answers, if you think the lost " + EmailItemType.ToLower() +
                              " you possess is theirs, please contact them." + Environment.NewLine + Environment.NewLine +
                              "The details of this individual:" + Environment.NewLine + "Name: " +
                              EmailRetrieveFullName
                              + Environment.NewLine + "Email Address: " + EmailRetrieveEmailAddress + Environment.NewLine +
                              "Phone Number: "
                              + EmailRetrievePhoneNumber + Environment.NewLine + Environment.NewLine +
                              "Thank you for using Treasure Room UK" + Environment.NewLine
                              + "A UK based lost & search platform";
            }
            else
            {
                body = "Dear " + EmailFullName + "," + Environment.NewLine + Environment.NewLine +
                              "We are pleased to inform you that the " +
                              EmailItemType.ToLower() +
                              " you posted about on treasure room has been identified by an individual as theirs."
                              + Environment.NewLine + Environment.NewLine +
                             "This individual has answered the security questions with the following answers: "
                              + Environment.NewLine + "Question 1: " + EmailQuestion1 + Environment.NewLine +
                              "Their answer:" + EmailAnswer1 + Environment.NewLine +
                              "Question 2: " + EmailQuestion2 + Environment.NewLine + "Their answer: " + EmailAnswer2 +
                              Environment.NewLine +
                              Environment.NewLine +
                              "Based on their answers, if you think the lost " + EmailItemType.ToLower() +
                              " you possess is theirs, please contact them." + Environment.NewLine + Environment.NewLine +
                              "The details of this individual:" + Environment.NewLine + "Name: " +
                              EmailRetrieveFullName
                              + Environment.NewLine + "Email Address: " + EmailRetrieveEmailAddress + Environment.NewLine +
                              "Phone Number: "
                              + EmailRetrievePhoneNumber + Environment.NewLine + Environment.NewLine +
                              "Thank you for using Treasure Room UK" + Environment.NewLine
                              + "A UK based lost & search platform";
            }

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

        public void SendConfirmationEmail(string ToEmailAddress, string EmailFullName, string EmailItemType, string EmailEditKey)
        {
            string fromEmailAddress = "treasureroomuk@gmail.com";
            string fromName = "Treasure Room UK";
            string body = null;
            string EditOrDeleteLink = "http://treasureroom.web.local/edit-or-delete-post";

            var fromAddress = new MailAddress(fromEmailAddress, fromName);
            var toAddress = new MailAddress(ToEmailAddress, EmailFullName);
            string subject = "Confirmation Of Success Post About A Lost " + EmailItemType;

            body = "Dear " + EmailFullName + "," + Environment.NewLine + Environment.NewLine +
                   "We are pleased to inform you that the your recent post about a lost " +
                   EmailItemType.ToLower() + "has been posted!"
                   + Environment.NewLine + Environment.NewLine +
                   "In case you would like to edit the post or delete it from Treasure Room, please use the key below at " + EditOrDeleteLink + ":" + Environment.NewLine
                   + Environment.NewLine + EmailEditKey +
                   Environment.NewLine + Environment.NewLine +
                   "Thank you for using Treasure Room UK" + Environment.NewLine
                   + "A UK based lost & search platform";

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