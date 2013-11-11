namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;
    using AppliedSystems.Tam.Ui.Tests.UIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class UIMap
    {
        private MotoCreateSiteRenewalParams mMotoCreateSiteRenewalParams;

        private OpenBrowser2Params mOpenBrowser2Params;

        private AddPolicyParams mAddPolicyParams;

        private AmendDateBeforeMessageExpectedValues mAmendDateBeforeMessageExpectedValues;

        private ExitEnabledExpectedValues mExitEnabledExpectedValues;

        private CoverDateBackCheckExpectedValues mCoverDateBackCheckExpectedValues;

        private CheckAutoPrintExpectedValues mCheckAutoPrintExpectedValues;

        private ChangePremiumParams mChangePremiumParams;

        private AssertSelectPolicyFormExpectedValues mAssertSelectPolicyFormExpectedValues;

        private AssertMethod3ExpectedValues mAssertMethod3ExpectedValues;

        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;

        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;

        private App_startedExpectedValues mAppStartedExpectedValues;

        private CommonParams mCommonParams;

        private SaveWithoutPremiumParams mSaveWithoutPremiumParams;

        private RenewalModuleEDIParams mRenewalModuleEDIParams;

        private RenewalCheckStatusExpectedValues mRenewalCheckStatusExpectedValues;

        private MotoMTAParams mMotoMTAParams;

        private QuoteResultsParams mQuoteResultsParams;

        private PostcodeLookupExpectedValues mPostcodeLookupExpectedValues;

        private MTAMessageBeforeCurrentExpectedValues mMTAMessageBeforeCurrentExpectedValues;

        private HouseholdQuoteParams mHouseholdQuoteParams;

        private VehicleLookupParams mVehicleLookupParams;

        private CancelPolicyParams mCancelPolicyParams;

        private ProposerParams mProposerParams;

        private RegressAppParams mRegressAppParams;

        public string CustomerCode { get; set; }

        public virtual CancelPolicyParams CancelPolicyParams
        {
            get
            {
                if ((this.mCancelPolicyParams == null))
                {
                    this.mCancelPolicyParams = new CancelPolicyParams();
                }
                return this.mCancelPolicyParams;
            }
        }

        public virtual RegressAppParams RegressAppParams
        {
            get
            {
                if ((this.mRegressAppParams == null))
                {
                    this.mRegressAppParams = new RegressAppParams();
                }
                return this.mRegressAppParams;
            }
        }

        public virtual MotoRenewalCheckRecordExpectedValues RenewalCheckRecordExpectedValues
        {
            get
            {
                return new MotoRenewalCheckRecordExpectedValues();
            }
        }

        public virtual MotoCreateSiteRenewalParams MotoCreateSiteRenewalParams
        {
            get
            {
                if ((this.mMotoCreateSiteRenewalParams == null))
                {
                    this.mMotoCreateSiteRenewalParams = new MotoCreateSiteRenewalParams();
                }
                return this.mMotoCreateSiteRenewalParams;
            }
        }

        public virtual OpenBrowser2Params OpenBrowser2Params
        {
            get
            {
                if ((this.mOpenBrowser2Params == null))
                {
                    this.mOpenBrowser2Params = new OpenBrowser2Params();
                }
                return this.mOpenBrowser2Params;
            }
        }

        public virtual AddPolicyParams AddPolicyParams
        {
            get
            {
                if ((this.mAddPolicyParams == null))
                {
                    this.mAddPolicyParams = new AddPolicyParams();
                }
                return this.mAddPolicyParams;
            }
        }

        public virtual AmendDateBeforeMessageExpectedValues AmendDateBeforeMessageExpectedValues
        {
            get
            {
                if ((this.mAmendDateBeforeMessageExpectedValues == null))
                {
                    this.mAmendDateBeforeMessageExpectedValues = new AmendDateBeforeMessageExpectedValues();
                }
                return this.mAmendDateBeforeMessageExpectedValues;
            }
        }

        public virtual ExitEnabledExpectedValues ExitEnabledExpectedValues
        {
            get
            {
                if ((this.mExitEnabledExpectedValues == null))
                {
                    this.mExitEnabledExpectedValues = new ExitEnabledExpectedValues();
                }
                return this.mExitEnabledExpectedValues;
            }
        }

        public virtual CoverDateBackCheckExpectedValues CoverDateBackCheckExpectedValues
        {
            get
            {
                if ((this.mCoverDateBackCheckExpectedValues == null))
                {
                    this.mCoverDateBackCheckExpectedValues = new CoverDateBackCheckExpectedValues();
                }
                return this.mCoverDateBackCheckExpectedValues;
            }
        }

        public virtual CheckAutoPrintExpectedValues CheckAutoPrintExpectedValues
        {
            get
            {
                if ((this.mCheckAutoPrintExpectedValues == null))
                {
                    this.mCheckAutoPrintExpectedValues = new CheckAutoPrintExpectedValues();
                }
                return this.mCheckAutoPrintExpectedValues;
            }
        }

        public virtual ChangePremiumParams ChangePremiumParams
        {
            get
            {
                if ((this.mChangePremiumParams == null))
                {
                    this.mChangePremiumParams = new ChangePremiumParams();
                }
                return this.mChangePremiumParams;
            }
        }

        public virtual AssertSelectPolicyFormExpectedValues AssertSelectPolicyFormExpectedValues
        {
            get
            {
                if ((this.mAssertSelectPolicyFormExpectedValues == null))
                {
                    this.mAssertSelectPolicyFormExpectedValues = new AssertSelectPolicyFormExpectedValues();
                }
                return this.mAssertSelectPolicyFormExpectedValues;
            }
        }

        public virtual AssertMethod3ExpectedValues AssertMethod3ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod3ExpectedValues == null))
                {
                    this.mAssertMethod3ExpectedValues = new AssertMethod3ExpectedValues();
                }
                return this.mAssertMethod3ExpectedValues;
            }
        }

        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }

        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }

        public virtual App_startedExpectedValues AppStartedExpectedValues
        {
            get
            {
                if ((this.mAppStartedExpectedValues == null))
                {
                    this.mAppStartedExpectedValues = new App_startedExpectedValues();
                }
                return this.mAppStartedExpectedValues;
            }
        }

        public virtual CommonParams CommonParams
        {
            get
            {
                if ((this.mCommonParams == null))
                {
                    this.mCommonParams = new CommonParams();
                }
                return this.mCommonParams;
            }
        }

        public virtual SaveWithoutPremiumParams SaveWithoutPremiumParams
        {
            get
            {
                if ((this.mSaveWithoutPremiumParams == null))
                {
                    this.mSaveWithoutPremiumParams = new SaveWithoutPremiumParams();
                }
                return this.mSaveWithoutPremiumParams;
            }
        }

        public virtual RenewalModuleEDIParams RenewalModuleEDIParams
        {
            get
            {
                if ((this.mRenewalModuleEDIParams == null))
                {
                    this.mRenewalModuleEDIParams = new RenewalModuleEDIParams();
                }
                return this.mRenewalModuleEDIParams;
            }
        }

        public virtual RenewalCheckStatusExpectedValues RenewalCheckStatusExpectedValues
        {
            get
            {
                if ((this.mRenewalCheckStatusExpectedValues == null))
                {
                    this.mRenewalCheckStatusExpectedValues = new RenewalCheckStatusExpectedValues();
                }
                return this.mRenewalCheckStatusExpectedValues;
            }
        }

        public virtual MotoMTAParams MotoMTAParams
        {
            get
            {
                if ((this.mMotoMTAParams == null))
                {
                    this.mMotoMTAParams = new MotoMTAParams();
                }
                return this.mMotoMTAParams;
            }
        }

        public virtual QuoteResultsParams QuoteResultsParams
        {
            get
            {
                if ((this.mQuoteResultsParams == null))
                {
                    this.mQuoteResultsParams = new QuoteResultsParams();
                }
                return this.mQuoteResultsParams;
            }
        }

        public virtual PostcodeLookupExpectedValues PostcodeLookupExpectedValues
        {
            get
            {
                if ((this.mPostcodeLookupExpectedValues == null))
                {
                    this.mPostcodeLookupExpectedValues = new PostcodeLookupExpectedValues();
                }
                return this.mPostcodeLookupExpectedValues;
            }
        }

        public virtual ProposerParams ProposerParams
        {
            get
            {
                if ((this.mProposerParams == null))
                {
                    this.mProposerParams = new ProposerParams();
                }
                return this.mProposerParams;
            }
        }

        public virtual MTAMessageBeforeCurrentExpectedValues MTAMessageBeforeCurrentExpectedValues
        {
            get
            {
                if ((this.mMTAMessageBeforeCurrentExpectedValues == null))
                {
                    this.mMTAMessageBeforeCurrentExpectedValues = new MTAMessageBeforeCurrentExpectedValues();
                }
                return this.mMTAMessageBeforeCurrentExpectedValues;
            }
        }

        public virtual HouseholdQuoteParams HouseholdQuoteParams
        {
            get
            {
                if ((this.mHouseholdQuoteParams == null))
                {
                    this.mHouseholdQuoteParams = new HouseholdQuoteParams();
                }
                return this.mHouseholdQuoteParams;
            }
        }

        public virtual SelectTamInsurersAndActivityParams SelectTamInsurersAndActivityParams
        {
            get
            {
                if ((this.mSelectTamInsurersAndActivityParams == null))
                {
                    this.mSelectTamInsurersAndActivityParams = new SelectTamInsurersAndActivityParams();
                }
                return this.mSelectTamInsurersAndActivityParams;
            }
        }

        public virtual VehicleLookupParams VehicleLookupParams
        {
            get
            {
                if ((this.mVehicleLookupParams == null))
                {
                    this.mVehicleLookupParams = new VehicleLookupParams();
                }
                return this.mVehicleLookupParams;
            }
        }

        public TestContext TestContext { get; set; }

        public string MtaEffectiveDate(string withDate = "")
        {
            WinEdit uIMTADate = this.UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinEdit uIMTATime = this.UIMTAEffectiveDatesWindow.UIMTATime.UIItemEdit;

            uIMTADate.Text = String.IsNullOrEmpty(withDate) ? DateTime.Now.AddDays(1).ToString("dd/MM/yy") : withDate;
            return uIMTADate.Text.Replace("/", "_") + "_" + uIMTATime.Text.Replace(":", "");
        }

        public string GetCustomerCode()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UICustomersWindow.UIItemWindow.UIItemEdit;

            return uIItemEdit.GetProperty("Text").ToString();
        }

        public void CloseDemands()
        {
            WinClient uiDemandsNeedsMotorComClient = this.UIDemandsNeedsMotorComWindow.UIDemandsNeedsMotorComClient;
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(uiDemandsNeedsMotorComClient, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void EtamOk(bool continueOnError)
        {
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.ContinueOnError = continueOnError;
            Mouse.Click(uIOKButton1);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void LapseOk()
        {
            WinButton uIOKButton = this.UIPersonalLinesWindow.UIOKWindow.UIOKButton;
            Mouse.Click(uIOKButton);
        }

        public void RenewalCheckRecord(int policyType, string customerCode)
        {
            WinWindow uIauto1871001Window = this.UIAutoPolicyWindow;

            StringAssert.Contains(uIauto1871001Window.Name, String.Format("{0}-{1}001", customerCode, policyType));
        }

        public void QuoteSelectListCancel()
        {
            WinControl uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uICancelButton);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void OpenBrowser()
        {
            WinControl okButXp = this.UIWindowsSecurityWindow1.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;
            WinWindow wXp = this.UIWindowsSecurityWindow1;
            WinControl okBut7 = this.UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            WinWindow w7 = this.UIWindowsSecurityWindow;
            WinControl okBut;
            WinWindow w;

            this.UIInsurEcomSystemMaintWindow.LaunchUrl(new Uri(this.OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl));
            //BrowserWindow.Launch(this.OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl);

            if (w7.Exists)
            {
                okBut = okBut7;
                w = w7;
            }
            else
            {
                okBut = okButXp;
                w = wXp;
            }

            Playback.PlaybackSettings.ContinueOnError = true;

            Keyboard.SendKeys(w, "Bus Sys{Tab}Tottenham1");

            Mouse.Click(okBut, new Point(31, 14));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIRenewalsMaintenanceHyperlink);
        }

        public void CloseBrowser()
        {
            BaseUiTest.CloseProcess("iexplore");
        }

        public void HomeFinishQuote()
        {
            WinControl uILookupButton = this.UIPolicyDetailConfirmationWindow.UILookupWindow.UILookupButton;
            WinControl uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = this.UIPolicyDetailConfirmationWindow.UIConfirmWindow.UIConfirmButton;

            Mouse.Click(uILookupButton);

            Mouse.Click(uIOKButton);

            Mouse.Click(uIConfirmButton);

            this.DeferPrinting();

            this.ImportToTam();

            this.SelectTAMActivities2();
        }

        public void RenewalModuleInvite1()
        {
            this.ConfirmDocuments();

            this.ContinueToRetrieveResponse();

            this.DeferPrinting();

            ImportToTam();

            this.SelectTamInsurersAndActivity(selectListItems1: 0);
        }

        public void AcceptQuote()
        {
            WinControl uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;


            Mouse.Click(this.UIQuoteResultsWindow);
            Mouse.Click(uIAcceptButton);
        }

        public void CancelTestNoPolicyDocsDialog()
        {
            WinButton uIOKButton = this.UIPersonalLinesDialogWindow.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.SearchTimeout = 1000;
            for (int i = 0; i < 10; i++)
            {

                try
                {
                    Process[] pname = Process.GetProcessesByName("splwow64");

                    if (pname.Length == 0)
                    {
                        Mouse.Click(uIOKButton);
                    }

                    BaseUiTest.CloseProcess("splwow64");

                    break;
                }
                catch
                {
                }
            }

            Playback.PlaybackSettings.SearchTimeout = Configs.SearchTimeout;
        }

        public void AmendDateBeforeMessage()
        {
            WinText uIDateBeforeInceptionDText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeInceptionDText;

            Assert.AreEqual(this.AmendDateBeforeMessageExpectedValues.UIDateBeforeInceptionDTextDisplayText, uIDateBeforeInceptionDText.DisplayText);
        }

        public void ExitEnabled()
        {
            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            Assert.AreEqual(this.ExitEnabledExpectedValues.UIExitButtonEnabled, uIExitButton.Enabled);
        }

        public void CloseAndOpenPolicyList(string customerCode)
        {
            WinButton uICancelButton = this.UICustomerListWindow.UINewCustomerDetailWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UICustomerListWindow.UIPoliciesWindow.UIItemButton;
            WinButton uIDetailButton = this.UICustomerListWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UICustomerListWindow.UISearchWindow.UIItemEdit;

            Mouse.Click(uICancelButton);

            uIItemEdit.Text = customerCode;

            Mouse.Click(uIItemButton);

            Mouse.Click(uIDetailButton);
        }

        public void SelectPolicyQuote()
        {
            WinClient uIQuoteResultsClient1 = this.UIQuoteResultsWindow.UIItemWindow.UIClient();
            WinClient uIQuoteResultsClient2 = this.UIQuoteResultsWindow.UIItemWindow2.UIClient();

            try
            {
                Mouse.Click(uIQuoteResultsClient1, new Point(224, 39));
            }
            catch (Exception)
            {
                Mouse.Click(uIQuoteResultsClient2, new Point(224, 39));
            }

            Playback.Wait(1000);

            Mouse.Move(new Point(500, 500));

            Playback.Wait(1000);
        }

        public void FinishQuote(string paymentType)
        {
            WinControl uIConfirmButton = this.UIPolicyDateTimeWindow.UIConfirmWindow.UIConfirmButton;

            this.EtamYes();

            this.PaymentMethod(paymentType);

            this.ConfirmDocuments();

            Mouse.Click(uIConfirmButton);

            this.CancelTestNoPolicyDocsDialog();
        }

        public void CloseOpenPolicyList()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;

            Mouse.Click(uICancelButton);

            Mouse.Click(uIItemButton);
        }

        public void CloseOpenPolicy()
        {
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            this.CloseOpenPolicyList();

            Mouse.Click(uIDetailButton);
        }

        public void Exit1()
        {
            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            Playback.Wait(5000);
            Mouse.Click(uIExitButton);

            this.EtamYes();

            this.ImportToTam();

            this.SelectTAMActivities2();

            this.CloseOpenPolicy();
        }

        public void EtamYes()
        {
            try
            {
                WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

                Mouse.Click(uIYesButton);
            }
            catch
            {
            }
        }

        public void DemandsAndNeeds()
        {
            WinControl uiViewQuoteDetailsWindowOkButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = this.UIQuoteResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            Mouse.Click(uiViewQuoteDetailsWindowOkButton);

            Mouse.Click(uIDemandsNeedsButton);
        }

        public void CoverDateBackCheck()
        {
            WinText uICoverCantBeBackDatedText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UICoverCantBeBackDatedText;

            Assert.AreEqual(this.CoverDateBackCheckExpectedValues.UICoverCantBeBackDatedTextDisplayText, uICoverCantBeBackDatedText.DisplayText);
        }

        public void ConfirmDocuments()
        {
            WinControl uiConfirmDocumentsWindowOkButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uiConfirmDocumentsWindowOkButton);
        }

        public void CloseRegressApp()
        {
            WinControl uIExitButton = this.UIRegressIETamPolicyWindow.UIExitWindow.UIExitButton;

            Mouse.Click(uIExitButton);
        }

        public void PaymentMethod(string type)
        {
            WinControl uIPaymentOkButton = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinRadioButton uIDirectDebitRadioButton = this.UIPaymentMethodsWindow.UIDirectDebitWindow.UIRadioButton("Direct Debit");

            WaitForControl(uIPaymentOkButton);

            if (type == "dd")
            {
                Mouse.Click(uIDirectDebitRadioButton);
            }

            Mouse.Click(uIPaymentOkButton);
        }

        public void ClosePolicy()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton);
        }

        public void CheckAutoPrint()
        {
            HtmlCell uIfordfiestablack16V13Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable.UIFORDFIESTABLACK16V13Cell;

            StringAssert.Contains(uIfordfiestablack16V13Cell.InnerText, this.VehicleLookupParams.CarMake);
        }

        public void ChangePremium(string overridePremium)
        {
            WinControl uIPremiumButton = this.UIQuoteResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIPremiumButton);

            uIItemEdit.Text = overridePremium;

            uIItemEdit1.Text = this.ChangePremiumParams.AuthCode;

            Mouse.Click(uIOKButton);
        }

        public void ChangeDatePolicy()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow3.UIItemEdit;
            WinControl uIOKButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIOKWindow.UIOKButton;

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");

            Mouse.Click(uIOKButton);
        }

        public void CancelPrint()
        {
            for (int i = 0; i < 30; i++)
            {
                Process[] pname = Process.GetProcessesByName("splwow64");

                if (pname.Length > 0)
                {
                    break;
                }
                Thread.Sleep(1000);
            }

            BaseUiTest.CloseProcess("splwow64");
        }

        public void CancelFilter()
        {
            WinControl uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton);

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void Calculate()
        {
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void AssertSelectPolicyForm()
        {
            WinWindow uIQuoteResultsWindow = this.UIQuoteResultsWindow;

            Assert.AreEqual(this.AssertSelectPolicyFormExpectedValues.UIQuoteResultsWindowName, uIQuoteResultsWindow.Name);
        }

        public void AssertCarDetailsCorrect()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(this.AssertMethod3ExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(this.AssertMethod3ExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        public void AssertQuoteCostIsZero()
        {
            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            Mouse.Click(uIItemEdit);

            Assert.AreEqual("0.00", uIItemEdit.Text);
        }

        public void AssertMethod1()
        {
            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            Mouse.Click(uIItemEdit);

            Assert.AreNotEqual("0", uIItemEdit.Text);
        }

        public void AmendSelectQuote()
        {
            WinClient uIAmendRiskResultsClient = this.UIAmendRiskResultsWindow.UIItemWindow.UIClient();

            Mouse.Click(uIAmendRiskResultsClient, new Point(362, 136));

            Keyboard.SendKeys(uIAmendRiskResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);
        }

        public void SelectMotoPolicy()
        {
            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomerListWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            uIItemEdit.Text = this.CommonParams.MotorPolicy;

            Mouse.Click(uIOKButton);
        }

        public void SelectMenu()
        {
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uILinksMenuItem, new Point(68, 6));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(102, 10));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(101, 9));
        }

        public void SelectHomeType()
        {
            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomerListWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            uIItemEdit.Text = this.CommonParams.HomePolicy;

            Mouse.Click(uIOKButton);
        }

        public void SaveWithoutPremium()
        {
            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            Mouse.Click(uIExitButton);

            this.EtamYes();

            this.ImportToTam();

            this.SelectTAMActivities2();
        }

        public void ContinueToRetrieveResponse()
        {
            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;
            Playback.PlaybackSettings.SearchTimeout = 300000;
            try
            {

                Mouse.Click(uIOKButton);
            }
            catch
            {
            }
        }

        public void RenewConfirmInvite()
        {
            WinControl uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton);

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void RenewalModuleSort()
        {
            WinClient uIInsurEtamRenewalsClient = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow12.UIClient();

            Mouse.Click(uIInsurEtamRenewalsClient, new Point(24, 8));
        }

        public void RenewalModuleRenew1()

        {
            try
            {
                this.PaymentMethod("cash");
                this.ConfirmDocuments();
            }
            catch
            {
            }

            this.DeferPrinting();

            this.CancelPrint();

            this.EtamOk(true);

            this.ImportToTam();

            this.SelectTAMActivities3();
        }

        public void RenewalModuleRenew(string paymentType)
        {
            WinControl uIRenewPolicyButton = this.UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;

            Mouse.Click(uIRenewPolicyButton);

            this.PaymentMethod(paymentType);

            Mouse.Click(uIYesButton);

            try
            {
                this.ConfirmDocuments();
            }
            catch
            {
            }
        }

        public void RenewalModuleInvite(bool selectAlternative)
        {
            WinControl uIInviteButton = this.UIAutoPolicyWindow.UIInviteWindow.UIInviteButton;
            WinControl uiYesButton = this.UIPersonalLinesDialogWindow.UIYesWindow.UIYesButton;

            if (selectAlternative)
            {
                Mouse.Click(uiYesButton);
            }

            Mouse.Click(uIInviteButton);
        }

        public void RenewalModuleFilter(string houseOrMoto)
        {
            WinControl uIFilterButton = this.UIInsurEtamWindow.UIQuotesWindow.UIFilterWindow.UIFilterButton;
            WinEdit uIItemEdit = this.UIFilterRenewalRecordsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIFilterRenewalRecordsWindow.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIFilterRenewalRecordsWindow.UIItemWindow2.UIItemComboBox;
            WinControl uIOKButton = this.UIFilterRenewalRecordsWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIFilterButton);

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemEdit1.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemComboBox.SelectedItem = houseOrMoto;

            Mouse.Click(uIOKButton);
        }

        public void RenewalModuleEdi1(bool continueOnError)
        {
            WinControl uIExitButton = this.UIPoliciesAutoRenewedAWindow.UIExitWindow.UIExitButton;
            WinControl uIediMatchButton = this.UIInsurEtamWindow.UIQuotesWindow.UIEDIMatchWindow.UIEDIMatchButton;
            WinControl uiRenewalSearchWindowOkButton = this.UIRenewalSearchWindow.UIOKWindow.UIOKButton;
            WinControl uILogandClearButton = this.UIInsurEtamWindow.UIQuotesWindow.UILogandClearWindow.UILogandClearButton;

            Playback.PlaybackSettings.SearchTimeout = 5000;
            try
            {
                this.EtamOk(true);
                this.EtamOk(true);
            }
            catch
            {
            }

            Playback.PlaybackSettings.SearchTimeout = Configs.SearchTimeout;

            Mouse.Click(uIediMatchButton);

            Mouse.Click(uiRenewalSearchWindowOkButton);

            this.EtamOk(true);

            try
            {
                Mouse.Click(uILogandClearButton);

                this.EtamOk(true);
            }
            catch
            {
            }
        }

        public void RenewalModuleEDI()
        {
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsModuleMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsModuleMenuItem;
            WinEdit uIItemEdit = this.UIIETAMRenewalsWindow.UIItemWindow.UIItemEdit;
            WinControl uiIETamRenewalsWindowOkButton = this.UIIETAMRenewalsWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uILinksMenuItem, new Point(101, 8));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(89, 10));

            Mouse.Click(uIRenewalsModuleMenuItem, new Point(98, 12));

            uIItemEdit.Text = this.RenewalModuleEDIParams.UIItemEditText;

            Mouse.Click(uiIETamRenewalsWindowOkButton);
        }

        public void RenewalModuleDisplay(string keyToSend)
        {
            WinClient uIInsurETAMRenewalsClient = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow10.UIClient();
            WinControl uIDisplayRecordButton = this.UIInsurEtamWindow.UIQuotesWindow.UIDisplayRecordWindow.UIDisplayRecordButton;

            Mouse.Click(uIInsurETAMRenewalsClient, new Point(10, 10));

            Keyboard.SendKeys(uIInsurETAMRenewalsClient, keyToSend, ModifierKeys.None);

            Mouse.Click(uIDisplayRecordButton);
        }

        public void RenewalModuleConfirm()
        {
            WinControl uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

            try
            {
                Mouse.Click(uIOKButton);
            }
            catch
            {
            }
        }

        public void RenewalModuleClose()
        {
            WinControl uIExitButton = this.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;

            Mouse.Click(uIExitButton);

            this.EtamYes();
        }

        public void RenewalLoaderRun()
        {
            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinEdit uIItemEdit = this.UIRenewalLoaderWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIRenewalLoaderWindow.UIItemWindow2.UIItemEdit;
            WinControl uIRunButton = this.UIRenewalLoaderWindow.UIRenewalLoaderClient.UIRunButton;

            Mouse.Click(uIRenewalLoaderTitleBar, new Point(103, 8));

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");

            uIItemEdit1.Text = DateTime.Now.AddDays(8).ToString("dd/MM/yyyy");

            Mouse.Click(uIRunButton);
        }

        public void RenewalLoaderOpen()
        {
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsLoaderMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsLoaderMenuItem;

            Mouse.Click(uIItemButton);

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uILinksMenuItem, new Point(79, 10));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(100, 16));

            Mouse.Click(uIRenewalsLoaderMenuItem, new Point(111, 11));
        }

        public void RenewalLoaderClose()
        {
            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinControl uICloseButton = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar.UICloseButton;

            Mouse.Click(uIRenewalLoaderTitleBar, new Point(89, 11));

            Mouse.Click(uICloseButton);
        }

        public void RenewalCheckStatus(string expectedStatus)
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            Assert.AreEqual(expectedStatus, uIItemEdit.Text);
        }

        public void RenewalAfterMTA1()
        {
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;
            WinControl uIMTAButton = this.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uIOKButton);

            Mouse.Click(uIAfterButton);

            Mouse.Click(uIMTAButton);

            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(39, 17));

            uIItemEdit.Text = this.MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void RegressAppDate()
        {
            WinEdit uIItemEdit = this.UIRegressIETamPolicyWindow.UIItemWindow3.UIItemEdit;

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
        }

        public void RegressAppPolicyTypeSelection(string policyType)
        {
            WinComboBox uIItemComboBox = this.UIRegressIETamPolicyWindow.UIItemWindow4.UIItemComboBox;

            if (policyType == "Motor")
            {
                uIItemComboBox.SelectedItem = "Private Motor";
                return;
            }
            uIItemComboBox.SelectedItem = policyType;
        }

        public void RegressAppFinish()
        {
            WinButton uIRegressButton = this.UIRegressIETamPolicyWindow.UIRegressWindow.UIRegressButton;

            Mouse.Click(uIRegressButton);
        }

        public void ClickOkButton()
        {
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOKButton);
        }

        public void CancelBillingScreen()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton);
        }

        public void HighlightBillingScreen()
        {
            UIBillingScreenWindow uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow;

            Mouse.Click(uIItemEdit, new Point(45, 4));
        }

        public string CheckPolicyPremium(string paymentType)
        {
            WinEdit uIItemEdit;
            switch (paymentType)
            {
                case "dd":
                    uIItemEdit = (WinEdit)this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowDdBilling.GetChildren()[3];
                    Mouse.Click(uIItemEdit);
                    break;
                default:
                    uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
                    break;
            }

            Mouse.Click(uIItemEdit);

            Assert.AreNotEqual("0.00", uIItemEdit.Text);

            return uIItemEdit.Text;
        }

        public void RebrokeSelectAlternative()
        {
            WinControl uISelectAlternativeButton = this.UIRebrokeResultsScreenWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            Mouse.Click(uISelectAlternativeButton);
        }

        public void RebrokeAlternativeRenew1()
        {
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uiImporttoTAMWindowOkButton = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            this.DeferPrinting();

            Playback.Wait(5000);

            this.EtamOk(false);
            this.EtamOk(true);

            this.EtamYes();

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uiImporttoTAMWindowOkButton);

            this.SelectTAMActivities3();
        }

        public void RebrokeAlternativeRenew(string paymentType)
        {
            WinControl uIRenewPolicyButton = this.UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uiInsurerNoticeRevaluaWindowOkButton = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIAcceptButton;
            WinControl uIAcceptButton2 = this.UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;
            WinClient uIRenewalsNewBusinessAClient = paymentType == "cash"
                                                         ? this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIClient()
                                                         : this.UIRenewalsNewBusinessAWindow.UIPolicyListWindow.UIClient();

            Mouse.Click(uIRenewPolicyButton);

            uIAlternativeRadioButton.Selected = this.CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton);

            //this.PaymentMethod(paymentType);

            Mouse.Click(uiInsurerNoticeRevaluaWindowOkButton);

            Playback.Wait(20000);

            Mouse.Click(uIRenewalsNewBusinessAClient, new Point(154, 28));

            Mouse.Move(new Point(500, 500));

            try
            {
                Mouse.Click(uIAcceptButton);
            }
            catch (Exception)
            {
                Mouse.Click(uIAcceptButton2);
            }

            this.CancelTestNoPolicyDocsDialog();
        }

        public void LapsePolicy(string policyNumber)
        {
            string lapseMessage = "Policy -1001. PolicyNo: " + policyNumber + " successfully lapsed.";

            WinButton uILapsePolicyButton = this.UiAutoWindow.UILapsePolicyWindow.UILapsePolicyButton;
            WinButton uIYesButton = this.UIPersonalLinesDialogWindow.UIYesWindow.UIYesButton;
            WinText uIPolicy1001PolicyNo81Text = this.UIPersonalLinesDialogWindow.UIPolicy1001PolicyNo81Window.UIText(lapseMessage);
            WinButton uIOKButton = this.UIPersonalLinesDialogWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uILapsePolicyButton);

            Mouse.Click(uIYesButton);

            Assert.IsTrue(uIPolicy1001PolicyNo81Text.Exists, "Policy lapse text not valid");

            Mouse.Click(uIOKButton);
        }

        public void RebrokeAlternativeFinish1()
        {
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uiImporttoTAMWindowOkButton = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            ConfirmDocuments();
            this.ContinueToRetrieveResponse();
            CancelPrint();

            this.DeferPrinting();

            this.EtamOk(true);
            this.EtamOk(true);

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uiImporttoTAMWindowOkButton);

            this.SelectTAMActivities3();
        }

        public void RebrokeAlternativeFinish(string paymentType)
        {
            WinControl uIRenewPolicyButton = this.UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIItemClient = this.UIRenewalsNewBusinessAWindow.UIPolicyListWindow.UIClient();
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;

            Mouse.Click(uIRenewPolicyButton);

            uIAlternativeRadioButton.Selected = this.CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton);

            //this.PaymentMethod(paymentType);

            Mouse.Click(uIOKButton1, new Point(27, 13));

            Mouse.Click(uIItemClient, new Point(398, 91));

            Keyboard.SendKeys(uIItemClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton);

            this.CancelTestNoPolicyDocsDialog();

            this.EtamYes();

            this.CancelPrint();
        }

        public void PublicCreditCheckOk()
        {
            WinControl uIOKButton = this.UIErrorWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton);
        }

        public void PrintQuote()
        {
            WinControl uIPrintQuoteButton = this.UIQuoteResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            Playback.Wait(2000);
            Mouse.Click(uIPrintQuoteButton);
        }

        public void MTAMessageBeforeCurrent()
        {
            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            Assert.AreEqual(
                this.MTAMessageBeforeCurrentExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText, uIDateBeforeCurrentMTAText.ToString());
        }

        public void MTAEffectiveDatesCancel()
        {
            WinControl uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton);
        }

        public void MTADate(string withDate)
        {
            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinControl uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            uIItemEdit.Text = withDate;

            Mouse.Click(uIOKButton);
        }

        public void MTACancel()
        {
            WinControl uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;
            WinControl uIExitButton = this.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;

            WinControl uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton);

            Mouse.Click(uIExitButton);

            this.EtamYes();

            Mouse.Click(uIOKButton);
        }

        public void Links()
        {
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOKButton);
        }

        public void RegressApp(string customerCode)
        {
            WinEdit uIItemEdit = this.UIRegressIETamPolicyWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIRegressIETamPolicyWindow.UIItemWindow2.UIItemEdit;

            ApplicationUnderTest.Launch(this.RegressAppParams.ExePath, this.RegressAppParams.AlternateExePath);

            uIItemEdit.Text = customerCode;

            uIItemEdit1.Text = this.RegressAppParams.UIItemEditText1;
        }

        public void SelectTamInsurersAndActivity(bool isMTA = false, string whoToSelect = "", bool onlyOnce = false, int selectListItems1 = -1, int selectListItems2 = -1)
        {
            WinControl tamXmlButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            for (int i = 0; i < selectListItems1; i++)
            {
                this.ImportToTamOptionsOnce(whoToSelect);
            }

            Mouse.Click(tamXmlButton);

            for (int i = 0; i < selectListItems2; i++)
            {
                this.ImportToTamOptionsOnce(whoToSelect);
            }

            if (selectListItems2 > -1)
            {
                Mouse.Click(tamXmlButton);
            }
        }

        public void WaitForControl(UITestControl control)
        {
            for (int i = 0; i < 30; i++)
            {
                if (control.Exists)
                {
                    return;
                }
                Thread.Sleep(1000);
            }

            Assert.IsTrue(control.Exists, "Control: " + control.Name + " does not exist");
        }

        public void CheckCorrectNumberTrans(int expected)
        {
            WinButton uIInvoicesButton = this.UIPolicyautotestWindow.UIInvoicesWindow.UIInvoicesButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UITransactionListWindow.UIDetailWindow.UIDetailButton;
            WinButton uICancelButton = this.UIUpdateGeneralTransacWindow.UICancelWindow.UICancelButton;
            WinList uILvwVListList = this.UITransactionListWindow.UILvwVListWindow.UIList("Enter Code");
            WinButton uICloseButton = this.UITransactionListWindow.UICloseWindow.UICloseButton;
            WinButton uiCancelButton2 = this.UIPolicyautotestWindow.UITransactionListWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIInvoicesButton);

            Mouse.Click(uIDetailButton);

            Mouse.Click(uICancelButton);

            Assert.AreEqual(expected, uILvwVListList.Items.Count, "Incorrect number of transactions.");

            Mouse.Click(uICloseButton);

            Mouse.Click(uiCancelButton2);
        }

        public bool OpenTransList(List<Transaction> expectedRows)
        {
            WinButton uIInvoicesButton = this.UIPolicyautotestWindow.UIInvoicesWindow.UIInvoicesButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UITransactionListWindow.UIDetailWindow.UIDetailButton;
            WinButton uICancelButton = this.UIUpdateGeneralTransacWindow.UICancelWindow.UICancelButton;
            WinEdit uILblTranEdit = this.UIUpdateGeneralTransacWindow.UILblTranWindow.UIEdit("Tran");
            WinEdit uILblBalanceEdit = this.UIUpdateGeneralTransacWindow.UILblBalanceWindow.UIEdit("Balance");
            WinButton uICloseButton = this.UITransactionListWindow.UICloseWindow.UICloseButton;
            WinButton uIOKButton = this.UICommissionAdjustmentWindow.UIOKWindow.UIOKButton;
            WinButton uiCancelButton2 = this.UIPolicyautotestWindow.UITransactionListWindow.UICancelWindow.UICancelButton;
            WinList uILvwVListList = this.UITransactionListWindow.UILvwVListWindow.UIList("Enter Code");

            if (expectedRows.Count == 0)
            {
                return false;
            }

            Mouse.Click(uIInvoicesButton);

            WinButton uIYesButton = this.UIPolicyWindow.UIYesWindow.UIYesButton;
            try
            {
                Mouse.Click(uIYesButton);
            }
            catch (Exception)
            {
            }

            Mouse.Click(uIDetailButton);

            Mouse.Click(uICancelButton);

            for (int i = 0; i < uILvwVListList.Items.Count; i++)
            {
                Mouse.DoubleClick(uILvwVListList.Items[i]);
                Transaction trans = expectedRows[i];
                if (trans.TransType == "TAX")
                {
                    Mouse.Click(uIOKButton);
                }
                Assert.AreEqual(trans.TransType, uILblTranEdit.Text.Replace(",", ""));
                Assert.AreEqual(trans.Premium, uILblBalanceEdit.Text.Replace(",", ""));
                Mouse.Click(uICancelButton);
            }

            Mouse.Click(uICloseButton);

            Mouse.Click(uiCancelButton2);

            return true;
        }

        public void CleanDocuments()
        {
            string[] files = Directory.GetFiles(Configs.LocalDocsPath, "*.htm");
            foreach (string file in files)
            {
                File.Delete(file);
            }

            files = Directory.GetFiles(Configs.LocalDocsPath, "*.pdf");
            foreach (string file in files)
            {
                File.Delete(file);
            }
        }

        public void CheckPremiumInQuoteDocument(List<Document> expectedDocs, string paymentType, double overridePremium = 0.00, double originalPremium = 0.00)
        {
            WinClient uIBillingScreenClient = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIPolicyDocumentsWindow.UIClient();
            WinEdit uIItemEdit;
            switch (paymentType)
            {
                case "dd":
                    uIItemEdit = (WinEdit)this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowDdBilling.GetChildren()[3];
                    break;
                default:
                    uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
                    break;
            }

            WinClient uIPolicyAttachmentsClient = this.UIPolicyAttachmentsWindow.UIItemWindow.UIClient();

            WinButton uIDetailButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIDetailButton;
            WinButton uICancelButton2 = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UICancelButton;

            WinEdit checkFileName = this.UIAttachmentDetailWindow.UIItemWindow.UIItemEdit;
            WinButton uICancelButton = this.UIAttachmentDetailWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIItemEdit);
            double premium = Math.Round(Double.Parse(uIItemEdit.Text) * 106) / 100;
            originalPremium = Math.Round(originalPremium * 106) / 100;

            Mouse.DoubleClick(uIBillingScreenClient, new Point(40, 14));

            string filename = String.Empty;
            int fsaCnt = 0;

            for (int i = 21; i < 500; i = i + 17)
            {
                this.CleanDocuments();

                Mouse.Click(uIPolicyAttachmentsClient, new Point(10, i));
                Mouse.Click(uIDetailButton);

                if (filename == checkFileName.Text)
                {
                    Mouse.Click(uICancelButton);
                    break;
                }

                filename = checkFileName.Text;

                IncreaseDocsListCount(expectedDocs, filename);

                Mouse.Click(uICancelButton);

                switch (filename)
                {
                    case "HHQuote":
                        this.CheckPremiumInQuote(premium, originalPremium , true);
                        break;
                    case "Quote":
                        this.CheckPremiumInQuote(premium, originalPremium, false);
                        break;
                    case "Schedule":
                        this.CheckPremiumInPdfProposal(premium, originalPremium);
                        break;
                    case "FSA":
                        this.CheckPremiumInWordDoc(fsaCnt == 0 ? premium : originalPremium);
                        fsaCnt++;
                        break;
                }
            }

            this.CheckDocsList(expectedDocs);
            Mouse.Click(uICancelButton2);
        }

        public void CheckCorrectDocumentPresent(List<Document> expectedDocs)
        {
            WinClient uIBillingScreenClient = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIPolicyDocumentsWindow.UIClient();
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
            WinClient uIPolicyAttachmentsClient = this.UIPolicyAttachmentsWindow.UIItemWindow.UIClient();

            WinButton uIDetailButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIDetailButton;
            WinEdit checkFileName = this.UIAttachmentDetailWindow.UIItemWindow.UIItemEdit;
            WinButton uICancelButton = this.UIAttachmentDetailWindow.UICancelWindow.UICancelButton;
            WinButton uICancelButton2 = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UICancelButton;

            Mouse.Click(uIItemEdit);

            Mouse.DoubleClick(uIBillingScreenClient, new Point(40, 14));

            string filename = String.Empty;
            for (int i = 21; i < 1000; i = i + 17)
            {
                Mouse.Click(uIPolicyAttachmentsClient, new Point(10, i));
                Mouse.Click(uIDetailButton);

                if (filename == checkFileName.Text)
                {
                    Mouse.Click(uICancelButton);
                    break;
                }

                filename = checkFileName.Text;

                IncreaseDocsListCount(expectedDocs, filename);

                Mouse.Click(uICancelButton);
            }

            this.CheckDocsList(expectedDocs);

            Mouse.Click(uICancelButton2);
        }

        public void CheckDocsList(IEnumerable<Document> expectedDocs)
        {
            foreach (Document doc in expectedDocs)
            {
                Assert.IsTrue(
                    doc.ActualCount == doc.ExpectedCount, "Incorrect occurences of " + doc.DocName + ". Expected : " + doc.ExpectedCount + ", actual : " + doc.ActualCount);
            }
        }

        public void CheckPremiumInPdfProposal(double premium, double originalPremium)
        {
            this.OpenAttachment();

            Playback.Wait(2500);

            Keyboard.SendKeys("Q", ModifierKeys.Control);

            string pdfFilePath = Configs.LocalDocsPath + DateTime.Now.Year + DateTime.Now.Month.ToString("00") + "~1.pdf";

            var parser = new PDFParser();

            string text = parser.ExtractText(pdfFilePath).Replace(" ", String.Empty);

            if (text.Contains("Cancellation"))
            {
                Assert.IsTrue(CheckStringForPremium(text, 0 - premium, 0 - originalPremium));
            }
            else
            {
                Assert.IsTrue(CheckStringForPremium(text, premium, originalPremium));
            }

            Playback.Wait(5000);
        }

        public void CreateScreenshot(string expectedDate)
        {
            if (!Directory.Exists(Configs.ScreenshotPath))
            {
                Directory.CreateDirectory(Configs.ScreenshotPath);
            }
            Image image = this.UIInsurEtamWindow.UIQuotesWindow.CaptureImage();
            image.Save(Configs.ScreenshotPath + expectedDate + ".jpg");
        }

        public void ImportToTamOptionsOnce(string whoToSelect)
        {
            WinList uIItemList = this.UISelectTaminsurerforiWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton = this.UISelectTaminsurerforiWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uiTransToInsert = this.UITransactiontoinsertWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton6 = this.UITransactiontoinsertWindow.UIItemWindow.UIOKButton;
            WinList uIItemList2 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton2 = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uIItemList3 = this.UISelectTamActivityTypWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton3 = this.UISelectTamActivityTypWindow.UIItemWindow1.UIClient().UIOKButton;

            int timeout = Playback.PlaybackSettings.SearchTimeout;
            Playback.PlaybackSettings.SearchTimeout = 5000;
            try
            {
                WinWindow win = this.TopWindow;
                string name = win.GetProperty("Name").ToString();
                if (name.Contains("Select Tam insurer for insurer code"))
                {
                    uIItemList.SelectedItemsAsString = uIItemList.Items.First().Name;
                    Mouse.Click(uIOKButton);
                }

                if (name.Contains("Transaction to insert"))
                {
                    uiTransToInsert.SelectedItemsAsString = "NEW";
                    Mouse.Click(uIOKButton6);
                }

                if (name.Contains("Please select WHO to follow up"))
                {
                    uIItemList2.SelectedItemsAsString = uIItemList2.Items.First().Name;

                    Mouse.Click(uIOKButton2);
                }

                if (name.Contains("Select Tam Activity Type"))
                {
                    uIItemList3.SelectedItemsAsString = this.SelectTamInsurersAndActivityParams.UIItemListSelectedItemsAsString;
                    Mouse.Click(uIOKButton3, new Point(27, 8));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
            Playback.PlaybackSettings.SearchTimeout = timeout;
        }

        public string GetPolicyNumber()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            string policyNo = uIItemEdit.GetProperty("Text").ToString();
            Debug.WriteLine("Customer Code : " + this.CustomerCode + ", Policy No: " + policyNo);
            Mouse.Click(uIItemEdit2, new Point(45, 4));

            return policyNo;
        }

        public void AmendedRenewalWindow()
        {
            WinButton uISaveButton = this.UISupercededRenewalInvWindow.UISaveWindow.UISaveButton;
            WinButton uICancelButton = this.UISavetheamendedrenewaWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uISaveButton);

            Mouse.Click(uICancelButton);
        }

        public void DeferPrinting()
        {
            WinCheckBox uIDeferPrintingCheckBox = null;
            WinControl uIOKButton = null;
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    var win = new WinWindow();
                    win.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";

                    string name = win.GetProperty("Name").ToString();

                    bool b = false;
                    switch (name)
                    {
                        case "Point Of Sale":
                            uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
                            uIOKButton = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
                            b = true;
                            break;
                        case "Print Documents":
                            uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
                            uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
                            b = true;
                            break;
                    }

                    if (b)
                    {
                        uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;
                        Mouse.Click(uIOKButton);
                        return;
                    }
                }
                catch (Exception)
                {
                    Playback.Wait(1000);
                }
            }

            try
            {
                uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
                uIOKButton = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
                uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;
                Mouse.Click(uIOKButton);
            }
            catch (Exception)
            {
                uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
                uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
                uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;
                Mouse.Click(uIOKButton);
            }
        }

        protected void ImportToTam()
        {
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton);
        }

        protected void SelectTAMActivities1()
        {
            this.SelectTamInsurersAndActivity(selectListItems1: 1);
        }

        protected void SelectTAMActivities2()
        {
            this.SelectTamInsurersAndActivity(selectListItems1: 2);
        }

        protected void SelectTAMActivities3()
        {
            this.SelectTamInsurersAndActivity(selectListItems1: 3);
        }

        private static void IncreaseDocsListCount(IEnumerable<Document> expectedDocs, string docName)
        {
            foreach (Document doc in expectedDocs.Where(doc => doc.DocName == docName))
            {
                doc.ActualCount++;
                Assert.IsFalse(doc.ActualCount > doc.ExpectedCount, "Too many occurences of " + doc.DocName + ". Expected : " + doc.ExpectedCount + ", actual : " + doc.ActualCount);
                break;
            }
        }

        private static bool CheckStringForPremium(string text, double premium, double originalPremium)
        {
            if (premium <= 0.0 && originalPremium <= 0.0)
            {
                return false;
            }

            return text.Contains(premium.ToString("0.00")) || 
                text.Contains((premium + 0.01).ToString("0.00")) || 
                text.Contains((premium - 0.01).ToString("0.00")) ||
                text.Contains(originalPremium.ToString("0.00")) ||
                text.Contains((originalPremium + 0.01).ToString("0.00")) ||
                text.Contains((originalPremium - 0.01).ToString("0.00")) 
                ;
        }

        private void CheckPremiumInQuote(double premium, double originalPremium, bool isHouse)
        {
            this.OpenAttachment();

            Playback.Wait(5000);
            CloseBrowser();

            string file;
            if (isHouse)
            {
                file = Configs.LocalDocsPath + "HHQuote.htm";
            }
            else
            {
                file = Configs.LocalDocsPath + "Quote.htm";
            }

            string body;
            using (var reader = new StreamReader(file))
            {
                body = reader.ReadToEnd();
            }

            Assert.IsTrue(CheckStringForPremium(body, premium, originalPremium), " Premium : " + premium + ", Original Premium: " + originalPremium + ", Body : " + body);
        }

        private void OpenAttachment()
        {
            WinButton uIOptionsButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIOptionsButton;
            WinButton uIOKButton = this.UIViewAttachmentWindow.UIOKWindow.UIOKButton;
            WinMenuItem uIViewAttachmentMenuItem = this.UIAttachmentsMenuWindow.UIContextMenu.UIMenuItem("View Attachment");
            Mouse.Click(uIOptionsButton);
            Mouse.Click(uIViewAttachmentMenuItem);
            try
            {
                Mouse.Click(uIOKButton);
            }
            catch (Exception)
            {
            }
        }

        private void CheckPremiumInWordDoc(double premium)
        {
            WinButton uIOptionsButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIViewAttachmentMenuItem = this.UIAttachmentsMenuWindow.UIContextMenu.UIMenuItem("View Attachment");
            WinMenuItem uIFindMenuItem = this.UIDemand2docMicrosoftWWindow.UIMenuBarMenuBar.UIEditMenuItem.UIFindMenuItem;
            WinEdit uIFindwhatEdit = this.UIFindandGotoWindow.UIFindandGotoDialog.UIEdit("Find what:");
            WinButton uIFindNextButton = this.UIFindandGotoWindow.UIFindandGotoDialog.UIButton("Find Next");
            WinButton uIOkButton = this.UIMicrosoftOfficeWordVWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = this.UIFindandGotoWindow.UIFindandGotoDialog.UICancelButton;
            WinButton uICloseButton = this.UIDemand2docMicrosoftWWindow.UIDemand2DocMicrosoftWTitleBar.UICloseButton;

            Mouse.Click(uIOptionsButton);
            Mouse.Click(uIViewAttachmentMenuItem);

            Mouse.Click(uIFindMenuItem, new Point(36, 6));

            uIFindwhatEdit.Text = (premium).ToString(CultureInfo.InvariantCulture);

            Mouse.Click(uIFindNextButton);

            bool b;
            try
            {
                b = !this.UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
            }
            catch (Exception)
            {
                b = true;
            }

            if (!b)
            {
                Mouse.Click(uIOkButton);
                uIFindwhatEdit.Text = (premium + 0.01).ToString(CultureInfo.InvariantCulture);

                Mouse.Click(uIFindNextButton);

                int defaultTimeout = Playback.PlaybackSettings.SearchTimeout;
                Playback.PlaybackSettings.SearchTimeout = 1000;
                try
                {
                    b = !this.UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
                }
                catch (Exception)
                {
                    b = true;
                }
                Playback.PlaybackSettings.SearchTimeout = defaultTimeout;
            }

            if (!b)
            {
                Mouse.Click(uIOkButton);
                uIFindwhatEdit.Text = (premium + 0.01).ToString(CultureInfo.InvariantCulture);

                Mouse.Click(uIFindNextButton);

                try
                {
                    b = !this.UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
                }
                catch (Exception)
                {
                    b = true;
                }
            }

            Assert.IsTrue(b);

            Mouse.Click(uICancelButton);

            Mouse.Click(uICloseButton);
        }
    }
}