using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionLesson.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Mail;
using Twilio.Rest.Api.V2010.Account;
using Twilio;
using DependencyInjectionLesson.Services;

namespace DependencyInjectionLesson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        public IEntitySaverService Service { get; set; }

        [HttpPost]
        public async Task<IActionResult> SaveEntity(EntityDTO entity)
        {
            //var entitySaver = new EntitySaverService();
            //await entitySaver.SaveEntity(entity);

            await Service.SaveEntity(entity);

            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> SendEmail(EmailMessageDTO emailMessage)
        {
            var emailService = new EmailSenderService();
            await emailService.SendEmail(emailMessage);
            return Ok();
        }
        [HttpGet("{phoneNumber}")]
        public async Task<IActionResult> GetCodeVerification(string phoneNumber)
        {
            var smsService = new SmsSenderService();
            await smsService.SendSms(phoneNumber);
            return Ok();
        }
    } 
}