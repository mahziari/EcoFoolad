using System.Net;

namespace ParsaPoolad.Common.Services
{
    public static class SmsServices
    {
        public static void SmsSend(string phoneNumber, string template,
            string token, string token2 = null, string token3 = null,string message = null)
        {
            var key = "4C306252314F44645945786B4348526B31756F7159744B6754776C6B696F593870377A6B7A7441765762733D";
            var client = new WebClient();
            string url = $"http://panel.kavenegar.com/v1/{key}/verify/lookup.json?receptor={phoneNumber}&token={token}&token2={token2}&token3={token3}&template={template}";
            var content= client.DownloadString(url);
        }
    }
}