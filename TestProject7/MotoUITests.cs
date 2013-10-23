namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class MotoUiTests : BaseUiTest
    {
        private const string PolicyType = "Motor";

        private const string RenewalPremium = "1357";

        [TestMethod]
        public void MotoCreateQuote()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            string premium = Moto.CheckPolicyPremium("cash");
            Moto.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash"));
            Moto.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoNewBusinessQuote, "cash");
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SaveWithoutPremium();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            //check premium
            Moto.HighlightBillingScreen();
            Moto.AssertQuoteCostIsZero();
            Moto.CancelBillingScreen();
            Moto.SelectMenu();
            Moto.ClickOkButton();
            Moto.AssertCarDetailsCorrect();
            Moto.Calculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.SelectPolicyQuote();
            Moto.ExitEnabled();
            Moto.Exit1();

            //check premium
            Moto.HighlightBillingScreen();
            Moto.AssertMethod1();
            Moto.CancelBillingScreen();
            Moto.SelectMenu();
            Moto.ClickOkButton();
            Moto.AssertCarDetailsCorrect();
            Moto.Calculate();

            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.SelectPolicyQuote();
            Moto.PrintQuote();
            Moto.CheckAutoPrint();
            Moto.DemandsAndNeeds();
            Playback.Wait(3000);
            Moto.CloseDemands();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            const string Premium = "17777.00";
            Moto.MotoAwap(Premium);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            Moto.MotoCheckAWAPpremium(Premium);
            Moto.OpenTransList(Transactions.GetTransactionDictionary(Premium, "cash"));
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            const string OverridePremiumGross = "3393.06";
            const string OverridePremiumNet = "3201.00";
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.ChangePremium(OverridePremiumGross);
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            Moto.MotoCheckChangedPremium(OverridePremiumNet);

            Moto.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoOverridePremium, "cash", double.Parse(OverridePremiumNet));
            Moto.OpenTransList(Transactions.GetTransactionDictionary(OverridePremiumNet, "cash"));
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.MotoCopyFinishedRisk();
            Moto.MotoCopyCheckProposer();
            Moto.MotoCopyRiskProposerOk();
            Moto.MotoCopyCheckCar();
            Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoCopyRiskQte()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SaveWithoutPremium();
            Moto.MotoCopyFinishedRisk();
            Moto.MotoCopyCheckProposer();
            Moto.MotoCopyRiskProposerOk();
            Moto.MotoCopyCheckCar();
            Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAExit()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.MotoMTA();
            Moto.MotoMTANoSave();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CreateMTA();
            Moto.MotoMTAOpenQuote();
            Moto.MotoMTACheckNewValue(false);
            Moto.CheckCorrectNumberTrans(2);
            Moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CreateMTA();
            Moto.CreateMTA();
            Moto.MotoCopyFinishedRisk();
            Moto.MotoCopyCheckProposer();
            Moto.MotoCopyRiskProposerOk();
            Moto.MotoMTACheckCar();
            Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAtoMTA()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.MotoMTA();
            Moto.MotoMTAParams.CostOfVehicle = "2500";
            Moto.MotoMTAAccept();
            Moto.MtaEffectiveDate("13/10/12");
            Moto.MotoMTAConfirmDate();
            Moto.CoverDateBackCheck();
            Moto.EtamOk();
            string coverDate = "MotoMTAtoMTA_" + Moto.MtaEffectiveDate();
            Moto.MotoMTAConfirmDate();
            Moto.MotoMTAConfirmPolicy("mta");
            Playback.Wait(5000);
            Moto.MotoMTAOpenQuote();

            Moto.MotoMTACheckNewValueExpectedValues.UIItemEditText = "2500";
            Moto.MotoMTACheckNewValue(true, coverDate);
            Moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCancelExit()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.MotoCloseDetails();
            //Cancel policy
            Moto.MotoMTA();
            Moto.MotoCancelPolicy();
            Moto.MtaEffectiveDate();
            Moto.MotoCancelPolicy1();
            Moto.MotoCancelExit();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            Moto.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoCancelAccept()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.CreateNewBusinessPolicy(ExpectedAddress);
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.CheckPolicyPremium("cash");
            Moto.MotoCloseDetails();
            Moto.MotoMTA();
            Moto.MotoCancelPolicy();
            Moto.MtaEffectiveDate();
            Moto.MotoCancelPolicy1();
            Moto.MotoMTAConfirmPolicy("cancel");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            Moto.MotoCheckPolicyStatus();
            Moto.CheckCorrectNumberTrans(2);
            Moto.CheckCorrectDocumentPresent(Docs.DocumentsForMotoNewBusinessCancelAccept);
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            string originalPremium = Moto.CheckPolicyPremium("cash");
            string policyNumber = Moto.GetPolicyNumber();

            this.SiteForRenewal(policyNumber, PolicyType, RenewalPremium);
            RegressApp(PolicyType);
            RenewalLoader();
            RenewalModule(UiMap.CustomerCode, PolicyType);
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.RenewalCheckStatus("REN");
            string premium = Moto.CheckPolicyPremium("cash");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRenewalBefore, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalPremium));
            Moto.ClosePolicy();

            //mta1
            Moto.SelectMenu();
            Moto.MotoMTABefore();
            Moto.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            Moto.MotoMTABeforeAccept();
            Moto.MotoMTAMessageCancelled();
            Moto.MotoMTABeforeFinish();

            //mta2
            Moto.SelectMenu();
            Moto.MotoMTABefore2();
            Moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.EtamOk();
            Moto.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.EtamOk();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();

            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            //moto.CancelFilter();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.RenewalCheckStatus("REN");
            Moto.ClosePolicy();
            ////MTA1
            Moto.SelectMenu();
            Moto.RenewalAfterMTA1();
            Moto.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            Moto.MotoFinishMTA();
            //MTA2
            Moto.SelectMenu();
            Moto.RenewalAfterMTA1();
            Moto.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.EtamOk();
            Moto.MTACancel();
            //MTA3
            Moto.SelectMenu();
            Moto.MotoMTABefore();
            Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.EtamOk();

            Moto.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            Moto.MotoMTABeforeAccept();
            Moto.MotoMTABeforeFinish();
            //mta4
            Moto.SelectMenu();
            Moto.MotoMTABefore2();

            Moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.EtamOk();

            Moto.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.EtamOk();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium("cash");

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoAmendRisk();
            Moto.PublicCreditCheckOk();
            Moto.QuoteSelectListCancel();
            Moto.AmendSelectQuote();
            Moto.MotoAmendRiskRenew();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium("cash");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoMotoAmendRiskExistingScheme, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  originalPremium));
            Moto.RenewalCheckStatus("REN");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium("cash");

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoAmendRisk();
            Moto.PublicCreditCheckOk();
            Moto.CommonParams.SendHomeKeys = "{End}";
            Moto.AmendSelectQuote();
            Moto.MotoAmendRiskNew("cash");
            Moto.RetrieveResponse();
            Moto.MotoAmendRiskNew1();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium("cash");
            Moto.RenewalCheckStatus("REW");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoAmendRiskNew, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  originalPremium));
            Moto.ClosePolicy();

            //mta1
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(5).ToString("dd/MM/yy"));
            Moto.AmendDateBeforeMessage();
            Moto.EtamOk();
            Moto.MTADate(DateTime.Now.AddDays(12).ToString("dd/MM/yy"));
            Moto.MotoFinishMTA();

            //mta2
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.EtamOk();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium("cash");

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeCurrent(false);
            RenewalsInvite(true);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string premium = Moto.CheckPolicyPremium("cash");
            Moto.RenewalCheckStatus("REN");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRenewalCurrent, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  originalPremium));
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium("cash");

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeSelectScheme(Moto.CommonParams.SendHomeKeys);
            Moto.RebrokeSelectAlternative();
            Moto.MotoRebrokeCurrent(false);
            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.RebrokeAlternativeFinish("cash");
            Moto.RetrieveResponse();
            Moto.CancelPrint();
            Moto.RebrokeAlternativeFinish1();
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string premium = Moto.CheckPolicyPremium("cash");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRebrokeRenewExistingScheme, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  originalPremium));
            Moto.RenewalCheckStatus("REW");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium("cash");

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeSelectScheme(Moto.CommonParams.SendEndKeys);
            Moto.RebrokeSelectAlternative();
            Moto.MotoRebrokeCurrent(false);
            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.RebrokeAlternativeFinish("cash");
            Moto.RetrieveResponse();
            Moto.CancelPrint();
            Moto.RebrokeAlternativeFinish1();
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium("cash");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRebrokeRenewExistingScheme, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash",  originalPremium));
            Moto.RenewalCheckStatus("REW");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoLapsePolicy()
        {
            SetOurHighwayRegKeys();
            UiMap.CustomerCode = Moto.TamMotorSteps(Customer);
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            Moto.AcceptAndFinishQuote("cash");
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.LapsePolicy(policyNumber);
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            Moto.RenewalCheckStatus("LAP");
            Moto.ClosePolicy();
        }

        #region Private Functions

        #endregion
    }
}