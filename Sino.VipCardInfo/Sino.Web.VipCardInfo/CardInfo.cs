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
        /// 状态码（1表示正常,-1表示输入有误,0表示没有卡号信息）
        /// </summary>
        [DeserializeAs(Name = "status")]
        public int Status { get; set; }

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
        /// 银行卡类型
        /// </summary>
        [DeserializeAs(Name = "cardtype")]
        public string CardType { get; set; }

        /// <summary>
        /// 卡号长度
        /// </summary>
        [DeserializeAs(Name = "cardlength")]
        public int CardLength { get; set; }

        /// <summary>
        /// 卡的前缀
        /// </summary>
        [DeserializeAs(Name = "cardprefixnum")]
        public string CardPreFixNum { get; set; }

        /// <summary>
        /// 卡的名称
        /// </summary>
        [DeserializeAs(Name = "cardname")]
        public string CardName { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [DeserializeAs(Name = "bankname")]
        public string BankName { get; set; }

        /// <summary>
        /// 参考开卡区域
        /// </summary>
        [DeserializeAs(Name = "areainfo")]
        public List<string> AreaInfo { get; set; }

        /// <summary>
        /// 银行信息
        /// </summary>
        [DeserializeAs(Name = "bankinfo")]
        public List<BankInfo> BankInfo { get; set; }

        /// <summary>
        /// Luhn校验值
        /// </summary>
        [DeserializeAs(Name = "isLuhn")]
        public bool IsLuhn { get; set; }

        /// <summary>
        /// 保留
        /// </summary>
        [DeserializeAs(Name = "banknum")]
        public string BankNum { get; set; }
    }

    /// <summary>
    /// 银行信息
    /// </summary>
    public class BankInfo
    {
        /// <summary>
        /// 银行客服电话
        /// </summary>
        [DeserializeAs(Name = "servicephone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 银行小Logo
        /// </summary>
        [DeserializeAs(Name = "logourl")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [DeserializeAs(Name = "bankname")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行官网
        /// </summary>
        [DeserializeAs(Name = "bankurl")]
        public string BankUrl { get; set; }
    }
}
