
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

            House.RebrokeAlternativeRenew1();
            House.RenewalModuleClose();
            House.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REW");
            //House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse(originalpremium));
            //string premium = House.CheckPolicyPremium("cash");
            //House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalPremium: originalpremium));
            House.ClosePolicy();
        }
    }
}
