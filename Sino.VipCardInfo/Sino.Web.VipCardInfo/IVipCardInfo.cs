using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sino.Web.VipCardInfo
{
    public interface IVipCardInfo
    {
        /// <summary>
        /// 查询卡信息
        /// </summary>
        /// <param name="key">密钥</param>
        /// <param name="cardnum">卡号</param>
        Task<CardInfo> QueryCardInfo(string key, string cardnum);
    }
}
