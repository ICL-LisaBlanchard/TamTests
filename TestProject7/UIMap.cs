namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;

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
                if ((mCancelPolicyParams == null))
                {
                    mCancelPolicyParams = new CancelPolicyParams();
                }
                return mCancelPolicyParams;
            }
        }

        public virtual RegressAppParams RegressAppParams
        {
            get
            {
                if ((mRegressAppParams == null))
                {
                    mRegressAppParams = new RegressAppParams();
                }
                return mRegressAppParams;
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
                if ((mMotoCreateSiteRenewalParams == null))
                {
                    mMotoCreateSiteRenewalParams = new MotoCreateSiteRenewalParams();
                }
                return mMotoCreateSiteRenewalParams;
            }
        }

        public virtual OpenBrowser2Params OpenBrowser2Params
        {
            get
            {
                if ((mOpenBrowser2Params == null))
                {
                    mOpenBrowser2Params = new OpenBrowser2Params();
                }
                return mOpenBrowser2Params;
            }
        }

        public virtual AddPolicyParams AddPolicyParams
        {
            get
            {
                if ((mAddPolicyParams == null))
                {
                    mAddPolicyParams = new AddPolicyParams();
                }
                return mAddPolicyParams;
            }
        }

        public virtual AmendDateBeforeMessageExpectedValues AmendDateBeforeMessageExpectedValues
        {
            get
            {
                if ((mAmendDateBeforeMessageExpectedValues == null))
                {
                    mAmendDateBeforeMessageExpectedValues = new AmendDateBeforeMessageExpectedValues();
                }
                return mAmendDateBeforeMessageExpectedValues;
            }
        }

        public virtual ExitEnabledExpectedValues ExitEnabledExpectedValues
        {
            get
            {
                if ((mExitEnabledExpectedValues == null))
                {
                    mExitEnabledExpectedValues = new ExitEnabledExpectedValues();
                }
                return mExitEnabledExpectedValues;
            }
        }

        public virtual CoverDateBackCheckExpectedValues CoverDateBackCheckExpectedValues
        {
            get
            {
                if ((mCoverDateBackCheckExpectedValues == null))
                {
                    mCoverDateBackCheckExpectedValues = new CoverDateBackCheckExpectedValues();
                }
                return mCoverDateBackCheckExpectedValues;
            }
        }

        public virtual CheckAutoPrintExpectedValues CheckAutoPrintExpectedValues
        {
            get
            {
                if ((mCheckAutoPrintExpectedValues == null))
                {
                    mCheckAutoPrintExpectedValues = new CheckAutoPrintExpectedValues();
                }
                return mCheckAutoPrintExpectedValues;
            }
        }

        public virtual ChangePremiumParams ChangePremiumParams
        {
            get
            {
                if ((mChangePremiumParams == null))
                {
                    mChangePremiumParams = new ChangePremiumParams();
                }
                return mChangePremiumParams;
            }
        }

        public virtual AssertSelectPolicyFormExpectedValues AssertSelectPolicyFormExpectedValues
        {
            get
            {
                if ((mAssertSelectPolicyFormExpectedValues == null))
                {
                    mAssertSelectPolicyFormExpectedValues = new AssertSelectPolicyFormExpectedValues();
                }
                return mAssertSelectPolicyFormExpectedValues;
            }
        }

        public virtual AssertMethod3ExpectedValues AssertMethod3ExpectedValues
        {
            get
            {
                if ((mAssertMethod3ExpectedValues == null))
                {
                    mAssertMethod3ExpectedValues = new AssertMethod3ExpectedValues();
                }
                return mAssertMethod3ExpectedValues;
            }
        }

        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((mAssertMethod2ExpectedValues == null))
                {
                    mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return mAssertMethod2ExpectedValues;
            }
        }

        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((mAssertMethod1ExpectedValues == null))
                {
                    mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return mAssertMethod1ExpectedValues;
            }
        }

        public virtual App_startedExpectedValues AppStartedExpectedValues
        {
            get
            {
                if ((mAppStartedExpectedValues == null))
                {
                    mAppStartedExpectedValues = new App_startedExpectedValues();
                }
                return mAppStartedExpectedValues;
            }
        }

        public virtual CommonParams CommonParams
        {
            get
            {
                if ((mCommonParams == null))
                {
                    mCommonParams = new CommonParams();
                }
                return mCommonParams;
            }
        }

        public virtual SaveWithoutPremiumParams SaveWithoutPremiumParams
        {
            get
            {
                if ((mSaveWithoutPremiumParams == null))
                {
                    mSaveWithoutPremiumParams = new SaveWithoutPremiumParams();
                }
                return mSaveWithoutPremiumParams;
            }
        }

        public virtual RenewalModuleEDIParams RenewalModuleEDIParams
        {
            get
            {
                if ((mRenewalModuleEDIParams == null))
                {
                    mRenewalModuleEDIParams = new RenewalModuleEDIParams();
                }
                return mRenewalModuleEDIParams;
            }
        }

        public virtual RenewalCheckStatusExpectedValues RenewalCheckStatusExpectedValues
        {
            get
            {
                if ((mRenewalCheckStatusExpectedValues == null))
                {
                    mRenewalCheckStatusExpectedValues = new RenewalCheckStatusExpectedValues();
                }
                return mRenewalCheckStatusExpectedValues;
            }
        }

        public virtual MotoMTAParams MotoMTAParams
        {
            get
            {
                if ((mMotoMTAParams == null))
                {
                    mMotoMTAParams = new MotoMTAParams();
                }
                return mMotoMTAParams;
            }
        }

        public virtual QuoteResultsParams QuoteResultsParams
        {
            get
            {
                if ((mQuoteResultsParams == null))
                {
                    mQuoteResultsParams = new QuoteResultsParams();
                }
                return mQuoteResultsParams;
            }
        }

        public virtual PostcodeLookupExpectedValues PostcodeLookupExpectedValues
        {
            get
            {
                if ((mPostcodeLookupExpectedValues == null))
                {
                    mPostcodeLookupExpectedValues = new PostcodeLookupExpectedValues();
                }
                return mPostcodeLookupExpectedValues;
            }
        }

        public virtual ProposerParams ProposerParams
        {
            get
            {
                if ((mProposerParams == null))
                {
                    mProposerParams = new ProposerParams();
                }
                return mProposerParams;
            }
        }

        public virtual MTAMessageBeforeCurrentExpectedValues MTAMessageBeforeCurrentExpectedValues
        {
            get
            {
                if ((mMTAMessageBeforeCurrentExpectedValues == null))
                {
                    mMTAMessageBeforeCurrentExpectedValues = new MTAMessageBeforeCurrentExpectedValues();
                }
                return mMTAMessageBeforeCurrentExpectedValues;
            }
        }

        public virtual HouseholdQuoteParams HouseholdQuoteParams
        {
            get
            {
                if ((mHouseholdQuoteParams == null))
                {
                    mHouseholdQuoteParams = new HouseholdQuoteParams();
                }
                return mHouseholdQuoteParams;
            }
        }

        public virtual SelectTamInsurersAndActivityParams SelectTamInsurersAndActivityParams
        {
            get
            {
                if ((mSelectTamInsurersAndActivityParams == null))
                {
                    mSelectTamInsurersAndActivityParams = new SelectTamInsurersAndActivityParams();
                }
                return mSelectTamInsurersAndActivityParams;
            }
        }

        public virtual VehicleLookupParams VehicleLookupParams
        {
            get
            {
                if ((mVehicleLookupParams == null))
                {
                    mVehicleLookupParams = new VehicleLookupParams();
                }
                return mVehicleLookupParams;
            }
        }

        /// <summary>
        ///     MTAEffectiveDate - Use 'MTAEffectiveDateParams' to pass parameters into this method.
        /// </summary>
        public string MtaEffectiveDate(string withDate = "")
        {
            #region Variable Declarations

            WinEdit uIMTADate = UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinEdit uIMTATime = UIMTAEffectiveDatesWindow.UIMTATime.UIItemEdit;

            #endregion

            uIMTADate.Text = String.IsNullOrEmpty(withDate) ? DateTime.Now.AddDays(1).ToString("dd/MM/yy") : withDate;
            return uIMTADate.Text.Replace("/", "_") + "_" + uIMTATime.Text.Replace(":", "");
        }

        /// <summary>
        ///     _
        ///     GetCustomerCode
        /// </summary>
        public string GetCustomerCode()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIPolicyautotestWindow.UICustomersWindow.UIItemWindow.UIItemEdit;

            #endregion

            return uIItemEdit.GetProperty("Text").ToString();
        }

        /// <summary>
        ///     CloseDemandsMoto
        /// </summary>
        public void CloseDemands()
        {
            #region Variable Declarations

            WinClient uiDemandsNeedsMotorComClient = UIDemandsNeedsMotorComWindow.UIDemandsNeedsMotorComClient;

            #endregion

            // Click 'Close' button
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(uiDemandsNeedsMotorComClient, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void EtamOk()
        {
            WinControl uIOKButton1 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton1, new Point(47, 12));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void LapseOk()
        {
            WinButton uIOKButton = UIPersonalLinesWindow.UIOKWindow.UIOKButton;
            Mouse.Click(uIOKButton, new Point(41, 12));
        }

        /// <summary>
        ///     MotoRenewalCheckRecord - Use 'MotoRenewalCheckRecordExpectedValues' to pass parameters into this method.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="customerCode"></param>
        public void RenewalCheckRecord(int policyType, string customerCode)
        {
            #region Variable Declarations

            WinWindow uIauto1871001Window = this.UIAutoPolicyWindow;

            #endregion

            StringAssert.Contains(uIauto1871001Window.Name, String.Format("{0}-{1}001", customerCode, policyType));
        }

        public void QuoteSelectListCancel()
        {
            WinControl uICancelButton = UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uICancelButton, new Point(14, 18));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     OpenBrowser2 - Use 'OpenBrowser2Params' to pass parameters into this method.
        /// </summary>
        public void OpenBrowser2()
        {
            #region Variable Declarations

            WinControl okButXp = UIWindowsSecurityWindow1.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;
            WinWindow wXp = UIWindowsSecurityWindow1;
            WinControl okBut7 = UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            WinWindow w7 = UIWindowsSecurityWindow;
            WinControl okBut;
            WinWindow w;

            #endregion

            UIInsurEcomSystemMaintWindow.LaunchUrl(new Uri(OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl));

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

        /// <summary>
        ///     CloseBrowser
        /// </summary>
        public void CloseBrowser()
        {
            BaseUiTest.CloseProcess("iexplore");
            //BaseUiTest.CloseProcess("chrome");
            //BaseUiTest.CloseProcess("chrome");
            //BaseUiTest.CloseProcess("chrome");
            //BaseUiTest.CloseProcess("chrome");
        }

        /// <summary>
        ///     HomeFinishQuote - Use 'HomeFinishQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeFinishQuote()
        {
            #region Variable Declarations

            WinControl uILookupButton = UIPolicyDetailConfirmationWindow.UILookupWindow.UILookupButton;
            WinControl uIOKButton = UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = UIPolicyDetailConfirmationWindow.UIConfirmWindow.UIConfirmButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton2 = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton3 = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            #endregion

            Mouse.Click(uILookupButton, new Point(23, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));

            Mouse.Click(uIConfirmButton, new Point(25, 11));

            int timeout = Playback.PlaybackSettings.SearchTimeout;

            Playback.PlaybackSettings.SearchTimeout = 120000;

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Playback.PlaybackSettings.SearchTimeout = timeout;

            Mouse.Click(uIOKButton2, new Point(61, 11));

            Playback.Wait(2000);

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);

            Mouse.Click(uIOKButton3, new Point(51, 10));

            SelectTAMActivities2();
        }

        /// <summary>
        ///     Confirm Docs --> OK
        ///     Defer print -- >
        ///     Import to Tam (only OK button)
        /// </summary>
        public void RenewalModuleInvite1()
        {
            #region Variable Declarations

            WinControl btnConfirmDocs = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl btnDeferPrint = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl btnImportToTam = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            WaitForControl(btnConfirmDocs);
            Mouse.Click(btnConfirmDocs, new Point(50, 16));

            RetrieveResponse();

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(btnDeferPrint);

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(btnImportToTam);

            SelectTamInsurersAndActivity(selectListItems1: 0);
        }

        ///// <summary>
        /////     HighlightCustomer
        ///// </summary>
        //public void HighlightCustomer()
        //{
        //    #region Variable Declarations

        //    WinClient uIcustomersClient = UIPolicyautotestWindow.UICustomersWindow.UIItemWindow1.UIClient();

        //    #endregion

        //    Mouse.Click(uIcustomersClient, new Point(31, 25));
        //    Mouse.Click(uIcustomersClient, new Point(31, 25));
        //}

        public void AcceptQuote()
        {
            #region Variable Declarations

            WinControl uIAcceptButton = UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            #endregion

            Mouse.Click(UIQuoteResultsWindow);
            Mouse.Click(uIAcceptButton);
        }

        public void AmendDateBeforeMessage()
        {
            #region Variable Declarations

            WinText uIDateBeforeInceptionDText = UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeInceptionDText;

            #endregion

            Assert.AreEqual(AmendDateBeforeMessageExpectedValues.UIDateBeforeInceptionDTextDisplayText, uIDateBeforeInceptionDText.DisplayText);
        }

        public void ExitEnabled()
        {
            #region Variable Declarations

            WinControl uIExitButton = UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            #endregion

            Assert.AreEqual(ExitEnabledExpectedValues.UIExitButtonEnabled, uIExitButton.Enabled);
        }

        public void CloseAndOpenPolicyList(string customerCode)
        {
            #region Variable Declarations

            WinButton uICancelButton = this.UICustomerListWindow.UINewCustomerDetailWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UICustomerListWindow.UIPoliciesWindow.UIItemButton;
            WinButton uIDetailButton = this.UICustomerListWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UICustomerListWindow.UISearchWindow.UIItemEdit;

            #endregion

            Mouse.Click(uICancelButton, new Point(31, 15));

            uIItemEdit.Text = customerCode;

            Mouse.Click(uIItemButton, new Point(27, 23));

            Mouse.Click(uIDetailButton, new Point(52, 11));
        }

        public void SelectPolicyQuote()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient1 = UIQuoteResultsWindow.UIItemWindow.UIClient();
            WinClient uIQuoteResultsClient2 = UIQuoteResultsWindow.UIItemWindow2.UIClient();

            #endregion

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

        /// <summary>
        ///     FinishQuote
        /// </summary>
        /// <param name="paymentType"></param>
        public void FinishQuote(string paymentType)
        {
            #region Variable Declarations

            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton1 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = UIPolicyDateTimeWindow.UIConfirmWindow.UIConfirmButton;

            #endregion

            Mouse.Click(uIYesButton);

            PaymentMethod(paymentType);

            Mouse.Click(uIOKButton1, new Point(54, 10));

            Mouse.Click(uIConfirmButton, new Point(37, 24));
        }

        /// <summary>
        ///     Exit1 - Use 'Exit1Params' to pass parameters into this method.
        /// </summary>
        public void Exit1()
        {
            #region Variable Declarations

            WinControl uIExitButton = UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uICancelButton = UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            Playback.Wait(5000);
            Mouse.Click(uIExitButton, new Point(46, 12));

            Mouse.Click(uIYesButton, new Point(39, 9));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(34, 11));

            SelectTAMActivities2();

            Mouse.Click(uICancelButton, new Point(23, 19));

            Mouse.Click(uIItemButton, new Point(19, 14));

            Mouse.Click(uIDetailButton, new Point(44, 15));
        }

        public void EtamYes()
        {
            #region Variable Declarations

            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIYesButton, new Point(42, 12));
        }

        public void DemandsAndNeeds()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = UIQuoteResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(31, 11));

            Mouse.Click(uIDemandsNeedsButton, new Point(47, 12));
        }

        public void CoverDateBackCheck()
        {
            #region Variable Declarations

            WinText uICoverCantBeBackDatedText = UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UICoverCantBeBackDatedText;

            #endregion

            Assert.AreEqual(CoverDateBackCheckExpectedValues.UICoverCantBeBackDatedTextDisplayText, uICoverCantBeBackDatedText.DisplayText);
        }

        public void ConfirmDocuments()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(33, 16));
        }

        public void CloseRegressApp()
        {
            #region Variable Declarations

            WinControl uIExitButton = UIRegressIETamPolicyWindow.UIExitWindow.UIExitButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(35, 20));
        }

        public void PaymentMethod(string type)
        {
            WinControl uIPaymentOkButton = UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinRadioButton uIDirectDebitRadioButton = this.UIPaymentMethodsWindow.UIDirectDebitWindow.UIRadioButton("Direct Debit");

            if (type == "dd")
            {
                Mouse.Click(uIDirectDebitRadioButton);
            }

            Mouse.Click(uIPaymentOkButton);
        }

        public void ClosePolicy()
        {
            #region Variable Declarations

            WinControl uICancelButton = UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(46, 7));
        }

        public void CheckAutoPrint()
        {
            #region Variable Declarations

            HtmlCell uIfordfiestablack16V13Cell = UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable.UIFORDFIESTABLACK16V13Cell;

            #endregion

            StringAssert.Contains(uIfordfiestablack16V13Cell.InnerText, VehicleLookupParams.CarMake);
        }

        public void ChangePremium(string overridePremium)
        {
            #region Variable Declarations

            WinControl uIPremiumButton = UIQuoteResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIPremiumButton, new Point(23, 7));

            uIItemEdit.Text = overridePremium;

            uIItemEdit1.Text = ChangePremiumParams.AuthCode;

            Mouse.Click(uIOKButton, new Point(25, 6));
        }

        public void ChangeDatePolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow3.UIItemEdit;
            WinControl uIOKButton = UIPolicyautotestWindow.UIBillingScreenWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");

            Mouse.Click(uIOKButton, new Point(36, 17));
        }

        public void CancelPrint()
        {
            #region Variable Declarations

            WinTitleBar uISavethefileasTitleBar = UISavethefileasWindow.UISavethefileasTitleBar;
            WinControl uICancelButton = UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uISavethefileasTitleBar, new Point(339, 17));

            Mouse.Click(uICancelButton, new Point(65, 12));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void CancelFilter()
        {
            #region Variable Declarations

            WinControl uICancelButton = UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(42, 8));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void Calculate()
        {
            #region Variable Declarations

            WinControl uICalculateQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uICalculateQuoteButton, new Point(68, 8));
        }

        public void AssertSelectPolicyForm()
        {
            #region Variable Declarations

            WinWindow uIQuoteResultsWindow = UIQuoteResultsWindow;

            #endregion

            Assert.AreEqual(AssertSelectPolicyFormExpectedValues.UIQuoteResultsWindowName, uIQuoteResultsWindow.Name);
        }

        public void AssertCarDetailsCorrect()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(AssertMethod3ExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(AssertMethod3ExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        public void AssertQuoteCostIsZero()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreEqual("0.00", uIItemEdit.Text);
        }

        public void AssertMethod1()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreNotEqual("0", uIItemEdit.Text);
        }

        public void AmendSelectQuote()
        {
            #region Variable Declarations

            WinClient uIAmendRiskResultsClient = UIAmendRiskResultsWindow.UIItemWindow.UIClient();

            #endregion

            Mouse.Click(uIAmendRiskResultsClient, new Point(362, 136));

            Keyboard.SendKeys(uIAmendRiskResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);
        }

        public void SelectMotoPolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomerListWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = CommonParams.MotorPolicy;

            Mouse.Click(uIOKButton, new Point(38, 18));
        }

        public void SelectMenu()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIQuoteSelectListMenuItem =
                UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(37, 10));

            Mouse.Click(uILinksMenuItem, new Point(68, 6));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(102, 10));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(101, 9));
        }

        public void SelectHomeType()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomerListWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomerListWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = CommonParams.HomePolicy;

            Mouse.Click(uIOKButton, new Point(40, 15));
        }

        public void SaveWithoutPremium()
        {
            #region Variable Declarations

            WinControl uIExitButton = UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(34, 18));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(32, 8));

            SelectTAMActivities2();
        }

        public void RetrieveResponse()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIInsurEtamWindow1.UIOKWindow1.UIOKButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(51, 11));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void RenewConfirmInvite()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(54, 7));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleSort
        /// </summary>
        public void RenewalModuleSort()
        {
            #region Variable Declarations

            WinClient uIInsurEtamRenewalsClient = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow12.UIClient();

            #endregion

            Mouse.Click(uIInsurEtamRenewalsClient, new Point(24, 8));
        }

        /// <summary>
        ///     RenewalModuleRenew_1 - Use 'RenewalModuleRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleRenew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIOKButton3 = UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            WinControl uIPaymentOkButton = UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmDocsButton = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            try
            {
                Mouse.Click(uIPaymentOkButton);
                Mouse.Click(uIConfirmDocsButton);
            }
            catch
            {
            }

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(76, 10));

            Mouse.Click(uIOKButton1, new Point(48, 19));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 16));

            Mouse.Click(uIOKButton3, new Point(47, 24));

            SelectTAMActivities2();
        }

        public void RenewalModuleRenew(string paymentType)
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uIOKButton = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(46, 10));

            PaymentMethod(paymentType);

            Mouse.Click(uIYesButton, new Point(55, 14));

            try
            {
                Mouse.Click(uIOKButton, new Point(44, 16));
            }
            catch
            {
            }
        }

        public void RenewalModuleInvite(bool selectAlternative)
        {
            #region Variable Declarations

            WinControl uIInviteButton = this.UIAutoPolicyWindow.UIInviteWindow.UIInviteButton;
            WinControl uiYesButton = UIPersonalLinesDialogWindow.UIYesWindow.UIYesButton;

            #endregion

            if (selectAlternative)
            {
                Mouse.Click(uiYesButton);
            }

            Mouse.Click(uIInviteButton, new Point(75, 8));
        }

        public void RenewalModuleFilter(string houseOrMoto)
        {
            #region Variable Declarations

            WinControl uIFilterButton = UIInsurEtamWindow.UIQuotesWindow.UIFilterWindow.UIFilterButton;
            WinEdit uIItemEdit = UIFilterRenewalRecordsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIFilterRenewalRecordsWindow.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = UIFilterRenewalRecordsWindow.UIItemWindow2.UIItemComboBox;
            WinControl uIOKButton = UIFilterRenewalRecordsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIFilterButton, new Point(40, 11));

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemEdit1.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemComboBox.SelectedItem = houseOrMoto;

            Mouse.Click(uIOKButton, new Point(39, 11));
        }

        public void RenewalModuleEdi1(bool continueOnError)
        {
            #region Variable Declarations

            WinControl uIOKButton = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinControl uIExitButton = UIPoliciesAutoRenewedAWindow.UIExitWindow.UIExitButton;
            WinControl uIediMatchButton = UIInsurEtamWindow.UIQuotesWindow.UIEDIMatchWindow.UIEDIMatchButton;
            WinControl uIOKButton1 = UIRenewalSearchWindow.UIOKWindow.UIOKButton;
            WinControl uILogandClearButton = UIInsurEtamWindow.UIQuotesWindow.UILogandClearWindow.UILogandClearButton;

            #endregion

            if (continueOnError)
            {
                try
                {
                    Mouse.Click(uIOKButton, new Point(36, 13));

                    Mouse.Click(uIExitButton, new Point(33, 11));
                }
                catch
                {
                }
            }

            Mouse.Click(uIediMatchButton, new Point(59, 10));

            Mouse.Click(uIOKButton1, new Point(37, 9));

            Mouse.Click(uIOKButton, new Point(46, 21));

            try
            {
                Mouse.Click(uILogandClearButton, new Point(50, 15));

                Mouse.Click(uIOKButton, new Point(50, 7));
            }
            catch
            {
            }
        }

        /// <summary>
        ///     RenewalModuleEDI - Use 'RenewalModuleEDIParams' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleEDI()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsModuleMenuItem =
                UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsModuleMenuItem;
            WinEdit uIItemEdit = UIIETAMRenewalsWindow.UIItemWindow.UIItemEdit;
            WinControl uIOKButton = UIIETAMRenewalsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(21, 12));

            Mouse.Click(uILinksMenuItem, new Point(101, 8));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(89, 10));

            Mouse.Click(uIRenewalsModuleMenuItem, new Point(98, 12));

            uIItemEdit.Text = RenewalModuleEDIParams.UIItemEditText;

            Mouse.Click(uIOKButton, new Point(31, 10));
        }

        /// <summary>
        ///     RenewalModuleDisplay - Use 'RenewalModuleDisplayParams' to pass parameters into this method.
        /// </summary>
        /// <param name="keyToSend"></param>
        public void RenewalModuleDisplay(string keyToSend)
        {
            #region Variable Declarations

            WinClient uIInsurETAMRenewalsClient = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow10.UIClient();
            WinControl uIDisplayRecordButton = UIInsurEtamWindow.UIQuotesWindow.UIDisplayRecordWindow.UIDisplayRecordButton;

            #endregion

            Mouse.Click(uIInsurETAMRenewalsClient, new Point(10, 10));

            Keyboard.SendKeys(uIInsurETAMRenewalsClient, keyToSend, ModifierKeys.None);

            Mouse.Click(uIDisplayRecordButton, new Point(67, 11));
        }

        /// <summary>
        ///     RenewalModuleConfirm
        /// </summary>
        public void RenewalModuleConfirm()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            try
            {
                Mouse.Click(uIOKButton);
            }
            catch
            {
            }
        }

        /// <summary>
        ///     RenewalModuleClose
        /// </summary>
        public void RenewalModuleClose()
        {
            #region Variable Declarations

            WinControl uIExitButton = UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(44, 19));

            Mouse.Click(uIYesButton, new Point(44, 14));
        }

        /// <summary>
        ///     RenewalLoaderRun - Use 'RenewalLoaderRunParams' to pass parameters into this method.
        /// </summary>
        public void RenewalLoaderRun()
        {
            #region Variable Declarations

            WinTitleBar uIRenewalLoaderTitleBar = UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinEdit uIItemEdit = UIRenewalLoaderWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIRenewalLoaderWindow.UIItemWindow2.UIItemEdit;
            WinControl uIRunButton = UIRenewalLoaderWindow.UIRenewalLoaderClient.UIRunButton;

            #endregion

            Mouse.Click(uIRenewalLoaderTitleBar, new Point(103, 8));

            uIItemEdit.Text = DateTime.Now.ToString("dd/MM/yyyy");

            uIItemEdit1.Text = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");

            Mouse.Click(uIRunButton, new Point(42, 15));
        }

        /// <summary>
        ///     RenewalLoaderOpen
        /// </summary>
        public void RenewalLoaderOpen()
        {
            #region Variable Declarations

            WinControl uIItemButton = UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsLoaderMenuItem =
                UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsLoaderMenuItem;

            #endregion

            Mouse.Click(uIItemButton, new Point(25, 19));

            Mouse.Click(uIOptionsButton, new Point(28, 11));

            Mouse.Click(uILinksMenuItem, new Point(79, 10));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(100, 16));

            Mouse.Click(uIRenewalsLoaderMenuItem, new Point(111, 11));
        }

        /// <summary>
        ///     RenewalLoaderClose
        /// </summary>
        public void RenewalLoaderClose()
        {
            #region Variable Declarations

            WinTitleBar uIRenewalLoaderTitleBar = UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinControl uICloseButton = UIRenewalLoaderWindow.UIRenewalLoaderTitleBar.UICloseButton;

            #endregion

            Mouse.Click(uIRenewalLoaderTitleBar, new Point(89, 11));

            Mouse.Click(uICloseButton, new Point(18, 9));
        }

        /// <summary>
        ///     RenewalCheckStatus - Use 'RenewalCheckStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        /// <param name="expectedStatus"></param>
        public void RenewalCheckStatus(string expectedStatus)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'REN'
            Assert.AreEqual(expectedStatus, uIItemEdit.Text);
        }

        /// <summary>
        ///     RenewalAfterMTA1 - Use 'RenewalAfterMTA1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalAfterMTA1()
        {
            #region Variable Declarations

            WinControl uIOKButton = UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uIAfterButton = UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;
            WinControl uIMTAButton = UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton1 = UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(42, 14));

            Mouse.Click(uIAfterButton, new Point(37, 8));

            Mouse.Click(uIMTAButton, new Point(55, 10));

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(39, 17));

            uIItemEdit.Text = MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton, new Point(71, 13));
        }

        public void RegressAppDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIRegressIETamPolicyWindow.UIItemWindow3.UIItemEdit;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
        }

        public void RegressAppPolicyTypeSelection(string policyType)
        {
            WinComboBox uIItemComboBox = UIRegressIETamPolicyWindow.UIItemWindow4.UIItemComboBox;

            if (policyType == "Motor")
            {
                uIItemComboBox.SelectedItem = "Private Motor";
                return;
            }
            uIItemComboBox.SelectedItem = policyType;
        }

        public void RegressAppFinish()
        {
            #region Variable Declarations

            WinButton uIRegressButton = UIRegressIETamPolicyWindow.UIRegressWindow.UIRegressButton;

            #endregion

            Mouse.Click(uIRegressButton, new Point(47, 22));
        }

        /// <summary>
        ///     RecordedMethod4_1
        /// </summary>
        public void ClickOkButton()
        {
            #region Variable Declarations

            WinControl uIOKButton = UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(23, 9));
        }

        /// <summary>
        ///     RecordedMethod4
        /// </summary>
        public void CancelBillingScreen()
        {
            #region Variable Declarations

            WinControl uICancelButton = UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(40, 13));
        }

        /// <summary>
        ///     RecordedMethod1
        /// </summary>
        public void HighlightBillingScreen()
        {
            #region Variable Declarations

            //WinEdit uIItemEdit = UIPolicyrtyertWindow.UIBillingScreenMotoTestWindow.UIItemWindow.UIItemEdit;
            var uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow;

            #endregion

            // Click text box
            Mouse.Click(uIItemEdit, new Point(45, 4));
        }

        public string CheckPolicyPremium(string paymentType)
        {
            //HighlightBillingScreen();
            WinEdit uIItemEdit;
            switch (paymentType)
            {
                case "dd":
                    uIItemEdit = (WinEdit) UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowDdBilling.GetChildren()[3];
                    Mouse.Click(uIItemEdit);
                    break;
                default:
                    uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
                    break;
            }

            Assert.AreNotEqual("0.00", uIItemEdit.Text);

            return uIItemEdit.Text;
        }

        /// <summary>
        ///     RebrokeSelectAlternative
        /// </summary>
        public void RebrokeSelectAlternative()
        {
            #region Variable Declarations

            WinControl uISelectAlternativeButton = UIRebrokeResultsScreenWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            #endregion

            Mouse.Click(uISelectAlternativeButton, new Point(56, 13));
        }

        /// <summary>
        ///     RebrokeAlternativeRenew_1 - Use 'RebrokeAlternativeRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(63, 21));

            //Check is lapse here.
            Mouse.Click(uIOKButton1, new Point(49, 8));

            Mouse.Click(uIOKButton1, new Point(62, 14));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(44, 7));

            SelectTAMActivities3();
        }

        /// <summary>
        ///     RebrokeAlternativeRenew - Use 'RebrokeAlternativeRenewParams' to pass parameters into this method.
        /// </summary>
        /// <param name="paymentType"></param>
        public void RebrokeAlternativeRenew(string paymentType)
        {

            WinControl uIRenewPolicyButton = this.UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinControl uIAcceptButton = UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton; 

            WinClient uIRenewalsNewBusinessAClient = paymentType == "cash" ? this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIClient() : this.UIRenewalsNewBusinessAWindow.UIPolicyListWindow.UIClient();

            Mouse.Click(uIRenewPolicyButton, new Point(48, 13));

            uIAlternativeRadioButton.Selected = CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(52, 20));

            PaymentMethod(paymentType);

            Mouse.Click(uIOKButton1, new Point(36, 11));

            Mouse.Click(uIRenewalsNewBusinessAClient, new Point(154, 25));

            Mouse.Click(uIAcceptButton, new Point(45, 17));

            CancelPrint();
        }

        public void LapsePolicy(string policyNumber)
        {
            #region Variable Declarations

            string lapseMessage = "Policy -1001. PolicyNo: " + policyNumber + " successfully lapsed.";

            WinButton uILapsePolicyButton = this.UiAutoWindow.UILapsePolicyWindow.UILapsePolicyButton;
            WinButton uIYesButton = UIPersonalLinesDialogWindow.UIYesWindow.UIYesButton;
            WinText uIPolicy1001PolicyNo81Text = UIPersonalLinesDialogWindow.UIPolicy1001PolicyNo81Window.UIText(lapseMessage);
            WinButton uIOKButton = UIPersonalLinesDialogWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uILapsePolicyButton);

            Mouse.Click(uIYesButton);

            Assert.IsTrue(uIPolicy1001PolicyNo81Text.Exists, "Policy lapse text not valid");

            Mouse.Click(uIOKButton);
        }

        public void RebrokeAlternativeFinish1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(75, 12));

            Mouse.Click(uIOKButton1, new Point(50, 6));

            Mouse.Click(uIOKButton1, new Point(58, 13));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 14));

            SelectTAMActivities3();
        }

        /// <summary>
        ///     RebrokeAlternativeFinish - Use 'RebrokeAlternativeFinishParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeFinish()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = UIAutoPolicyWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIItemClient = UIRenewalsNewBusinessAWindow.UIPolicyListWindow.UIClient();
            WinControl uIAcceptButton = UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton2 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(79, 13));

            uIAlternativeRadioButton.Selected = CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(30, 12));

            Mouse.Click(uIOKButton1, new Point(27, 13));

            Mouse.Click(uIItemClient, new Point(398, 91));

            Keyboard.SendKeys(uIItemClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(36, 9));

            CancelPrint();

            Mouse.Click(uIOKButton2, new Point(72, 10));

            CancelPrint();
        }

        public void PublicCreditCheckOk()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIErrorWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(49, 10));
        }

        public void PrintQuote()
        {
            #region Variable Declarations

            WinControl uIPrintQuoteButton = UIQuoteResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            #endregion

            Playback.Wait(2000);
            Mouse.Click(uIPrintQuoteButton, new Point(49, 10));
        }

        public void MTAMessageBeforeCurrent()
        {
            #region Variable Declarations

            WinText uIDateBeforeCurrentMTAText = UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            #endregion

            Assert.AreEqual(
                MTAMessageBeforeCurrentExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText, uIDateBeforeCurrentMTAText.ToString());
        }

        public void MTAEffectiveDatesCancel()
        {
            #region Variable Declarations

            WinControl uICancelButton = UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(28, 12));
        }

        public void MTADate(string withDate)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinControl uIOKButton = UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = withDate;

            Mouse.Click(uIOKButton, new Point(39, 10));
        }

        public void MTACloseMessageBefore()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(52, 12));
        }

        /// <summary>
        ///     MTACloseMessageAfter
        /// </summary>
        public void MTACloseMessageAfter()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(59, 13));
        }

        /// <summary>
        ///     MTACancel
        /// </summary>
        public void MTACancel()
        {
            #region Variable Declarations

            WinControl uICancelButton = UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;
            WinControl uIExitButton = UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton);

            Mouse.Click(uIExitButton);

            Mouse.Click(uIYesButton);

            Mouse.Click(uIOKButton);
        }

        /// <summary>
        ///     Links_1
        /// </summary>
        public void Links()
        {
            #region Variable Declarations

            WinControl uIOKButton = UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(40, 5));
        }

        public void RegressApp(string customerCode)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIRegressIETamPolicyWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIRegressIETamPolicyWindow.UIItemWindow2.UIItemEdit;

            #endregion

            ApplicationUnderTest.Launch(RegressAppParams.ExePath, RegressAppParams.AlternateExePath);

            uIItemEdit.Text = customerCode;

            uIItemEdit1.Text = RegressAppParams.UIItemEditText1;
        }

        public void SelectTamInsurersAndActivity(bool isMTA = false, string whoToSelect = "", bool onlyOnce = false, int selectListItems1 = -1, int selectListItems2 = -1)
        {
            #region Variable Declarations

            WinControl tamXmlButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            for (int i = 0; i < selectListItems1; i++)
            {
                ImportToTamOptionsOnce(whoToSelect);
            }

            Mouse.Click(tamXmlButton);

            for (int i = 0; i < selectListItems2; i++)
            {
                ImportToTamOptionsOnce(whoToSelect);
            }

            if (selectListItems2 > 0)
            {
                Mouse.Click(tamXmlButton);
            }
        }

        public void WaitForControl(UITestControl control)
        {
            int timeout = Playback.PlaybackSettings.SearchTimeout;
            Playback.PlaybackSettings.SearchTimeout = 120000;
            Assert.IsTrue(control.Exists, "Control: " + control.Name + " does not exist");
            Playback.PlaybackSettings.SearchTimeout = timeout;
        }

        public void CheckCorrectNumberTrans(int expected)
        {
            WinButton uIInvoicesButton = UIPolicyautotestWindow.UIInvoicesWindow.UIInvoicesButton;
            WinButton uIDetailButton = UIPolicyautotestWindow.UITransactionListWindow.UIDetailWindow.UIDetailButton;
            WinButton uICancelButton = UIUpdateGeneralTransacWindow.UICancelWindow.UICancelButton;
            WinList uILvwVListList = UITransactionListWindow.UILvwVListWindow.UIList("Enter Code");
            WinButton uICloseButton = UITransactionListWindow.UICloseWindow.UICloseButton;
            WinButton uiCancelButton2 = UIPolicyautotestWindow.UITransactionListWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIInvoicesButton);

            Mouse.Click(uIDetailButton);

            Mouse.Click(uICancelButton);

            Assert.AreEqual(expected, uILvwVListList.Items.Count, "Incorrect number of transactions.");

            Mouse.Click(uICloseButton);

            Mouse.Click(uiCancelButton2);
        }

        public bool OpenTransList(List<Transaction> expectedRows)
        {
            #region Variable Declarations

            WinButton uIInvoicesButton = UIPolicyautotestWindow.UIInvoicesWindow.UIInvoicesButton;
            WinButton uIDetailButton = UIPolicyautotestWindow.UITransactionListWindow.UIDetailWindow.UIDetailButton;
            WinButton uICancelButton = UIUpdateGeneralTransacWindow.UICancelWindow.UICancelButton;
            WinEdit uILblTranEdit = UIUpdateGeneralTransacWindow.UILblTranWindow.UIEdit("Tran");
            WinEdit uILblBalanceEdit = UIUpdateGeneralTransacWindow.UILblBalanceWindow.UIEdit("Balance");
            WinButton uICloseButton = UITransactionListWindow.UICloseWindow.UICloseButton;
            WinButton uIOKButton = UICommissionAdjustmentWindow.UIOKWindow.UIOKButton;
            WinButton uiCancelButton2 = UIPolicyautotestWindow.UITransactionListWindow.UICancelWindow.UICancelButton;
            WinList uILvwVListList = UITransactionListWindow.UILvwVListWindow.UIList("Enter Code");

            #endregion

            if (expectedRows.Count > 0)
            {
                return false;
            }


            Mouse.Click(uIInvoicesButton);

            WinButton uIYesButton = UIPolicyWindow.UIYesWindow.UIYesButton;
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
            WinClient uIBillingScreenClient = UIPolicyautotestWindow.UIBillingScreenWindow.UIPolicyDocumentsWindow.UIClient();
            WinEdit uIItemEdit;
            switch (paymentType)
            {
                case "dd":
                    uIItemEdit = (WinEdit)UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowDdBilling.GetChildren()[3];
                    break;
                default:
                    uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
                    break;
            }

            WinClient uIPolicyAttachmentsClient = UIPolicyAttachmentsWindow.UIItemWindow.UIClient();

            WinButton uIDetailButton = UIPolicyAttachmentsWindow.UIOptionsWindow.UIDetailButton;
            WinButton uICancelButton2 = UIPolicyAttachmentsWindow.UIOptionsWindow.UICancelButton;

            WinEdit checkFileName = UIAttachmentDetailWindow.UIItemWindow.UIItemEdit;
            WinButton uICancelButton = UIAttachmentDetailWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIItemEdit);
            double premium = Math.Round(Double.Parse(uIItemEdit.Text) * 106) / 100;
            originalPremium = Math.Round(originalPremium * 106) / 100;

            Mouse.DoubleClick(uIBillingScreenClient, new Point(40, 14));

            string filename = String.Empty;
            for (int i = 20; i < 300; i = i + 18)
            {
                CleanDocuments();

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
                        if (overridePremium > 0.0)
                        {
                            if (originalPremium > 0.0)
                            {
                                CheckPremiumInQuote(originalPremium, false);
                            }
                            break;
                        }
                        CheckPremiumInQuote(premium, true);
                        break;
                    case "Quote":
                        if (overridePremium > 0.0)
                        {
                            if (originalPremium > 0.0)
                            {
                                CheckPremiumInQuote(originalPremium, false);
                            }
                            break;
                        }
                        CheckPremiumInQuote(premium, false);
                        break;
                    case "Schedule":
                        CheckPremiumInPdfProposal(premium);
                        break;
                    case "FSA":
                        CheckPremiumInWordDoc(premium);
                        premium = originalPremium;
                        break;
                }
            }

            CheckDocsList(expectedDocs);
            Mouse.Click(uICancelButton2);
        }

        public void CheckCorrectDocumentPresent(List<Document> expectedDocs)
        {
            WinClient uIBillingScreenClient = UIPolicyautotestWindow.UIBillingScreenWindow.UIPolicyDocumentsWindow.UIClient();
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;
            WinClient uIPolicyAttachmentsClient = UIPolicyAttachmentsWindow.UIItemWindow.UIClient();

            WinButton uIDetailButton = UIPolicyAttachmentsWindow.UIOptionsWindow.UIDetailButton;
            WinEdit checkFileName = UIAttachmentDetailWindow.UIItemWindow.UIItemEdit;
            WinButton uICancelButton = UIAttachmentDetailWindow.UICancelWindow.UICancelButton;
            WinButton uICancelButton2 = UIPolicyAttachmentsWindow.UIOptionsWindow.UICancelButton;

            Mouse.Click(uIItemEdit);

            Mouse.DoubleClick(uIBillingScreenClient, new Point(40, 14));

            string filename = String.Empty;
            for (int i = 16; i < 1000; i = i + 18)
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

            CheckDocsList(expectedDocs);

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

        public void CheckPremiumInPdfProposal(double premium)
        {
            OpenAttachment();

            Playback.Wait(2500);

            Keyboard.SendKeys("Q", ModifierKeys.Control);

            string pdfFilePath = Configs.LocalDocsPath + DateTime.Now.Year + DateTime.Now.Month.ToString("00") + "~1.pdf";

            var parser = new PDFParser();

            string text = parser.ExtractText(pdfFilePath).Replace(" ", String.Empty);

            if (text.Contains("Cancellation"))
            {
                Assert.IsTrue(CheckStringForPremium(text, 0 - premium));
            }
            else
            {
                Assert.IsTrue(CheckStringForPremium(text, premium));
            }

            Playback.Wait(5000);
        }

        public void CreateScreenshot(string expectedDate)
        {
            if (!Directory.Exists(Configs.ScreenshotPath))
            {
                Directory.CreateDirectory(Configs.ScreenshotPath);
            }
            Image image = UIInsurEtamWindow.UIQuotesWindow.CaptureImage();
            image.Save(Configs.ScreenshotPath + expectedDate + ".jpg");
        }

        public void ImportToTamOptionsOnce(string whoToSelect)
        {
            WinList uIItemList = UISelectTaminsurerforiWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton = UISelectTaminsurerforiWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uiTransToInsert = UITransactiontoinsertWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton6 = UITransactiontoinsertWindow.UIItemWindow.UIOKButton;
            WinList uIItemList2 = UIPleaseselectWHOtofolWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton2 = UIPleaseselectWHOtofolWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uIItemList3 = UISelectTamActivityTypWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton3 = UISelectTamActivityTypWindow.UIItemWindow1.UIClient().UIOKButton;

            try
            {
                WinWindow win = TopWindow;
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
                    uIItemList3.SelectedItemsAsString = SelectTamInsurersAndActivityParams.UIItemListSelectedItemsAsString;
                    Mouse.Click(uIOKButton3, new Point(27, 8));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public string GetPolicyNumber()
        {
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            string policyNo = uIItemEdit.GetProperty("Text").ToString();
            Debug.WriteLine("Customer Code : " + CustomerCode + ", Policy No: " + policyNo);
            Mouse.Click(uIItemEdit2, new Point(45, 4));

            return policyNo;
        }

        public void AmendedRenewalWindow()
        {
            WinButton uISaveButton = this.UISupercededRenewalInvWindow.UISaveWindow.UISaveButton;
            WinButton uICancelButton = this.UISavetheamendedrenewaWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uISaveButton, new Point(43, 13));

            Mouse.Click(uICancelButton, new Point(34, 16));
        }

        protected void SelectTAMActivities1()
        {
            SelectTamInsurersAndActivity(selectListItems1: 1);
        }

        protected void SelectTAMActivities2()
        {
            SelectTamInsurersAndActivity(selectListItems1: 2);
        }

        protected void SelectTAMActivities3()
        {
            SelectTamInsurersAndActivity(selectListItems1: 3);
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

        private static bool CheckStringForPremium(string text, double premium)
        {
            return text.Contains(premium.ToString("0.00")) || text.Contains((premium + 0.01).ToString("0.00")) || text.Contains((premium - 0.01).ToString("0.00"));
        }

        private void CheckPremiumInQuote(double premium, bool isHouse)
        {
            OpenAttachment();

            Playback.Wait(5000);
            Keyboard.SendKeys("Q", ModifierKeys.Control);

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

            Assert.IsTrue(CheckStringForPremium(body, premium), " Premium : " + premium + ", Body : " + body);
        }

        private void OpenAttachment()
        {
            WinButton uIOptionsButton = UIPolicyAttachmentsWindow.UIOptionsWindow.UIOptionsButton;
            WinButton uIOKButton = UIViewAttachmentWindow.UIOKWindow.UIOKButton;
            WinMenuItem uIViewAttachmentMenuItem = UIAttachmentsMenuWindow.UIContextMenu.UIMenuItem("View Attachment");
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
            WinButton uIOptionsButton = UIPolicyAttachmentsWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIViewAttachmentMenuItem = UIAttachmentsMenuWindow.UIContextMenu.UIMenuItem("View Attachment");
            WinMenuItem uIFindMenuItem = UIDemand2docMicrosoftWWindow.UIMenuBarMenuBar.UIEditMenuItem.UIFindMenuItem;
            WinEdit uIFindwhatEdit = UIFindandGotoWindow.UIFindandGotoDialog.UIEdit("Find what:");
            WinButton uIFindNextButton = UIFindandGotoWindow.UIFindandGotoDialog.UIButton("Find Next");
            WinButton uIOkButton = UIMicrosoftOfficeWordVWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = UIFindandGotoWindow.UIFindandGotoDialog.UICancelButton;
            WinButton uICloseButton = UIDemand2docMicrosoftWWindow.UIDemand2DocMicrosoftWTitleBar.UICloseButton;

            Mouse.Click(uIOptionsButton);
            Mouse.Click(uIViewAttachmentMenuItem);

            Mouse.Click(uIFindMenuItem, new Point(36, 6));

            uIFindwhatEdit.Text = (premium).ToString(CultureInfo.InvariantCulture);

            Mouse.Click(uIFindNextButton, new Point(28, 14));

            bool b;
            try
            {
                b = !UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
            }
            catch (Exception)
            {
                b = true;
            }

            if (!b)
            {
                Mouse.Click(uIOkButton);
                uIFindwhatEdit.Text = (premium + 0.01).ToString(CultureInfo.InvariantCulture);

                Mouse.Click(uIFindNextButton, new Point(28, 14));

                try
                {
                    b = !UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
                }
                catch (Exception)
                {
                    b = true;
                }
            }

            if (!b)
            {
                Mouse.Click(uIOkButton);
                uIFindwhatEdit.Text = (premium + 0.01).ToString(CultureInfo.InvariantCulture);

                Mouse.Click(uIFindNextButton, new Point(28, 14));

                try
                {
                    b = !UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
                }
                catch (Exception)
                {
                    b = true;
                }
            }

            Assert.IsTrue(b);

            Mouse.Click(uICancelButton, new Point(50, 15));

            Mouse.Click(uICloseButton, new Point(22, 8));
        }
    }
}