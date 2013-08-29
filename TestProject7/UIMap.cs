namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Drawing;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public partial class UIMap
    {
        private MTAEffectiveDateParams mMtaEffectiveDateParams;

        private MotoCreateSiteRenewalParams mMotoCreateSiteRenewalParams;

        private OpenBrowser2Params mOpenBrowser2Params;

        private HomeFinishQuoteParams mHomeFinishQuoteParams;

        private RenewalModuleInvite_1Params mRenewalModuleInvite1Params;

        private AddPolicyParams mAddPolicyParams;

        private AddressLookupHomeExpectedValues mAddressLookupHomeExpectedValues;

        private AmendDateBeforeMessageExpectedValues mAmendDateBeforeMessageExpectedValues;

        private ExitEnabledExpectedValues mExitEnabledExpectedValues;

        private FinishQuote1Params mFinishQuote1Params;

        private Exit1Params mExit1Params;

        private CoverDateBackCheckExpectedValues mCoverDateBackCheckExpectedValues;

        private CheckQuoteMessageExpectedValues mCheckQuoteMessageExpectedValues;

        private CheckBillingScreenExpectedValues mCheckBillingScreenExpectedValues;

        private CheckAutoPrintExpectedValues mCheckAutoPrintExpectedValues;

        private ChangePremiumParams mChangePremiumParams;

        private ChangeDatePolicyParams mChangeDatePolicyParams;

        private AssertSelectPolicyFormExpectedValues mAssertSelectPolicyFormExpectedValues;

        private AssertMethod3ExpectedValues mAssertMethod3ExpectedValues;

        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;

        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;

        private App_startedExpectedValues mAppStartedExpectedValues;

        private AmendSelectQuoteParams mAmendSelectQuoteParams;

        private SelectPolicyQuoteParams mSelectPolicyQuoteParams;

        private SelectMotoPolicyParams mSelectMotoPolicyParams;

        private SelectHomeTypeParams mSelectHomeTypeParams;

        private SaveWithoutPremiumParams mSaveWithoutPremiumParams;

        private RenewalModuleRenew_1Params mRenewalModuleRenew1Params;

        private RenewalModuleFilterMotoParams mRenewalModuleFilterMotoParams;

        private RenewalModuleEDIParams mRenewalModuleEDIParams;

        private RenewalModuleDisplayParams mRenewalModuleDisplayParams;

        private RenewalLoaderRunParams mRenewalLoaderRunParams;

        private RenewalCheckStatusExpectedValues mRenewalCheckStatusExpectedValues;

        private RenewalAfterMTA1Params mRenewalAfterMTA1Params;

        private RegressAppDateParams mRegressAppDateParams;

        private RebrokeAlternativeRenew_1Params mRebrokeAlternativeRenew1Params;

        private RebrokeAlternativeRenewParams mRebrokeAlternativeRenewParams;

        private RebrokeAlternativeFinish_1Params mRebrokeAlternativeFinish1Params;

        private RebrokeAlternativeFinishParams mRebrokeAlternativeFinishParams;

        private QuoteResultsParams mQuoteResultsParams;

        private PostcodeLookupExpectedValues mPostcodeLookupExpectedValues;

        private MTAMessageBeforeCurrentExpectedValues mMTAMessageBeforeCurrentExpectedValues;

        private MTADateParams mMTADateParams;

        public virtual MTAEffectiveDateParams MTAEffectiveDateParams
        {
            get
            {
                if ((this.mMtaEffectiveDateParams == null))
                {
                    this.mMtaEffectiveDateParams = new MTAEffectiveDateParams();
                }
                return this.mMtaEffectiveDateParams;
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

        public virtual HomeFinishQuoteParams HomeFinishQuoteParams
        {
            get
            {
                if ((this.mHomeFinishQuoteParams == null))
                {
                    this.mHomeFinishQuoteParams = new HomeFinishQuoteParams();
                }
                return this.mHomeFinishQuoteParams;
            }
        }

        public virtual RenewalModuleInvite_1Params RenewalModuleInvite1Params
        {
            get
            {
                if ((this.mRenewalModuleInvite1Params == null))
                {
                    this.mRenewalModuleInvite1Params = new RenewalModuleInvite_1Params();
                }
                return this.mRenewalModuleInvite1Params;
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

        public virtual AddressLookupHomeExpectedValues AddressLookupHomeExpectedValues
        {
            get
            {
                if ((this.mAddressLookupHomeExpectedValues == null))
                {
                    this.mAddressLookupHomeExpectedValues = new AddressLookupHomeExpectedValues();
                }
                return this.mAddressLookupHomeExpectedValues;
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

        public virtual FinishQuote1Params FinishQuote1Params
        {
            get
            {
                if ((this.mFinishQuote1Params == null))
                {
                    this.mFinishQuote1Params = new FinishQuote1Params();
                }
                return this.mFinishQuote1Params;
            }
        }

        public virtual Exit1Params Exit1Params
        {
            get
            {
                if ((this.mExit1Params == null))
                {
                    this.mExit1Params = new Exit1Params();
                }
                return this.mExit1Params;
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

        public virtual CheckQuoteMessageExpectedValues CheckQuoteMessageExpectedValues
        {
            get
            {
                if ((this.mCheckQuoteMessageExpectedValues == null))
                {
                    this.mCheckQuoteMessageExpectedValues = new CheckQuoteMessageExpectedValues();
                }
                return this.mCheckQuoteMessageExpectedValues;
            }
        }

        public virtual CheckBillingScreenExpectedValues CheckBillingScreenExpectedValues
        {
            get
            {
                if ((this.mCheckBillingScreenExpectedValues == null))
                {
                    this.mCheckBillingScreenExpectedValues = new CheckBillingScreenExpectedValues();
                }
                return this.mCheckBillingScreenExpectedValues;
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

        public virtual ChangeDatePolicyParams ChangeDatePolicyParams
        {
            get
            {
                if ((this.mChangeDatePolicyParams == null))
                {
                    this.mChangeDatePolicyParams = new ChangeDatePolicyParams();
                }
                return this.mChangeDatePolicyParams;
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

        public virtual AmendSelectQuoteParams AmendSelectQuoteParams
        {
            get
            {
                if ((this.mAmendSelectQuoteParams == null))
                {
                    this.mAmendSelectQuoteParams = new AmendSelectQuoteParams();
                }
                return this.mAmendSelectQuoteParams;
            }
        }

        public virtual SelectPolicyQuoteParams SelectPolicyQuoteParams
        {
            get
            {
                if ((this.mSelectPolicyQuoteParams == null))
                {
                    this.mSelectPolicyQuoteParams = new SelectPolicyQuoteParams();
                }
                return this.mSelectPolicyQuoteParams;
            }
        }

        public virtual SelectMotoPolicyParams SelectMotoPolicyParams
        {
            get
            {
                if ((this.mSelectMotoPolicyParams == null))
                {
                    this.mSelectMotoPolicyParams = new SelectMotoPolicyParams();
                }
                return this.mSelectMotoPolicyParams;
            }
        }

        public virtual SelectHomeTypeParams SelectHomeTypeParams
        {
            get
            {
                if ((this.mSelectHomeTypeParams == null))
                {
                    this.mSelectHomeTypeParams = new SelectHomeTypeParams();
                }
                return this.mSelectHomeTypeParams;
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

        public virtual RenewalModuleRenew_1Params RenewalModuleRenew1Params
        {
            get
            {
                if ((this.mRenewalModuleRenew1Params == null))
                {
                    this.mRenewalModuleRenew1Params = new RenewalModuleRenew_1Params();
                }
                return this.mRenewalModuleRenew1Params;
            }
        }

        public virtual RenewalModuleFilterMotoParams RenewalModuleFilterMotoParams
        {
            get
            {
                if ((this.mRenewalModuleFilterMotoParams == null))
                {
                    this.mRenewalModuleFilterMotoParams = new RenewalModuleFilterMotoParams();
                }
                return this.mRenewalModuleFilterMotoParams;
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

        public virtual RenewalModuleDisplayParams RenewalModuleDisplayParams
        {
            get
            {
                if ((this.mRenewalModuleDisplayParams == null))
                {
                    this.mRenewalModuleDisplayParams = new RenewalModuleDisplayParams();
                }
                return this.mRenewalModuleDisplayParams;
            }
        }

        public virtual RenewalLoaderRunParams RenewalLoaderRunParams
        {
            get
            {
                if ((this.mRenewalLoaderRunParams == null))
                {
                    this.mRenewalLoaderRunParams = new RenewalLoaderRunParams();
                }
                return this.mRenewalLoaderRunParams;
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

        public virtual RenewalAfterMTA1Params RenewalAfterMTA1Params
        {
            get
            {
                if ((this.mRenewalAfterMTA1Params == null))
                {
                    this.mRenewalAfterMTA1Params = new RenewalAfterMTA1Params();
                }
                return this.mRenewalAfterMTA1Params;
            }
        }

        public virtual RegressAppDateParams RegressAppDateParams
        {
            get
            {
                if ((this.mRegressAppDateParams == null))
                {
                    this.mRegressAppDateParams = new RegressAppDateParams();
                }
                return this.mRegressAppDateParams;
            }
        }

        public virtual RebrokeAlternativeRenew_1Params RebrokeAlternativeRenew1Params
        {
            get
            {
                if ((this.mRebrokeAlternativeRenew1Params == null))
                {
                    this.mRebrokeAlternativeRenew1Params = new RebrokeAlternativeRenew_1Params();
                }
                return this.mRebrokeAlternativeRenew1Params;
            }
        }

        public virtual RebrokeAlternativeRenewParams RebrokeAlternativeRenewParams
        {
            get
            {
                if ((this.mRebrokeAlternativeRenewParams == null))
                {
                    this.mRebrokeAlternativeRenewParams = new RebrokeAlternativeRenewParams();
                }
                return this.mRebrokeAlternativeRenewParams;
            }
        }

        public virtual RebrokeAlternativeFinish_1Params RebrokeAlternativeFinish1Params
        {
            get
            {
                if ((this.mRebrokeAlternativeFinish1Params == null))
                {
                    this.mRebrokeAlternativeFinish1Params = new RebrokeAlternativeFinish_1Params();
                }
                return this.mRebrokeAlternativeFinish1Params;
            }
        }

        public virtual RebrokeAlternativeFinishParams RebrokeAlternativeFinishParams
        {
            get
            {
                if ((this.mRebrokeAlternativeFinishParams == null))
                {
                    this.mRebrokeAlternativeFinishParams = new RebrokeAlternativeFinishParams();
                }
                return this.mRebrokeAlternativeFinishParams;
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

        public virtual MTADateParams MTADateParams
        {
            get
            {
                if ((this.mMTADateParams == null))
                {
                    this.mMTADateParams = new MTADateParams();
                }
                return this.mMTADateParams;
            }
        }

        /// <summary>
        ///     MTAEffectiveDate - Use 'MTAEffectiveDateParams' to pass parameters into this method.
        /// </summary>
        public void MtaEffectiveDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;

            #endregion

            uIItemEdit.Text = this.MTAEffectiveDateParams.UIItemEditText;
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
        public void CloseDemandsMoto()
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

            if (wXp.Exists)
            {
                okBut = okButXp;
                w = wXp;
            }
            else
            {
                okBut = okBut7;
                w = w7;
            }

            Playback.PlaybackSettings.ContinueOnError = true;

            Keyboard.SendKeys(w, "Bus Sys{Tab}Tottenham1");

            Mouse.Click(okBut, new Point(31, 14));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIRenewalsMaintenanceHyperlink, new Point(39, 7));
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
            WinControl uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton3 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uILookupButton, new Point(23, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));

            Mouse.Click(uIConfirmButton, new Point(25, 11));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton1, new Point(27, 7));

            Playback.PlaybackSettings.ContinueOnError = false;

            uIDeferPrintingCheckBox.Checked = this.HomeFinishQuoteParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(61, 11));

            uIAddActivityCheckBox.Checked = this.HomeFinishQuoteParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton3, new Point(51, 10));

            Mouse.Click(uIOKButton4, new Point(50, 10));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton4, new Point(50, 10));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton5, new Point(44, 10));
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
            WinControl uIOKButton3 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(50, 16));

            this.RetrieveResponse();

            uIDeferPrintingCheckBox.Checked = this.RenewalModuleInvite1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(72, 10));

            uIAddActivityCheckBox.Checked = this.RenewalModuleInvite1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(24, 12));

            Mouse.Click(uIOKButton3, new Point(35, 10));
        }

        /// <summary>
        ///     HighlightCustomer
        /// </summary>
        public void HighlightCustomer()
        {
            #region Variable Declarations

            WinClient uIcustomersClient = this.UIPolicyautotestWindow.UICustomersWindow.UIItemWindow1.UIClient;

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
            WinControl uIOKButton2 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton3 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.FinishQuote1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(51, 7));

            uIAddActivityCheckBox.Checked = this.FinishQuote1Params.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);
            Mouse.Click(uIOKButton1, new Point(41, 15));

            Mouse.Click(uIOKButton2, new Point(42, 14));

            Mouse.Click(uIOKButton3, new Point(47, 19));
        }

        /// <summary>
        ///     SelectPolicyQuote - Use 'SelectPolicyQuoteParams' to pass parameters into this method.
        /// </summary>
        public void SelectPolicyQuote()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.UIQuoteResultsWindow.UIItemWindow.UIClient;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(295, 127));

            Keyboard.SendKeys(uIQuoteResultsClient, this.SelectPolicyQuoteParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);
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
            WinControl uIOKButton1 = this.UITamxml7Window.UIClient.UIOKButton;
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            Playback.Wait(5000);
            Mouse.Click(uIExitButton, new Point(46, 12));

            Mouse.Click(uIYesButton, new Point(39, 9));

            uIAddActivityCheckBox.Checked = this.Exit1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(34, 11));

            Mouse.Click(uIOKButton1, new Point(52, 14));

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

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UICancelWindow.UICancelButton;

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

            StringAssert.Contains(uIfordfiestablack16V13Cell.InnerText, this.CheckAutoPrintExpectedValues.UIFORDFIESTABLACK16V13CellInnerText);
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

            uIItemEdit.Text = this.ChangePremiumParams.UIItemEditText;

            uIItemEdit1.Text = this.ChangePremiumParams.UIItemEditText1;

            Mouse.Click(uIOKButton, new Point(25, 6));
        }

        /// <summary>
        ///     ChangeDatePolicy - Use 'ChangeDatePolicyParams' to pass parameters into this method.
        /// </summary>
        public void ChangeDatePolicy()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow3.UIItemEdit;
            WinControl uIOKButton = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = this.ChangeDatePolicyParams.UIItemEditText;

            Mouse.Click(uIOKButton, new Point(36, 17));
        }

        /// <summary>
        ///     CancelPrint
        /// </summary>
        public void CancelPrint()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

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
        public void AssertMethod3()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.AssertMethod3ExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.AssertMethod3ExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreEqual(this.AssertMethod2ExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UICustomertxt1tdsfsWindow.UINewPolicyDetailWindow.UIItemWindow11.UIItemEdit;

            #endregion

            Assert.AreNotEqual(this.AssertMethod1ExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     AmendSelectQuote - Use 'AmendSelectQuoteParams' to pass parameters into this method.
        /// </summary>
        public void AmendSelectQuote()
        {
            #region Variable Declarations

            WinClient uIAmendRiskResultsClient = this.UIAmendRiskResultsWindow.UIItemWindow.UIClient;

            #endregion

            Mouse.Click(uIAmendRiskResultsClient, new Point(362, 136));

            Keyboard.SendKeys(uIAmendRiskResultsClient, this.AmendSelectQuoteParams.UIAmendRiskResultsClientSendKeys, ModifierKeys.None);
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

            uIItemEdit.Text = this.SelectMotoPolicyParams.UIItemEditText;

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

            uIItemEdit.Text = this.SelectHomeTypeParams.UIItemEditText;

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
            WinList uIItemList = this.UISelectTaminsurerforiWindow.UIItemWindow.UIItemList;
            WinControl uIOKButton1 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UIClient.UIOKButton;
            WinControl uIOKButton2 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(34, 18));

            uIAddActivityCheckBox.Checked = this.SaveWithoutPremiumParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(32, 8));

            uIItemList.SelectedItemsAsString = this.SaveWithoutPremiumParams.UIItemListSelectedItemsAsString;

            Mouse.Click(uIOKButton1, new Point(33, 19));

            Mouse.Click(uIOKButton2, new Point(44, 15));
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

            WinClient uIInsurEtamRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow12.UIClient;

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
            WinControl uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinControl uIOKButton4 = this.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.RenewalModuleRenew1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(76, 10));

            Mouse.Click(uIOKButton1, new Point(48, 19));

            uIAddActivityCheckBox.Checked = this.RenewalModuleRenew1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 16));

            Mouse.Click(uIOKButton3, new Point(47, 24));

            uIItemList.SelectedItemsAsString = this.RenewalModuleRenew1Params.UIItemListSelectedItemsAsString;

            Mouse.Click(uIOKButton4, new Point(46, 4));

            Mouse.Click(uIOKButton5, new Point(44, 8));
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
        public void RenewalModuleFilterMoto()
        {
            #region Variable Declarations

            WinControl uIFilterButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIFilterWindow.UIFilterButton1;
            WinEdit uIItemEdit = this.UIFilterRenewalRecordsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIFilterRenewalRecordsWindow.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIFilterRenewalRecordsWindow.UIItemWindow2.UIItemComboBox;
            WinControl uIOKButton = this.UIFilterRenewalRecordsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIFilterButton, new Point(40, 11));

            uIItemEdit.Text = this.RenewalModuleFilterMotoParams.UIItemEditText;

            uIItemEdit1.Text = this.RenewalModuleFilterMotoParams.UIItemEditText1;

            uIItemComboBox.SelectedItem = this.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(39, 11));
        }

        /// <summary>
        ///     RenewalModuleEDI_1
        /// </summary>
        public void RenewalModuleEdi1()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinControl uIExitButton = this.UIPoliciesAutoRenewedAWindow.UIExitWindow.UIExitButton;
            WinControl uIediMatchButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIEDIMatchWindow.UIEDIMatchButton2;
            WinControl uIOKButton1 = this.UIRenewalSearchWindow.UIOKWindow.UIOKButton;
            WinControl uILogandClearButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILogandClearWindow.UILogandClearButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(36, 13));

            Mouse.Click(uIExitButton, new Point(33, 11));

            Playback.PlaybackSettings.ContinueOnError = false;

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
        public void RenewalModuleDisplay()
        {
            #region Variable Declarations

            WinClient uIInsurETAMRenewalsClient = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow10.UIClient;
            WinControl uIDisplayRecordButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIDisplayRecordWindow.UIDisplayRecordButton;

            #endregion

            Mouse.Click(uIInsurETAMRenewalsClient, new Point(10, 10));

            Keyboard.SendKeys(uIInsurETAMRenewalsClient, this.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys, ModifierKeys.None);

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

            uIItemEdit.Text = this.RenewalLoaderRunParams.UIItemEditText;

            uIItemEdit1.Text = this.RenewalLoaderRunParams.UIItemEditText1;

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

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow1.UIItemEdit;

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
            WinControl uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton2;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton1 = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(42, 14));

            Mouse.Click(uIAfterButton, new Point(37, 8));

            Mouse.Click(uIMTAButton, new Point(55, 10));

            uIItemComboBox.SelectedItem = this.RenewalAfterMTA1Params.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton1, new Point(39, 17));

            uIItemEdit.Text = this.RenewalAfterMTA1Params.UIItemEditText;

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

            uIItemEdit.Text = this.RegressAppDateParams.UIItemEditText;
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
        public void RecordedMethod4()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(40, 13));
        }

        /// <summary>
        ///     RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
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
            WinControl uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinControl uIOKButton4 = this.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.RebrokeAlternativeRenew1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(63, 21));

            Mouse.Click(uIOKButton1, new Point(49, 8));

            Mouse.Click(uIOKButton1, new Point(62, 14));

            uIAddActivityCheckBox.Checked = this.RebrokeAlternativeRenew1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(44, 7));

            Mouse.Click(uIOKButton3, new Point(54, 7));

            uIItemList.SelectedItemsAsString = this.RebrokeAlternativeRenew1Params.UIItemListSelectedItemsAsString;

            Mouse.Click(uIOKButton4, new Point(59, 13));

            Mouse.Click(uIOKButton5, new Point(48, 4));
        }

        /// <summary>
        ///     RebrokeAlternativeRenew - Use 'RebrokeAlternativeRenewParams' to pass parameters into this method.
        /// </summary>
        public void RebrokeAlternativeRenew()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIAUTO2311001Window.UIRenewPolicyWindow.UIRenewPolicyButton2;
            WinRadioButton uIAlternativeRadioButton = this.UIRenewalAcceptWindow.UIAlternativeWindow.UIAlternativeRadioButton;
            WinControl uIOKButton = this.UIRenewalAcceptWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIInsurerNoticeRevaluaWindow.UIOKWindow.UIOKButton;
            WinClient uIRenewalsNewBusinessAClient = this.UIRenewalsNewBusinessAWindow1.UIItemWindow.UIClient;
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow1.UIAcceptWindow.UIAcceptButton;
            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(48, 13));

            uIAlternativeRadioButton.Selected = this.RebrokeAlternativeRenewParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(52, 20));

            Mouse.Click(uIOKButton1, new Point(36, 11));

            Mouse.Click(uIRenewalsNewBusinessAClient, new Point(433, 51));

            Mouse.Click(uIAcceptButton, new Point(45, 17));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(51, 14));

            Playback.PlaybackSettings.ContinueOnError = false;
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
            WinControl uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinControl uIOKButton4 = this.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.RebrokeAlternativeFinish1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(75, 12));

            Mouse.Click(uIOKButton1, new Point(50, 6));

            Mouse.Click(uIOKButton1, new Point(58, 13));

            uIAddActivityCheckBox.Checked = this.RebrokeAlternativeFinish1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 14));

            Mouse.Click(uIOKButton3, new Point(49, 7));

            uIItemList.SelectedItemsAsString = this.RebrokeAlternativeFinish1Params.UIItemListSelectedItemsAsString;

            Mouse.Click(uIOKButton4, new Point(55, 12));

            Mouse.Click(uIOKButton5, new Point(41, 10));
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
            WinClient uIItemClient = this.UIRenewalsNewBusinessAWindow.UIItemWindow.UIClient;
            WinControl uIAcceptButton = this.UIRenewalsNewBusinessAWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinControl uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(79, 13));

            uIAlternativeRadioButton.Selected = this.RebrokeAlternativeFinishParams.UIAlternativeRadioButtonSelected;

            Mouse.Click(uIOKButton, new Point(30, 12));

            Mouse.Click(uIOKButton1, new Point(27, 13));

            Mouse.Click(uIItemClient, new Point(398, 91));

            Keyboard.SendKeys(uIItemClient, this.RebrokeAlternativeFinishParams.UIItemClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(36, 9));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(71, 16));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton2, new Point(72, 10));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(74, 15));

            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     QuoteResults_1
        /// </summary>
        public void QuoteResults1()
        {
            #region Variable Declarations

            WinControl uINOButton = this.UICreditCheckWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uINOButton, new Point(28, 10));
        }

        /// <summary>
        ///     QuoteResults - Use 'QuoteResultsParams' to pass parameters into this method.
        /// </summary>
        public void QuoteResults()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinControl uIOKButton1 = this.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = this.UIVehicleLookupWindow.UIItemWindow.UIItemEdit;
            WinControl uIFilterButton = this.UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinControl uIOKButton2 = this.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 12));

            uIItemComboBox.SelectedItem = this.QuoteResultsParams.UIItemComboBoxSelectedItem;

            uIItemComboBox1.SelectedItem = this.QuoteResultsParams.UIItemComboBoxSelectedItem1;

            uIItemEdit.Text = this.QuoteResultsParams.UIItemEditText;

            Mouse.Click(uIOKButton1, new Point(38, 4));

            uIItemEdit1.Text = this.QuoteResultsParams.UIItemEditText1;

            Mouse.Click(uIFilterButton, new Point(59, 14));

            Mouse.Click(uIOKButton2, new Point(33, 5));

            uIItemEdit2.Text = this.QuoteResultsParams.UIItemEditText2;

            Mouse.Click(uICalculateQuoteButton, new Point(25, 13));
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

            Assert.AreEqual(this.PostcodeLookupExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.PostcodeLookupExpectedValues.UIItemEditText1, uIItemEdit1.Text);
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
        public void MTADate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;
            WinControl uIOKButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            uIItemEdit.Text = this.MTADateParams.UIItemEditText;

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
            WinControl uIOKButton = this.UITamxml7Window.UIClient.UIOKButton;

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
    }
}