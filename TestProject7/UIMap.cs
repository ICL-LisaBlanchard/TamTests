namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Globalization;
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

        /// <summary>
        ///     MTAEffectiveDate - Use 'MTAEffectiveDateParams' to pass parameters into this method.
        /// </summary>
        /// <param name="withDate"></param>
        public void MtaEffectiveDate(string withDate = "")
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;

            #endregion

            if (string.IsNullOrEmpty(withDate))
            {
                uIItemEdit.Text = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            }
            else
            {
                uIItemEdit.Text = withDate;
            }
        }

        /// <summary>
        ///     _
        ///     GetCustomerCode
        /// </summary>
        public string GetCustomerCode()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UICustomersWindow.UIItemWindow.UIItemEdit;

            #endregion

            return uIItemEdit.GetProperty("Text").ToString();
        }

        /// <summary>
        ///     CloseDemandsMoto
        /// </summary>
        public void CloseDemands()
        {
            #region Variable Declarations

            WinClient uiDemandsNeedsMotorComClient = this.UIDemandsNeedsMotorComWindow.UIDemandsNeedsMotorComClient;

            #endregion

            // Click 'Close' button
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(uiDemandsNeedsMotorComClient, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void EtamOk()
        {
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton1, new Point(47, 12));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     MotoRenewalCheckRecord - Use 'MotoRenewalCheckRecordExpectedValues' to pass parameters into this method.
        /// </summary>
        /// <param name="policyType"></param>
        /// <param name="customerCode"></param>
        public void RenewalCheckRecord(int policyType, string customerCode)
        {
            #region Variable Declarations

            WinWindow uIauto1871001Window = this.UIAUTO1871001Window;

            #endregion

            StringAssert.Contains(uIauto1871001Window.Name, string.Format("{0}-{1}001", customerCode, policyType));
        }

        public void QuoteSelectListCancel()
        {
            WinControl uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
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

            WinControl okButXp = this.UIWindowsSecurityWindow1.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;
            WinWindow wXp = this.UIWindowsSecurityWindow1;
            WinControl okBut7 = this.UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            WinWindow w7 = this.UIWindowsSecurityWindow;
            WinControl okBut;
            WinWindow w;

            #endregion

            this.UIInsurEcomSystemMaintWindow.LaunchUrl(new Uri(this.OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl));

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
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(this.UIBlankPageMicrosoftInWindow, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     HomeFinishQuote - Use 'HomeFinishQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeFinishQuote()
        {
            #region Variable Declarations

            WinControl uILookupButton = this.UIPolicyDetailConfirmationWindow.UILookupWindow.UILookupButton;
            WinControl uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = this.UIPolicyDetailConfirmationWindow.UIConfirmWindow.UIConfirmButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton3 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            #endregion

            Mouse.Click(uILookupButton, new Point(23, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));

            Mouse.Click(uIConfirmButton, new Point(25, 11));

            int timeout = Playback.PlaybackSettings.SearchTimeout;

            Playback.PlaybackSettings.SearchTimeout = 120000;

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Playback.PlaybackSettings.SearchTimeout = timeout;

            Mouse.Click(uIOKButton2, new Point(61, 11));

            Playback.Wait(2000);

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);

            Mouse.Click(uIOKButton3, new Point(51, 10));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     RenewalModuleInvite_1 - Use 'RenewalModuleInvite_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleInvite1()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            this.WaitForControl(uIOKButton);
            Mouse.Click(uIOKButton, new Point(50, 16));

            this.RetrieveResponse();

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(72, 10));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(24, 12));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     HighlightCustomer
        /// </summary>
        public void HighlightCustomer()
        {
            #region Variable Declarations

            WinClient uIcustomersClient = this.UIPolicyautotestWindow.UICustomersWindow.UIItemWindow1.UIClient();

            #endregion

            Mouse.Click(uIcustomersClient, new Point(31, 25));
            Mouse.Click(uIcustomersClient, new Point(31, 25));
        }

        /// <summary>
        ///     AcceptQuote
        /// </summary>
        public void AcceptQuote()
        {
            #region Variable Declarations

            WinControl uIAcceptButton = this.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            #endregion

            Playback.Wait(3000);
            Mouse.Click(uIAcceptButton, new Point(70, 7));
        }

        /// <summary>
        ///     AmendDateBeforeMessage - Use 'AmendDateBeforeMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AmendDateBeforeMessage()
        {
            #region Variable Declarations

            WinText uIDateBeforeInceptionDText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeInceptionDText;

            #endregion

            Assert.AreEqual(this.AmendDateBeforeMessageExpectedValues.UIDateBeforeInceptionDTextDisplayText, uIDateBeforeInceptionDText.DisplayText);
        }

        /// <summary>
        ///     ExitEnabled - Use 'ExitEnabledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ExitEnabled()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            #endregion

            Assert.AreEqual(this.ExitEnabledExpectedValues.UIExitButtonEnabled, uIExitButton.Enabled);
        }

        /// <summary>
        ///     FinishQuote1 - Use 'FinishQuote1Params' to pass parameters into this method.
        /// </summary>
        public void FinishQuote1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uIOKButton2 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(51, 7));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);
            Mouse.Click(uIOKButton1, new Point(41, 15));

            Mouse.Click(uIOKButton2, new Point(42, 14));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     SelectPolicyQuote - Use 'SelectPolicyQuoteParams' to pass parameters into this method.
        /// </summary>
        public void SelectPolicyQuote()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIClient();

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(295, 127));

            Mouse.Move(new Point(500, 500));
        }

        /// <summary>
        ///     FinishQuote
        /// </summary>
        public void FinishQuote()
        {
            #region Variable Declarations

            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = this.UIPolicyDateTimeWindow.UIConfirmWindow.UIConfirmButton;

            #endregion

            Mouse.Click(uIYesButton, new Point(35, 8));

            Mouse.Click(uIOKButton, new Point(40, 10));

            Mouse.Click(uIOKButton1, new Point(54, 10));

            Mouse.Click(uIConfirmButton, new Point(37, 24));
        }

        /// <summary>
        ///     Exit1 - Use 'Exit1Params' to pass parameters into this method.
        /// </summary>
        public void Exit1()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            Playback.Wait(5000);
            Mouse.Click(uIExitButton, new Point(46, 12));

            Mouse.Click(uIYesButton, new Point(39, 9));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(34, 11));

            this.SelectTamInsurersAndActivity(false);

            Mouse.Click(uICancelButton, new Point(23, 19));

            Mouse.Click(uIItemButton, new Point(19, 14));

            Mouse.Click(uIDetailButton, new Point(44, 15));
        }

        /// <summary>
        ///     etam_yes
        /// </summary>
        public void EtamYes()
        {
            #region Variable Declarations

            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIYesButton, new Point(42, 12));
        }

        /// <summary>
        ///     DemandsAndNeeds
        /// </summary>
        public void DemandsAndNeeds()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = this.UIQuoteResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(31, 11));

            Mouse.Click(uIDemandsNeedsButton, new Point(47, 12));
        }

        /// <summary>
        ///     CoverDateBackCheck - Use 'CoverDateBackCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void CoverDateBackCheck()
        {
            #region Variable Declarations

            WinText uICoverCantBeBackDatedText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UICoverCantBeBackDatedText;

            #endregion

            Assert.AreEqual(this.CoverDateBackCheckExpectedValues.UICoverCantBeBackDatedTextDisplayText, uICoverCantBeBackDatedText.DisplayText);
        }

        /// <summary>
        ///     ConfirmDocuments
        /// </summary>
        public void ConfirmDocuments()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(33, 16));
        }

        /// <summary>
        ///     CloseRegressApp
        /// </summary>
        public void CloseRegressApp()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIRegressIETamPolicyWindow.UIExitWindow.UIExitButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(35, 20));
        }

        /// <summary>
        ///     ClosePolicy
        /// </summary>
        public void ClosePolicy()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(46, 7));
        }

        /// <summary>
        ///     CheckAutoPrint - Use 'CheckAutoPrintExpectedValues' to pass parameters into this method.
        /// </summary>
        public void CheckAutoPrint()
        {
            #region Variable Declarations

            HtmlCell uIfordfiestablack16V13Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable.UIFORDFIESTABLACK16V13Cell;

            #endregion

            StringAssert.Contains(uIfordfiestablack16V13Cell.InnerText, this.VehicleLookupParams.CarMake);
        }

        /// <summary>
        ///     ChangePremium - Use 'ChangePremiumParams' to pass parameters into this method.
        /// </summary>
        public void ChangePremium()
        {
            #region Variable Declarations

            WinControl uIPremiumButton = this.UIQuoteResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIPremiumButton, new Point(23, 7));

            uIItemEdit.Text = this.ChangePremiumParams.BrokerPremium;

            uIItemEdit1.Text = this.ChangePremiumParams.AuthCode;

            Mouse.Click(uIOKButton, new Point(25, 6));
        }

        /// <summary>
        ///     ChangeDatePolicy - Use 'ChangeDatePolicyParams' to pass parameters into this method.
        /// </summary>
        public void ChangeDatePolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow3.UIItemEdit;
            WinControl uIOKButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");

            Mouse.Click(uIOKButton, new Point(36, 17));
        }

        /// <summary>
        ///     CancelPrint
        /// </summary>
        public void CancelPrint()
        {
            #region Variable Declarations

            WinTitleBar uISavethefileasTitleBar = this.UISavethefileasWindow.UISavethefileasTitleBar;
            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uISavethefileasTitleBar, new Point(339, 17));

            Mouse.Click(uICancelButton, new Point(65, 12));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     CancelFilter
        /// </summary>
        public void CancelFilter()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(42, 8));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     Calculate
        /// </summary>
        public void Calculate()
        {
            #region Variable Declarations

            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uICalculateQuoteButton, new Point(68, 8));
        }

        /// <summary>
        ///     AssertSelectPolicyForm - Use 'AssertSelectPolicyFormExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertSelectPolicyForm()
        {
            #region Variable Declarations

            WinWindow uIQuoteResultsWindow = this.UIQuoteResultsWindow;

            #endregion

            Assert.AreEqual(this.AssertSelectPolicyFormExpectedValues.UIQuoteResultsWindowName, uIQuoteResultsWindow.Name);
        }

        /// <summary>
        ///     AssertMethod3 - Use 'AssertMethod3ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertCarDetailsCorrect()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.AssertMethod3ExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(this.AssertMethod3ExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        /// <summary>
        ///     AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertQuoteCostIsZero()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreEqual("0", uIItemEdit.Text);
        }

        /// <summary>
        ///     AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreNotEqual("0", uIItemEdit.Text);
        }

        /// <summary>
        ///     AmendSelectQuote - Use 'AmendSelectQuoteParams' to pass parameters into this method.
        /// </summary>
        public void AmendSelectQuote()
        {
            #region Variable Declarations

            WinClient uIAmendRiskResultsClient = this.UIAmendRiskResultsWindow.UIItemWindow.UIClient();

            #endregion

            Mouse.Click(uIAmendRiskResultsClient, new Point(362, 136));

            Keyboard.SendKeys(uIAmendRiskResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     SelectMotoPolicy - Use 'SelectMotoPolicyParams' to pass parameters into this method.
        /// </summary>
        public void SelectMotoPolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = this.CommonParams.MotorPolicy;

            Mouse.Click(uIOKButton, new Point(38, 18));
        }

        /// <summary>
        ///     SelectMenu
        /// </summary>
        public void SelectMenu()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(37, 10));

            Mouse.Click(uILinksMenuItem, new Point(68, 6));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(102, 10));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(101, 9));
        }

        /// <summary>
        ///     SelectHomeType - Use 'SelectHomeTypeParams' to pass parameters into this method.
        /// </summary>
        public void SelectHomeType()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = this.CommonParams.HomePolicy;

            Mouse.Click(uIOKButton, new Point(40, 15));
        }

        /// <summary>
        ///     SaveWithoutPremium - Use 'SaveWithoutPremiumParams' to pass parameters into this method.
        /// </summary>
        public void SaveWithoutPremium()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(34, 18));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(32, 8));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     RetrieveResponse
        /// </summary>
        public void RetrieveResponse()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(51, 11));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewConfirmInvite
        /// </summary>
        public void RenewConfirmInvite()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

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

            WinClient uIInsurEtamRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow12.UIClient();

            #endregion

            Mouse.Click(uIInsurEtamRenewalsClient, new Point(24, 8));
        }

        /// <summary>
        ///     RenewalModuleRenew_1 - Use 'RenewalModuleRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleRenew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(76, 10));

            Mouse.Click(uIOKButton1, new Point(48, 19));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 16));

            Mouse.Click(uIOKButton3, new Point(47, 24));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     RenewalModuleRenew
        /// </summary>
        public void RenewalModuleRenew()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIAUTO1871001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(46, 10));

            Mouse.Click(uIYesButton, new Point(55, 14));

            Mouse.Click(uIOKButton, new Point(44, 16));
        }

        /// <summary>
        ///     RenewalModuleInvite
        /// </summary>
        public void RenewalModuleInvite()
        {
            #region Variable Declarations

            WinControl uIInviteButton = this.UIAUTO1871001Window.UIInviteWindow.UIInviteButton;

            #endregion

            // Click '&Invite' button
            Mouse.Click(uIInviteButton, new Point(75, 8));
        }

        /// <summary>
        ///     RenewalModuleFilterMoto - Use 'RenewalModuleFilterMotoParams' to pass parameters into this method.
        /// </summary>
        /// <param name="houseOrMoto"></param>
        public void RenewalModuleFilter(string houseOrMoto)
        {
            #region Variable Declarations

            WinControl uIFilterButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIFilterWindow.UIFilterButton;
            WinEdit uIItemEdit = this.UIFilterRenewalRecordsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIFilterRenewalRecordsWindow.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIFilterRenewalRecordsWindow.UIItemWindow2.UIItemComboBox;
            WinControl uIOKButton = this.UIFilterRenewalRecordsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIFilterButton, new Point(40, 11));

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemEdit1.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");

            uIItemComboBox.SelectedItem = houseOrMoto;

            Mouse.Click(uIOKButton, new Point(39, 11));
        }

        /// <summary>
        ///     RenewalModuleEDI_1
        /// </summary>
        /// <param name="continueOnError"></param>
        public void RenewalModuleEdi1(bool continueOnError)
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinControl uIExitButton = this.UIPoliciesAutoRenewedAWindow.UIExitWindow.UIExitButton;
            WinControl uIediMatchButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIEDIMatchWindow.UIEDIMatchButton;
            WinControl uIOKButton1 = this.UIRenewalSearchWindow.UIOKWindow.UIOKButton;
            WinControl uILogandClearButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILogandClearWindow.UILogandClearButton;

            #endregion

            if (continueOnError)
            {
                Playback.PlaybackSettings.ContinueOnError = true;

                Mouse.Click(uIOKButton, new Point(36, 13));

                Mouse.Click(uIExitButton, new Point(33, 11));

                Playback.PlaybackSettings.ContinueOnError = false;
            }

            Mouse.Click(uIediMatchButton, new Point(59, 10));

            Mouse.Click(uIOKButton1, new Point(37, 9));

            Mouse.Click(uIOKButton, new Point(46, 21));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uILogandClearButton, new Point(50, 15));

            Mouse.Click(uIOKButton, new Point(50, 7));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleEDI - Use 'RenewalModuleEDIParams' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleEDI()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsModuleMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsModuleMenuItem;
            WinEdit uIItemEdit = this.UIIETAMRenewalsWindow.UIItemWindow.UIItemEdit;
            WinControl uIOKButton = this.UIIETAMRenewalsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(21, 12));

            Mouse.Click(uILinksMenuItem, new Point(101, 8));

            Mouse.Click(uIItem3RdPartyIntegratMenuItem, new Point(89, 10));

            Mouse.Click(uIRenewalsModuleMenuItem, new Point(98, 12));

            uIItemEdit.Text = this.RenewalModuleEDIParams.UIItemEditText;

            Mouse.Click(uIOKButton, new Point(31, 10));
        }

        /// <summary>
        ///     RenewalModuleDisplay - Use 'RenewalModuleDisplayParams' to pass parameters into this method.
        /// </summary>
        /// <param name="keyToSend"></param>
        public void RenewalModuleDisplay(string keyToSend)
        {
            #region Variable Declarations

            WinClient uIInsurETAMRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow10.UIClient();
            WinControl uIDisplayRecordButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIDisplayRecordWindow.UIDisplayRecordButton;

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

            WinControl uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(45, 13));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     RenewalModuleClose
        /// </summary>
        public void RenewalModuleClose()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

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

            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinEdit uIItemEdit = this.UIRenewalLoaderWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIRenewalLoaderWindow.UIItemWindow2.UIItemEdit;
            WinControl uIRunButton = this.UIRenewalLoaderWindow.UIRenewalLoaderClient.UIRunButton;

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

            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uILinksMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem;
            WinMenuItem uIItem3RdPartyIntegratMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem;
            WinMenuItem uIRenewalsLoaderMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIRenewalsLoaderMenuItem;

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

            WinTitleBar uIRenewalLoaderTitleBar = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar;
            WinControl uICloseButton = this.UIRenewalLoaderWindow.UIRenewalLoaderTitleBar.UICloseButton;

            #endregion

            Mouse.Click(uIRenewalLoaderTitleBar, new Point(89, 11));

            Mouse.Click(uICloseButton, new Point(18, 9));
        }

        /// <summary>
        ///     RenewalCheckStatus - Use 'RenewalCheckStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void RenewalCheckStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'REN'
            Assert.AreEqual(this.RenewalCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     RenewalAfterMTA1 - Use 'RenewalAfterMTA1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalAfterMTA1()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;
            WinControl uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(42, 14));

            Mouse.Click(uIAfterButton, new Point(37, 8));

            Mouse.Click(uIMTAButton, new Point(55, 10));

            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(39, 17));

            uIItemEdit.Text = this.MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton, new Point(71, 13));
        }

        /// <summary>
        ///     RegressAppDate - Use 'RegressAppDateParams' to pass parameters into this method.
        /// </summary>
        public void RegressAppDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIRegressIETamPolicyWindow.UIItemWindow3.UIItemEdit;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
        }

        /// <summary>
        ///     RecordedMethod4_1
        /// </summary>
        public void ClickOkButton()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(23, 9));
        }

        /// <summary>
        ///     RecordedMethod4
        /// </summary>
        public void CancelBillingScreen()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(40, 13));
        }

        /// <summary>
        ///     RecordedMethod1
        /// </summary>
        public void HighlightBillingScreen()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyrtyertWindow.UIBillingScreenMotoTestWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click text box
            Mouse.Click(uIItemEdit, new Point(45, 4));
        }

        /// <summary>
        ///     RebrokeSelectAlternative
        /// </summary>
        public void RebrokeSelectAlternative()
        {
            #region Variable Declarations

            WinControl uISelectAlternativeButton = this.UIRebrokeResultsScreenWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            #endregion

            Mouse.Click(uISelectAlternativeButton, new Point(56, 13));
        }

        /// <summary>
        ///     RebrokeAlternativeRenew_1 - Use 'RebrokeAlternativeRenew_1Params' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(63, 21));

            Mouse.Click(uIOKButton1, new Point(49, 8));

            Mouse.Click(uIOKButton1, new Point(62, 14));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(44, 7));

            Mouse.Click(uIOKButton3, new Point(54, 7));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     RebrokeAlternativeRenew - Use 'RebrokeAlternativeRenewParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIAUTO2311001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIRenewalsNewBusinessAClient = this.UIRenewalsNewBusinessAWindow1.UIItemWindow.UIClient();
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow1.UIAcceptWindow.UIAcceptButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(48, 13));

            uIAlternativeRadioButton.Selected = this.CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(52, 20));

            Mouse.Click(uIOKButton1, new Point(36, 11));

            Mouse.Click(uIRenewalsNewBusinessAClient, new Point(433, 51));

            Mouse.Click(uIAcceptButton, new Point(45, 17));

            this.CancelPrint();
        }

        /// <summary>
        ///     RebrokeAlternativeFinish_1 - Use 'RebrokeAlternativeFinish_1Params' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeFinish1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(75, 12));

            Mouse.Click(uIOKButton1, new Point(50, 6));

            Mouse.Click(uIOKButton1, new Point(58, 13));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 14));

            this.SelectTamInsurersAndActivity(false);
        }

        /// <summary>
        ///     RebrokeAlternativeFinish - Use 'RebrokeAlternativeFinishParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeFinish()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIAUTO2211001Window.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIItemClient = this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(79, 13));

            uIAlternativeRadioButton.Selected = this.CommonParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(30, 12));

            Mouse.Click(uIOKButton1, new Point(27, 13));

            Mouse.Click(uIItemClient, new Point(398, 91));

            Keyboard.SendKeys(uIItemClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(36, 9));

            this.CancelPrint();

            Mouse.Click(uIOKButton2, new Point(72, 10));

            this.CancelPrint();
        }

        /// <summary>
        ///     PublicCreditCheckOk
        /// </summary>
        public void PublicCreditCheckOk()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIErrorWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(49, 10));
        }

        /// <summary>
        ///     PrintQuote
        /// </summary>
        public void PrintQuote()
        {
            #region Variable Declarations

            WinControl uIPrintQuoteButton = this.UIQuoteResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            #endregion

            Playback.Wait(2000);
            Mouse.Click(uIPrintQuoteButton, new Point(49, 10));
        }

        /// <summary>
        ///     PostcodeLookup - Use 'PostcodeLookupExpectedValues' to pass parameters into this method.
        /// </summary>
        public void PostcodeLookup()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIProposerDetailsWindow.UIItemWindow5.UIItemEdit;

            #endregion

            Assert.AreEqual(this.PostcodeLookupExpectedValues.AddressLine1, uIItemEdit.Text);

            Assert.AreEqual(this.PostcodeLookupExpectedValues.AddressLine2, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MTAMessageBeforeCurrent - Use 'MTAMessageBeforeCurrentExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MTAMessageBeforeCurrent()
        {
            #region Variable Declarations

            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            #endregion

            Assert.AreEqual(this.MTAMessageBeforeCurrentExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        /// <summary>
        ///     MTAEffectiveDatesCancel
        /// </summary>
        public void MTAEffectiveDatesCancel()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(28, 12));
        }

        /// <summary>
        ///     MTADate - Use 'MTADateParams' to pass parameters into this method.
        /// </summary>
        /// <param name="withDate"></param>
        public void MTADate(string withDate)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;
            WinControl uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = withDate;

            Mouse.Click(uIOKButton, new Point(39, 10));
        }

        /// <summary>
        ///     MTACloseMessageBefore
        /// </summary>
        public void MTACloseMessageBefore()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(52, 12));
        }

        /// <summary>
        ///     MTACloseMessageAfter
        /// </summary>
        public void MTACloseMessageAfter()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(59, 13));
        }

        /// <summary>
        ///     MTACancel
        /// </summary>
        public void MTACancel()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIMTAEffectiveDatesWindow.UICancelWindow.UICancelButton;
            WinControl uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(26, 13));

            Mouse.Click(uIExitButton, new Point(65, 13));

            Mouse.Click(uIYesButton, new Point(46, 9));

            Mouse.Click(uIOKButton, new Point(50, 11));
        }

        /// <summary>
        ///     Links_1
        /// </summary>
        public void Links()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(40, 5));
        }

        public void SelectTamInsurersAndActivity(bool isMTA, string whoToSelect = "")
        {
            #region Variable Declarations

            WinControl uIokButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            int timeOut = Playback.PlaybackSettings.SearchTimeout;
            Playback.PlaybackSettings.SearchTimeout = 3000;

            this.ImportToTamOptions(whoToSelect);
            if (isMTA)
            {
                try
                {
                    Mouse.Click(uIokButton5);
                }
                catch (Exception)
                {
                }
            }

            this.ImportToTamOptions(whoToSelect);

            try
            {
                Mouse.Click(uIokButton5);
            }
            catch (Exception)
            {
            }

            Playback.PlaybackSettings.SearchTimeout = timeOut;
        }

        public void WaitForControl(UITestControl control)
        {
            int timeout = Playback.PlaybackSettings.SearchTimeout;
            Playback.PlaybackSettings.SearchTimeout = 120000;
            Assert.IsTrue(control.Exists, "Control: " + control.Name + " does not exist");
            Playback.PlaybackSettings.SearchTimeout = timeout;
        }

        public void CheckPremiumInQuoteDocument(List<Document> expectedDocs, double overridePremium = 0.00)
        {
            WinClient uIBillingScreenClient = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIPolicyDocumentsWindow.UIClient();
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;
            WinClient uIPolicyAttachmentsClient = this.UIPolicyAttachmentsWindow.UIItemWindow.UIClient();

            WinButton uIDetailButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIDetailButton;
            WinEdit checkFileName = this.UIAttachmentDetailWindow.UIItemWindow.UIItemEdit;
            WinButton uICancelButton = this.UIAttachmentDetailWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIItemEdit);
            double premium = (Math.Round(Double.Parse(uIItemEdit.Text) * 1.06 * 100) / 100);

            Mouse.DoubleClick(uIBillingScreenClient, new Point(40, 14));

            string filename = string.Empty;
            for (int i = 19; i < 220; i = i + 19)
            {
                Mouse.Click(uIPolicyAttachmentsClient, new Point(10, i));
                Mouse.Click(uIDetailButton);

                if (filename == checkFileName.Text)
                {
                    Mouse.Click(uICancelButton);
                    break;
                }

                filename = checkFileName.Text;

                this.IncreaseDocsListCount(expectedDocs, filename);

                Mouse.Click(uICancelButton);

                switch (filename)
                {
                    case "HHQuote":

                        if (overridePremium > 0.0)
                        {
                            break;
                        }
                        this.CheckPremiumInHhQuote(premium);
                        break;
                    case "Schedule":
                        this.CheckPremiumInPdfProposal(premium);
                        break;
                    case "FSA":
                        this.CheckPremiumInWordDoc(premium);
                        break;
                }
            }

            this.CheckDocsList(expectedDocs);
        }

        private void IncreaseDocsListCount(IEnumerable<Document> expectedDocs, string docName)
        {
            foreach (Document doc in expectedDocs)
            {
                if (doc.DocName == docName)
                {
                    doc.ActualCount++;
                }

                Assert.IsFalse(doc.ActualCount > doc.ExpectedCount, "Too many occurences of " + doc.DocName + ". Expected : " + doc.ExpectedCount + ", actual : " + doc.ActualCount);
            }
        }

        private void CheckDocsList(IEnumerable<Document> expectedDocs)
        {
            foreach (Document doc in expectedDocs)
            {
                Assert.IsTrue(
                    doc.ActualCount == doc.ExpectedCount, "Incorrect occurences of " + doc.DocName + ". Expected : " + doc.ExpectedCount + ", actual : " + doc.ActualCount);
                ;
            }
        }

        private bool CheckStringForPremium(string text, double premium)
        {
            if (text.Contains(premium.ToString(CultureInfo.InvariantCulture)))
            {
                return true;
            }

            if (text.Contains((premium + 0.01).ToString(CultureInfo.InvariantCulture)))
            {
                return true;
            }

            if (text.Contains((premium - 0.01).ToString(CultureInfo.InvariantCulture)))
            {
                return true;
            }
            return false;
        }

        private void CheckPremiumInHhQuote(double premium)
        {
            this.OpenAttachment();

            HtmlCell uIItem26652Cell = this.UIIEPolicyDocumentWindow.UIFileCUsersLisaBlanchDocument.UIItemTable.UIItem26652Cell;
            Assert.IsTrue(this.UIIEPolicyDocumentWindow.UIFileCUsersLisaBlanchDocument.Exists);
            Assert.IsTrue(this.CheckStringForPremium(uIItem26652Cell.InnerText, premium));
            this.UIIEPolicyDocumentWindow.Close();
        }

        private void OpenAttachment()
        {
            WinButton uIOptionsButton = this.UIPolicyAttachmentsWindow.UIOptionsWindow.UIOptionsButton;
            WinButton uIOKButton = this.UIViewAttachmentWindow.UIOKWindow.UIOKButton;
            WinMenuItem uIViewAttachmentMenuItem = this.UIAttachmentsMenuWindow.UIContextMenu.UIMenuItem("View Attachment");
            Mouse.Click(uIOptionsButton);
            Mouse.Click(uIViewAttachmentMenuItem);
            Mouse.Click(uIOKButton);
        }

        private void CheckPremiumInPdfProposal(double premium)
        {
            this.OpenAttachment();

            WinMenuItem uIPropertiesCtrlDMenuItem = this.UIItemPdfSecureWindow.UIApplicationMenuBar.UIFileMenuItem.UIPropertiesCtrlDMenuItem;
            WinEdit uIItemEdit = this.UIDocumentPropertiesWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.UIDocumentPropertiesWindow.UIOKWindow.UIOKButton;
            WinButton uICloseButton = this.UIItemPdfSecureWindow.UITitleBar.UICloseButton;

            Mouse.Click(uIPropertiesCtrlDMenuItem);
            Mouse.Click(uIItemEdit);

            string pdfFilePath = uIItemEdit.Text;

            Mouse.Click(uIOKButton, new Point(33, 12));

            Mouse.Click(uICloseButton);

            var parser = new PDFParser();

            string text = parser.ExtractText(pdfFilePath).Replace(" ", string.Empty);

            Assert.IsTrue(this.CheckStringForPremium(text, premium));
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

            Mouse.Click(uIFindNextButton, new Point(28, 14));

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

                Mouse.Click(uIFindNextButton, new Point(28, 14));

                try
                {
                    b = !this.UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
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
                    b = !this.UIMicrosoftOfficeWordVWindow.UIOKWindow.Exists;
                }
                catch (Exception)
                {
                    b = true;
                }
            }

            Assert.IsTrue(b);

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(50, 15));

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(22, 8));
        }

        private void ImportToTamOptions(string whoToSelect)
        {
            WinList uIItemList = this.UISelectTaminsurerforiWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton = this.UISelectTaminsurerforiWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uiTransToInsert = this.UITransactiontoinsertWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton6 = this.UITransactiontoinsertWindow.UIItemWindow.UIOKButton;
            WinList uIItemList2 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton2 = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIClient().UIOKButton;
            WinList uIItemList3 = this.UISelectTamActivityTypWindow.UIItemWindow.UIItemList;
            WinButton uIOKButton3 = this.UISelectTamActivityTypWindow.UIItemWindow1.UIClient().UIOKButton;

            try
            {
                do
                {
                    WinWindow win = this.TopWindow;
                    string name = win.GetProperty("Name").ToString();

                    if (name.Contains("Select Tam insurer for insurer code"))
                    {
                        uIItemList.SelectedItemsAsString = this.SelectTamInsurersAndActivityParams.UIItemListSelectedItemsAsString;
                        Mouse.Click(uIOKButton, new Point(21, 16));
                    }

                    if (name.Contains("Transaction to insert"))
                    {
                        uiTransToInsert.SelectedItemsAsString = "NEW";
                        Mouse.Click(uIOKButton6);
                    }

                    if (name.Contains("Please select WHO to follow up"))
                    {
                        if (string.IsNullOrEmpty(whoToSelect))
                        {
                            uIItemList2.SelectedItemsAsString = this.SelectTamInsurersAndActivityParams.UIItemListSelectedItemsAsString2;
                        }
                        else
                        {
                            uIItemList2.SelectedItemsAsString = whoToSelect;
                        }

                        Mouse.Click(uIOKButton2, new Point(33, 13));
                    }

                    if (name.Contains("Select Tam Activity Type for FSA "))
                    {
                        uIItemList3.SelectedItemsAsString = this.SelectTamInsurersAndActivityParams.UIItemListSelectedItemsAsString;
                        Mouse.Click(uIOKButton3, new Point(27, 8));
                    }
                }
                while (true);
            }
            catch (Exception)
            {
            }
        }
    }
}