namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class MotoUiTests : BaseUiTest
    {
        private readonly MotoActions moto = new MotoActions();

        private readonly CustomerActions customer = new CustomerActions();

        [TestMethod]
        public void MotoCreateQuote()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RecordedMethod1();
            this.moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SaveWithoutPremium();
            this.moto.MotoCloseAndOpenPolicyList();
            //check premium
            this.moto.RecordedMethod1();
            this.moto.AssertMethod2();
            this.moto.RecordedMethod4();
            this.moto.SelectMenu();
            this.moto.ClickOkButton();
            this.moto.AssertMethod3();
            this.moto.Calculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.ExitEnabled();
            this.moto.Exit1();
            //check premium
            this.moto.RecordedMethod1();
            this.moto.AssertMethod1();
            this.moto.RecordedMethod4();
            this.moto.SelectMenu();
            this.moto.ClickOkButton();
            this.moto.AssertMethod3();
            this.moto.Calculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.PrintQuote();
            this.moto.CheckAutoPrint();
            this.moto.DemandsAndNeeds();
            Playback.Wait(3000);
            this.moto.CloseDemandsMoto();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RecordedMethod1();
            this.moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoAwap();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RecordedMethod1();
            this.moto.MotoCheckAWAPpremium();
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.ChangePremium();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RecordedMethod1();
            this.moto.MotoCheckChangedPremium();
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCopyFinishedRisk();
            this.moto.MotoCopyCheckProposer();
            this.moto.MotoCopyRiskProposerOk();
            this.moto.MotoCopyCheckCar();
            this.moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoCopyRiskQte()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SaveWithoutPremium();
            this.moto.MotoCopyFinishedRisk();
            this.moto.MotoCopyCheckProposer();
            this.moto.MotoCopyRiskProposerOk();
            this.moto.MotoCopyCheckCar();
            this.moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAExit()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTANoSave();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RecordedMethod1();
            this.moto.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.MotoMTAConfirmPolicy1();
            this.moto.MotoMTAOpenQuote();
            this.moto.MotoMTACheckNewValue();
            this.moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.MotoMTAConfirmPolicy1();
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.MotoMTAConfirmPolicy1();
            this.moto.MotoCopyFinishedRisk();
            this.moto.MotoCopyCheckProposer();
            this.moto.MotoCopyRiskProposerOk();
            this.moto.MotoMTACheckCar();
            this.moto.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAtoMTA()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTAAcceptParams.UIItemEditText = "2500";
            this.moto.MotoMTAAccept();
            this.moto.MTAEffectiveDateParams.UIItemEditText = "13/10/12";
            this.moto.MtaEffectiveDate();
            this.moto.MotoMTAConfirmDate();
            this.moto.CoverDateBackCheck();
            this.moto.MotoMTACloseMessage();
            this.moto.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.moto.MtaEffectiveDate();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.MotoMTAConfirmPolicy1();
            this.moto.MotoMTAOpenQuote();
            this.moto.MotoMTACheckNewValueExpectedValues.UIItemEditText = "2500";
            this.moto.MotoMTACheckNewValue();
            this.moto.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCancelExit()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.MotoCloseDetails();
            //Cancel policy
            this.moto.MotoMTA();
            this.moto.MotoCancelPolicy();
            this.moto.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.moto.MtaEffectiveDate();
            this.moto.MotoCancelPolicy1();
            this.moto.MotoCancelExit();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            this.moto.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoCancelAccept()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.MotoCloseDetails();
            this.moto.MotoMTA();
            this.moto.MotoCancelPolicy();
            this.moto.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.moto.MtaEffectiveDate();
            this.moto.MotoCancelPolicy1();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            this.moto.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
            //mta1
            this.moto.SelectMenu();
            this.moto.MotoMTABefore();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoMTABeforeAccept();
            this.moto.MotoMTAMessageCancelled();
            this.moto.MotoMTABeforeFinish();
            //mta2
            this.moto.SelectMenu();
            this.moto.MotoMTABefore2();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.moto.MTACloseMessageAfter();
            this.moto.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
            ////MTA1
            this.moto.SelectMenu();
            this.moto.RenewalAfterMTA1();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoFinishMTA();
            //MTA2
            this.moto.SelectMenu();
            this.moto.RenewalAfterMTA1();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTACancel();
            //MTA3
            this.moto.SelectMenu();
            this.moto.MotoMTABefore();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.moto.MTACloseMessageAfter();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoMTABeforeAccept();
            this.moto.MotoMTABeforeFinish();
            //mta4
            this.moto.SelectMenu();
            this.moto.MotoMTABefore2();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.moto.MTACloseMessageAfter();
            this.moto.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(6000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.MotoAmendRisk();
            this.moto.PublicCreditCheckOk();
            this.moto.QuoteSelectListCancel();
            this.moto.AmendSelectQuote();
            this.moto.MotoAmendRiskRenew();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.MotoAmendRisk();
            this.moto.PublicCreditCheckOk();
            this.moto.AmendSelectQuoteParams.UIAmendRiskResultsClientSendKeys = "{End}";
            this.moto.AmendSelectQuote();
            this.moto.MotoAmendRiskNew();
            this.moto.RetrieveResponse();
            this.moto.MotoAmendRiskNew1();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
            //mta1
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(5).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.AmendDateBeforeMessage();
            this.moto.MTACloseMessageBefore();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(12).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MotoFinishMTA();
            //mta2
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.moto.MTADate();
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.MotoRebroke();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeCurrent();
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.MotoRebroke();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeSelectScheme();
            this.moto.RebrokeSelectAlternative();
            this.moto.MotoRebrokeCurrent();
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RebrokeAlternativeFinish();
            this.moto.RetrieveResponse();
            this.moto.CancelPrint();
            this.moto.RebrokeAlternativeFinish1();
            this.moto.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoCloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.moto.MotoCreateSiteRenewal();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.moto.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.moto.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1();
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.moto.RenewalModuleFilterMoto();
            this.moto.RenewalModuleSort();
            this.moto.RenewalModuleSort();
            this.moto.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.moto.MotoRebroke();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeSelectSchemeParams.UIItemClientSendKeys = "{End}";
            this.moto.MotoRebrokeSelectScheme();
            this.moto.RebrokeSelectAlternative();
            this.moto.MotoRebrokeCurrent();
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RebrokeAlternativeFinish();
            this.moto.RetrieveResponse();
            this.moto.CancelPrint();
            this.moto.RebrokeAlternativeFinish1();
            this.moto.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
        }

        private void TamMotorSteps()
        {
            this.customer.AddPolicy();
            this.moto.SelectMotoPolicy();
            this.moto.SelectMenu();
            this.moto.Links();
        }
    }
}