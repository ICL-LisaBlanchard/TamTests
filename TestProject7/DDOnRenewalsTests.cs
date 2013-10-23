namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class DdOnRenewalsTests : BaseUiTest
    {
        private const string PolicyType = "Household";

        private const string RenewalPremium = "1232";

        [TestMethod]
        public void HouseAmendQuoteDirectDebit()
        {
            this.SetOurAnsvarRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeProposer();
            House.HomeAddressLookup("Red House", "Blue Square");
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("dd");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.CheckPolicyPremium("dd");
            House.CheckCorrectDocumentPresent(Docs.DocumentsForHhDirectDebit);

            string policyNumber = House.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium, "Ansvar Insurance");

            House.HomeAmendRisk();
            House.PublicCreditCheckOk();
            House.HomeAmendSelecPolicy(false);
            House.HomeAmendRenewFinish();
        }

        [TestMethod]
        public void MotoAmendQuoteDirectDebit()
        {
            SetOurZurichRegKeys();
            Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("dd");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            string originalPremium = Moto.CheckPolicyPremium("dd");
            Moto.OpenTransList(Transactions.GetTransactionDictionary(originalPremium, "dd"));
            Moto.CheckCorrectDocumentPresent(this.Docs.DocumentsForMotoNewBusinessQuoteDd);

            string policyNumber = Moto.GetPolicyNumber();
            Renewals(policyNumber, "Motor", RenewalPremium, "Zurich");
            Moto.MotoAmendRisk();
            Moto.PublicCreditCheckOk();
            Moto.CommonParams.SendHomeKeys = "{End}";
            Moto.AmendSelectQuote();
            Moto.MotoAmendRiskNew("dd");
            Moto.RetrieveResponse();
            Moto.MotoAmendRiskNew1();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();

            string premium = Moto.CheckPolicyPremium("dd");
            House.CheckCorrectDocumentPresent(this.Docs.DocumentsForMotoAmendRiskNew);
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "dd", originalPremium: originalPremium));
            Moto.ClosePolicy();
        }
    }
}
