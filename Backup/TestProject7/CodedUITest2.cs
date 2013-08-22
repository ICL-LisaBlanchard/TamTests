using System;
using System.Threading;
using System.Diagnostics;  
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Linq;
using Meyn.TestLink;

namespace Ver1
{
    /// <summary>
    /// Summary description for CodedUITest2
    /// </summary>
    [CodedUITest]
    public class CodedUITest2
    {
        private const string PlanName = "Ver. 12.05";
        private const string ProjectName = "TAM";

        //private static string buildName = DateTime.Now.Date.ToShortDateString();
        private static string buildName = "InsureTam.exe v4.0.8 May";

        //private const int PlatformId = 3;  // WIN XP
        //private const int PlatformId = 4;   // Win7 32
        private const int PlatformId = 5;   // Win7 64
        private static TestLink tl;
        private static int testPlanId;
        private static int buildId;
        public string TestName;

        public CodedUITest2()
        {
        }

        [TestInitialize]
        public void StartTest()
        {
            TestName = TestContext.TestName;
            TestLinkInitialize();
            UIMap.Login_newParams.UIItemEditSendKeys = Playback.EncryptText("PLUS");
            UIMap.Login_new();
            // can check if pass is incorrect then use another one 
            //WinWindow controls = new WinWindow();
            //controls.SearchProperties[WinWindow.PropertyNames.Name] = "Signon Error";
            //bool t = controls.Exists;
            //if (t)
            //{
            //    UIMap.CloseLogin();
            //    Playback.Wait(2000);
            //    UIMap.Login_newParams.UIItemEditSendKeys = Playback.EncryptText("PSWD");
            //    UIMap.Login_new();
            //}
            UIMap.LoginEnterDateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            UIMap.LoginEnterDateParams.UIItemEditText1 = DateTime.Now.ToString("yyyy");
            UIMap.LoginEnterDateParams.UIItemComboBoxSelectedItem = DateTime.Now.ToString("MMMM");
            UIMap.LoginEnterDate();
            UIMap.WarningOk();
            UIMap.App_startedExpectedValues.UITheAgencyManagerWindow1Name = "The Agency Manager";
        }

       [TestCleanup]
        public void FinishTest()
        {
            try
            {
                if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
                {
                    PostTestResult(TestCaseResultStatus.Fail);
                }
                else
                {
                    PostTestResult(TestCaseResultStatus.Pass);
                }
            }
            catch (Exception)
            {
                // do nothing
            }
            CloseProcess("TamXML7");
            CloseProcess("InsureTam");
            CloseProcess("clntfile");
            CloseProcess("Homebase");
        }

        //[TestMethod]
        public void test1()
        {
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();

        }

        [TestMethod]
        public void MotoCreateQuote()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.AssertSelectPolicyForm();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RecordedMethod1();
            UIMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoSaveQuoteWithoutPremium()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SaveWithoutPremium();
            UIMap.MotoCloseAndOpenPolicyList();
            //check premium
            UIMap.RecordedMethod1();
            UIMap.AssertMethod2();
            UIMap.RecordedMethod4();
            UIMap.SelectMenu();
            UIMap.RecordedMethod4_1();
            UIMap.AssertMethod3();
            UIMap.Calculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.ExitEnabled();
            UIMap.Exit1();
            //check premium
            UIMap.RecordedMethod1();
            UIMap.AssertMethod1();
            UIMap.RecordedMethod4();
            UIMap.SelectMenu();
            UIMap.RecordedMethod4_1();
            UIMap.AssertMethod3();
            UIMap.Calculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.PrintQuote();
            UIMap.CheckAutoPrint();
            UIMap.DemandsAndNeeds();
            Playback.Wait(3000);
            UIMap.CloseDemandsMoto();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RecordedMethod1();
            UIMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoAWAP()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoAWAP();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RecordedMethod1();
            UIMap.MotoCheckAWAPpremium();
        }

