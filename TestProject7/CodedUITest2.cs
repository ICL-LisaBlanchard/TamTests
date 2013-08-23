﻿namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class CodedUITest2 : BaseUiTest
    {
        [TestMethod]
        public void MotoCreateQuote()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.AssertSelectPolicyForm();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RecordedMethod1();
            this.UiMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SaveWithoutPremium();
            this.UiMap.MotoCloseAndOpenPolicyList();
            //check premium
            this.UiMap.RecordedMethod1();
            this.UiMap.AssertMethod2();
            this.UiMap.RecordedMethod4();
            this.UiMap.SelectMenu();
            this.UiMap.RecordedMethod4_1();
            this.UiMap.AssertMethod3();
            this.UiMap.Calculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.ExitEnabled();
            this.UiMap.Exit1();
            //check premium
            this.UiMap.RecordedMethod1();
            this.UiMap.AssertMethod1();
            this.UiMap.RecordedMethod4();
            this.UiMap.SelectMenu();
            this.UiMap.RecordedMethod4_1();
            this.UiMap.AssertMethod3();
            this.UiMap.Calculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.PrintQuote();
            this.UiMap.CheckAutoPrint();
            this.UiMap.DemandsAndNeeds();
            Playback.Wait(3000);
            this.UiMap.CloseDemandsMoto();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RecordedMethod1();
            this.UiMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoAWAP();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RecordedMethod1();
            this.UiMap.MotoCheckAWAPpremium();
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.AssertSelectPolicyForm();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.ChangePremium();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RecordedMethod1();
            this.UiMap.MotoCheckChangedPremium();
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCopyFinishedRisk();
            this.UiMap.MotoCopyCheckProposer();
            this.UiMap.MotoCopyRiskProposerOk();
            this.UiMap.MotoCopyCheckCar();
            this.UiMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoCopyRiskQTE()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SaveWithoutPremium();
            this.UiMap.MotoCopyFinishedRisk();
            this.UiMap.MotoCopyCheckProposer();
            this.UiMap.MotoCopyRiskProposerOk();
            this.UiMap.MotoCopyCheckCar();
            this.UiMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTANoSave();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RecordedMethod1();
            this.UiMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAccept();
            this.UiMap.MotoMTAConfirmDate();
            this.UiMap.MotoMTAConfirmPolicy();
            this.UiMap.MotoMTAConfirmPolicy_1();
            this.UiMap.MotoMTAOpenQuote();
            this.UiMap.MotoMTACheckNewValue();
            this.UiMap.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAccept();
            this.UiMap.MotoMTAConfirmDate();
            this.UiMap.MotoMTAConfirmPolicy();
            this.UiMap.MotoMTAConfirmPolicy_1();
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAccept();
            this.UiMap.MotoMTAConfirmDate();
            this.UiMap.MotoMTAConfirmPolicy();
            this.UiMap.MotoMTAConfirmPolicy_1();
            this.UiMap.MotoCopyFinishedRisk();
            this.UiMap.MotoCopyCheckProposer();
            this.UiMap.MotoCopyRiskProposerOk();
            this.UiMap.MotoMTACheckCar();
            this.UiMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAtoMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAcceptParams.UIItemEditText = "2500";
            this.UiMap.MotoMTAAccept();
            this.UiMap.MTAEffectiveDateParams.UIItemEditText = "13/10/12";
            this.UiMap.MTAEffectiveDate();
            this.UiMap.MotoMTAConfirmDate();
            this.UiMap.CoverDateBackCheck();
            this.UiMap.MotoMTACloseMessage();
            this.UiMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTAEffectiveDate();
            this.UiMap.MotoMTAConfirmDate();
            this.UiMap.MotoMTAConfirmPolicy();
            this.UiMap.MotoMTAConfirmPolicy_1();
            this.UiMap.MotoMTAOpenQuote();
            this.UiMap.MotoMTACheckNewValueExpectedValues.UIItemEditText = "2500";
            this.UiMap.MotoMTACheckNewValue();
            this.UiMap.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCancelExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            //create policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.AssertSelectPolicyForm();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.MotoCloseDetails();
            //Cancel policy
            this.UiMap.MotoMTA();
            this.UiMap.MotoCancelPolicy();
            this.UiMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTAEffectiveDate();
            this.UiMap.MotoCancelPolicy_1();
            this.UiMap.MotoCancelExit();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            this.UiMap.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoCancelAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPolicyPerson();
            this.UiMap.PostcodeLookup();
            this.UiMap.QuoteResults();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.AssertSelectPolicyForm();
            this.UiMap.SelectPolicyQuote();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.MotoCloseDetails();
            this.UiMap.MotoMTA();
            this.UiMap.MotoCancelPolicy();
            this.UiMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTAEffectiveDate();
            this.UiMap.MotoCancelPolicy_1();
            this.UiMap.MotoMTAConfirmPolicy();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            this.UiMap.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //mta1
            this.UiMap.SelectMenu();
            this.UiMap.MotoMTABefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTABeforeAccept();
            this.UiMap.MotoMTAMessageCancelled();
            this.UiMap.MotoMTABeforeFinish();
            //mta2
            this.UiMap.SelectMenu();
            this.UiMap.MotoMTABefore2();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            ////MTA1
            this.UiMap.SelectMenu();
            this.UiMap.RenewalAfterMTA1();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoFinishMTA();
            //MTA2
            this.UiMap.SelectMenu();
            this.UiMap.RenewalAfterMTA1();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTACancel();
            //MTA3
            this.UiMap.SelectMenu();
            this.UiMap.MotoMTABefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTABeforeAccept();
            this.UiMap.MotoMTABeforeFinish();
            //mta4
            this.UiMap.SelectMenu();
            this.UiMap.MotoMTABefore2();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            //change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(6000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.MotoAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.QuoteSelectListCancel();
            this.UiMap.AmendSelectQuote();
            this.UiMap.MotoAmendRiskRenew();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            //change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.MotoAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.AmendSelectQuoteParams.UIAmendRiskResultsClientSendKeys = "{End}";
            this.UiMap.AmendSelectQuote();
            this.UiMap.MotoAmendRiskNew();
            this.UiMap.RetrieveResponse();
            this.UiMap.MotoAmendRiskNew_1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //mta1
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(5).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.AmendDateBeforeMessage();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(12).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoFinishMTA();
            //mta2
            this.UiMap.MotoMTA();
            this.UiMap.MotoMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            //change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.MotoRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoRebrokeCurrent();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            //change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.MotoRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoRebrokeSelectScheme();
            this.UiMap.RebrokeSelectAlternative();
            this.UiMap.MotoRebrokeCurrent();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RebrokeAlternativeFinish();
            this.UiMap.RetrieveResponse();
            this.UiMap.CancelPrint();
            this.UiMap.RebrokeAlternativeFinish_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            //change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            this.UiMap.RegistryHighway();
            // add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectMotoPolicy();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.MotoPostcodeLookup();
            this.UiMap.MotoSearchCar();
            this.UiMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.MotoInceptionDate();
            this.UiMap.MotoCalculate();
            this.UiMap.CancelFilter();
            this.UiMap.QuoteResults_1();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoSelectHighwayPolicy();
            this.UiMap.AcceptQuote();
            this.UiMap.FinishQuote();
            this.UiMap.CancelPrint();
            this.UiMap.FinishQuote1();
            this.UiMap.MotoCloseAndOpenPolicyList();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            this.UiMap.OpenBrowser2();
            this.UiMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.MotoRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.MotoRebrokeSelectSchemeParams.UIItemClientSendKeys = "{End}";
            this.UiMap.MotoRebrokeSelectScheme();
            this.UiMap.RebrokeSelectAlternative();
            this.UiMap.MotoRebrokeCurrent();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RebrokeAlternativeFinish();
            this.UiMap.RetrieveResponse();
            this.UiMap.CancelPrint();
            this.UiMap.RebrokeAlternativeFinish_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseCreateQuote()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeExitWithoutPolicy();
            this.UiMap.HomeCloseOpenPolicy();
            this.UiMap.HomeClickPremium();
            this.UiMap.HomeCheckZeroPremium();
            this.UiMap.HomeExitWithPolicy();
            this.UiMap.HomeCheckPremium();
            this.UiMap.HomePrintQuote();
            this.UiMap.SelectMenu();
            this.UiMap.HomePrintQuote_1();
            this.UiMap.HomeCheckPrint();
            this.UiMap.HomeDemands();
            this.UiMap.CloseDemandsMoto();
            this.UiMap.HomeAcceptQuote();
            this.UiMap.CancelPrint();
            this.UiMap.HomeAcceptQuote_1();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeChangePremium();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckNewPremium();
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeCopyCheckData();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeExitWithoutPolicy();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeCopyCheckData();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTACancel();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckCancelled();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckChanged();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeMTACopyCheck();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            // create new policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //MTA
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            //new MTA
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = "30/09/12";
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTACheckMessage();
            this.UiMap.HomeMTACloseMessage();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.UiMap.HomeMTACheckChanged();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            //create policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //cancel policy
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeCancelPolicy();
            this.UiMap.HomeCancelPolicyQuote();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeCancelPolicyQuote_1();
            this.UiMap.HomeCancelPolicyExit();
            //check status
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            this.UiMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //cancel policy
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeCancelPolicy();
            this.UiMap.HomeCancelPolicyQuote();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeCancelPolicyQuote_1();
            this.UiMap.HomeCancelPolicyAccept();
            //check status
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            this.UiMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            //  renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //mta1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTABefore();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeRenewalBeforeAccept();
            this.UiMap.HomeRenewalCancelledCheck();
            this.UiMap.HomeRenewalBeforeFinish();
            ////mta2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeRenewalConfirm();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            ////MTA1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAAfter();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeMTASelectQuote();
            //MTA2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAAfter();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
            //MTA3
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTABefore();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeRenewalBeforeAccept();
            this.UiMap.HomeRenewalBeforeFinish();
            //mta4
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeRenewalConfirm();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeAmendSelecPolicy();
            this.UiMap.HomeAmendRenew();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys = "{End}";
            this.UiMap.HomeAmendSelecPolicy();
            this.UiMap.HomeAmendRenewFinish();
            this.UiMap.etam_ok();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.HomeAmendRenewFinish_1();
            this.UiMap.etam_ok();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //MTA1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.AmendDateBeforeMessage();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeMTASelectQuote();
            //MTA2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeCurrent();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeSelectPolicy();
            this.UiMap.HomeRebrokeSelectAlternative();
            this.UiMap.HomeRebrokeFinish();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RebrokeAlternativeRenew();
            this.UiMap.etam_ok();
            this.UiMap.etam_yes();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.RebrokeAlternativeRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links_1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEDI_1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys = "{END}";
            this.UiMap.HomeRebrokeSelectPolicy();
            this.UiMap.HomeRebrokeSelectAlternative();
            this.UiMap.HomeRebrokeFinish();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite_1();
            this.UiMap.RebrokeAlternativeRenew();
            this.UiMap.etam_ok();
            this.UiMap.etam_yes();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.RebrokeAlternativeRenew_1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.ClosePolicy();
        }
    }
}