using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestExample.Services;

namespace TestExample.MyModels
{
    public static class MailSender
    {
       

        public static void Sender(string Server, int Port, string Username, string Password,string toMail,string subject,string text)
        {
            
            var message = new  MimeMessage();
            message.From.Add(new MailboxAddress(Username));
            message.To.Add(new MailboxAddress(toMail));
            message.Subject = subject;
            message.Body = new TextPart("html")
            {
                Text = text
            };
            using (var client = new SmtpClient())
            {
                client.Connect(Server, Port,false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate(Username, Password);
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
