namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class HouseActions : UIMap
    {
        private HomeCheckPremiumExpectedValues mHomeCheckPremiumExpectedValues;

        private HomeCheckPrintExpectedValues mHomeCheckPrintExpectedValues;

        private HomeCheckStatusExpectedValues mHomeCheckStatusExpectedValues;

        private HomeCheckZeroPremiumExpectedValues mHomeCheckZeroPremiumExpectedValues;

        private HomeCopyCheckDataExpectedValues mHomeCopyCheckDataExpectedValues;

        private HomeCheckPolicyPremiumExpectedValues mHomeCheckPolicyPremiumExpectedValues;

        private HomeMTAChangeParams mHomeMtaChangeParams;

        private HomeMTACheckCancelledExpectedValues mHomeMTACheckCancelledExpectedValues;

        private HomeMTACheckChangedExpectedValues mHomeMTACheckChangedExpectedValues;

        private HomeMTACheckMessageExpectedValues mHomeMTACheckMessageExpectedValues;

        private HomeMTACopyCheckExpectedValues mHomeMTACopyCheckExpectedValues;

        private AddressLookupExpectedValues mAddressLookupExpectedValues;

        private HomeCreatePolicyParams mHomeCreatePolicyParams;

        private HomeCheckNewPremiumExpectedValues mHomeCheckNewPremiumExpectedValues;

        private HomeChangePremiumParams mHomeChangePremiumParams;

        private HomeAmendRiskParams mHomeAmendRiskParams;

        private HomeRenewalCancelledCheckExpectedValues mHomeRenewalCancelledCheckExpectedValues;

        public string CustomerCode { get; set; }

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

        public virtual AddressLookupExpectedValues AddressLookupExpectedValues
        {
            get
            {
                if ((this.mAddressLookupExpectedValues == null))
                {
                    this.mAddressLookupExpectedValues = new AddressLookupExpectedValues();
                }
                return this.mAddressLookupExpectedValues;
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

        public void HomePrintQuote1()
        {
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = this.UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIPrintQuoteButton = this.UIQuotesResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

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

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIQuotesResultsClient, new Point(526, 161));

            Keyboard.SendKeys(uIQuotesResultsClient, this.CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Click(uIPrintQuoteButton, new Point(65, 11));
        }

        public void HomeExitWithPolicy()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIOKButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = this.UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uICancelButton1 = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

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

            Keyboard.SendKeys(uIQuotesResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIExitButton, new Point(46, 13));

            Mouse.Click(uIYesButton, new Point(51, 13));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(45, 15));

            this.SelectTamInsurersAndActivity(selectListItems1: 1);

            Mouse.Click(uICancelButton1, new Point(37, 17));

            Mouse.Click(uIItemButton, new Point(28, 18));

            Mouse.Click(uIDetailButton, new Point(29, 11));

            Mouse.Click(uIItemEdit, new Point(22, 8));
        }

        public void HomeAcceptPolicy()
        {
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmationWindow.UIItemWindow.UIItemEdit;

            Playback.Wait(3000);

            Mouse.Move(UIQuotesResultsWindow, new Point(500, 500));
            Mouse.Click(UIQuotesResultsWindow);

            Playback.Wait(3000);

            Mouse.Click(uIAcceptButton, new Point(47, 11));

            Mouse.Click(uIYesButton, new Point(49, 11));

            this.CancelPrint();

            Mouse.Click(uIOKButton1, new Point(47, 22));

            Mouse.Click(uIOKButton2, new Point(46, 11));

            uIItemEdit.Text = this.ProposerParams.Postcode;
        }

        public void HomeCheckPrint()
        {
            HtmlCell uIItem1989Cell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIItem1989Cell;
            HtmlCell uIMrTestTestCell = this.UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIMrTestTestCell;

            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIItem1989CellInnerText, uIItem1989Cell.InnerText);

            Assert.AreEqual(this.HomeCheckPrintExpectedValues.UIMrTestTestCellInnerText, uIMrTestTestCell.InnerText);
        }

        public void HomeCheckStatus()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            Assert.AreEqual(this.HomeCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeCheckZeroPremium()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(this.HomeCheckZeroPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeClickPremium()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Mouse.Click(uIItemEdit, new Point(24, 5));
        }

        public void HomeCloseOpenPolicy()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            Mouse.Click(uICancelButton, new Point(33, 16));

            Mouse.Click(uIItemButton, new Point(18, 20));

            Mouse.Click(uIDetailButton, new Point(44, 16));
        }

        public void HomeCloseOpenPolicyList()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;

            Mouse.Click(uICancelButton, new Point(47, 19));

            Mouse.Click(uIItemButton, new Point(21, 14));
        }

        public void HomeClosePolicy()
        {
            WinControl uICloseButton = this.UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICloseButton;
            WinControl uIokButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICloseButton, new Point(33, 13));

            Mouse.Click(uIokButton, new Point(36, 14));
        }

        public void HomeCopyCheckData()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIQuotesWindow.TbxJobTitle.UIItemComboBox;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            Assert.AreEqual(this.HomeCopyCheckDataExpectedValues.UIItemEditText2, uIItemEdit2.Text);
        }

        public void HomeCopyRisk()
        {
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinControl uIOKButton = this.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinRadioButton uIHouseholdRadioButton = this.UIProductSelectionWindow.UIHouseholdWindow.UIHouseholdRadioButton;
            WinControl uIOKButton1 = this.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOptionsButton, new Point(26, 9));

            Mouse.Click(uICopyRiskMenuItem, new Point(93, 8));

            Mouse.Click(uIOKButton, new Point(54, 10));

            uIHouseholdRadioButton.Selected = this.CommonParams.UIHouseholdRadioButtonSelected;

            Mouse.Click(uIOKButton1, new Point(42, 21));
        }

        public void HomeDemands()
        {
            WinControl uIokButton = this.UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = this.UIQuotesResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            Mouse.Click(uIokButton, new Point(36, 9));

            Mouse.Click(uIDemandsNeedsButton, new Point(59, 13));
        }

        public void HomeExitWithoutPolicy()
        {
            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            Mouse.Click(uIExitButton, new Point(54, 9));

            Mouse.Click(uIYesButton, new Point(45, 6));

            Mouse.Click(uIAddActivityCheckBox);

            Mouse.Click(uIOKButton, new Point(30, 15));

            this.SelectTamInsurersAndActivity(selectListItems1: 2);
        }

        /// <summary>
        ///     HomeMTAAccept
        /// </summary>
        /// <param name="needScreenshot"></param>
        /// <param name="expectedDate"></param>
        public void HomeMTAAccept(bool needScreenshot, string expectedDate = "")
        {
            WinControl uINextButton = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;

            Mouse.Click(uINextButton, new Point(39, 12));

            Mouse.Click(uINextButton1, new Point(47, 12));

            Mouse.Click(uINextButton2, new Point(47, 12));

            Mouse.Click(uINextButton3, new Point(47, 12));

            Mouse.Click(uINextButton4, new Point(47, 12));

            Mouse.Click(uINextButton5, new Point(47, 12));

            Mouse.Click(uINextButton6, new Point(47, 12));

            if (needScreenshot)
            {
                Image image = this.UIInsurEtamWindow.UIQuotesWindow.CaptureImage();
                image.Save(string.Format(Configs.ScreenshotPath, expectedDate));
            }

            Mouse.Click(uIQuoteButton, new Point(47, 12));
        }

        public void HomeMTAAfter()
        {
            WinControl uIAfterButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;

            Mouse.Click(uIAfterButton, new Point(38, 10));
        }

        public void HomeMTABefore()
        {
            WinControl uIBeforeButton = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;

            Mouse.Click(uIBeforeButton, new Point(27, 12));
        }

        public void HomeMTACancel()
        {
            WinControl uICancelButton = this.UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(42, 13));

            Mouse.Click(uIYesButton, new Point(35, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));
        }

        public void HomeMTACancel1()
        {
            WinControl uICancelButton = this.UIInsurEtamWindow.UIQuotesWindow.UICancelWindow2.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(37, 17));

            Mouse.Click(uIYesButton, new Point(66, 11));

            Mouse.Click(uIOKButton, new Point(49, 13));
        }

        public void HomeMTAChange()
        {
            WinControl uIMTAButton = this.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Playback.Wait(2000);
            Mouse.Click(uIMTAButton, new Point(45, 12));

            uIItemComboBox.SelectedItem = this.HomeMTAChangeParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(35, 15));

            uIItemEdit.Text = this.HomeMTAChangeParams.UIItemEditText;
        }

        public void HomeMTACheckCancelled()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Assert.AreEqual(this.HomeMTACheckCancelledExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeMTACheckChanged()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Assert.AreEqual(this.HomeMTACheckChangedExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeMTACheckMessage()
        {
            WinText uIDateBeforeCurrentMTAText = this.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            Assert.AreEqual(this.HomeMTACheckMessageExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        public void HomeMTACloseMessage()
        {
            WinControl uIOKButton = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton, new Point(52, 7));
        }

        public void HomeMTACopyCheck()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;
            WinComboBox uIItemComboBox = this.UIInsurEtamWindow.UIQuotesWindow.TbxJobSector.UIItemComboBox;

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.NewSurname, uIItemEdit.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.Postcode, uIItemEdit1.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.Address, uIItemEdit2.Text);

            Assert.AreEqual(this.HomeMTACopyCheckExpectedValues.JobSector, uIItemComboBox.SelectedItem);
        }

        public void HomeAddressLookup()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow7.UIItemEdit;

            Assert.AreEqual(this.AddressLookupExpectedValues.AddressLine1, uIItemEdit.Text);

            Assert.AreEqual(this.AddressLookupExpectedValues.AddressLine2, uIItemEdit1.Text);
        }

        public void HomeAcceptQuote1()
        {
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
            WinControl uIOKButton7 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(35, 13));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton1, new Point(35, 17));

            Mouse.Click(uIOKButton2, new Point(29, 10));

            uIItemEdit.Text = this.ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(25, 13));

            Mouse.Click(uIOKButton3, new Point(20, 19));

            Mouse.Click(uIConfirmButton, new Point(26, 9));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton4, new Point(46, 12));

            Playback.PlaybackSettings.ContinueOnError = false;

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton5, new Point(60, 10));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton6, new Point(40, 8));

            Mouse.Click(uIOKButton7, new Point(54, 8));

            this.SelectTamInsurersAndActivity(selectListItems1: 2);
        }

        public void HomeRebrokeSelectAlternative()
        {
            WinControl uISelectAlternativeButton = this.UIHouseholdRebrokeResuWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            Mouse.Click(uISelectAlternativeButton, new Point(49, 13));
        }

        public void HomeRebrokeFinish()
        {
            WinControl uIokButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIokButton, new Point(36, 13));
        }

        public void HomeRebrokeCurrent()
        {
            WinControl uIokButton = this.UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Click(uIokButton, new Point(60, 9));

            Mouse.Click(uIYesButton, new Point(63, 11));
        }

        public void HomeRebroke()
        {
            WinControl uIRebrokeButton = this.UIAUTOWindow.UIRebrokeWindow.UIRebrokeButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            Mouse.Click(uIRebrokeButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(41, 15));

            Mouse.Click(uIProceedButton, new Point(61, 11));
        }

        public void HomeProposer()
        {
            WinEdit tbxFirstname = this.UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinEdit tbxLastName = this.UIInsurEtamWindow.UIQuotesWindow.TbxLastName.UIItemEdit;
            WinComboBox tbxJobTitle = this.UIInsurEtamWindow.UIQuotesWindow.TbxJobTitle.UIItemComboBox;
            WinComboBox tbxJobSector = this.UIInsurEtamWindow.UIQuotesWindow.TbxJobSector.UIItemComboBox;
            WinEdit tbxDateOfBirth = this.UIInsurEtamWindow.UIQuotesWindow.TbxDateOfBirth.UIItemEdit;
            WinEdit txbPostcode = this.UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinControl uILookupButton = this.UIInsurEtamWindow.UIQuotesWindow.UILookupWindow.UILookupButton;
            WinControl uIokButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            tbxLastName.Text = this.ProposerParams.Lastname;

            tbxFirstname.Text = this.ProposerParams.Firstname;

            tbxJobTitle.SelectedItem = this.ProposerParams.JobTitle;

            tbxJobSector.SelectedItem = this.ProposerParams.JobSector;

            tbxDateOfBirth.Text = this.ProposerParams.DateOfBirth;

            Mouse.Click(txbPostcode, new Point(48, 10));

            txbPostcode.Text = this.ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(28, 13));

            Mouse.Click(uIokButton, new Point(43, 7));
        }

        public void HomeProposerFull()
        {
            WinButton uIQuoteButton = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIQuoteWindow.UIQuoteButton;

            this.HomeProposerFullStep1();
            this.HomeProposerFullStep2();
            this.HomeProposerFullStep3();
            this.HomeProposerFullStep4();
            this.HomeProposerFullStep5();
            this.HomeProposerFullStep6();

            Mouse.Click(uIQuoteButton, new Point(14, 11));
        }

        public void HomePrintQuote()
        {
            WinControl uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton, new Point(19, 8));
        }

        public void HomeOpenQuote()
        {
            WinControl uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIokButton = this.UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOptionsButton, new Point(31, 8));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(123, 7));

            Mouse.Move(new Point(500, 500));

            this.WaitForControl(uIokButton);
            Mouse.Click(uIokButton, new Point(44, 13));
        }

        public void HomeOpenPolicy()
        {
            WinControl uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Mouse.Click(uIDetailButton, new Point(26, 12));

            Mouse.Click(uIItemEdit, new Point(25, 5));
        }

        public void HomeMTASelectQuote()
        {
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Mouse.Click(uIQuotesResultsClient, new Point(424, 227));

            Keyboard.SendKeys(uIQuotesResultsClient, this.CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(64, 11));

            Mouse.Click(uIokButton, new Point(37, 8));

            Mouse.Click(uIokButton1, new Point(39, 16));

            this.WaitForControl(uIokButton2);

            Mouse.Click(uIokButton2, new Point(58, 15));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(50, 8));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(29, 19));

            this.SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        public void HomeMTAEnterDate(string withDate = "")
        {
            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;

            uIItemEdit.Text = string.IsNullOrEmpty(withDate) ? DateTime.Now.AddDays(2).ToString("dd/MM/yy") : withDate;
        }

        public string HomeMTACoverDate()
        {
            WinEdit uIMTADate = this.UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinEdit uIMTATime = this.UIMTAEffectiveDatesWindow.UIMTATime.UIItemEdit;
            WinControl uIokButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            string mtaDate = uIMTADate.Text.Replace(" ", "_") + "_" + uIMTATime.Text.Replace(":", "");
            Mouse.Click(uIokButton, new Point(46, 8));

            return mtaDate;
        }

        public void HomeCreatePolicy()
        {
            WinControl uINextButton = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow8.UIItemEdit;
            WinControl uINextButton1 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinEdit uIItemEdit1 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow22.UIItemEdit;
            WinControl uINextButton4 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinEdit uIItemEdit4 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow41.UIItemEdit;
            WinControl uINextButton5 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uInoButton = this.UICreditCheckWindow.UINoWindow.UINoButton;

            Mouse.Click(uINextButton, new Point(19, 6));

            uIItemEdit.Text = this.HomeCreatePolicyParams.UIItemEditText;

            Mouse.Click(uINextButton1, new Point(39, 18));

            Mouse.Click(uINextButton2, new Point(39, 18));

            Mouse.Click(uINextButton3, new Point(39, 18));

            uIItemEdit1.Text = this.HomeCreatePolicyParams.UIItemEditText1;

            uIItemEdit2.Text = this.HomeCreatePolicyParams.UIItemEditText2;

            Mouse.Click(uINextButton4, new Point(42, 17));

            uIItemEdit4.Text = this.HomeCreatePolicyParams.UIItemEditText4;

            Mouse.Click(uINextButton5, new Point(16, 13));

            Mouse.Click(uINextButton6, new Point(31, 11));

            Mouse.Click(uIQuoteButton, new Point(31, 11));

            Mouse.Click(uInoButton, new Point(56, 12));
        }

        public void HomeCheckNewPremium()
        {
            WinEdit uIItemEdit = this.UIPolicygdfhdfdfghgdfWindow.UIBillingScreenHomeTestWindow.UIItemWindow.UIItemEdit;

            Assert.AreNotEqual(this.HomeCheckNewPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeChangePremium(int overridePremium)
        {
            WinControl uIPremiumButton = this.UIQuotesResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = this.UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIokButton = this.UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIPremiumButton, new Point(38, 11));

            uIItemEdit.Text = overridePremium.ToString(CultureInfo.InvariantCulture);

            uIItemEdit1.Text = this.HomeChangePremiumParams.UIItemEditText1;

            Mouse.Click(uIokButton, new Point(52, 15));
        }

        public void HomeCancelPolicyQuote1()
        {
            WinControl uIokButton = this.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinControl uInoButton = this.UIClaimsWindow.UINoWindow.UINoButton;

            Mouse.Click(uIokButton, new Point(52, 9));

            Mouse.Click(uInoButton, new Point(43, 18));
        }

        public void HomeCancelPolicyQuote()
        {
            WinControl uIQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;

            Mouse.Click(uIQuoteButton, new Point(41, 7));
        }

        public void HomeCancelPolicyExit()
        {
            WinControl uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIokButton = this.UIInsurEtamWindow1.UIOKWindow1.UIOKButton;
            WinControl uICancelButton = this.UIOpenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIExitButton, new Point(58, 11));

            Mouse.Click(uIokButton, new Point(40, 10));

            Mouse.Click(uICancelButton, new Point(54, 12));
        }

        public void HomeCancelPolicyAccept()
        {
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Playback.Wait(2000);

            Mouse.Click(uIQuotesResultsClient, new Point(491, 235));

            Keyboard.SendKeys(uIQuotesResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(85, 15));

            Mouse.Click(uIokButton, new Point(65, 9));

            Mouse.Click(uIokButton1, new Point(39, 10));

            Mouse.Click(uIokButton2, new Point(47, 13));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(68, 12));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(42, 12));

            this.SelectTamInsurersAndActivity(selectListItems1: 1);
        }

        public void HomeCancelPolicy()
        {
            WinControl uIMTAButton = this.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = this.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = this.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;

            Playback.Wait(5000);
            Mouse.Click(uIMTAButton, new Point(35, 8));

            uIItemComboBox.SelectedItem = this.CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(31, 11));
        }

        public void HomeCancelCopy()
        {
            WinControl uICancelButton = this.UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = this.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(42, 12));

            Mouse.Click(uIYesButton, new Point(56, 7));

            Mouse.Click(uIYesButton, new Point(31, 15));

            Mouse.Click(uIOKButton, new Point(49, 15));
        }

        public void HomeAmendSelecPolicy(bool newPolicy)
        {
            Playback.Wait(2000);
            WinClient uIHouseholdRenewalsAmeClient = this.UIHouseholdRenewalsResultsWindow.UIItemWindow.UIClient();

            Mouse.Click(uIHouseholdRenewalsAmeClient, newPolicy ? new Point(101, 60) : new Point(101, 31));

            Mouse.Move(new Point(500, 500));
        }

        public void HomeAmendRisk()
        {
            WinControl uIAmendRiskButton = this.UIAUTO2251001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.UIHouseholdRenewalsWindow.UIItemWindow.UIItemEdit;
            WinControl uINextButton = this.UIHouseholdRenewalsWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = this.UIHouseholdRenewalsWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = this.UIHouseholdRenewalsWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = this.UIHouseholdRenewalsWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = this.UIHouseholdRenewalsWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = this.UIHouseholdRenewalsWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = this.UIHouseholdRenewalsWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = this.UIHouseholdRenewalsWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

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

        public void HomeAmendRenewFinish1()
        {
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton, new Point(74, 12));

            int timeout = Playback.PlaybackSettings.SearchTimeout;

            Playback.PlaybackSettings.SearchTimeout = 120000;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIokButton1, new Point(47, 12));

            Playback.PlaybackSettings.ContinueOnError = false;

            Playback.PlaybackSettings.SearchTimeout = timeout;

            this.WaitForControl(uIAddActivityCheckBox);
            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton2, new Point(48, 9));

            Mouse.Click(uIokButton3, new Point(19, 12));

            this.SelectTamInsurersAndActivity(false, onlyOnce: true);
        }

        public void HomeAmendRenewFinish()
        {
            WinControl uIRenewPolicyButton = this.UIHouseholdRenewalsResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;

            Mouse.Click(uIRenewPolicyButton, new Point(52, 9));

            Mouse.Click(uIYesButton, new Point(55, 11));

            this.CancelPrint();
        }

        public void HomeAmendRenew()
        {
            WinControl uIRenewPolicyButton = this.UIHouseholdRenewalsResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uIokButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinControl uIokButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            Playback.Wait(2000);

            Mouse.Click(uIRenewPolicyButton, new Point(36, 18));

            Mouse.Click(uIYesButton, new Point(50, 20));

            Mouse.Click(uIYesButton, new Point(65, 18));

            Mouse.Click(uIokButton, new Point(26, 16));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton1, new Point(74, 19));

            Mouse.Move(new Point(500,500));

            Mouse.Click(uIokButton2, new Point(64, 14));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(60, 17));

            Mouse.Click(uIokButton4, new Point(21, 8));

            this.SelectTamInsurersAndActivity(selectListItems1:2);
        }

        public void HomeAcceptQuote()
        {
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(33, 15));

            Mouse.Click(uIYesButton, new Point(39, 13));
        }

        public void HomeStartDate()
        {
            WinEdit uIItemEdit = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow13.UIItemEdit;

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
        }

        public void HomeSiteRenewal(string policyNumber, string renewalPremium)
        {
            HtmlHyperlink uICreateaHouseholdTestHyperlink =
                this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaHouseholdTestHyperlink;
            HtmlComboBox uIInsurerIDComboBox = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPolicyNumberEdit;
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtRenewalDateEdit;
            HtmlEdit uITxtAutoLapseDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtAutoLapseDateEdit;
            HtmlTextArea uITxtClientXmlEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtClientXmlEdit;
            HtmlInputButton uIGetXMLfromServerButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIGetXMLfromServerButton;
            HtmlEdit uITxtPremiumEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPremiumEdit;
            
            HtmlInputButton uICreateRecordButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.UIInsurEcomSystemMaintWindow;

            Mouse.Click(uICreateaHouseholdTestHyperlink, new Point(48, 20));

            uIInsurerIDComboBox.SelectedItem = this.CommonParams.UIInsurerIDComboBoxSelectedItem;

            uITxtPolicyNumberEdit.Text = policyNumber;

            uITxtPremiumEdit.Text = renewalPremium;

            uITxtRenewalDateEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");

            uITxtAutoLapseDateEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");


            Mouse.Click(uITxtClientXmlEdit, new Point(284, 43));

            Mouse.Click(uIGetXMLfromServerButton, new Point(114, 9));

            Mouse.Click(uICreateRecordButton, new Point(102, 11));

            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        public void HomeSelectPolicy()
        {
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();

            Mouse.Click(uIQuotesResultsClient, new Point(30, 30));

            Playback.Wait(1000);
            Mouse.Move(new Point(500, 500));
        }

        public void HomeRenewalConfirm()
        {
            WinControl uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Click(uIYesButton, new Point(33, 10));
        }

        public void HomeRenewalCancelledCheck()
        {
            WinText uIMTAsuccessfullyproceText = this.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            StringAssert.Contains(uIMTAsuccessfullyproceText.DisplayText, this.HomeRenewalCancelledCheckExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        public void HomeRenewalBeforeFinish()
        {
            WinControl uIOKButton = this.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton1 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Mouse.Click(uIOKButton, new Point(49, 11));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(53, 18));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(33, 12));

            this.SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        public void HomeRenewalBeforeAccept()
        {
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = this.UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            Mouse.Click(uIQuotesResultsClient, new Point(420, 229));

            Keyboard.SendKeys(uIQuotesResultsClient, this.CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(75, 10));

            Mouse.Click(uIokButton, new Point(36, 16));

            Mouse.Click(uIokButton1, new Point(37, 19));

            Mouse.Click(uIokButton2, new Point(48, 14));
        }

        public void HomeRebrokeSelectPolicy(string withKeys)
        {
            WinClient uIHouseholdRebrokeResuClient = this.UIHouseholdRebrokeResuWindow.UIItemWindow.UIClient();

            Mouse.Click(uIHouseholdRebrokeResuClient, new Point(208, 85));

           // Keyboard.SendKeys(uIHouseholdRebrokeResuClient, withKeys, ModifierKeys.None);
        }

        public void HomeCheckPremium()
        {
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Assert.AreNotEqual(this.HomeCheckPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        private void HomeProposerFullStep1()
        {
            WinComboBox mortgageBuildingSociety = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow.UIItemComboBox;
            WinComboBox previousPaymentPeriod = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow1.UIItemComboBox;
            WinCheckBox uIIstheapplicationinjoCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIstheapplicationinjoWindow.UICheckBox("Is the application in joint names?");
            WinButton uIOtherpersonButton = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIOtherpersonWindow.UIButton("Other person...");
            WinComboBox secondApplicantTItle = this.UISecondApplicantDetaiWindow.UIItemWindow.UIItemComboBox;
            WinEdit secondApplicantFirstName = this.UISecondApplicantDetaiWindow.UIItemWindow1.UIItemEdit;
            WinEdit secondApplicantLastname = this.UISecondApplicantDetaiWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UISecondApplicantDetaiWindow.UIItemWindow4.UIItemEdit;
            WinComboBox secondApplicantGender = this.UISecondApplicantDetaiWindow.UIItemWindow5.UIItemComboBox;
            WinComboBox secondApplicantRelationship = this.UISecondApplicantDetaiWindow.UIItemWindow6.UIItemComboBox;
            WinComboBox secondApplicantJobSector = this.UISecondApplicantDetaiWindow.UIItemWindow8.UIItemComboBox;
            WinComboBox secondApplicantJobTitle = this.UISecondApplicantDetaiWindow.UIItemWindow7.UIItemComboBox;
            WinButton uIOKButton = this.UISecondApplicantDetaiWindow.UIOKWindow.UIOKButton;
            WinEdit telephone = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow2.UIEdit("Occupants");
            WinEdit totalOccupants = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow3.UIItemEdit;
            WinEdit childen = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow4.UIItemEdit;
            WinButton uINextButton = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow.UINextButton;

            mortgageBuildingSociety.SelectedItem = this.HouseholdQuoteParams.MortgageBuildingSociety;

            previousPaymentPeriod.SelectedItem = this.HouseholdQuoteParams.PreviousPaymentPeriod;

            uIIstheapplicationinjoCheckBox.Checked = this.HouseholdQuoteParams.UIIstheapplicationinjoCheckBoxChecked;

            Mouse.Click(uIOtherpersonButton, new Point(45, 10));

            secondApplicantTItle.SelectedItem = this.HouseholdQuoteParams.SecondApplicantTItle;

            secondApplicantFirstName.Text = this.HouseholdQuoteParams.SecondApplicantFirstName;

            secondApplicantLastname.Text = this.HouseholdQuoteParams.SecondApplicantLastname;

            uIItemEdit2.Text = this.HouseholdQuoteParams.SecondApplicantDateOfBirth;

            secondApplicantGender.SelectedItem = this.HouseholdQuoteParams.SecondApplicantGender;

            secondApplicantRelationship.SelectedItem = this.HouseholdQuoteParams.SecondApplicantRelationship;

            secondApplicantJobTitle.SelectedItem = this.HouseholdQuoteParams.SecondApplicantJobTItle;

            secondApplicantJobSector.SelectedItem = this.HouseholdQuoteParams.SecondApplicantJobSector;

            Mouse.Click(uIOKButton, new Point(17, 13));

            telephone.Text = this.HouseholdQuoteParams.Telephone;

            totalOccupants.Text = this.HouseholdQuoteParams.TotalOccupants;

            childen.Text = this.HouseholdQuoteParams.Childen;

            Mouse.Click(uINextButton, new Point(33, 11));
        }

        private void HomeProposerFullStep2()
        {
            WinComboBox ownership = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow6.UIItemComboBox;
            WinComboBox mortgageCompany = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow7.UIItemComboBox;
            WinCheckBox uIAreyouafirsttimebuyeCheckBox = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIAreyouafirsttimebuyeWindow.UICheckBox("Are you a first time buyer?");
            WinEdit yearBuilt = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow8.UIItemEdit;
            WinComboBox buildingWallType = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow9.UIItemComboBox;
            WinComboBox buildingRoofType = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow10.UIItemComboBox;
            WinCheckBox uIDoesanypartofthepropCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesanypartofthepropWindow.UICheckBox("Does any part of the property have a flat roof?");
            WinEdit percentFlatRoof = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow11.UIItemEdit;
            WinButton uINextButton1 = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow1.UINextButton;

            ownership.SelectedItem = this.HouseholdQuoteParams.Ownership;

            mortgageCompany.SelectedItem = this.HouseholdQuoteParams.MortgageCompany;

            uIAreyouafirsttimebuyeCheckBox.Checked = this.HouseholdQuoteParams.UIAreyouafirsttimebuyeCheckBoxChecked;

            yearBuilt.Text = this.HouseholdQuoteParams.YearBuilt;

            buildingWallType.SelectedItem = this.HouseholdQuoteParams.BuildingWallType;

            buildingRoofType.SelectedItem = this.HouseholdQuoteParams.BuildingRoofType;

            uIDoesanypartofthepropCheckBox.Checked = this.HouseholdQuoteParams.UIDoesanypartofthepropCheckBoxChecked;

            percentFlatRoof.Text = this.HouseholdQuoteParams.PercentFlatRoof;

            Mouse.Click(uINextButton1, new Point(32, 17));
        }

        private void HomeProposerFullStep3()
        {
            WinCheckBox uIDoesthepropertyhaveaCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow.UICheckBox("Does the property have approved locks?");
            WinCheckBox uIArethereapprovedlockCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow.UICheckBox("Are there approved locks on the final exit doors?");
            WinCheckBox uIArethereapprovedlockCheckBox1 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow1.UICheckBox("Are there approved locks on the windows & skylights?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox1 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow1.UICheckBox("Does the property have any other external doors?");
            WinCheckBox uIArethereapprovedlockCheckBox2 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow2.UICheckBox("Are there approved locks on the other external doors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox2 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow2.UICheckBox("Does the property have any French or Double Doors?");
            WinCheckBox uIArethereapprovedlockCheckBox3 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow3.UICheckBox("Are there approved locks on the French or Double Doors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox3 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow3.UICheckBox("Does the property have any Patio or Sliding Doors?");
            WinCheckBox uIArethereapprovedlockCheckBox4 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow4.UICheckBox("Are there approved locks on the Patio or Sliding Doors?");
            WinButton uINextButton2 = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow2.UINextButton;
            WinCheckBox uIIncludedinaNeighbourCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIncludedinaNeighbourWindow.UICheckBox("Included in a Neighbourhood Watch scheme?");
            WinCheckBox uIDoesthepropertyhavesCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhavesWindow.UICheckBox("Does the property have smoke detectors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox4 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow4.UICheckBox("Does the property have a burglar alarm?");
            WinCheckBox uIIsthereanalarmmainteCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthereanalarmmainteWindow.UICheckBox("Is there an alarm maintenance agreement? ");
            WinCheckBox uIDoesthepropertyhaveaCheckBox5 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow5.UICheckBox("Does the property have a safe?");
            WinComboBox alarmType = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow12.UIItemComboBox;
            WinComboBox safeType = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow13.UIItemComboBox;
            WinButton uINextButton3 = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow3.UINextButton;

            uIDoesthepropertyhaveaCheckBox.Checked = this.HouseholdQuoteParams.ApprovedLocks;

            uIArethereapprovedlockCheckBox.Checked = this.HouseholdQuoteParams.LocksFinalExitDoors;

            uIArethereapprovedlockCheckBox1.Checked = this.HouseholdQuoteParams.LocksWindow;

            uIDoesthepropertyhaveaCheckBox1.Checked = this.HouseholdQuoteParams.OtherExternalDoors;

            uIArethereapprovedlockCheckBox2.Checked = this.HouseholdQuoteParams.LocksOtherExternalDoors;

            uIDoesthepropertyhaveaCheckBox2.Checked = this.HouseholdQuoteParams.HaveFrenchDoors;

            uIArethereapprovedlockCheckBox3.Checked = this.HouseholdQuoteParams.LocksFrenchDoors;

            uIDoesthepropertyhaveaCheckBox3.Checked = this.HouseholdQuoteParams.HavePatioDoors;

            uIArethereapprovedlockCheckBox4.Checked = this.HouseholdQuoteParams.UIArethereapprovedlockCheckBoxChecked4;

            Mouse.Click(uINextButton2, new Point(53, 17));

            uIIncludedinaNeighbourCheckBox.Checked = this.HouseholdQuoteParams.UIIncludedinaNeighbourCheckBoxChecked;

            uIDoesthepropertyhavesCheckBox.Checked = this.HouseholdQuoteParams.UIDoesthepropertyhavesCheckBoxChecked;

            uIDoesthepropertyhaveaCheckBox4.Checked = this.HouseholdQuoteParams.UIDoesthepropertyhaveaCheckBoxChecked4;

            uIIsthereanalarmmainteCheckBox.Checked = this.HouseholdQuoteParams.UIIsthereanalarmmainteCheckBoxChecked;

            uIDoesthepropertyhaveaCheckBox5.Checked = this.HouseholdQuoteParams.UIDoesthepropertyhaveaCheckBoxChecked5;

            alarmType.SelectedItem = this.HouseholdQuoteParams.AlarmType;

            safeType.SelectedItem = this.HouseholdQuoteParams.SafeType;

            Mouse.Click(uINextButton3, new Point(51, 21));
        }

        private void HomeProposerFullStep4()
        {
            WinEdit coverRequired = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow14.UIItemEdit;
            WinComboBox volunataryExcess = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow15.UIItemComboBox;
            WinEdit ncdYears = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow16.UIItemEdit;
            WinComboBox uIItemComboBox15 = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow17.UIItemComboBox;
            WinGroup uIBuildingCoverDetailsGroup = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIBuildingCoverDetailsWindow.UIGroup("Building Cover Details");
            WinWindow uIItemWindow = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow18.UIClient("Building Cover Details").UIItemWindow;
            WinEdit contentsCoverReq = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow19.UIItemEdit;
            WinEdit totalAmountValuables = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow20.UIItemEdit;
            WinComboBox contentsExcess = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow21.UIItemComboBox;
            WinEdit contentsNcd = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow22.UIItemEdit;
            WinCheckBox uIAnyindividualitemswoCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIAnyindividualitemswoWindow.UICheckBox("Any individual items worth over £1000?");
            WinButton uIItemsButton = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemsWindow.UIButton("Items...");
            WinButton uINewButton = this.UISpecifiedItemsInsideWindow.UINewWindow.UINewButton;
            WinGroup uIItemGroup = this.UISpecifiedItemsInsideWindow.UIItemWindow.UIGroup();
            WinComboBox extraInsideItems = this.UISpecifiedItemsInsideWindow.UIItemWindow1.UIItemComboBox;
            WinEdit extraInsideItemsValue = this.UISpecifiedItemsInsideWindow.UIItemWindow2.UIItemEdit;
            WinEdit extraInsiteItemsFreeText = this.UISpecifiedItemsInsideWindow.UITxtDescriptionWindow.UIItemEdit;
            WinButton uISaveButton = this.UISpecifiedItemsInsideWindow.UISaveWindow.UISaveButton;
            WinButton uIOKButton1 = this.UISpecifiedItemsInsideWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDoyourequirecoverforCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow.UICheckBox("Do you require cover for Freezer Contents?");
            WinEdit freezerContents = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow23.UIItemEdit;
            WinButton coverDetailsNext = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow4.UINextButton;

            volunataryExcess.SelectedItem = this.HouseholdQuoteParams.VolunataryExcess;

            ncdYears.Text = this.HouseholdQuoteParams.NCDYears;

            Mouse.Click(uIItemComboBox15, new Point(16, 10));

            Mouse.Click(uIBuildingCoverDetailsGroup, new Point(480, 100));

            Mouse.Click(uIItemWindow, new Point(16, 20));

            Mouse.Click(contentsCoverReq, new Point(15, 11));

            coverRequired.Text = this.HouseholdQuoteParams.CoverRequired;

            contentsCoverReq.Text = this.HouseholdQuoteParams.ContentsCoverReq;

            totalAmountValuables.Text = this.HouseholdQuoteParams.TotalAmountValuables;

            contentsExcess.SelectedItem = this.HouseholdQuoteParams.ContentsExcess;

            contentsNcd.Text = this.HouseholdQuoteParams.ContentsNCD;

            uIAnyindividualitemswoCheckBox.Checked = this.HouseholdQuoteParams.UIAnyindividualitemswoCheckBoxChecked;

            Mouse.Click(uIItemsButton, new Point(56, 11));

            Mouse.Click(uINewButton, new Point(16, 17));

            Mouse.Click(uIItemGroup, new Point(115, 20));

            extraInsideItems.SelectedItem = this.HouseholdQuoteParams.ExtraInsideItems;

            extraInsideItemsValue.Text = this.HouseholdQuoteParams.ExtraInsideItemsValue;

            extraInsiteItemsFreeText.Text = this.HouseholdQuoteParams.ExtraInsiteItemsFreeText;

            Mouse.Click(uISaveButton, new Point(33, 11));

            Mouse.Click(uIOKButton1, new Point(33, 15));

            uIDoyourequirecoverforCheckBox.Checked = this.HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked;

            freezerContents.Text = this.HouseholdQuoteParams.FreezerContents;

            Mouse.Click(coverDetailsNext, new Point(19, 9));
        }

        private void HomeProposerFullStep5()
        {
            WinEdit itemsOutsideHomeValue = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow24.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox1 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow1.UICheckBox("Do you require cover for Pedal Cycles?");
            WinButton uICyclesButton = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UICyclesWindow.UIButton("Cycles...");
            WinComboBox pedalCycleType = this.UIPedalCyclesWindow.UIItemWindow.UIItemComboBox;
            WinButton pedalCyclesNew = this.UIPedalCyclesWindow.UINewWindow.UINewButton;
            WinEdit pedalCycleValue = this.UIPedalCyclesWindow.UIItemWindow1.UIItemEdit;
            WinEdit pedalCycleMake = this.UIPedalCyclesWindow.UITxtModelWindow.UIItemEdit;
            WinEdit pedalCycleSerial = this.UIPedalCyclesWindow.UITxtSerialNumberWindow.UIItemEdit;
            WinButton uISaveButton1 = this.UIPedalCyclesWindow.UISaveWindow.UISaveButton;
            WinButton uIOKButton2 = this.UIPedalCyclesWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDoyourequirecoverforCheckBox2 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow2.UICheckBox("Do you require cover for Money? (£)");
            WinEdit coverForMoneyAmount = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow26.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox3 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow3.UICheckBox("Do you require cover for Credit/Debit Cards? (£)");
            WinEdit coverForCreditCards = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow27.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox4 =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow4.UICheckBox("Do you require cover for Legal Expenses?");
            WinButton coverContNext = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow5.UINextButton;

            itemsOutsideHomeValue.Text = this.HouseholdQuoteParams.ItemsOutsideHomeValue;

            uIDoyourequirecoverforCheckBox1.Checked = this.HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked1;

            Mouse.Click(uICyclesButton, new Point(47, 15));

            Mouse.Click(pedalCyclesNew, new Point(31, 13));

            pedalCycleType.SelectedItem = this.HouseholdQuoteParams.PedalCycleType;

            pedalCycleValue.Text = this.HouseholdQuoteParams.PedalCycleValue;

            pedalCycleMake.Text = this.HouseholdQuoteParams.PedalCycleMake;

            pedalCycleSerial.Text = this.HouseholdQuoteParams.PedalCycleSerial;

            Mouse.Click(uISaveButton1, new Point(27, 16));

            Mouse.Click(uIOKButton2, new Point(24, 2));

            uIDoyourequirecoverforCheckBox2.Checked = this.HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked2;

            coverForMoneyAmount.Text = this.HouseholdQuoteParams.CoverForMoneyAmount;

            uIDoyourequirecoverforCheckBox3.Checked = this.HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked3;

            coverForCreditCards.Text = this.HouseholdQuoteParams.CoverForCreditCards;

            uIDoyourequirecoverforCheckBox4.Checked = this.HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked4;

            Mouse.Click(coverContNext, new Point(12, 10));
        }

        private void HomeProposerFullStep6()
        {
            WinCheckBox uIIsthepropertyusedforCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthepropertyusedforWindow.UICheckBox("Is the property used for business?");
            WinCheckBox uIIsthebusinessuseforcCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthebusinessuseforcWindow.UICheckBox("Is the business use for clerical purposes only?");
            WinButton generalNext = this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow6.UINextButton;
            WinCheckBox uIHavespecialconditionCheckBox =
                this.UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIHavespecialconditionWindow.UICheckBox("Have special conditions  previously been applied?");

            uIIsthepropertyusedforCheckBox.Checked = this.HouseholdQuoteParams.UIIsthepropertyusedforCheckBoxChecked;

            uIIsthebusinessuseforcCheckBox.Checked = this.HouseholdQuoteParams.UIIsthebusinessuseforcCheckBoxChecked;

            Mouse.Click(generalNext, new Point(25, 9));

            uIHavespecialconditionCheckBox.Checked = this.HouseholdQuoteParams.UIHavespecialconditionCheckBoxChecked;
        }
    }
}