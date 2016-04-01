using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading.Tasks;

namespace Sino.Web.VipCardInfo
{
	/// <summary>
	/// 由Apix第三方支持
	/// </summary>
	public class ApixVipCardInfo : IVipCardInfo
    {
        public const string URL = "http://e.apix.cn/apixcredit/bankcardinfo/bankcardinfo?cardno={0}";

        public Task<CardInfo> QueryCardInfo(string key, string cardnum)
        {
            return Task<CardInfo>.Factory.StartNew(() =>
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key");

                if (String.IsNullOrEmpty(cardnum))
                    throw new ArgumentNullException("cardnum");

                var client = new RestClient(string.Format(URL, cardnum));
                var request = new RestRequest(Method.GET);
                request.AddHeader("apix-key", key);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("accept", "application/json");
                var response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<CardInfo>(response.Content);
                return result;
            });
        }
    }
}
