using DependencyInjectionLesson.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLesson.Services
{
    public interface IEmailSenderService
    {
        public Task SendEmail(EmailMessageDTO emailMessage);
    }
}