        [TestMethod]
        public void MotoOverridePremium()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.AssertSelectPolicyForm();
            UIMap.SelectPolicyQuote();
            UIMap.ChangePremium();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RecordedMethod1();
            UIMap.MotoCheckChangedPremium();
        }

        [TestMethod]
        public void MotoCopyRiskNew()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCopyFinishedRisk();
            UIMap.MotoCopyCheckProposer();
            UIMap.MotoCopyRiskProposerOk();
            UIMap.MotoCopyCheckCar();
            UIMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoCopyRiskQTE()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SaveWithoutPremium();
            UIMap.MotoCopyFinishedRisk();
            UIMap.MotoCopyCheckProposer();
            UIMap.MotoCopyRiskProposerOk();
            UIMap.MotoCopyCheckCar();
            UIMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAExit()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoMTA();
            UIMap.MotoMTANoSave();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RecordedMethod1();
            UIMap.AssertMethod1();
        }

        [TestMethod]
        public void MotoMTAAccept()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoMTA();
            UIMap.MotoMTAAccept();
            UIMap.MotoMTAConfirmDate();
            UIMap.MotoMTAConfirmPolicy();
            UIMap.MotoMTAConfirmPolicy_1();
            UIMap.MotoMTAOpenQuote();
            UIMap.MotoMTACheckNewValue();
            UIMap.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCopyMTA()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoMTA();
            UIMap.MotoMTAAccept();
            UIMap.MotoMTAConfirmDate();
            UIMap.MotoMTAConfirmPolicy();
            UIMap.MotoMTAConfirmPolicy_1();
            UIMap.MotoMTA();
            UIMap.MotoMTAAccept();
            UIMap.MotoMTAConfirmDate();
            UIMap.MotoMTAConfirmPolicy();
            UIMap.MotoMTAConfirmPolicy_1();
            UIMap.MotoCopyFinishedRisk();
            UIMap.MotoCopyCheckProposer();
            UIMap.MotoCopyRiskProposerOk();
            UIMap.MotoMTACheckCar();
            UIMap.MotoCopyRiskExit();
        }

        [TestMethod]
        public void MotoMTAtoMTA()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoMTA();
            UIMap.MotoMTAAcceptParams.UIItemEditText = "2500";
            UIMap.MotoMTAAccept();
            UIMap.MTAEffectiveDateParams.UIItemEditText = "13/10/12";
            UIMap.MTAEffectiveDate();
            UIMap.MotoMTAConfirmDate();
            UIMap.CoverDateBackCheck();
            UIMap.MotoMTACloseMessage();
            UIMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTAEffectiveDate();
            UIMap.MotoMTAConfirmDate();
            UIMap.MotoMTAConfirmPolicy();
            UIMap.MotoMTAConfirmPolicy_1();
            UIMap.MotoMTAOpenQuote();
            UIMap.MotoMTACheckNewValueExpectedValues.UIItemEditText = "2500";
            UIMap.MotoMTACheckNewValue();
            UIMap.MotoExitMTA();
        }

        [TestMethod]
        public void MotoCancelExit()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            //create policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.AssertSelectPolicyForm();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.MotoCloseDetails();
            //Cancel policy
            UIMap.MotoMTA();
            UIMap.MotoCancelPolicy();
            UIMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTAEffectiveDate();
            UIMap.MotoCancelPolicy_1();
            UIMap.MotoCancelExit();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "NEW";
            UIMap.MotoCheckPolicyStatus();
        }
        [TestMethod]
        public void MotoCancelAccept()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPolicyPerson();
            UIMap.PostcodeLookup();
            UIMap.QuoteResults();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.AssertSelectPolicyForm();
            UIMap.SelectPolicyQuote();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.MotoCloseDetails();
            UIMap.MotoMTA();
            UIMap.MotoCancelPolicy();
            UIMap.MTAEffectiveDateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTAEffectiveDate();
            UIMap.MotoCancelPolicy_1();
            UIMap.MotoMTAConfirmPolicy();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.MotoCheckPolicyStatusExpectedValues.UIItemEditText = "CAN";
            UIMap.MotoCheckPolicyStatus();
        }

        [TestMethod]
        public void MotoRenewalBefore()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
           UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); UIMap.RetrieveResponse(); UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            //mta1
            UIMap.SelectMenu();
            UIMap.MotoMTABefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTABeforeAccept();
            UIMap.MotoMTAMessageCancelled();
            UIMap.MotoMTABeforeFinish();
            //mta2
            UIMap.SelectMenu();
            UIMap.MotoMTABefore2();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTACancel();
        }

        [TestMethod]
        public void MotoRenewalAfter()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); UIMap.RetrieveResponse(); UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            ////MTA1
            UIMap.SelectMenu();
            UIMap.RenewalAfterMTA1();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoFinishMTA();
            //MTA2
            UIMap.SelectMenu();
            UIMap.RenewalAfterMTA1();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTACancel();
            //MTA3
            UIMap.SelectMenu();
            UIMap.MotoMTABefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTABeforeAccept();
            UIMap.MotoMTABeforeFinish();
            //mta4
            UIMap.SelectMenu();
            UIMap.MotoMTABefore2();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTACancel();
        }

        [TestMethod]
        public void MotoAmendRiskExistingScheme()
        {
            //change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(6000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.MotoAmendRisk();
            UIMap.PublicCreditCheckOk();
            UIMap.QuoteSelectListCancel();
            UIMap.AmendSelectQuote();
            UIMap.MotoAmendRiskRenew();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoAmendRiskNewScheme()
        {
            //change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.MotoAmendRisk();
            UIMap.PublicCreditCheckOk();
            UIMap.AmendSelectQuoteParams.UIAmendRiskResultsClientSendKeys = "{End}";
            UIMap.AmendSelectQuote();
            UIMap.MotoAmendRiskNew();
            UIMap.RetrieveResponse();
            UIMap.MotoAmendRiskNew_1();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            //mta1
            UIMap.MotoMTA();
            UIMap.MotoMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(5).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.AmendDateBeforeMessage();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(12).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoFinishMTA();
            //mta2
            UIMap.MotoMTA();
            UIMap.MotoMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTACancel();
        }

        [TestMethod]
        public void MotoRebrokeRenewCurrent()
        {
            //change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000); UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000); UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.MotoRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoRebrokeCurrent();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); UIMap.RetrieveResponse(); UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewExistingScheme()
        {
            //change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.MotoRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoRebrokeSelectScheme();
            UIMap.RebrokeSelectAlternative();
            UIMap.MotoRebrokeCurrent();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RebrokeAlternativeFinish();
            UIMap.RetrieveResponse();
            UIMap.CancelPrint();
            UIMap.RebrokeAlternativeFinish_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void MotoRebrokeRenewNewScheme()
        {
            //change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourhighway.reg";
            UIMap.RegistryHighway();
            // add policy
            UIMap.AddPolicy();
            UIMap.SelectMotoPolicy();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.MotoPostcodeLookup();
            UIMap.MotoSearchCar();
            UIMap.MotoInceptionDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.MotoInceptionDate();
            UIMap.MotoCalculate();
            UIMap.CancelFilter();
            UIMap.QuoteResults_1();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoSelectHighwayPolicy();
            UIMap.AcceptQuote();
            UIMap.FinishQuote();
            UIMap.CancelPrint();
            UIMap.FinishQuote1();
            UIMap.MotoCloseAndOpenPolicyList();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            UIMap.OpenBrowser2();
            UIMap.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.MotoCreateSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.MotoRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.MotoRebrokeSelectSchemeParams.UIItemClientSendKeys = "{End}";
            UIMap.MotoRebrokeSelectScheme();
            UIMap.RebrokeSelectAlternative();
            UIMap.MotoRebrokeCurrent();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RebrokeAlternativeFinish();
            UIMap.RetrieveResponse();
            UIMap.CancelPrint();
            UIMap.RebrokeAlternativeFinish_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseCreateQuote()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            UIMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeExitWithoutPolicy();
            UIMap.HomeCloseOpenPolicy();
            UIMap.HomeClickPremium();
            UIMap.HomeCheckZeroPremium();
            UIMap.HomeExitWithPolicy();
            UIMap.HomeCheckPremium();
            UIMap.HomePrintQuote();
            UIMap.SelectMenu();
            UIMap.HomePrintQuote_1();
            UIMap.HomeCheckPrint();
            UIMap.HomeDemands();
            UIMap.CloseDemandsMoto();
            UIMap.HomeAcceptQuote();
            UIMap.CancelPrint();
            UIMap.HomeAcceptQuote_1();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            UIMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeChangePremium();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            UIMap.HomeCheckNewPremium();
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeCopyRisk();
            UIMap.HomeCopyCheckData();
            UIMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeExitWithoutPolicy();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeCopyRisk();
            UIMap.HomeCopyCheckData();
            UIMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTACancel();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTACheckCancelled();
            UIMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.HomeMTACoverDate();
            UIMap.HomeMTASelectQuote();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTACheckChanged();
            UIMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.HomeMTACoverDate();
            UIMap.HomeMTASelectQuote();
            UIMap.HomeCopyRisk();
            UIMap.HomeMTACopyCheck();
            UIMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            // create new policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            //MTA
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.HomeMTACoverDate();
            UIMap.HomeMTASelectQuote();
            //new MTA
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.HomeMTAEnterDateParams.UIItemEditText = "30/09/12";
            UIMap.HomeMTAEnterDate();
            UIMap.HomeMTACoverDate();
            UIMap.HomeMTACheckMessage();
            UIMap.HomeMTACloseMessage();
            UIMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            UIMap.HomeMTAEnterDate();
            UIMap.HomeMTACoverDate();
            UIMap.HomeMTASelectQuote();
            UIMap.HomeOpenQuote();
            UIMap.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            UIMap.HomeMTACheckChanged();
            UIMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            //create policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            //cancel policy
            UIMap.HomeOpenQuote();
            UIMap.HomeCancelPolicy();
            UIMap.HomeCancelPolicyQuote();
            UIMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            UIMap.HomeMTAEnterDate();
            UIMap.HomeCancelPolicyQuote_1();
            UIMap.HomeCancelPolicyExit();
            //check status
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            UIMap.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            UIMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeProposer();
            UIMap.HomeAddressLookup();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            //cancel policy
            UIMap.HomeOpenQuote();
            UIMap.HomeCancelPolicy();
            UIMap.HomeCancelPolicyQuote();
            UIMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            UIMap.HomeMTAEnterDate();
            UIMap.HomeCancelPolicyQuote_1();
            UIMap.HomeCancelPolicyAccept();
            //check status
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            UIMap.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            UIMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
           //  renewal module
            UIMap.RenewalModuleEDI(); 
            UIMap.RenewalModuleConfirm(); 
            UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); 
            UIMap.RetrieveResponse(); 
            UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            //mta1
            UIMap.HomeOpenQuote();
            UIMap.HomeMTABefore();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.HomeRenewalBeforeAccept();
            UIMap.HomeRenewalCancelledCheck();
            UIMap.HomeRenewalBeforeFinish();
            ////mta2
            UIMap.HomeOpenQuote();
            UIMap.HomeRenewalConfirm();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTAEffectiveDatesCancel();
            UIMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); 
            UIMap.RetrieveResponse(); 
            UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            ////MTA1
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAAfter();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.HomeMTASelectQuote();
            //MTA2
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAAfter();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTAEffectiveDatesCancel();
            UIMap.HomeMTACancel1();
            //MTA3
            UIMap.HomeOpenQuote();
            UIMap.HomeMTABefore();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.HomeRenewalBeforeAccept();
            UIMap.HomeRenewalBeforeFinish();
            //mta4
            UIMap.HomeOpenQuote();
            UIMap.HomeRenewalConfirm();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MotoMTAMessageAfterDate();
            UIMap.MTACloseMessageAfter();
            UIMap.MTAEffectiveDatesCancel();
            UIMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); 
            UIMap.RenewalModuleConfirm(); 
            UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.HomeAmendRisk();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeAmendSelecPolicy();
            UIMap.HomeAmendRenew();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.HomeAmendRisk();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys = "{End}";
            UIMap.HomeAmendSelecPolicy();
            UIMap.HomeAmendRenewFinish();
            UIMap.etam_ok();
            UIMap.ConfirmDocuments();
            UIMap.RetrieveResponse();
            UIMap.HomeAmendRenewFinish_1();
            UIMap.etam_ok();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
            //MTA1
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.AmendDateBeforeMessage();
            UIMap.MTACloseMessageBefore();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.HomeMTASelectQuote();
            //MTA2
            UIMap.HomeOpenQuote();
            UIMap.HomeMTAChange();
            UIMap.HomeMTAAccept();
            UIMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            UIMap.MTADate();
            UIMap.MTAMessageBeforeCurrent();
            UIMap.MTACloseMessageBefore();
            UIMap.MTAEffectiveDatesCancel();
            UIMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.HomeRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeRebrokeCurrent();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RenewalModuleRenew(); UIMap.RetrieveResponse(); UIMap.RenewalModuleRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.HomeRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeRebrokeSelectPolicy();
            UIMap.HomeRebrokeSelectAlternative();
            UIMap.HomeRebrokeFinish();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RebrokeAlternativeRenew();
            UIMap.etam_ok();
            UIMap.etam_yes();
            UIMap.ConfirmDocuments();
            UIMap.RetrieveResponse();
            UIMap.RebrokeAlternativeRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.RenewalCheckStatus();
            UIMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            UIMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            UIMap.RegistryHighway();
            //add policy
            UIMap.AddPolicy();
            UIMap.SelectHomeType();
            UIMap.SelectMenu();
            UIMap.Links_1();
            UIMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.HomeStartDate();
            UIMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            UIMap.HomeProposer();
            UIMap.HomeCreatePolicy();
            UIMap.PublicCreditCheckOk(); UIMap.HomeSelectPolicy1();
            UIMap.HomeAcceptPolicy();
            UIMap.HomeFinishQuote();
            UIMap.HomeCloseOpenPolicyList();
            UIMap.HomeOpenPolicy();
            string policyNumber = UIMap.MotoGetPolicyNumber();
            //site for renewal
            UIMap.OpenBrowser2();
            UIMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            UIMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            UIMap.HomeSiteRenewal();
            Playback.Wait(5000);UIMap.CloseBrowser();
            UIMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.ChangeDatePolicy();
            //regress app
            UIMap.HighlightCustomer();
            string customerCode = UIMap.GetCustomerCode();
            UIMap.MotoRegressAppParams.UIItemEditText = customerCode;
            UIMap.MotoRegressApp();
            UIMap.HouseRegressApp();
            UIMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            UIMap.RegressAppDate();
            UIMap.MotoRegressAppFinish();
            UIMap.CloseRegressApp();
            //renewal loader
            UIMap.RenewalLoaderOpen();
            UIMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy"); 
            UIMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            UIMap.RenewalLoaderRun();
            Playback.Wait(5000);
            UIMap.CloseBrowser();
            UIMap.RenewalLoaderClose();
            // renewal module
            UIMap.RenewalModuleEDI(); UIMap.RenewalModuleConfirm(); UIMap.RenewalModuleEDI_1();
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            UIMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            UIMap.RenewalModuleFilterMoto();
            UIMap.RenewalModuleSort();
            UIMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            UIMap.RenewalModuleDisplay();
            UIMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            UIMap.MotoRenewalCheckRecord();
            UIMap.HomeRebroke();
            UIMap.PublicCreditCheckOk();
            UIMap.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys = "{END}";
            UIMap.HomeRebrokeSelectPolicy();
            UIMap.HomeRebrokeSelectAlternative();
            UIMap.HomeRebrokeFinish();
            UIMap.RenewalModuleInvite();
            UIMap.RenewConfirmInvite();
            UIMap.RenewalModuleInvite_1();
            UIMap.RebrokeAlternativeRenew();
            UIMap.etam_ok();
            UIMap.etam_yes();
            UIMap.ConfirmDocuments();
            UIMap.RetrieveResponse();
            UIMap.RebrokeAlternativeRenew_1();
            UIMap.RenewalModuleClose();
            UIMap.MotoCloseAndOpenPolicyList();
            UIMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            UIMap.ClosePolicy();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        protected void PostTestResult(TestCaseResultStatus status)
        {
            try
            {
                tl.ReportTCResult(
                    tl.GetTestCaseIDByName(TestName)[0].id,
                    testPlanId,
                    status,
                    PlatformId,
                    buildid: buildId); // it posts result for testcase.
            }
            catch (Exception ex)
            {
                //
            }
        }

        protected void TestLinkInitialize()
        {
            try
            {
                tl = new TestLink("f71e80e4c23bba99dfedf1b442bb42f5", "http://172.30.2.44/testlink/lib/api/xmlrpc.php");
                testPlanId = tl.getTestPlanByName(ProjectName, PlanName).id;

                if (tl.GetBuildsForTestPlan(testPlanId).FirstOrDefault(x => x.name == buildName) == null)
                {
                    tl.CreateBuild(testPlanId, buildName, "Build created by script");
                }

                buildId = tl.GetBuildsForTestPlan(testPlanId).FirstOrDefault(x => x.name == buildName).id;
            }
            catch (Exception ex)
            {
                //
            }
        }

        public static void CloseProcess(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
        }  

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
