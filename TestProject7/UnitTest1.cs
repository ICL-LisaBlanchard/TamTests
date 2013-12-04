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

Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium("cash");
            Moto.RenewalCheckStatus("REW");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoAmendRiskNew, "cash", originalPremium: double.Parse("0:00"));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  "0"));
            Moto.ClosePolicy();

            //mta1
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(5).ToString("dd/MM/yy"));
            Moto.AmendDateBeforeMessage();
            Moto.EtamOk(true);
            Moto.MTADate(DateTime.Now.AddDays(12).ToString("dd/MM/yy"));
            Moto.MotoFinishMTA();

            //mta2
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.EtamOk(true);
            Moto.MTACancel();
        }
    }
}