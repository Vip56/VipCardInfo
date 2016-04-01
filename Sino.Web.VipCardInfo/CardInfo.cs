using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Web.VipCardInfo
{
    /// <summary>
    /// 卡信息
    /// </summary>
    public class CardInfo
    {
        /// <summary>
        /// 状态码（0表示请求成功，其他表示查询失败）
        /// </summary>
        [DeserializeAs(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// 对应code的信息
        /// </summary>
        [DeserializeAs(Name = "msg")]
        public string Msg { get; set; }

        /// <summary>
        /// Luhn校验值
        /// </summary>
        [DeserializeAs(Name = "isLuhn")]
        public bool IsLuhn { get; set; }

        /// <summary>
        /// 卡主体信息
        /// </summary>
        [DeserializeAs(Name = "data")]
        public CardInfoBody Data { get; set; }


    }

    /// <summary>
    /// 卡信息主体
    /// </summary>
    public class CardInfoBody
    {
        /// <summary>
        /// 卡种
        /// </summary>
        [DeserializeAs(Name = "cardtype")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡片类型
        /// </summary>
        [DeserializeAs(Name = "cardname")]
        public string CardName { get; set; }

        /// <summary>
        /// 开户银行名称
        /// </summary>
        [DeserializeAs(Name = "bankname")]
        public string BankName { get; set; }
        
        /// <summary>
        /// 保留（开户行编码）
        /// </summary>
        [DeserializeAs(Name = "banknum")]
        public string BankNum { get; set; }

        /// <summary>
        /// 开户省份
        /// </summary>
        [DeserializeAs(Name = "province")]
        public string Province { get; set; }

        /// <summary>
        /// 开户城市
        /// </summary>
        [DeserializeAs(Name = "city")]
        public string City { get; set; }

        /// <summary>
        /// 银行客服电话
        /// </summary>
        [DeserializeAs(Name = "servicephone")]
        public string ServicePhone { get; set; }
       
        /// <summary>
        /// 银行官网
        /// </summary>
        [DeserializeAs(Name = "bankurl")]
        public string BankUrl { get; set; }
        
        /// <summary>
        /// 卡的前缀（银行卡bin号）
        /// </summary>
        [DeserializeAs(Name = "cardprefixnum")]
        public string CardPreFixNum { get; set; }

        /// <summary>
        /// 银行小Logo
        /// </summary>
        [DeserializeAs(Name = "logourl")]
        public string LogoUrl { get; set; }

    }

}
