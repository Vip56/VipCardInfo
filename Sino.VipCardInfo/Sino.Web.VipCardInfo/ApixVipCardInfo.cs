using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Web.VipCardInfo
{
    /// <summary>
    /// 由Apix第三方支持
    /// </summary>
    public class ApixVipCardInfo : IVipCardInfo
    {
        public const string URL = "http://a.apix.cn/datatiny/vipcardinfo/?cardnum={0}";

        public Task<CardInfo> QueryCardInfo(string key, string cardnum)
        {
            return Task<CardInfo>.Factory.StartNew(() =>
            {
                if (String.IsNullOrEmpty(key))
                    throw new ArgumentNullException("key");

                if (String.IsNullOrEmpty(cardnum))
                    throw new ArgumentNullException("cardnum");

                var client = new RestClient(String.Format(URL, cardnum));
                var request = new RestRequest(Method.GET);
                request.AddHeader("apix-key", key);

                var result = client.Execute<CardInfo>(request);
                return result.Data;
            });
        }
    }
}
