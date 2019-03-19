using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EbulkSmsNet
{
    public static class EbulkSmsClient
    {
        public static async Task<SmsResponse> SendMessageAsync(EbulkSmsAuth auth, string phoneNumber, string message)
        {
            using (var client = new HttpClient())
            {
                var payload = GetMessagePayload(auth, phoneNumber, message);
                client.BaseAddress = new Uri(SmsConstants.BaseUrl);

                var json = JsonConvert.SerializeObject(payload);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var result = await client.PostAsync("sendsms.json", content);
                string resultContent = await result.Content.ReadAsStringAsync();

                var response = JsonConvert.DeserializeObject<SmsResponse>(resultContent);

                return response;
            }

        }

        private static EbulkSmsData GetMessagePayload(EbulkSmsAuth auth, string phoneNumber, string message)
        {
            var payload = new EbulkSmsData
            {
                Sms = new Sms
                {
                    Auth = new Auth { Apikey = auth.ApiKey, Username = auth.UserName },
                    Message = new Message { Flash = "0", Messagetext = message, Sender = auth.Sender },
                    Recipients = new Recipients
                    {
                        Gsm = new List<Gsm>
                        {
                            new Gsm { Msgid = Guid.NewGuid().ToString(), Msidn = phoneNumber }
                        }
                    }
                }
            };

            return payload;
        }

    }
}
