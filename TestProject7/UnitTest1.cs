namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Diagnostics;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1 
    {
        protected readonly MotoActions Moto = new MotoActions();

        protected readonly HouseActions House = new HouseActions();

        protected readonly UIMap UiMap = new UIMap();

        protected readonly DocumentsList Docs = new DocumentsList();

        protected readonly CustomerActions cust = new CustomerActions();

        protected readonly Documents d = new Documents();

        [TestMethod]
        public void TestMethod1()
        {
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse("296.29"));
        }
    }
}