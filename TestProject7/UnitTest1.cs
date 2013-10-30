namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        protected readonly MotoActions Moto = new MotoActions();

        protected readonly HouseActions House = new HouseActions();

        protected readonly UIMap UiMap = new UIMap();

        protected readonly DocumentsList Docs = new DocumentsList();

        protected readonly CustomerActions cust = new CustomerActions();

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void TestMethod1()
        {
            var originalpremium = "1234";
            House.RebrokeAlternativeRenew("cash");
            //House.EtamOk(true);
            //House.EtamYes();
            //House.ConfirmDocuments();
            //House.RetrieveResponse();
            //House.RebrokeAlternativeRenew1();
            //House.RenewalModuleClose();
            //Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            //House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse(originalpremium));
            //string premium = House.CheckPolicyPremium("cash");
            //House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalPremium: originalpremium));
            //House.RenewalCheckStatus("REW");
            //House.ClosePolicy();
        }
    }
}