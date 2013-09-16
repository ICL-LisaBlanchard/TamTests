namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class MotoUiTests : BaseUiTest
    {
        private const string PolicyType = "Motor";

        private readonly MotoActions moto = new MotoActions();

        private readonly CustomerActions customer = new CustomerActions();

        private readonly DocumentsList docs = new DocumentsList();

        [TestMethod]
        public void MotoCreateQuote()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
            string premium = this.moto.CheckPolicyPremium();
            this.moto.OpenTransList(GetTransactionDictionary(premium));
            this.moto.CheckPremiumInQuoteDocument(this.docs.DocumentsForMotoNewBusinessQuote);
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            ////this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SaveWithoutPremium();
            this.moto.CloseAndOpenPolicyList();
            //check premium
            this.moto.HighlightBillingScreen();
            this.moto.AssertQuoteCostIsZero();
            this.moto.CancelBillingScreen();
            this.moto.SelectMenu();
            this.moto.ClickOkButton();
            this.moto.AssertCarDetailsCorrect();
            this.moto.Calculate();
            ////this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.ExitEnabled();
            this.moto.Exit1();
            //check premium
            this.moto.HighlightBillingScreen();
            this.moto.AssertMethod1();
            this.moto.CancelBillingScreen();
            this.moto.SelectMenu();
            this.moto.ClickOkButton();
            this.moto.AssertCarDetailsCorrect();
            this.moto.Calculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.PrintQuote();
            this.moto.CheckAutoPrint();
            this.moto.DemandsAndNeeds();
            Playback.Wait(3000);
            this.moto.CloseDemands();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
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
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            const string Premium = "17777.00";
            this.moto.MotoAwap(Premium);
            this.moto.CloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
            this.moto.MotoCheckAWAPpremium(Premium);
            this.moto.OpenTransList(GetTransactionDictionary(Premium));
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            this.SetOfficeRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPolicyPerson();
            this.moto.PostcodeLookup();
            this.moto.QuoteResults();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.ChangePremium();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
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
            //this.moto.CancelFilter();
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
            //this.moto.CancelFilter();
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
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTANoSave();
            this.moto.CloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
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
            this.moto.MotoMTAOpenQuote();
            this.moto.MotoMTACheckNewValue();
            this.moto.CheckCorrectNumberTrans(2);
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
            //this.moto.CancelFilter();
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
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            //this.moto.MotoMTAConfirmPolicy1();
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
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.MotoMTA();
            this.moto.MotoMTAParams.CostOfVehicle = "2500";
            this.moto.MotoMTAAccept();
            this.moto.MtaEffectiveDate("13/10/12");
            this.moto.MotoMTAConfirmDate();
            this.moto.CoverDateBackCheck();
            this.moto.MotoMTACloseMessage();
            this.moto.MtaEffectiveDate();
            this.moto.MotoMTAConfirmDate();
            this.moto.MotoMTAConfirmPolicy();
            //this.moto.MotoMTAConfirmPolicy1();
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
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            this.moto.MotoCloseDetails();
            //Cancel policy
            this.moto.MotoMTA();
            this.moto.MotoCancelPolicy();
            this.moto.MtaEffectiveDate();
            this.moto.MotoCancelPolicy1();
            this.moto.MotoCancelExit();
            this.moto.CloseAndOpenPolicyList();
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
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.AssertSelectPolicyForm();
            this.moto.SelectPolicyQuote();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string premium = this.moto.CheckPolicyPremium();
            this.moto.MotoCloseDetails();
            this.moto.MotoMTA();
            this.moto.MotoCancelPolicy();
            this.moto.MtaEffectiveDate();
            this.moto.MotoCancelPolicy1();
            this.moto.MotoMTAConfirmPolicy();
            this.moto.CloseAndOpenPolicyList();
            this.moto.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            this.moto.MotoCheckPolicyStatus();
            this.moto.CheckPremiumInQuoteDocument(this.docs.DocumentsForMotoNewBusinessCancelAccept);
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            this.SetOurHighwayRegKeys();
            this.TamMotorSteps();
            this.moto.MotoPostcodeLookup();
            this.moto.MotoSearchCar();
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            ////this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
            //mta1
            this.moto.SelectMenu();
            this.moto.MotoMTABefore();

            this.moto.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            this.moto.MotoMTABeforeAccept();
            this.moto.MotoMTAMessageCancelled();
            this.moto.MotoMTABeforeFinish();
            //mta2
            this.moto.SelectMenu();
            this.moto.MotoMTABefore2();
            this.moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
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

            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
            ////MTA1
            this.moto.SelectMenu();
            this.moto.RenewalAfterMTA1();
            this.moto.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.moto.MotoFinishMTA();
            //MTA2
            this.moto.SelectMenu();
            this.moto.RenewalAfterMTA1();
            this.moto.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();
            this.moto.MTACancel();
            //MTA3
            this.moto.SelectMenu();
            this.moto.MotoMTABefore();
            this.moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            this.moto.MotoMTAMessageAfterDate();
            this.moto.MTACloseMessageAfter();

            this.moto.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.moto.MotoMTABeforeAccept();
            this.moto.MotoMTABeforeFinish();
            //mta4
            this.moto.SelectMenu();
            this.moto.MotoMTABefore2();

            this.moto.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.moto.MTAMessageBeforeCurrent();
            this.moto.MTACloseMessageBefore();

            this.moto.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
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

            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(6000);
            this.moto.CloseBrowser();

            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.MotoAmendRisk();
            this.moto.PublicCreditCheckOk();
            this.moto.QuoteSelectListCancel();
            this.moto.AmendSelectQuote();
            this.moto.MotoAmendRiskRenew();
            this.moto.CloseAndOpenPolicyList();
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
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();

            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.MotoAmendRisk();
            this.moto.PublicCreditCheckOk();
            this.moto.CommonParams.SendHomeKeys = "{End}";
            this.moto.AmendSelectQuote();
            this.moto.MotoAmendRiskNew();
            this.moto.RetrieveResponse();
            this.moto.MotoAmendRiskNew1();
            this.moto.CloseAndOpenPolicyList();
            this.moto.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();

            //mta1
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MTADate(DateTime.Now.AddDays(5).ToString("dd/MM/yy"));
            this.moto.AmendDateBeforeMessage();
            this.moto.MTACloseMessageBefore();
            this.moto.MTADate(DateTime.Now.AddDays(12).ToString("dd/MM/yy"));
            this.moto.MotoFinishMTA();

            //mta2
            this.moto.MotoMTA();
            this.moto.MotoMTAAccept();
            this.moto.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
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
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();

            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(false);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.MotoRebroke(false, false);
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeCurrent(false);
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RenewalModuleRenew();
            this.moto.RetrieveResponse();
            this.moto.RenewalModuleRenew1();
            this.moto.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
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
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();

            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();
            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.MotoRebroke(false, false);
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeSelectScheme(this.moto.CommonParams.SendHomeKeys);
            this.moto.RebrokeSelectAlternative();
            this.moto.MotoRebrokeCurrent(false);
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RebrokeAlternativeFinish();
            this.moto.RetrieveResponse();
            this.moto.CancelPrint();
            this.moto.RebrokeAlternativeFinish1();
            this.moto.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
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
            this.moto.MotoInceptionDate();
            this.moto.MotoCalculate();
            //this.moto.CancelFilter();
            this.moto.QuoteResults1();
            this.moto.PublicCreditCheckOk();
            this.moto.MotoSelectHighwayPolicy();
            this.moto.AcceptQuote();
            this.moto.FinishQuote();
            this.moto.CancelPrint();
            this.moto.FinishQuote1();
            this.moto.CloseAndOpenPolicyList();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.moto.OpenBrowser2();
            this.moto.MotoCreateSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.ChangeDatePolicy();
            this.moto.HighlightCustomer();
            string customerCode = this.moto.GetCustomerCode();

            this.moto.RegressApp(customerCode);

            this.moto.RegressAppDate();
            this.moto.RegressAppFinish();
            this.moto.CloseRegressApp();
            this.moto.RenewalLoaderOpen();

            this.moto.RenewalLoaderRun();
            Playback.Wait(5000);
            this.moto.CloseBrowser();
            this.moto.RenewalLoaderClose();
            this.moto.RenewalModuleEDI();
            this.moto.RenewalModuleConfirm();
            this.moto.RenewalModuleEdi1(true);
            this.moto.RenewalModuleFilter(PolicyType);
            this.moto.RenewalModuleSort();
            this.moto.RenewalModuleSort();
            this.moto.RenewalModuleDisplay(this.moto.CommonParams.SendEndKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.moto.CustomerCode);
            this.moto.MotoRebroke(false, false);
            this.moto.PublicCreditCheckOk();
            this.moto.MotoRebrokeSelectScheme(this.moto.CommonParams.SendEndKeys);
            this.moto.RebrokeSelectAlternative();
            this.moto.MotoRebrokeCurrent(false);
            this.moto.RenewalModuleInvite();
            this.moto.RenewConfirmInvite();
            this.moto.RenewalModuleInvite1();
            this.moto.RebrokeAlternativeFinish();
            this.moto.RetrieveResponse();
            this.moto.CancelPrint();
            this.moto.RebrokeAlternativeFinish1();
            this.moto.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.moto.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.moto.RenewalCheckStatus();
            this.moto.ClosePolicy();
        }

        private void TamMotorSteps()
        {
            this.moto.CustomerCode = this.customer.AddPolicy();
            this.moto.SelectMotoPolicy();
            this.moto.SelectMenu();
            this.moto.Links();
        }
    }
}