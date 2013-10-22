
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;

    [CodedUITest]
    public class UnitTest1
    {
        protected readonly MotoActions Moto = new MotoActions();
        protected readonly HouseActions House = new HouseActions();
        protected readonly UIMap UiMap = new UIMap();
        protected readonly DocumentsList Docs = new DocumentsList();

        [TestMethod]
        public void TestMethod1()
        {

            string premium = Moto.CheckPolicyPremium("cash");
            Moto.RenewalCheckStatus("REN");
          
        }
    }
}
