namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;

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
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.AssertSelectPolicyForm();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            
            string premium = this.Moto.CheckPolicyPremium();
            this.Moto.OpenTransList(Transactions.GetTransactionDictionary(premium));
            this.Moto.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoNewBusinessQuote);
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SaveWithoutPremium();
            this.Moto.CloseAndOpenPolicyList();

            //check premium
            this.Moto.HighlightBillingScreen();
            this.Moto.AssertQuoteCostIsZero();
            this.Moto.CancelBillingScreen();
            this.Moto.SelectMenu();
            this.Moto.ClickOkButton();
            this.Moto.AssertCarDetailsCorrect();
            this.Moto.Calculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.SelectPolicyQuote();
            this.Moto.ExitEnabled();
            this.Moto.Exit1();

            //check premium
            this.Moto.HighlightBillingScreen();
            this.Moto.AssertMethod1();
            this.Moto.CancelBillingScreen();
            this.Moto.SelectMenu();
            this.Moto.ClickOkButton();
            this.Moto.AssertCarDetailsCorrect();
            this.Moto.Calculate();

            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.SelectPolicyQuote();
            this.Moto.PrintQuote();
            this.Moto.CheckAutoPrint();
            this.Moto.DemandsAndNeeds();
            Playback.Wait(3000);
            this.Moto.CloseDemands();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            this.Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            const string Premium = "17777.00";
            this.Moto.MotoAwap(Premium);
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            this.Moto.MotoCheckAWAPpremium(Premium);
            this.Moto.OpenTransList(Transactions.GetTransactionDictionary(Premium));
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            const string OverridePremiumGross = "3393.06";
            const string OverridePremiumNet = "3201.00";
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.AssertSelectPolicyForm();
            this.Moto.SelectPolicyQuote();
            this.Moto.ChangePremium(OverridePremiumGross);
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            this.Moto.MotoCheckChangedPremium(OverridePremiumNet);

            this.Moto.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoOverridePremium, double.Parse(OverridePremiumNet));
            this.Moto.OpenTransList(Transactions.GetTransactionDictionary(OverridePremiumNet));
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.MotoCopyFinishedRisk();
            this.Moto.MotoCopyCheckProposer();
            this.Moto.MotoCopyRiskProposerOk();
            this.Moto.MotoCopyCheckCar();
            this.Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoCopyRiskQte()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SaveWithoutPremium();
            this.Moto.MotoCopyFinishedRisk();
            this.Moto.MotoCopyCheckProposer();
            this.Moto.MotoCopyRiskProposerOk();
            this.Moto.MotoCopyCheckCar();
            this.Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAExit()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.MotoMTA();
            this.Moto.MotoMTANoSave();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            this.Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.CreateMTA();
            this.Moto.MotoMTAOpenQuote();
            this.Moto.MotoMTACheckNewValue(false);
            this.Moto.CheckCorrectNumberTrans(2);
            this.Moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.CreateMTA();
            this.CreateMTA();
            this.Moto.MotoCopyFinishedRisk();
            this.Moto.MotoCopyCheckProposer();
            this.Moto.MotoCopyRiskProposerOk();
            this.Moto.MotoMTACheckCar();
            this.Moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAtoMTA()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.MotoMTA();
            this.Moto.MotoMTAParams.CostOfVehicle = "2500";
            this.Moto.MotoMTAAccept();
            this.Moto.MtaEffectiveDate("13/10/12");
            this.Moto.MotoMTAConfirmDate();
            this.Moto.CoverDateBackCheck();
            this.Moto.MotoMTACloseMessage();
            string coverDate = "MotoMTAtoMTA_" + this.Moto.MtaEffectiveDate();
            this.Moto.MotoMTAConfirmDate();
            this.Moto.MotoMTAConfirmPolicy("mta");
            Playback.Wait(5000);
            this.Moto.MotoMTAOpenQuote();

            this.Moto.MotoMTACheckNewValueExpectedValues.UIItemEditText = "2500";
            this.Moto.MotoMTACheckNewValue(true, coverDate);
            this.Moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCancelExit()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.AssertSelectPolicyForm();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.MotoCloseDetails();
            //Cancel policy
            this.Moto.MotoMTA();
            this.Moto.MotoCancelPolicy();
            this.Moto.MtaEffectiveDate();
            this.Moto.MotoCancelPolicy1();
            this.Moto.MotoCancelExit();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            this.Moto.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoCancelAccept()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.CreateNewBusinessPolicy();
            this.Moto.AssertSelectPolicyForm();
            this.Moto.SelectPolicyQuote();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.CheckPolicyPremium();
            this.Moto.MotoCloseDetails();
            this.Moto.MotoMTA();
            this.Moto.MotoCancelPolicy();
            this.Moto.MtaEffectiveDate();
            this.Moto.MotoCancelPolicy1();
            this.Moto.MotoMTAConfirmPolicy("cancel");
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            this.Moto.MotoCheckPolicyStatus();
            this.Moto.CheckCorrectNumberTrans(2);
            this.Moto.CheckCorrectDocumentPresent(this.Docs.DocumentsForMotoNewBusinessCancelAccept);
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            string premium = this.Moto.CheckPolicyPremium();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.SiteForRenewal(policyNumber, PolicyType, RenewalPremium);
            string customerCode = this.RegressApp(PolicyType);
            this.RenewalLoader();
            this.RenewalModule(customerCode, PolicyType);
            this.RenewalsInvite(false);
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.RenewalCheckStatus("REN");
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRenewalBefore, originalPremium: double.Parse(premium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(RenewalPremium, premium));
            this.Moto.ClosePolicy();

            //mta1
            this.Moto.SelectMenu();
            this.Moto.MotoMTABefore();
            this.Moto.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            this.Moto.MotoMTABeforeAccept();
            this.Moto.MotoMTAMessageCancelled();
            this.Moto.MotoMTABeforeFinish();

            //mta2
            this.Moto.SelectMenu();
            this.Moto.MotoMTABefore2();
            this.Moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.Moto.MTAMessageBeforeCurrent();
            this.Moto.MTACloseMessageBefore();
            this.Moto.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.Moto.MTACloseMessageAfter();
            this.Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();

            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.RenewalsInvite(false);
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.RenewalCheckStatus("REN");
            this.Moto.ClosePolicy();
            ////MTA1
            this.Moto.SelectMenu();
            this.Moto.RenewalAfterMTA1();
            this.Moto.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.Moto.MotoFinishMTA();
            //MTA2
            this.Moto.SelectMenu();
            this.Moto.RenewalAfterMTA1();
            this.Moto.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.Moto.MTAMessageBeforeCurrent();
            this.Moto.MTACloseMessageBefore();
            this.Moto.MTACancel();
            //MTA3
            this.Moto.SelectMenu();
            this.Moto.MotoMTABefore();
            this.Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.Moto.MTACloseMessageAfter();

            this.Moto.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.Moto.MotoMTABeforeAccept();
            this.Moto.MotoMTABeforeFinish();
            //mta4
            this.Moto.SelectMenu();
            this.Moto.MotoMTABefore2();

            this.Moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.Moto.MTAMessageBeforeCurrent();
            this.Moto.MTACloseMessageBefore();

            this.Moto.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.Moto.MTACloseMessageAfter();
            this.Moto.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string originalPremium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.Moto.MotoAmendRisk();
            this.Moto.PublicCreditCheckOk();
            this.Moto.QuoteSelectListCancel();
            this.Moto.AmendSelectQuote();
            this.Moto.MotoAmendRiskRenew();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            string premium = this.Moto.CheckPolicyPremium();
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoMotoAmendRiskExistingScheme, originalPremium: double.Parse(originalPremium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            this.Moto.RenewalCheckStatus("REN");
            this.Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string originalPremium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.Moto.MotoAmendRisk();
            this.Moto.PublicCreditCheckOk();
            this.Moto.CommonParams.SendHomeKeys = "{End}";
            this.Moto.AmendSelectQuote();
            this.Moto.MotoAmendRiskNew();
            this.Moto.RetrieveResponse();
            this.Moto.MotoAmendRiskNew1();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            string premium = this.Moto.CheckPolicyPremium();
            this.Moto.RenewalCheckStatus("REW");
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoAmendRiskNew, originalPremium: double.Parse(originalPremium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            this.Moto.ClosePolicy();

            //mta1
            this.Moto.MotoMTA();
            this.Moto.MotoMTAAccept();
            this.Moto.MTADate(DateTime.Now.AddDays(5).ToString("dd/MM/yy"));
            this.Moto.AmendDateBeforeMessage();
            this.Moto.MTACloseMessageBefore();
            this.Moto.MTADate(DateTime.Now.AddDays(12).ToString("dd/MM/yy"));
            this.Moto.MotoFinishMTA();

            //mta2
            this.Moto.MotoMTA();
            this.Moto.MotoMTAAccept();
            this.Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            this.Moto.MTAMessageBeforeCurrent();
            this.Moto.MTACloseMessageBefore();
            this.Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string premium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.Moto.MotoRebroke(false, false);
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoRebrokeCurrent(false);
            this.RenewalsInvite(true);
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.RenewalCheckStatus("REN");
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRenewalCurrent, originalPremium: double.Parse(premium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(RenewalPremium, premium));
            this.Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
    
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string premium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.Moto.MotoRebroke(false, false);
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoRebrokeSelectScheme(this.Moto.CommonParams.SendHomeKeys);
            this.Moto.RebrokeSelectAlternative();
            this.Moto.MotoRebrokeCurrent(false);
            this.Moto.RenewalModuleInvite(false);
            this.Moto.RenewConfirmInvite();
            this.Moto.RenewalModuleInvite1();
            this.Moto.RebrokeAlternativeFinish();
            this.Moto.RetrieveResponse();
            this.Moto.CancelPrint();
            this.Moto.RebrokeAlternativeFinish1();
            this.Moto.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRebrokeRenewExistingScheme, originalPremium: double.Parse(premium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(RenewalPremium, premium));
            this.Moto.RenewalCheckStatus("REW");
            this.Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string originalPremium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            this.Moto.MotoRebroke(false, false);
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoRebrokeSelectScheme(this.Moto.CommonParams.SendEndKeys);
            this.Moto.RebrokeSelectAlternative();
            this.Moto.MotoRebrokeCurrent(false);
            this.Moto.RenewalModuleInvite(false);
            this.Moto.RenewConfirmInvite();
            this.Moto.RenewalModuleInvite1();
            this.Moto.RebrokeAlternativeFinish();
            this.Moto.RetrieveResponse();
            this.Moto.CancelPrint();
            this.Moto.RebrokeAlternativeFinish1();
            this.Moto.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.HighlightBillingScreen();
            string premium = this.Moto.CheckPolicyPremium();
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRebrokeRenewExistingScheme, originalPremium: double.Parse(originalPremium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            this.Moto.RenewalCheckStatus("REW");
            this.Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoLapsePolicy()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.Moto.MotoPostcodeLookup();
            this.Moto.MotoSearchCar();
            this.Moto.MotoInceptionDate();
            this.Moto.MotoCalculate();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
            this.Moto.MotoSelectHighwayPolicy();
            this.AcceptAndFinishQuote();
            this.Moto.CloseAndOpenPolicyList();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string originalPremium = this.Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);


            this.Moto.RenewalModuleInvite(false);
            this.Moto.RenewConfirmInvite();
            this.Moto.RenewalModuleInvite1();
            this.Moto.LapsePolicy(policyNumber);
            this.Moto.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();
            this.Moto.RenewalCheckStatus("LAP");
            this.Moto.ClosePolicy();
        }

        #region Private Functions

        private void CreateMTA()
        {
            this.Moto.MotoMTA();
            this.Moto.MotoMTAAccept();
            this.Moto.MotoMTAConfirmDate();
            this.Moto.MotoMTAConfirmPolicy("mta");
        }

        private void AcceptAndFinishQuote()
        {
            this.Moto.AcceptQuote();
            this.Moto.FinishQuote();
            this.Moto.CancelPrint();
            this.Moto.MotoFinishQuote();
        }

        private void CreateNewBusinessPolicy()
        {
            this.Moto.MotoPolicyPerson();
            this.Moto.PostcodeLookup();
            this.Moto.QuoteResults();
            this.Moto.QuoteResults1();
            this.Moto.PublicCreditCheckOk();
        }

        private void TamMotorSteps()
        {
            this.Moto.CustomerCode = this.Customer.AddPolicy();
            this.Moto.SelectMotoPolicy();
            this.Moto.SelectMenu();
            this.Moto.Links();
        }

        #endregion
    }
}