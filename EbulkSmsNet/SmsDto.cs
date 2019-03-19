using Newtonsoft.Json;
using System.Collections.Generic;

namespace EbulkSmsNet
{
    public class EbulkSmsData
    {
        [JsonProperty("SMS")]
        public Sms Sms { get; set; }
    }

    public class Sms
    {
        [JsonProperty("auth")]
        public Auth Auth { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("recipients")]
        public Recipients Recipients { get; set; }
    }

    public class Auth
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("apikey")]
        public string Apikey { get; set; }
    }

    public class Message
    {
        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("messagetext")]
        public string Messagetext { get; set; }

        [JsonProperty("flash")]
        public string Flash { get; set; }
    }

    public class Recipients
    {
        [JsonProperty("gsm")]
        public List<Gsm> Gsm { get; set; }
    }

    public class Gsm
    {
        [JsonProperty("msidn")]
        public string Msidn { get; set; }

        [JsonProperty("msgid")]
        public string Msgid { get; set; }
    }


    public class SmsResponse
    {
        public SmsResponseData Response { get; set; }
    }

    public class SmsResponseData
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("totalsent")]
        public long Totalsent { get; set; }

        [JsonProperty("cost")]
        public long Cost { get; set; }
    }
}
