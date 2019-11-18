using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DependencyInjectionLesson.Services
{
    public class SmsSenderService : ISmsSenderService
    {
        public Task SendSms(string phoneNumber)
        {
            const string accountSid = "AC3fbf63191267f4b50067a585825e4294";
            const string authToken = "4ade5aaa6abfc741eeb674bb70bd9ea5";

            TwilioClient.Init(accountSid, authToken);
            return MessageResource.CreateAsync(
                body: "Hello from Ruslan ;)",
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber(phoneNumber)
            );
        }
    }
}
