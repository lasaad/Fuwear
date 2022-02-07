using Fuwear.WebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fuwear.WebApi.Services
{
    public class EmailService : IEmailService
    {
        public EmailService()
        {

        }
        public string MailDest { get; set; }
        public string MailCC { get; set; }
        public string MailCCi { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string SendMessage()
        {
            return "Email envoyé";
        }
    }
}
