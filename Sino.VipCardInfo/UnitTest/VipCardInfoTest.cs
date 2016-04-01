using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sino.Web.VipCardInfo;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class VipCardInfoTest
    {
        private IVipCardInfo VipCardInfo;

        [TestInitialize]
        public void Init()
        {
            VipCardInfo = new ApixVipCardInfo();
        }

        [Description("银行卡信息查询")]
        [TestMethod]
        public async Task TestMethod1()
        {
            var result = await VipCardInfo.QueryCardInfo("cd8afb38ec5c4a59507b7d5aa6713dfa", "6227001303530103472");
            Assert.AreEqual(result.Code, 0);
            Assert.AreEqual(result.Msg, "请求成功");
            Assert.IsNotNull(result.Data);
        }
    }
}
