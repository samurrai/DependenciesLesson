using DependencyInjectionLesson.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public class EmailSenderService
    {
        public Task SendEmail(EmailMessageDTO emailMessage)
        {
            using (SmtpClient client = new SmtpClient("smtp.mail.ru", 457))
            {
                return client.SendMailAsync("admin@mail.ru", emailMessage.To, emailMessage.Title, emailMessage.Text);
            }
        }
    }
}
