﻿namespace AppliedSystems.Tam.Ui.Tests
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
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            
            string premium = Moto.CheckPolicyPremium();
            Moto.OpenTransList(Transactions.GetTransactionDictionary(premium));
            Moto.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoNewBusinessQuote);
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SaveWithoutPremium();
            Moto.CloseAndOpenPolicyList();

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
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            const string Premium = "17777.00";
            Moto.MotoAwap(Premium);
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            Moto.MotoCheckAWAPpremium(Premium);
            Moto.OpenTransList(Transactions.GetTransactionDictionary(Premium));
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            const string OverridePremiumGross = "3393.06";
            const string OverridePremiumNet = "3201.00";
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            Moto.ChangePremium(OverridePremiumGross);
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            Moto.MotoCheckChangedPremium(OverridePremiumNet);

            Moto.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoOverridePremium, double.Parse(OverridePremiumNet));
            Moto.OpenTransList(Transactions.GetTransactionDictionary(OverridePremiumNet));
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
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
            TamMotorSteps();
            CreateNewBusinessPolicy();
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
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            Moto.MotoMTA();
            Moto.MotoMTANoSave();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            Moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            CreateMTA();
            Moto.MotoMTAOpenQuote();
            Moto.MotoMTACheckNewValue(false);
            Moto.CheckCorrectNumberTrans(2);
            Moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            CreateMTA();
            CreateMTA();
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
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            Moto.MotoMTA();
            Moto.MotoMTAParams.CostOfVehicle = "2500";
            Moto.MotoMTAAccept();
            Moto.MtaEffectiveDate("13/10/12");
            Moto.MotoMTAConfirmDate();
            Moto.CoverDateBackCheck();
            Moto.MotoMTACloseMessage();
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
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            Moto.MotoCloseDetails();
            //Cancel policy
            Moto.MotoMTA();
            Moto.MotoCancelPolicy();
            Moto.MtaEffectiveDate();
            Moto.MotoCancelPolicy1();
            Moto.MotoCancelExit();
            Moto.CloseAndOpenPolicyList();
            Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            Moto.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoCancelAccept()
        {
            SetOfficeRegKeys();
            TamMotorSteps();
            CreateNewBusinessPolicy();
            Moto.AssertSelectPolicyForm();
            Moto.SelectPolicyQuote();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            Moto.CheckPolicyPremium();
            Moto.MotoCloseDetails();
            Moto.MotoMTA();
            Moto.MotoCancelPolicy();
            Moto.MtaEffectiveDate();
            Moto.MotoCancelPolicy1();
            Moto.MotoMTAConfirmPolicy("cancel");
            Moto.CloseAndOpenPolicyList();
            Moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            Moto.MotoCheckPolicyStatus();
            Moto.CheckCorrectNumberTrans(2);
            Moto.CheckCorrectDocumentPresent(Docs.DocumentsForMotoNewBusinessCancelAccept);
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            string originalPremium = Moto.CheckPolicyPremium();
            string policyNumber = Moto.GetPolicyNumber();

            SiteForRenewal(policyNumber, PolicyType, RenewalPremium);
            string customerCode = RegressApp(PolicyType);
            RenewalLoader();
            RenewalModule(customerCode, PolicyType);
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList();
            Moto.RenewalCheckStatus("REN");
            string premium = Moto.CheckPolicyPremium();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoRenewalBefore, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
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
            Moto.MTACloseMessageBefore();
            Moto.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.MTACloseMessageAfter();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();

            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            //moto.CancelFilter();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList();
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
            Moto.MTACloseMessageBefore();
            Moto.MTACancel();
            //MTA3
            Moto.SelectMenu();
            Moto.MotoMTABefore();
            Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.MTACloseMessageAfter();

            Moto.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            Moto.MotoMTABeforeAccept();
            Moto.MotoMTABeforeFinish();
            //mta4
            Moto.SelectMenu();
            Moto.MotoMTABefore2();

            Moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.MTACloseMessageBefore();

            Moto.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            Moto.MTACloseMessageAfter();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoAmendRisk();
            Moto.PublicCreditCheckOk();
            Moto.QuoteSelectListCancel();
            Moto.AmendSelectQuote();
            Moto.MotoAmendRiskRenew();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoMotoAmendRiskExistingScheme, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            Moto.RenewalCheckStatus("REN");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoAmendRisk();
            Moto.PublicCreditCheckOk();
            Moto.CommonParams.SendHomeKeys = "{End}";
            Moto.AmendSelectQuote();
            Moto.MotoAmendRiskNew();
            Moto.RetrieveResponse();
            Moto.MotoAmendRiskNew1();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium();
            Moto.RenewalCheckStatus("REW");
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoAmendRiskNew, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            Moto.ClosePolicy();

            //mta1
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(5).ToString("dd/MM/yy"));
            Moto.AmendDateBeforeMessage();
            Moto.MTACloseMessageBefore();
            Moto.MTADate(DateTime.Now.AddDays(12).ToString("dd/MM/yy"));
            Moto.MotoFinishMTA();

            //mta2
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MTAMessageBeforeCurrent();
            Moto.MTACloseMessageBefore();
            Moto.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeCurrent(false);
            RenewalsInvite(true);
            Moto.CloseAndOpenPolicyList();
            string premium = Moto.CheckPolicyPremium();
            Moto.RenewalCheckStatus("REN");
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoRenewalCurrent, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
    
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeSelectScheme(Moto.CommonParams.SendHomeKeys);
            Moto.RebrokeSelectAlternative();
            Moto.MotoRebrokeCurrent(false);
            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.RebrokeAlternativeFinish();
            Moto.RetrieveResponse();
            Moto.CancelPrint();
            Moto.RebrokeAlternativeFinish1();
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();
            string premium = Moto.CheckPolicyPremium();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoRebrokeRenewExistingScheme, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            Moto.RenewalCheckStatus("REW");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);
            Moto.MotoRebroke(false, false);
            Moto.PublicCreditCheckOk();
            Moto.MotoRebrokeSelectScheme(Moto.CommonParams.SendEndKeys);
            Moto.RebrokeSelectAlternative();
            Moto.MotoRebrokeCurrent(false);
            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.RebrokeAlternativeFinish();
            Moto.RetrieveResponse();
            Moto.CancelPrint();
            Moto.RebrokeAlternativeFinish1();
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();
            Moto.HighlightBillingScreen();
            string premium = Moto.CheckPolicyPremium();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForMotoRebrokeRenewExistingScheme, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            Moto.RenewalCheckStatus("REW");
            Moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoLapsePolicy()
        {
            SetOurHighwayRegKeys();
            TamMotorSteps();
            Moto.MotoPostcodeLookup();
            Moto.MotoSearchCar();
            Moto.MotoInceptionDate();
            Moto.MotoCalculate();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
            Moto.MotoSelectHighwayPolicy();
            AcceptAndFinishQuote();
            Moto.CloseAndOpenPolicyList();
            string policyNumber = Moto.GetPolicyNumber();
            string originalPremium = Moto.CheckPolicyPremium();

            Renewals(policyNumber, PolicyType, RenewalPremium);


            Moto.RenewalModuleInvite(false);
            Moto.RenewConfirmInvite();
            Moto.RenewalModuleInvite1();
            Moto.LapsePolicy(policyNumber);
            Moto.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();
            Moto.RenewalCheckStatus("LAP");
            Moto.ClosePolicy();
        }

        #region Private Functions

        private void CreateMTA()
        {
            Moto.MotoMTA();
            Moto.MotoMTAAccept();
            Moto.MotoMTAConfirmDate();
            Moto.MotoMTAConfirmPolicy("mta");
        }

        private void AcceptAndFinishQuote()
        {
            Moto.AcceptQuote();
            Moto.FinishQuote();
            Moto.CancelPrint();
            Moto.MotoFinishQuote();
        }

        private void CreateNewBusinessPolicy()
        {
            Moto.MotoPolicyPerson();
            Moto.PostcodeLookup();
            Moto.QuoteResults();
            Moto.QuoteResults1();
            Moto.PublicCreditCheckOk();
        }

        private void TamMotorSteps()
        {
            Moto.CustomerCode = Customer.AddPolicy();
            Moto.SelectMotoPolicy();
            Moto.SelectMenu();
            Moto.Links();
        }

        #endregion
    }
}