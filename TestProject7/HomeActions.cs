namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Drawing;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class HomeActions : UIMap
    {
        private HomePrintQuote_1Params mHomePrintQuote1Params;

        private HomeExitWithPolicyParams mHomeExitWithPolicyParams;

        private HomeAcceptPolicyParams mHomeAcceptPolicyParams;

        private HomeCheckPremiumExpectedValues mHomeCheckPremiumExpectedValues;

        private HomeCheckPrintExpectedValues mHomeCheckPrintExpectedValues;

        private HomeCheckStatusExpectedValues mHomeCheckStatusExpectedValues;

        private HomeCheckZeroPremiumExpectedValues mHomeCheckZeroPremiumExpectedValues;

        private HomeCopyCheckDataExpectedValues mHomeCopyCheckDataExpectedValues;

        private HomeCopyRiskParams mHomeCopyRiskParams;

        private HomeCheckPolicyPremiumExpectedValues mHomeCheckPolicyPremiumExpectedValues;

        private HomeExitWithoutPolicyParams mHomeExitWithoutPolicyParams;

        private HomeMTAChangeParams mHomeMtaChangeParams;

        private HomeMTACheckCancelledExpectedValues mHomeMTACheckCancelledExpectedValues;

        private HomeMTACheckChangedExpectedValues mHomeMTACheckChangedExpectedValues;

        private HomeMTACheckMessageExpectedValues mHomeMTACheckMessageExpectedValues;

        private HomeMTACopyCheckExpectedValues mHomeMTACopyCheckExpectedValues;

        private HomeAddressLookupExpectedValues mHomeAddressLookupExpectedValues;

        private HomeAcceptQuote_1Params mHomeAcceptQuote1Params;

        private HomeProposerParams mHomeProposerParams;

        private HomeMTASelectQuoteParams mHomeMTASelectQuoteParams;

        private HomeMTAEnterDateParams mHomeMTAEnterDateParams;

        private HomeCreatePolicyParams mHomeCreatePolicyParams;

        private HomeCheckNewPremiumExpectedValues mHomeCheckNewPremiumExpectedValues;

        private HomeChangePremiumParams mHomeChangePremiumParams;

        private HomeCancelPolicyAcceptParams mHomeCancelPolicyAcceptParams;

        private HomeCancelPolicyParams mHomeCancelPolicyParams;

        private HomeAmendSelecPolicyParams mHomeAmendSelecPolicyParams;

        private HomeAmendRiskParams mHomeAmendRiskParams;

        private HomeAmendRenewFinish_1Params mHomeAmendRenewFinish1Params;

        private HomeAmendRenewParams mHomeAmendRenewParams;

        private HouseRegressAppParams mHouseRegressAppParams;

        private HomeStartDateParams mHomeStartDateParams;

        private HomeSiteRenewalParams mHomeSiteRenewalParams;

        private HomeSelectPolicy1Params mHomeSelectPolicy1Params;

        private HomeSelectPolicyParams mHomeSelectPolicyParams;

        private HomeRenewalCancelledCheckExpectedValues mHomeRenewalCancelledCheckExpectedValues;

        private HomeRenewalBeforeFinishParams mHomeRenewalBeforeFinishParams;

        private HomeRenewalBeforeAcceptParams mHomeRenewalBeforeAcceptParams;

        private HomeRebrokeSelectPolicyParams mHomeRebrokeSelectPolicyParams;

        public virtual HomePrintQuote_1Params HomePrintQuote1Params
        {
            get
            {
                if ((this.mHomePrintQuote1Params == null))
                {
                    this.mHomePrintQuote1Params = new HomePrintQuote_1Params();
                }
                return this.mHomePrintQuote1Params;
            }
        }

        public virtual HomeExitWithPolicyParams HomeExitWithPolicyParams
        {
            get
            {
                if ((this.mHomeExitWithPolicyParams == null))
                {
                    this.mHomeExitWithPolicyParams = new HomeExitWithPolicyParams();
                }
                return this.mHomeExitWithPolicyParams;
            }
        }

        public virtual HomeAcceptPolicyParams HomeAcceptPolicyParams
        {
            get
            {
                if ((this.mHomeAcceptPolicyParams == null))
                {
                    this.mHomeAcceptPolicyParams = new HomeAcceptPolicyParams();
                }
                return this.mHomeAcceptPolicyParams;
            }
        }

        public virtual HomeCheckPrintExpectedValues HomeCheckPrintExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPrintExpectedValues == null))
                {
                    this.mHomeCheckPrintExpectedValues = new HomeCheckPrintExpectedValues();
                }
                return this.mHomeCheckPrintExpectedValues;
            }
        }

        public virtual HomeCheckStatusExpectedValues HomeCheckStatusExpectedValues
        {
            get
            {
                if ((this.mHomeCheckStatusExpectedValues == null))
                {
                    this.mHomeCheckStatusExpectedValues = new HomeCheckStatusExpectedValues();
                }
                return this.mHomeCheckStatusExpectedValues;
            }
        }

        public virtual HomeCheckZeroPremiumExpectedValues HomeCheckZeroPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckZeroPremiumExpectedValues == null))
                {
                    this.mHomeCheckZeroPremiumExpectedValues = new HomeCheckZeroPremiumExpectedValues();
                }
                return this.mHomeCheckZeroPremiumExpectedValues;
            }
        }

        public virtual HomeCopyCheckDataExpectedValues HomeCopyCheckDataExpectedValues
        {
            get
            {
                if ((this.mHomeCopyCheckDataExpectedValues == null))
                {
                    this.mHomeCopyCheckDataExpectedValues = new HomeCopyCheckDataExpectedValues();
                }
                return this.mHomeCopyCheckDataExpectedValues;
            }
        }

        public virtual HomeCopyRiskParams HomeCopyRiskParams
        {
            get
            {
                if ((this.mHomeCopyRiskParams == null))
                {
                    this.mHomeCopyRiskParams = new HomeCopyRiskParams();
                }
                return this.mHomeCopyRiskParams;
            }
        }

        public virtual HomeCheckPolicyPremiumExpectedValues HomeCheckPolicyPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPolicyPremiumExpectedValues == null))
                {
                    this.mHomeCheckPolicyPremiumExpectedValues = new HomeCheckPolicyPremiumExpectedValues();
                }
                return this.mHomeCheckPolicyPremiumExpectedValues;
            }
        }

        public virtual HomeExitWithoutPolicyParams HomeExitWithoutPolicyParams
        {
            get
            {
                if ((this.mHomeExitWithoutPolicyParams == null))
                {
                    this.mHomeExitWithoutPolicyParams = new HomeExitWithoutPolicyParams();
                }
                return this.mHomeExitWithoutPolicyParams;
            }
        }

        public virtual HomeMTAChangeParams HomeMTAChangeParams
        {
            get
            {
                if ((this.mHomeMtaChangeParams == null))
                {
                    this.mHomeMtaChangeParams = new HomeMTAChangeParams();
                }
                return this.mHomeMtaChangeParams;
            }
        }

        public virtual HomeMTACheckCancelledExpectedValues HomeMTACheckCancelledExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckCancelledExpectedValues == null))
                {
                    this.mHomeMTACheckCancelledExpectedValues = new HomeMTACheckCancelledExpectedValues();
                }
                return this.mHomeMTACheckCancelledExpectedValues;
            }
        }

        public virtual HomeMTACheckChangedExpectedValues HomeMTACheckChangedExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckChangedExpectedValues == null))
                {
                    this.mHomeMTACheckChangedExpectedValues = new HomeMTACheckChangedExpectedValues();
                }
                return this.mHomeMTACheckChangedExpectedValues;
            }
        }

        public virtual HomeMTACheckMessageExpectedValues HomeMTACheckMessageExpectedValues
        {
            get
            {
                if ((this.mHomeMTACheckMessageExpectedValues == null))
                {
                    this.mHomeMTACheckMessageExpectedValues = new HomeMTACheckMessageExpectedValues();
                }
                return this.mHomeMTACheckMessageExpectedValues;
            }
        }

        public virtual HomeMTACopyCheckExpectedValues HomeMTACopyCheckExpectedValues
        {
            get
            {
                if ((this.mHomeMTACopyCheckExpectedValues == null))
                {
                    this.mHomeMTACopyCheckExpectedValues = new HomeMTACopyCheckExpectedValues();
                }
                return this.mHomeMTACopyCheckExpectedValues;
            }
        }

        public virtual HomeAddressLookupExpectedValues HomeAddressLookupExpectedValues
        {
            get
            {
                if ((this.mHomeAddressLookupExpectedValues == null))
                {
                    this.mHomeAddressLookupExpectedValues = new HomeAddressLookupExpectedValues();
                }
                return this.mHomeAddressLookupExpectedValues;
            }
        }

        public virtual HomeAcceptQuote_1Params HomeAcceptQuote1Params
        {
            get
            {
                if ((this.mHomeAcceptQuote1Params == null))
                {
                    this.mHomeAcceptQuote1Params = new HomeAcceptQuote_1Params();
                }
                return this.mHomeAcceptQuote1Params;
            }
        }

        public virtual HomeProposerParams HomeProposerParams
        {
            get
            {
                if ((this.mHomeProposerParams == null))
                {
                    this.mHomeProposerParams = new HomeProposerParams();
                }
                return this.mHomeProposerParams;
            }
        }

        public virtual HomeMTASelectQuoteParams HomeMTASelectQuoteParams
        {
            get
            {
                if ((this.mHomeMTASelectQuoteParams == null))
                {
                    this.mHomeMTASelectQuoteParams = new HomeMTASelectQuoteParams();
                }
                return this.mHomeMTASelectQuoteParams;
            }
        }

        public virtual HomeMTAEnterDateParams HomeMTAEnterDateParams
        {
            get
            {
                if ((this.mHomeMTAEnterDateParams == null))
                {
                    this.mHomeMTAEnterDateParams = new HomeMTAEnterDateParams();
                }
                return this.mHomeMTAEnterDateParams;
            }
        }

        public virtual HomeCreatePolicyParams HomeCreatePolicyParams
        {
            get
            {
                if ((this.mHomeCreatePolicyParams == null))
                {
                    this.mHomeCreatePolicyParams = new HomeCreatePolicyParams();
                }
                return this.mHomeCreatePolicyParams;
            }
        }

        public virtual HomeCheckNewPremiumExpectedValues HomeCheckNewPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckNewPremiumExpectedValues == null))
                {
                    this.mHomeCheckNewPremiumExpectedValues = new HomeCheckNewPremiumExpectedValues();
                }
                return this.mHomeCheckNewPremiumExpectedValues;
            }
        }

        public virtual HomeChangePremiumParams HomeChangePremiumParams
        {
            get
            {
                if ((this.mHomeChangePremiumParams == null))
                {
                    this.mHomeChangePremiumParams = new HomeChangePremiumParams();
                }
                return this.mHomeChangePremiumParams;
            }
        }

        public virtual HomeCancelPolicyAcceptParams HomeCancelPolicyAcceptParams
        {
            get
            {
                if ((this.mHomeCancelPolicyAcceptParams == null))
                {
                    this.mHomeCancelPolicyAcceptParams = new HomeCancelPolicyAcceptParams();
                }
                return this.mHomeCancelPolicyAcceptParams;
            }
        }

        public virtual HomeCancelPolicyParams HomeCancelPolicyParams
        {
            get
            {
                if ((this.mHomeCancelPolicyParams == null))
                {
                    this.mHomeCancelPolicyParams = new HomeCancelPolicyParams();
                }
                return this.mHomeCancelPolicyParams;
            }
        }

        public virtual HomeAmendSelecPolicyParams HomeAmendSelecPolicyParams
        {
            get
            {
                if ((this.mHomeAmendSelecPolicyParams == null))
                {
                    this.mHomeAmendSelecPolicyParams = new HomeAmendSelecPolicyParams();
                }
                return this.mHomeAmendSelecPolicyParams;
            }
        }

        public virtual HomeAmendRiskParams HomeAmendRiskParams
        {
            get
            {
                if ((this.mHomeAmendRiskParams == null))
                {
                    this.mHomeAmendRiskParams = new HomeAmendRiskParams();
                }
                return this.mHomeAmendRiskParams;
            }
        }

        public virtual HomeAmendRenewFinish_1Params HomeAmendRenewFinish1Params
        {
            get
            {
                if ((this.mHomeAmendRenewFinish1Params == null))
                {
                    this.mHomeAmendRenewFinish1Params = new HomeAmendRenewFinish_1Params();
                }
                return this.mHomeAmendRenewFinish1Params;
            }
        }

        public virtual HomeAmendRenewParams HomeAmendRenewParams
        {
            get
            {
                if ((this.mHomeAmendRenewParams == null))
                {
                    this.mHomeAmendRenewParams = new HomeAmendRenewParams();
                }
                return this.mHomeAmendRenewParams;
            }
        }

        public virtual HouseRegressAppParams HouseRegressAppParams
        {
            get
            {
                if ((this.mHouseRegressAppParams == null))
                {
                    this.mHouseRegressAppParams = new HouseRegressAppParams();
                }
                return this.mHouseRegressAppParams;
            }
        }

        public virtual HomeStartDateParams HomeStartDateParams
        {
            get
            {
                if ((this.mHomeStartDateParams == null))
                {
                    this.mHomeStartDateParams = new HomeStartDateParams();
                }
                return this.mHomeStartDateParams;
            }
        }

        public virtual HomeSiteRenewalParams HomeSiteRenewalParams
        {
            get
            {
                if ((this.mHomeSiteRenewalParams == null))
                {
                    this.mHomeSiteRenewalParams = new HomeSiteRenewalParams();
                }
                return this.mHomeSiteRenewalParams;
            }
        }

        public virtual HomeSelectPolicy1Params HomeSelectPolicy1Params
        {
            get
            {
                if ((this.mHomeSelectPolicy1Params == null))
                {
                    this.mHomeSelectPolicy1Params = new HomeSelectPolicy1Params();
                }
                return this.mHomeSelectPolicy1Params;
            }
        }

        public virtual HomeSelectPolicyParams HomeSelectPolicyParams
        {
            get
            {
                if ((this.mHomeSelectPolicyParams == null))
                {
                    this.mHomeSelectPolicyParams = new HomeSelectPolicyParams();
                }
                return this.mHomeSelectPolicyParams;
            }
        }

        public virtual HomeRenewalCancelledCheckExpectedValues HomeRenewalCancelledCheckExpectedValues
        {
            get
            {
                if ((this.mHomeRenewalCancelledCheckExpectedValues == null))
                {
                    this.mHomeRenewalCancelledCheckExpectedValues = new HomeRenewalCancelledCheckExpectedValues();
                }
                return this.mHomeRenewalCancelledCheckExpectedValues;
            }
        }

        public virtual HomeRenewalBeforeFinishParams HomeRenewalBeforeFinishParams
        {
            get
            {
                if ((this.mHomeRenewalBeforeFinishParams == null))
                {
                    this.mHomeRenewalBeforeFinishParams = new HomeRenewalBeforeFinishParams();
                }
                return this.mHomeRenewalBeforeFinishParams;
            }
        }

        public virtual HomeRenewalBeforeAcceptParams HomeRenewalBeforeAcceptParams
        {
            get
            {
                if ((this.mHomeRenewalBeforeAcceptParams == null))
                {
                    this.mHomeRenewalBeforeAcceptParams = new HomeRenewalBeforeAcceptParams();
                }
                return this.mHomeRenewalBeforeAcceptParams;
            }
        }

        public virtual HomeRebrokeSelectPolicyParams HomeRebrokeSelectPolicyParams
        {
            get
            {
                if ((this.mHomeRebrokeSelectPolicyParams == null))
                {
                    this.mHomeRebrokeSelectPolicyParams = new HomeRebrokeSelectPolicyParams();
                }
                return this.mHomeRebrokeSelectPolicyParams;
            }
        }

        public virtual HomeCheckPremiumExpectedValues HomeCheckPremiumExpectedValues
        {
            get
            {
                if ((this.mHomeCheckPremiumExpectedValues == null))
                {
                    this.mHomeCheckPremiumExpectedValues = new HomeCheckPremiumExpectedValues();
                }
                return this.mHomeCheckPremiumExpectedValues;
            }
        }

        /// <summary>
        ///     HomePrintQuote_1 - Use 'HomePrintQuote_1Params' to pass parameters into this method.
        /// </summary>
        public void HomePrintQuote1()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = this.UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient;
            WinControl uIPrintQuoteButton = this.UIQuotesResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(40, 5));

            Mouse.Click(uINextButton, new Point(31, 17));

            Mouse.Click(uINextButton1, new Point(39, 17));

            Mouse.Click(uINextButton2, new Point(39, 17));

            Mouse.Click(uINextButton3, new Point(39, 17));

            Mouse.Click(uINextButton4, new Point(39, 17));

            Mouse.Click(uINextButton5, new Point(39, 17));

            Mouse.Click(uINextButton6, new Point(39, 17));

            Mouse.Click(uIQuoteButton, new Point(39, 17));

            Mouse.Click(uINOButton, new Point(9, 9));

            this.PublicCreditCheckOk();

            Mouse.Click(uIQuotesResultsClient, new Point(526, 161));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomePrintQuote1Params.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIPrintQuoteButton, new Point(65, 11));
        }

        /// <summary>
        ///     HomeExitWithPolicy - Use 'HomeExitWithPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeExitWithPolicy()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UICancelWindow.UICancelButton;
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = this.UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient;
            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uIOKButton2 = this.UITamxml7Window.UIClient.UIOKButton;
            WinControl uICancelButton1 = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenHomeWindow.UIItemWindow.UIItemEdit;
            WinControl uIOKButton3 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(41, 14));

            Mouse.Click(uIOptionsButton, new Point(49, 4));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(89, 11));

            Mouse.Click(uIOKButton, new Point(33, 10));

            Mouse.Click(uINextButton, new Point(38, 13));

            Mouse.Click(uINextButton1, new Point(46, 13));

            Mouse.Click(uINextButton2, new Point(46, 13));

            Mouse.Click(uINextButton3, new Point(46, 13));

            Mouse.Click(uINextButton4, new Point(46, 13));

            Mouse.Click(uINextButton5, new Point(46, 13));

            Mouse.Click(uINextButton6, new Point(46, 13));

            Mouse.Click(uIQuoteButton, new Point(46, 13));

            Mouse.Click(uINOButton, new Point(48, 3));

            this.PublicCreditCheckOk();

            Mouse.Click(uIQuotesResultsClient, new Point(500, 164));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeExitWithPolicyParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIExitButton, new Point(46, 13));

            Mouse.Click(uIYesButton, new Point(51, 13));

            uIAddActivityCheckBox.Checked = this.HomeExitWithPolicyParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(45, 15));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton3, new Point(42, 10));

            Mouse.Click(uIOKButton2, new Point(55, 7));

            Mouse.Click(uICancelButton1, new Point(37, 17));

            Mouse.Click(uIItemButton, new Point(28, 18));

            Mouse.Click(uIDetailButton, new Point(29, 11));

            Mouse.Click(uIItemEdit, new Point(22, 8));
        }

        /// <summary>
        ///     HomeAcceptPolicy - Use 'HomeAcceptPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeAcceptPolicy()
        {
            #region Variable Declarations

            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinControl uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmationWindow.UIItemWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIAcceptButton, new Point(47, 11));

            Mouse.Click(uIYesButton, new Point(49, 11));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(30, 14));

            Mouse.Click(uICancelButton, new Point(41, 9));

            Playback.PlaybackSettings.ContinueOnError = false;

            this.EtamOk();

            Mouse.Click(uIOKButton1, new Point(47, 22));

            Mouse.Click(uIOKButton2, new Point(46, 11));

            uIItemEdit.Text = this.HomeAcceptPolicyParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeCheckPrint - Use 'HomeCheckPrintExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPrint()
        {
            #region Variable Declarations

            HtmlCell uIItem1989Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIItem1989Cell;
            HtmlCell uIMrTestTestCell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIMrTestTestCell;

            #endregion

            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIItem1989CellInnerText, uIItem1989Cell.InnerText);

            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIMrTestTestCellInnerText, uIMrTestTestCell.InnerText);
        }

        /// <summary>
        ///     HomeCheckStatus - Use 'HomeCheckStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow1.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeCheckZeroPremium - Use 'HomeCheckZeroPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckZeroPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeCheckZeroPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeClickPremium
        /// </summary>
        public void HomeClickPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIItemEdit, new Point(24, 5));
        }

        public void HomeCloseOpenPolicy()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(33, 16));

            Mouse.Click(uIItemButton, new Point(18, 20));

            Mouse.Click(uIDetailButton, new Point(44, 16));
        }

        /// <summary>
        ///     HomeCloseOpenPolicyList
        /// </summary>
        public void HomeCloseOpenPolicyList()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(47, 19));

            Mouse.Click(uIItemButton, new Point(21, 14));
        }

        /// <summary>
        ///     HomeClosePilicy
        /// </summary>
        public void HomeClosePilicy()
        {
            #region Variable Declarations

            WinControl uICloseButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICloseButton;
            WinControl uIokButton = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uICloseButton, new Point(33, 13));

            Mouse.Click(uIokButton, new Point(36, 14));
        }

        /// <summary>
        ///     HomeCopyCheckData - Use 'HomeCopyCheckDataExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCopyCheckData()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow21.UIItemComboBox;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText2, uIItemEdit2.Text);
        }

        /// <summary>
        ///     HomeCopyRisk - Use 'HomeCopyRiskParams' to pass parameters into this method.
        /// </summary>
        public void HomeCopyRisk()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinControl uIOKButton = this.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient.UIOKButton;
            WinRadioButton uIHouseholdRadioButton = this.UIProductSelectionWindow.UIHouseholdWindow.UIHouseholdRadioButton;
            WinControl uIOKButton1 = this.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(26, 9));

            Mouse.Click(uICopyRiskMenuItem, new Point(93, 8));

            Mouse.Click(uIOKButton, new Point(54, 10));

            uIHouseholdRadioButton.Selected = this.HomeCopyRiskParams.UIHouseholdRadioButtonSelected;

            Mouse.Click(uIOKButton1, new Point(42, 21));
        }

        /// <summary>
        ///     HomeCheckPolicyPremium - Use 'HomeCheckPolicyPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPolicyPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreNotEqual(this.HomeCheckPolicyPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeDemands
        /// </summary>
        public void HomeDemands()
        {
            #region Variable Declarations

            WinControl uIokButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = this.UIQuotesResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            #endregion

            Mouse.Click(uIokButton, new Point(36, 9));

            Mouse.Click(uIDemandsNeedsButton, new Point(59, 13));
        }

        /// <summary>
        ///     HomeExitWithoutPolicy - Use 'HomeExitWithoutPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeExitWithoutPolicy()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uIOKButton1 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UIClient.UIOKButton;
            WinControl uIOKButton2 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(54, 9));

            Mouse.Click(uIYesButton, new Point(45, 6));

            uIAddActivityCheckBox.Checked = this.HomeExitWithoutPolicyParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(30, 15));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton1, new Point(42, 10));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton2, new Point(70, 14));
        }

        /// <summary>
        ///     HomeMTAAccept
        /// </summary>
        public void HomeMTAAccept()
        {
            #region Variable Declarations

            WinControl uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;

            #endregion

            Mouse.Click(uINextButton, new Point(39, 12));

            Mouse.Click(uINextButton1, new Point(47, 12));

            Mouse.Click(uINextButton2, new Point(47, 12));

            Mouse.Click(uINextButton3, new Point(47, 12));

            Mouse.Click(uINextButton4, new Point(47, 12));

            Mouse.Click(uINextButton5, new Point(47, 12));

            Mouse.Click(uINextButton6, new Point(47, 12));

            Mouse.Click(uIQuoteButton, new Point(47, 12));
        }

        /// <summary>
        ///     HomeMTAAfter
        /// </summary>
        public void HomeMTAAfter()
        {
            #region Variable Declarations

            WinControl uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;

            #endregion

            Mouse.Click(uIAfterButton, new Point(38, 10));
        }

        /// <summary>
        ///     HomeMTABefore
        /// </summary>
        public void HomeMTABefore()
        {
            #region Variable Declarations

            WinControl uIBeforeButton = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;

            #endregion

            Mouse.Click(uIBeforeButton, new Point(27, 12));
        }

        /// <summary>
        ///     HomeMTACancel
        /// </summary>
        public void HomeMTACancel()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(42, 13));

            Mouse.Click(uIYesButton, new Point(35, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));
        }

        /// <summary>
        ///     HomeMTACancel1
        /// </summary>
        public void HomeMTACancel1()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow2.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(37, 17));

            Mouse.Click(uIYesButton, new Point(66, 11));

            Mouse.Click(uIOKButton, new Point(49, 13));
        }

        /// <summary>
        ///     HomeMTAChange - Use 'HomeMTAChangeParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTAChange()
        {
            #region Variable Declarations

            WinControl uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow1.UIMTAButton2;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            Mouse.Click(uIMTAButton, new Point(45, 12));

            uIItemComboBox.SelectedItem = this.HomeMTAChangeParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(35, 15));

            uIItemEdit.Text = this.HomeMTAChangeParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeMTACheckCancelled - Use 'HomeMTACheckCancelledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckCancelled()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeMTACheckCancelledExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeMTACheckChanged - Use 'HomeMTACheckChangedExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckChanged()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeMTACheckChangedExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeMTACheckMessage - Use 'HomeMTACheckMessageExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACheckMessage()
        {
            #region Variable Declarations

            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            #endregion

            Assert.AreEqual(this.HomeMTACheckMessageExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        /// <summary>
        ///     HomeMTACloseMessage
        /// </summary>
        public void HomeMTACloseMessage()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(52, 7));
        }

        /// <summary>
        ///     HomeMTACopyCheck - Use 'HomeMTACopyCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeMTACopyCheck()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow31.UIItemComboBox;

            #endregion

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemEditText2, uIItemEdit2.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);
        }

        /// <summary>
        ///     HomeAddressLookup - Use 'HomeAddressLookupExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeAddressLookup()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow6.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow7.UIItemEdit;

            #endregion

            Assert.AreEqual(this.HomeAddressLookupExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.HomeAddressLookupExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     HomeAcceptQuote_1 - Use 'HomeAcceptQuote_1Params' to pass parameters into this method.
        /// </summary>
        public void HomeAcceptQuote1()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmationWindow.UIItemWindow.UIItemEdit;
            WinControl uILookupButton = this.UIPolicyDetailConfirmationWindow.UILookupWindow.UILookupButton;
            WinControl uIOKButton3 = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = this.UIPolicyDetailConfirmationWindow.UIConfirmWindow.UIConfirmButton;
            WinControl uIOKButton4 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton5 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton6 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uIOKButton7 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIOKButton8 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(35, 13));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton1, new Point(35, 17));

            Mouse.Click(uIOKButton2, new Point(29, 10));

            uIItemEdit.Text = this.HomeAcceptQuote1Params.UIItemEditText;

            Mouse.Click(uILookupButton, new Point(25, 13));

            Mouse.Click(uIOKButton3, new Point(20, 19));

            Mouse.Click(uIConfirmButton, new Point(26, 9));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton4, new Point(46, 12));

            Playback.PlaybackSettings.ContinueOnError = false;

            uIDeferPrintingCheckBox.Checked = this.HomeAcceptQuote1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton5, new Point(60, 10));

            uIAddActivityCheckBox.Checked = this.HomeAcceptQuote1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton6, new Point(40, 8));

            Mouse.Click(uIOKButton7, new Point(54, 8));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton7, new Point(40, 18));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton8, new Point(43, 20));
        }

        /// <summary>
        ///     HomeRebrokeSelectAlternative
        /// </summary>
        public void HomeRebrokeSelectAlternative()
        {
            #region Variable Declarations

            WinControl uISelectAlternativeButton = this.UIHouseholdRebrokeResuWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            #endregion

            // Click '&Select Alternative' button
            Mouse.Click(uISelectAlternativeButton, new Point(49, 13));
        }

        /// <summary>
        ///     HomeRebrokeFinish
        /// </summary>
        public void HomeRebrokeFinish()
        {
            #region Variable Declarations

            WinControl uIokButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIokButton, new Point(36, 13));
        }

        /// <summary>
        ///     HomeRebrokeCurrent
        /// </summary>
        public void HomeRebrokeCurrent()
        {
            #region Variable Declarations

            WinControl uIokButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIokButton, new Point(60, 9));

            Mouse.Click(uIYesButton, new Point(63, 11));
        }

        /// <summary>
        ///     HomeRebroke
        /// </summary>
        public void HomeRebroke()
        {
            #region Variable Declarations

            WinControl uIRebrokeButton = this.UIAUTO2301001Window.UIRebrokeWindow.UIRebrokeButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            #endregion

            Mouse.Click(uIRebrokeButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(41, 15));

            Mouse.Click(uIProceedButton, new Point(61, 11));
        }

        /// <summary>
        ///     HomeProposer - Use 'HomeProposerParams' to pass parameters into this method.
        /// </summary>
        public void HomeProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow11.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow21.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow31.UIItemComboBox;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow5.UIItemEdit;
            WinControl uILookupButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UILookupWindow.UILookupButton;
            WinControl uIokButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type 'test1' in text box
            uIItemEdit.Text = this.HomeProposerParams.UIItemEditText;

            // Type 'test' in text box
            uIItemEdit1.Text = this.HomeProposerParams.UIItemEditText1;

            // Type 'test' in text box
            uIItemEdit.Text = this.HomeProposerParams.UIItemEditText2;

            // Select 'Account Director' in combo box
            uIItemComboBox.SelectedItem = this.HomeProposerParams.UIItemComboBoxSelectedItem;

            // Select 'Advertising' in combo box
            uIItemComboBox1.SelectedItem = this.HomeProposerParams.UIItemComboBoxSelectedItem1;

            // Type '160589' in text box
            uIItemEdit2.Text = this.HomeProposerParams.UIItemEditText3;

            // Click text box
            Mouse.Click(uIItemEdit3, new Point(48, 10));

            // Type 'B338TH' in text box
            uIItemEdit3.Text = this.HomeProposerParams.UIItemEditText4;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(28, 13));

            Mouse.Click(uIokButton, new Point(43, 7));
        }

        /// <summary>
        ///     HomePrintQuote
        /// </summary>
        public void HomePrintQuote()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(19, 8));
        }

        /// <summary>
        ///     HomeOpenQuote
        /// </summary>
        public void HomeOpenQuote()
        {
            #region Variable Declarations

            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIokButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(31, 8));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(123, 7));

            Mouse.Click(uIokButton, new Point(44, 13));
        }

        /// <summary>
        ///     HomeOpenPolicy
        /// </summary>
        public void HomeOpenPolicy()
        {
            #region Variable Declarations

            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIDetailButton, new Point(26, 12));

            // Click text box
            Mouse.Click(uIItemEdit, new Point(25, 5));
        }

        /// <summary>
        ///     HomeMTASelectQuote - Use 'HomeMTASelectQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTASelectQuote()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIClient;
            WinClient uIQuotesResultsClient1 = this.UIQuotesResultsWindow.UIItemWindow2.UIClient;
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIQuotesResultsClient, new Point(424, 227));

            Keyboard.SendKeys(uIQuotesResultsClient1, this.HomeMTASelectQuoteParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(64, 11));

            Mouse.Click(uIokButton, new Point(37, 8));

            Mouse.Click(uIokButton1, new Point(39, 16));

            Mouse.Click(uIokButton2, new Point(58, 15));

            uIDeferPrintingCheckBox.Checked = this.HomeMTASelectQuoteParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(50, 8));

            uIAddActivityCheckBox.Checked = this.HomeMTASelectQuoteParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(29, 19));

            Mouse.Click(uIokButton5, new Point(33, 12));

            Mouse.Click(uIokButton5, new Point(39, 13));
        }

        /// <summary>
        ///     HomeMTAEnterDate - Use 'HomeMTAEnterDateParams' to pass parameters into this method.
        /// </summary>
        public void HomeMTAEnterDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;

            #endregion

            uIItemEdit.Text = this.HomeMTAEnterDateParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeMTACoverDate
        /// </summary>
        public void HomeMTACoverDate()
        {
            #region Variable Declarations

            WinControl uIokButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIokButton, new Point(46, 8));
        }

        /// <summary>
        ///     HomeCreatePolicy - Use 'HomeCreatePolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeCreatePolicy()
        {
            #region Variable Declarations

            WinControl uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow8.UIItemEdit;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow22.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow32.UIItemEdit;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinEdit uIItemEdit4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow41.UIItemEdit;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uInoButton = this.UICreditCheckWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uINextButton, new Point(19, 6));

            uIItemEdit.Text = this.HomeCreatePolicyParams.UIItemEditText;

            Mouse.Click(uINextButton1, new Point(39, 18));

            Mouse.Click(uINextButton2, new Point(39, 18));

            Mouse.Click(uINextButton3, new Point(39, 18));

            uIItemEdit1.Text = this.HomeCreatePolicyParams.UIItemEditText1;

            uIItemEdit2.Text = this.HomeCreatePolicyParams.UIItemEditText2;

            uIItemEdit3.Text = this.HomeCreatePolicyParams.UIItemEditText3;

            Mouse.Click(uINextButton4, new Point(42, 17));

            uIItemEdit4.Text = this.HomeCreatePolicyParams.UIItemEditText4;

            Mouse.Click(uINextButton5, new Point(16, 13));

            Mouse.Click(uINextButton6, new Point(31, 11));

            Mouse.Click(uIQuoteButton, new Point(31, 11));

            Mouse.Click(uInoButton, new Point(56, 12));
        }

        /// <summary>
        ///     HomeCheckNewPremium - Use 'HomeCheckNewPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckNewPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicygdfhdfdfghgdfWindow.UIBillingScreenHomeTestWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreNotEqual(this.HomeCheckNewPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     HomeChangePremium - Use 'HomeChangePremiumParams' to pass parameters into this method.
        /// </summary>
        public void HomeChangePremium()
        {
            #region Variable Declarations

            WinControl uIPremiumButton = this.UIQuotesResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIokButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIPremiumButton, new Point(38, 11));

            uIItemEdit.Text = this.HomeChangePremiumParams.UIItemEditText;

            uIItemEdit1.Text = this.HomeChangePremiumParams.UIItemEditText1;

            Mouse.Click(uIokButton, new Point(52, 15));
        }

        /// <summary>
        ///     HomeCancelPolicyQuote_1
        /// </summary>
        public void HomeCancelPolicyQuote1()
        {
            #region Variable Declarations

            WinControl uIokButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinControl uInoButton = this.UIClaimsWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uIokButton, new Point(52, 9));

            Mouse.Click(uInoButton, new Point(43, 18));
        }

        /// <summary>
        ///     HomeCancelPolicyQuote
        /// </summary>
        public void HomeCancelPolicyQuote()
        {
            #region Variable Declarations

            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;

            #endregion

            Mouse.Click(uIQuoteButton, new Point(41, 7));
        }

        /// <summary>
        ///     HomeCancelPolicyExit
        /// </summary>
        public void HomeCancelPolicyExit()
        {
            #region Variable Declarations

            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIokButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;
            WinControl uICancelButton = this.UIOpenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(58, 11));

            Mouse.Click(uIokButton, new Point(40, 10));

            Mouse.Click(uICancelButton, new Point(54, 12));
        }

        /// <summary>
        ///     HomeCancelPolicyAccept - Use 'HomeCancelPolicyAcceptParams' to pass parameters into this method.
        /// </summary>
        public void HomeCancelPolicyAccept()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIClient;
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIQuotesResultsClient, new Point(491, 235));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeCancelPolicyAcceptParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(85, 15));

            Mouse.Click(uIokButton, new Point(65, 9));

            Mouse.Click(uIokButton1, new Point(39, 10));

            Mouse.Click(uIokButton2, new Point(47, 13));

            uIDeferPrintingCheckBox.Checked = this.HomeCancelPolicyAcceptParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(68, 12));

            uIAddActivityCheckBox.Checked = this.HomeCancelPolicyAcceptParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(42, 12));

            Mouse.Click(uIokButton5, new Point(23, 5));
        }

        /// <summary>
        ///     HomeCancelPolicy - Use 'HomeCancelPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeCancelPolicy()
        {
            #region Variable Declarations

            WinControl uIMTAButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow1.UIMTAButton2;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIMTAButton, new Point(35, 8));

            uIItemComboBox.SelectedItem = this.HomeCancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(31, 11));
        }

        /// <summary>
        ///     HomeCancelCopy
        /// </summary>
        public void HomeCancelCopy()
        {
            #region Variable Declarations

            WinControl uICancelButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(42, 12));

            Mouse.Click(uIYesButton, new Point(56, 7));

            Mouse.Click(uIYesButton, new Point(31, 15));

            Mouse.Click(uIOKButton, new Point(49, 15));
        }

        /// <summary>
        ///     HomeAmendSelecPolicy - Use 'HomeAmendSelecPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendSelecPolicy()
        {
            #region Variable Declarations

            WinClient uIHouseholdRenewalsAmeClient = this.UIHouseholdRenewalsAmeWindow.UIItemWindow7.UIClient;

            #endregion

            Mouse.Click(uIHouseholdRenewalsAmeClient, new Point(337, 202));

            Keyboard.SendKeys(uIHouseholdRenewalsAmeClient, this.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeAmendRisk - Use 'HomeAmendRiskParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRisk()
        {
            #region Variable Declarations

            WinControl uIAmendRiskButton = this.UIAUTO2251001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.UIHouseholdRenewalsAmeWindow.UIItemWindow.UIItemEdit;
            WinControl uINextButton = this.UIHouseholdRenewalsAmeWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIHouseholdRenewalsAmeWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIHouseholdRenewalsAmeWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIHouseholdRenewalsAmeWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIHouseholdRenewalsAmeWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIHouseholdRenewalsAmeWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIHouseholdRenewalsAmeWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIHouseholdRenewalsAmeWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            #endregion

            Mouse.Click(uIAmendRiskButton, new Point(67, 17));

            uIItemEdit.Text = this.HomeAmendRiskParams.UIItemEditText;

            Mouse.Click(uINextButton, new Point(36, 13));

            Mouse.Click(uINextButton1, new Point(44, 13));

            Mouse.Click(uINextButton2, new Point(44, 13));

            Mouse.Click(uINextButton3, new Point(44, 13));

            Mouse.Click(uINextButton4, new Point(44, 13));

            Mouse.Click(uINextButton5, new Point(44, 13));

            Mouse.Click(uINextButton6, new Point(44, 13));

            Mouse.Click(uIQuoteButton, new Point(44, 13));

            Mouse.Click(uIProceedButton, new Point(59, 15));
        }

        /// <summary>
        ///     HomeAmendRenewFinish_1 - Use 'HomeAmendRenewFinish_1Params' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRenewFinish1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinControl uIokButton4 = this.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIokButton5 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.HomeAmendRenewFinish1Params.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton, new Point(74, 12));

            Mouse.Click(uIokButton1, new Point(47, 12));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIokButton1, new Point(54, 13));

            Playback.PlaybackSettings.ContinueOnError = false;

            uIAddActivityCheckBox.Checked = this.HomeAmendRenewFinish1Params.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton2, new Point(48, 9));

            Mouse.Click(uIokButton3, new Point(19, 12));

            uIItemList.SelectedItemsAsString = this.HomeAmendRenewFinish1Params.UIItemListSelectedItemsAsString;

            Mouse.Click(uIokButton4, new Point(13, 16));

            Mouse.Click(uIokButton5, new Point(46, 16));
        }

        /// <summary>
        ///     HomeAmendRenewFinish
        /// </summary>
        public void HomeAmendRenewFinish()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIHouseholdRenewalsAmeWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(52, 9));

            Mouse.Click(uIYesButton, new Point(55, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uICancelButton, new Point(51, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     HomeAmendRenew - Use 'HomeAmendRenewParams' to pass parameters into this method.
        /// </summary>
        public void HomeAmendRenew()
        {
            #region Variable Declarations

            WinControl uIRenewPolicyButton = this.UIHouseholdRenewalsAmeWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uIokButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinControl uIokButton5 = this.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinControl uIokButton6 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(36, 18));

            Mouse.Click(uIYesButton, new Point(50, 20));

            Mouse.Click(uIYesButton, new Point(65, 18));

            Mouse.Click(uIokButton, new Point(26, 16));

            uIDeferPrintingCheckBox.Checked = this.HomeAmendRenewParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton1, new Point(74, 19));

            Mouse.Click(uIokButton2, new Point(64, 14));

            uIAddActivityCheckBox.Checked = this.HomeAmendRenewParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(60, 17));

            Mouse.Click(uIokButton4, new Point(21, 8));

            // Select 'AG Administrator General' in list box
            uIItemList.SelectedItemsAsString = this.HomeAmendRenewParams.UIItemListSelectedItemsAsString;

            Mouse.Click(uIokButton5, new Point(60, 14));

            Mouse.Click(uIokButton6, new Point(30, 15));
        }

        /// <summary>
        ///     HomeAcceptQuote
        /// </summary>
        public void HomeAcceptQuote()
        {
            #region Variable Declarations

            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIAcceptButton, new Point(33, 15));

            Mouse.Click(uIYesButton, new Point(39, 13));
        }

        /// <summary>
        ///     HouseRegressApp - Use 'HouseRegressAppParams' to pass parameters into this method.
        /// </summary>
        public void HouseRegressApp()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.UIRegressIETamPolicyWindow.UIItemWindow4.UIItemComboBox;

            #endregion

            // Select 'Household' in combo box
            uIItemComboBox.SelectedItem = this.HouseRegressAppParams.UIItemComboBoxSelectedItem;
        }

        /// <summary>
        ///     HomeStartDate - Use 'HomeStartDateParams' to pass parameters into this method.
        /// </summary>
        public void HomeStartDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            uIItemEdit.Text = this.HomeStartDateParams.UIItemEditText;
        }

        /// <summary>
        ///     HomeSiteRenewal - Use 'HomeSiteRenewalParams' to pass parameters into this method.
        /// </summary>
        public void HomeSiteRenewal()
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaHouseholdTestHyperlink =
                this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaHouseholdTestHyperlink;
            HtmlComboBox uIInsurerIDComboBox = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPolicyNumberEdit;
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtRenewalDateEdit;
            HtmlEdit uITxtAutoLapseDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtAutoLapseDateEdit;
            HtmlTextArea uITxtClientXmlEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtClientXmlEdit;
            HtmlInputButton uIGetXMLfromServerButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIGetXMLfromServerButton;
            HtmlInputButton uICreateRecordButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.UIInsurEcomSystemMaintWindow;

            #endregion

            Mouse.Click(uICreateaHouseholdTestHyperlink, new Point(48, 20));

            uIInsurerIDComboBox.SelectedItem = this.HomeSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            uITxtPolicyNumberEdit.Text = this.HomeSiteRenewalParams.UITxtPolicyNumberEditText;

            uITxtRenewalDateEdit.Text = this.HomeSiteRenewalParams.UITxtRenewalDateEditText;

            uITxtAutoLapseDateEdit.Text = this.HomeSiteRenewalParams.UITxtAutoLapseDateEditText;

            Mouse.Click(uITxtClientXmlEdit, new Point(284, 43));

            Mouse.Click(uIGetXMLfromServerButton, new Point(114, 9));

            Mouse.Click(uICreateRecordButton, new Point(102, 11));

            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        /// <summary>
        ///     HomeSelectPolicy1 - Use 'HomeSelectPolicy1Params' to pass parameters into this method.
        /// </summary>
        public void HomeSelectPolicy1()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIClient;

            #endregion

            Mouse.Click(uIQuotesResultsClient, new Point(354, 212));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeSelectPolicy1Params.UIQuotesResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeSelectPolicy - Use 'HomeSelectPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeSelectPolicy()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient;

            #endregion

            Mouse.Click(uIQuotesResultsClient, new Point(367, 171));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeSelectPolicyParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeRenewalConfirm
        /// </summary>
        public void HomeRenewalConfirm()
        {
            #region Variable Declarations

            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIYesButton, new Point(33, 10));
        }

        /// <summary>
        ///     HomeRenewalCancelledCheck - Use 'HomeRenewalCancelledCheckExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalCancelledCheck()
        {
            #region Variable Declarations

            WinText uIMTAsuccessfullyproceText = this.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            #endregion

            StringAssert.Contains(uIMTAsuccessfullyproceText.DisplayText, this.HomeRenewalCancelledCheckExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     HomeRenewalBeforeFinish - Use 'HomeRenewalBeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalBeforeFinish()
        {
            #region Variable Declarations

            WinControl uIOKButton = this.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton1 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIOKButton3 = this.UITamxml7Window.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(49, 11));

            uIDeferPrintingCheckBox.Checked = this.HomeRenewalBeforeFinishParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(53, 18));

            uIAddActivityCheckBox.Checked = this.HomeRenewalBeforeFinishParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(33, 12));

            Mouse.Click(uIOKButton3, new Point(28, 13));

            Mouse.Click(uIOKButton3, new Point(35, 11));
        }

        /// <summary>
        ///     HomeRenewalBeforeAccept - Use 'HomeRenewalBeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void HomeRenewalBeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow1.UIClient;
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIQuotesResultsClient, new Point(420, 229));

            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeRenewalBeforeAcceptParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(75, 10));

            Mouse.Click(uIokButton, new Point(36, 16));

            Mouse.Click(uIokButton1, new Point(37, 19));

            Mouse.Click(uIokButton2, new Point(48, 14));
        }

        /// <summary>
        ///     HomeRebrokeSelectPolicy - Use 'HomeRebrokeSelectPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeRebrokeSelectPolicy()
        {
            #region Variable Declarations

            WinClient uIHouseholdRebrokeResuClient = this.UIHouseholdRebrokeResuWindow.UIItemWindow.UIClient;

            #endregion

            Mouse.Click(uIHouseholdRebrokeResuClient, new Point(449, 216));

            Keyboard.SendKeys(uIHouseholdRebrokeResuClient, this.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     HomeCheckPremium - Use 'HomeCheckPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void HomeCheckPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreNotEqual(this.HomeCheckPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }
    }
}