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
                if ((mHomeCheckPrintExpectedValues == null))
                {
                    mHomeCheckPrintExpectedValues = new HomeCheckPrintExpectedValues();
                }
                return mHomeCheckPrintExpectedValues;
            }
        }

        public virtual HomeCheckStatusExpectedValues HomeCheckStatusExpectedValues
        {
            get
            {
                if ((mHomeCheckStatusExpectedValues == null))
                {
                    mHomeCheckStatusExpectedValues = new HomeCheckStatusExpectedValues();
                }
                return mHomeCheckStatusExpectedValues;
            }
        }

        public virtual HomeCheckZeroPremiumExpectedValues HomeCheckZeroPremiumExpectedValues
        {
            get
            {
                if ((mHomeCheckZeroPremiumExpectedValues == null))
                {
                    mHomeCheckZeroPremiumExpectedValues = new HomeCheckZeroPremiumExpectedValues();
                }
                return mHomeCheckZeroPremiumExpectedValues;
            }
        }

        public virtual HomeCopyCheckDataExpectedValues HomeCopyCheckDataExpectedValues
        {
            get
            {
                if ((mHomeCopyCheckDataExpectedValues == null))
                {
                    mHomeCopyCheckDataExpectedValues = new HomeCopyCheckDataExpectedValues();
                }
                return mHomeCopyCheckDataExpectedValues;
            }
        }

        public virtual HomeCheckPolicyPremiumExpectedValues HomeCheckPolicyPremiumExpectedValues
        {
            get
            {
                if ((mHomeCheckPolicyPremiumExpectedValues == null))
                {
                    mHomeCheckPolicyPremiumExpectedValues = new HomeCheckPolicyPremiumExpectedValues();
                }
                return mHomeCheckPolicyPremiumExpectedValues;
            }
        }

        public virtual HomeMTAChangeParams HomeMTAChangeParams
        {
            get
            {
                if ((mHomeMtaChangeParams == null))
                {
                    mHomeMtaChangeParams = new HomeMTAChangeParams();
                }
                return mHomeMtaChangeParams;
            }
        }

        public virtual HomeMTACheckCancelledExpectedValues HomeMTACheckCancelledExpectedValues
        {
            get
            {
                if ((mHomeMTACheckCancelledExpectedValues == null))
                {
                    mHomeMTACheckCancelledExpectedValues = new HomeMTACheckCancelledExpectedValues();
                }
                return mHomeMTACheckCancelledExpectedValues;
            }
        }

        public virtual HomeMTACheckChangedExpectedValues HomeMTACheckChangedExpectedValues
        {
            get
            {
                if ((mHomeMTACheckChangedExpectedValues == null))
                {
                    mHomeMTACheckChangedExpectedValues = new HomeMTACheckChangedExpectedValues();
                }
                return mHomeMTACheckChangedExpectedValues;
            }
        }

        public virtual HomeMTACheckMessageExpectedValues HomeMTACheckMessageExpectedValues
        {
            get
            {
                if ((mHomeMTACheckMessageExpectedValues == null))
                {
                    mHomeMTACheckMessageExpectedValues = new HomeMTACheckMessageExpectedValues();
                }
                return mHomeMTACheckMessageExpectedValues;
            }
        }

        public virtual HomeMTACopyCheckExpectedValues HomeMTACopyCheckExpectedValues
        {
            get
            {
                if ((mHomeMTACopyCheckExpectedValues == null))
                {
                    mHomeMTACopyCheckExpectedValues = new HomeMTACopyCheckExpectedValues();
                }
                return mHomeMTACopyCheckExpectedValues;
            }
        }

        public virtual AddressLookupExpectedValues AddressLookupExpectedValues
        {
            get
            {
                if ((mAddressLookupExpectedValues == null))
                {
                    mAddressLookupExpectedValues = new AddressLookupExpectedValues();
                }
                return mAddressLookupExpectedValues;
            }
        }

        public virtual HomeCreatePolicyParams HomeCreatePolicyParams
        {
            get
            {
                if ((mHomeCreatePolicyParams == null))
                {
                    mHomeCreatePolicyParams = new HomeCreatePolicyParams();
                }
                return mHomeCreatePolicyParams;
            }
        }

        public virtual HomeCheckNewPremiumExpectedValues HomeCheckNewPremiumExpectedValues
        {
            get
            {
                if ((mHomeCheckNewPremiumExpectedValues == null))
                {
                    mHomeCheckNewPremiumExpectedValues = new HomeCheckNewPremiumExpectedValues();
                }
                return mHomeCheckNewPremiumExpectedValues;
            }
        }

        public virtual HomeChangePremiumParams HomeChangePremiumParams
        {
            get
            {
                if ((mHomeChangePremiumParams == null))
                {
                    mHomeChangePremiumParams = new HomeChangePremiumParams();
                }
                return mHomeChangePremiumParams;
            }
        }

        public virtual HomeAmendRiskParams HomeAmendRiskParams
        {
            get
            {
                if ((mHomeAmendRiskParams == null))
                {
                    mHomeAmendRiskParams = new HomeAmendRiskParams();
                }
                return mHomeAmendRiskParams;
            }
        }

        public virtual HomeRenewalCancelledCheckExpectedValues HomeRenewalCancelledCheckExpectedValues
        {
            get
            {
                if ((mHomeRenewalCancelledCheckExpectedValues == null))
                {
                    mHomeRenewalCancelledCheckExpectedValues = new HomeRenewalCancelledCheckExpectedValues();
                }
                return mHomeRenewalCancelledCheckExpectedValues;
            }
        }

        public virtual HomeCheckPremiumExpectedValues HomeCheckPremiumExpectedValues
        {
            get
            {
                if ((mHomeCheckPremiumExpectedValues == null))
                {
                    mHomeCheckPremiumExpectedValues = new HomeCheckPremiumExpectedValues();
                }
                return mHomeCheckPremiumExpectedValues;
            }
        }

        public void HomePrintQuote1()
        {
            WinControl uIOKButton = UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIPrintQuoteButton = UIQuotesResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;

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

            PublicCreditCheckOk();

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIQuotesResultsClient, new Point(526, 161));

            Keyboard.SendKeys(uIQuotesResultsClient, CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Click(uIPrintQuoteButton, new Point(65, 11));
        }

        public void HomeExitWithPolicy()
        {
            WinControl uICancelButton = UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;
            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIOKButton = UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinControl uINextButton = UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uINOButton = UICreditCheckWindow.UINoWindow.UINoButton;
            WinClient uIQuotesResultsClient = UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIExitButton = UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton1 = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinControl uICancelButton1 = UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

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

            PublicCreditCheckOk();

            Mouse.Click(uIQuotesResultsClient, new Point(30, 30));

            Keyboard.SendKeys(uIQuotesResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIExitButton, new Point(46, 13));

            Mouse.Click(uIYesButton, new Point(51, 13));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(45, 15));

            SelectTAMActivities1();

            Mouse.Click(uICancelButton1, new Point(37, 17));

            Mouse.Click(uIItemButton, new Point(28, 18));

            Mouse.Click(uIDetailButton, new Point(29, 11));

            Mouse.Click(uIItemEdit, new Point(22, 8));
        }



        public void HomeAcceptPolicy()
        {
            WinControl uIAcceptButton = UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton1 = UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton2 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = UIPolicyDetailConfirmationWindow.UIItemWindow.UIItemEdit;

            Playback.Wait(3000);

            Mouse.Move(new Point(500, 500));

            Playback.Wait(500);

            Mouse.Click(uIAcceptButton, new Point(47, 11));

            Mouse.Click(uIYesButton, new Point(49, 11));

            CancelPrint();

            Mouse.Click(uIOKButton1, new Point(47, 22));

            Mouse.Click(uIOKButton2, new Point(46, 11));

            uIItemEdit.Text = ProposerParams.Postcode;
        }

        public void HomeCheckPrint()
        {
            HtmlCell uIItem1989Cell = UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIItem1989Cell;
            HtmlCell uIMrTestTestCell = UIViewQuoteDetailsWindow.UIItemClient.UIFileJAPPSIEOfficeDatDocument.UIItemTable1.UIMrTestTestCell;

            Assert.AreEqual(HomeCheckPrintExpectedValues.UIItem1989CellInnerText, uIItem1989Cell.InnerText);

            Assert.AreEqual(HomeCheckPrintExpectedValues.UIMrTestTestCellInnerText, uIMrTestTestCell.InnerText);
        }

        public void HomeCheckStatus()
        {
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            Assert.AreEqual(HomeCheckStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeCheckZeroPremium()
        {
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(HomeCheckZeroPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeClickPremium()
        {
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Mouse.Click(uIItemEdit, new Point(24, 5));
        }

        public void HomeCloseOpenPolicy()
        {
            WinControl uICancelButton = UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinControl uIDetailButton = UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;

            Mouse.Click(uICancelButton, new Point(33, 16));

            Mouse.Click(uIItemButton, new Point(18, 20));

            Mouse.Click(uIDetailButton, new Point(44, 16));
        }

        public void HomeCloseOpenPolicyList()
        {
            WinControl uICancelButton = UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinControl uIItemButton = UIPolicyautotestWindow.UIItemWindow.UIItemButton;

            Mouse.Click(uICancelButton, new Point(47, 19));

            Mouse.Click(uIItemButton, new Point(21, 14));
        }

        public void HomeClosePolicy()
        {
            WinControl uICloseButton = UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICloseButton;
            WinControl uIokButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICloseButton, new Point(33, 13));

            Mouse.Click(uIokButton, new Point(36, 14));
        }

        public void HomeCopyCheckData()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinComboBox uIItemComboBox = UIInsurEtamWindow.UIQuotesWindow.TbxJobTitle.UIItemComboBox;
            WinEdit uIItemEdit1 = UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinEdit uIItemEdit2 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;

            Assert.AreEqual(HomeCopyCheckDataExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(HomeCopyCheckDataExpectedValues.UIItemComboBoxSelectedItem, uIItemComboBox.SelectedItem);

            Assert.AreEqual(HomeCopyCheckDataExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            Assert.AreEqual(HomeCopyCheckDataExpectedValues.UIItemEditText2, uIItemEdit2.Text);
        }

        public void HomeCopyRisk()
        {
            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinControl uIOKButton = UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinRadioButton uIHouseholdRadioButton = UIProductSelectionWindow.UIHouseholdWindow.UIHouseholdRadioButton;
            WinControl uIOKButton1 = UIProductSelectionWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOptionsButton, new Point(26, 9));

            Mouse.Click(uICopyRiskMenuItem, new Point(93, 8));

            Mouse.Click(uIOKButton, new Point(54, 10));

            uIHouseholdRadioButton.Selected = CommonParams.UIHouseholdRadioButtonSelected;

            Mouse.Click(uIOKButton1, new Point(42, 21));
        }

        public void HomeDemands()
        {
            WinControl uIokButton = UIViewQuoteDetailsWindow.UIOKWindow.UIOKButton;
            WinControl uIDemandsNeedsButton = UIQuotesResultsWindow.UIDemandsNeedsWindow.UIDemandsNeedsButton;

            Mouse.Click(uIokButton, new Point(36, 9));

            Mouse.Click(uIDemandsNeedsButton, new Point(59, 13));
        }

        public void HomeExitWithoutPolicy()
        {
            WinControl uIExitButton = UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            Mouse.Click(uIExitButton, new Point(54, 9));

            Mouse.Click(uIYesButton, new Point(45, 6));

            Mouse.Click(uIAddActivityCheckBox);

            Mouse.Click(uIOKButton, new Point(30, 15));

            SelectTAMActivities2();
        }

        /// <summary>
        ///     HomeMTAAccept
        /// </summary>
        /// <param name="needScreenshot"></param>
        /// <param name="expectedDate"></param>
        public void HomeMTAAccept(bool needScreenshot, string expectedDate = "")
        {
            WinControl uINextButton = UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;

            Mouse.Click(uINextButton, new Point(39, 12));

            Mouse.Click(uINextButton1, new Point(47, 12));

            Mouse.Click(uINextButton2, new Point(47, 12));

            Mouse.Click(uINextButton3, new Point(47, 12));

            Mouse.Click(uINextButton4, new Point(47, 12));

            Mouse.Click(uINextButton5, new Point(47, 12));

            Mouse.Click(uINextButton6, new Point(47, 12));

            if (needScreenshot)
            {
                CreateScreenshot(expectedDate);
            }

            Mouse.Click(uIQuoteButton, new Point(47, 12));
        }

        public void HomeMTAAfter()
        {
            WinControl uIAfterButton = UIMidTermAdjustmentsWindow.UIOKWindow.UIAfterButton;

            Mouse.Click(uIAfterButton, new Point(38, 10));
        }

        public void HomeMTABefore()
        {
            WinControl uIBeforeButton = UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;

            Mouse.Click(uIBeforeButton, new Point(27, 12));
        }

        public void HomeMTACancel()
        {
            WinControl uICancelButton = UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(42, 13));

            Mouse.Click(uIYesButton, new Point(35, 12));

            Mouse.Click(uIOKButton, new Point(46, 14));
        }

        public void HomeMTACancel1()
        {
            WinControl uICancelButton = UIInsurEtamWindow.UIQuotesWindow.UICancelWindow2.UICancelButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(37, 17));

            Mouse.Click(uIYesButton, new Point(66, 11));

            Mouse.Click(uIOKButton, new Point(49, 13));
        }

        public void HomeMTAChange()
        {
            WinControl uIMTAButton = UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Playback.Wait(2000);
            Mouse.Click(uIMTAButton, new Point(45, 12));

            uIItemComboBox.SelectedItem = HomeMTAChangeParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(35, 15));

            uIItemEdit.Text = HomeMTAChangeParams.UIItemEditText;
        }

        public void HomeMTACheckCancelled()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Assert.AreEqual(HomeMTACheckCancelledExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeMTACheckChanged()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;

            Assert.AreEqual(HomeMTACheckChangedExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeMTACheckMessage()
        {
            WinText uIDateBeforeCurrentMTAText = UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIDateBeforeCurrentMTAText;

            Assert.AreEqual(HomeMTACheckMessageExpectedValues.UIDateBeforeCurrentMTATextDisplayText, uIDateBeforeCurrentMTAText.DisplayText);
        }

        public void HomeMTACloseMessage()
        {
            WinControl uIOKButton = UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton, new Point(52, 7));
        }

        public void HomeMTACopyCheck()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinEdit uIItemEdit1 = UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinEdit uIItemEdit2 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;
            WinComboBox uIItemComboBox = UIInsurEtamWindow.UIQuotesWindow.TbxJobSector.UIItemComboBox;

            Assert.AreEqual(HomeMTACopyCheckExpectedValues.NewSurname, uIItemEdit.Text);

            Assert.AreEqual(HomeMTACopyCheckExpectedValues.Postcode, uIItemEdit1.Text);

            Assert.AreEqual(HomeMTACopyCheckExpectedValues.Address, uIItemEdit2.Text);

            Assert.AreEqual(HomeMTACopyCheckExpectedValues.JobSector, uIItemComboBox.SelectedItem);
        }

        public void HomeAddressLookup()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow6.UIItemEdit;
            WinEdit uIItemEdit1 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow7.UIItemEdit;

            Assert.AreEqual(AddressLookupExpectedValues.AddressLine1, uIItemEdit.Text);

            Assert.AreEqual(AddressLookupExpectedValues.AddressLine2, uIItemEdit1.Text);
        }

        public void HomeAcceptQuote1()
        {
            WinControl uIOKButton = UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton1 = UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinControl uIOKButton2 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = UIPolicyDetailConfirmationWindow.UIItemWindow.UIItemEdit;
            WinControl uILookupButton = UIPolicyDetailConfirmationWindow.UILookupWindow.UILookupButton;
            WinControl uIOKButton3 = UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinControl uIConfirmButton = UIPolicyDetailConfirmationWindow.UIConfirmWindow.UIConfirmButton;
            WinControl uIOKButton4 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton5 = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton6 = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton, new Point(35, 13));

            Playback.PlaybackSettings.ContinueOnError = false;

            Mouse.Click(uIOKButton1, new Point(35, 17));

            Mouse.Click(uIOKButton2, new Point(29, 10));

            uIItemEdit.Text = ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(25, 13));

            Mouse.Click(uIOKButton3, new Point(20, 19));

            Mouse.Click(uIConfirmButton, new Point(26, 9));

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Click(uIOKButton4, new Point(46, 12));

            Playback.PlaybackSettings.ContinueOnError = false;

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton5, new Point(60, 10));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton6, new Point(40, 8));

            SelectTAMActivities3();
        }

        public void HomeRebrokeSelectAlternative()
        {
            WinControl uISelectAlternativeButton = UIHouseholdRebrokeResuWindow.UISelectAlternativeWindow.UISelectAlternativeButton;

            Mouse.Click(uISelectAlternativeButton, new Point(49, 13));
        }

        public void HomeRebrokeFinish()
        {
            WinControl uIokButton = UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIokButton, new Point(36, 13));
        }

        public void HomeRebrokeCurrent()
        {
            WinControl uIokButton = UIHouseholdRebrokeResuWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Click(uIokButton, new Point(60, 9));

            Mouse.Click(uIYesButton, new Point(63, 11));
        }

        public void HomeRebroke()
        {
            WinControl uIRebrokeButton = UIAUTOWindow.UIRebrokeWindow.UIRebrokeButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIProceedButton = UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            Mouse.Click(uIRebrokeButton, new Point(55, 11));

            Mouse.Click(uIYesButton, new Point(41, 15));

            Mouse.Click(uIProceedButton, new Point(61, 11));
        }

        public void HomeProposer()
        {
            WinEdit tbxFirstname = UIInsurEtamWindow.UIQuotesWindow.TbxFirstname.UIItemEdit;
            WinEdit tbxLastName = UIInsurEtamWindow.UIQuotesWindow.TbxLastName.UIItemEdit;
            WinComboBox tbxJobTitle = UIInsurEtamWindow.UIQuotesWindow.TbxJobTitle.UIItemComboBox;
            WinComboBox tbxJobSector = UIInsurEtamWindow.UIQuotesWindow.TbxJobSector.UIItemComboBox;
            WinEdit tbxDateOfBirth = UIInsurEtamWindow.UIQuotesWindow.TbxDateOfBirth.UIItemEdit;
            WinEdit txbPostcode = UIInsurEtamWindow.UIQuotesWindow.TbxPostcode.UIItemEdit;
            WinControl uILookupButton = UIInsurEtamWindow.UIQuotesWindow.UILookupWindow.UILookupButton;
            WinControl uIokButton = UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            tbxLastName.Text = ProposerParams.Lastname;

            tbxFirstname.Text = ProposerParams.Firstname;

            tbxJobTitle.SelectedItem = ProposerParams.JobTitle;

            tbxJobSector.SelectedItem = ProposerParams.JobSector;

            tbxDateOfBirth.Text = ProposerParams.DateOfBirth;

            Mouse.Click(txbPostcode, new Point(48, 10));

            txbPostcode.Text = ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(28, 13));

            Mouse.Click(uIokButton, new Point(43, 7));
        }

        public void HomeProposerFull()
        {
            WinButton uIQuoteButton = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIQuoteWindow.UIQuoteButton;

            HomeProposerFullStep1();
            HomeProposerFullStep2();
            HomeProposerFullStep3();
            HomeProposerFullStep4();
            HomeProposerFullStep5();
            HomeProposerFullStep6();

            Mouse.Click(uIQuoteButton, new Point(14, 11));
        }

        public void HomePrintQuote()
        {
            WinControl uICancelButton = UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton, new Point(19, 8));
        }

        public void HomeOpenQuote()
        {
            WinControl uIOptionsButton = UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinControl uIokButton = UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOptionsButton, new Point(31, 8));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(123, 7));

            Mouse.Move(new Point(500, 500));

            WaitForControl(uIokButton);
            Mouse.Click(uIokButton, new Point(44, 13));
        }

        public void HomeOpenPolicy()
        {
            WinControl uIDetailButton = UIPolicyautotestWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;
            System.Diagnostics.Debug.WriteLine("Customer Code : " + CustomerCode);
            Mouse.Click(uIDetailButton, new Point(26, 12));

            Mouse.Click(uIItemEdit, new Point(25, 5));
        }

        public void HomeMTASelectQuote()
        {
            WinClient uIQuotesResultsClient = UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Mouse.Click(uIQuotesResultsClient, new Point(424, 227));

            Keyboard.SendKeys(uIQuotesResultsClient, CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(64, 11));

            Mouse.Click(uIokButton, new Point(37, 8));

            Mouse.Click(uIokButton1, new Point(39, 16));

            WaitForControl(uIokButton2);

            Mouse.Click(uIokButton2, new Point(58, 15));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(50, 8));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(29, 19));

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        public void HomeMTAEnterDate(string withDate = "")
        {
            WinEdit uIItemEdit = UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;

            uIItemEdit.Text = string.IsNullOrEmpty(withDate) ? DateTime.Now.AddDays(2).ToString("dd/MM/yy") : withDate;
        }

        public string HomeMTACoverDate()
        {
            WinEdit uIMTADate = UIMTAEffectiveDatesWindow.UIMTADate.UIItemEdit;
            WinEdit uIMTATime = UIMTAEffectiveDatesWindow.UIMTATime.UIItemEdit;
            WinControl uIokButton = UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            string mtaDate = uIMTADate.Text.Replace(" ", "_") + "_" + uIMTATime.Text.Replace(":", "");
            Mouse.Click(uIokButton, new Point(46, 8));

            return mtaDate;
        }

        public void HomeCreatePolicy()
        {
            WinControl uINextButton = UIInsurEtamWindow.UIQuotesWindow.UINextWindow.UINextButton;
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow8.UIItemEdit;
            WinControl uINextButton1 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow3.UINextButton;
            WinEdit uIItemEdit1 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow22.UIItemEdit;
            WinControl uINextButton4 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow4.UINextButton;
            WinEdit uIItemEdit4 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow41.UIItemEdit;
            WinControl uINextButton5 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = UIInsurEtamWindow.UIQuotesWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uInoButton = UICreditCheckWindow.UINoWindow.UINoButton;

            Mouse.Click(uINextButton, new Point(19, 6));

            uIItemEdit.Text = HomeCreatePolicyParams.UIItemEditText;

            Mouse.Click(uINextButton1, new Point(39, 18));

            Mouse.Click(uINextButton2, new Point(39, 18));

            Mouse.Click(uINextButton3, new Point(39, 18));

            uIItemEdit1.Text = HomeCreatePolicyParams.UIItemEditText1;

            uIItemEdit2.Text = HomeCreatePolicyParams.UIItemEditText2;

            Mouse.Click(uINextButton4, new Point(42, 17));

            uIItemEdit4.Text = HomeCreatePolicyParams.UIItemEditText4;

            Mouse.Click(uINextButton5, new Point(16, 13));

            Mouse.Click(uINextButton6, new Point(31, 11));

            Mouse.Click(uIQuoteButton, new Point(31, 11));

            Mouse.Click(uInoButton, new Point(56, 12));
        }

        public void HomeCheckNewPremium()
        {
            WinEdit uIItemEdit = UIPolicygdfhdfdfghgdfWindow.UIBillingScreenHomeTestWindow.UIItemWindow.UIItemEdit;

            Assert.AreNotEqual(HomeCheckNewPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void HomeChangePremium(int overridePremium)
        {
            WinControl uIPremiumButton = UIQuotesResultsWindow.UIPremiumWindow.UIPremiumButton;
            WinEdit uIItemEdit = UIOverridePremiumWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = UIOverridePremiumWindow.UIItemWindow1.UIItemEdit;
            WinControl uIokButton = UIOverridePremiumWindow.UIOKWindow.UIOKButton;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIPremiumButton, new Point(38, 11));

            uIItemEdit.Text = overridePremium.ToString(CultureInfo.InvariantCulture);

            uIItemEdit1.Text = HomeChangePremiumParams.UIItemEditText1;

            Mouse.Click(uIokButton, new Point(52, 15));
        }

        public void HomeCancelPolicyQuote1()
        {
            WinControl uIokButton = UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinControl uInoButton = UIClaimsWindow.UINoWindow.UINoButton;

            Mouse.Click(uIokButton, new Point(52, 9));

            Mouse.Click(uInoButton, new Point(43, 18));
        }

        public void HomeCancelPolicyQuote()
        {
            WinControl uIQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UIQuoteWindow.UIQuoteButton;

            Mouse.Click(uIQuoteButton, new Point(41, 7));
        }

        public void HomeCancelPolicyExit()
        {
            WinControl uIExitButton = UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinControl uIokButton = UIInsurEtamWindow1.UIOKWindow1.UIOKButton;
            WinControl uICancelButton = UIOpenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uIExitButton, new Point(58, 11));

            Mouse.Click(uIokButton, new Point(40, 10));

            Mouse.Click(uICancelButton, new Point(54, 12));
        }

        public void HomeCancelPolicyAccept()
        {
            WinControl uIAcceptButton = UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton3 = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton4 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Playback.Wait(2000);

            HomeSelectPolicy();

            Mouse.Click(uIAcceptButton, new Point(85, 15));

            Mouse.Click(uIokButton, new Point(65, 9));

            Mouse.Click(uIokButton1, new Point(39, 10));

            Mouse.Click(uIokButton2, new Point(47, 13));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(68, 12));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton4, new Point(42, 12));

            SelectTamInsurersAndActivity(selectListItems1: 1);
        }

        public void HomeCancelPolicy()
        {
            WinControl uIMTAButton = UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow1.UIMTAButton;
            WinComboBox uIItemComboBox = UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinControl uIOKButton = UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;

            Playback.Wait(5000);
            Mouse.Click(uIMTAButton, new Point(35, 8));

            uIItemComboBox.SelectedItem = CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(31, 11));
        }

        public void HomeCancelCopy()
        {
            WinControl uICancelButton = UIInsurEtamWindow.UIQuotesWindow.UICancelWindow.UICancelButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinControl uIOKButton = UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uICancelButton, new Point(42, 12));

            Mouse.Click(uIYesButton, new Point(56, 7));

            Mouse.Click(uIYesButton, new Point(31, 15));

            Mouse.Click(uIOKButton, new Point(49, 15));
        }

        public void HomeAmendSelecPolicy(bool newPolicy)
        {
            Playback.Wait(2000);
            WinClient uIHouseholdRenewalsAmeClient = UIHouseholdRenewalsResultsWindow.UIItemWindow.UIClient();

            Mouse.Click(uIHouseholdRenewalsAmeClient, newPolicy ? new Point(101, 60) : new Point(101, 31));

            Mouse.Move(new Point(500, 500));
        }

        public void HomeAmendRisk()
        {
            WinControl uIAmendRiskButton = UIAUTO2251001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = UIHouseholdRenewalsWindow.UIItemWindow.UIItemEdit;
            WinControl uINextButton = UIHouseholdRenewalsWindow.UINextWindow.UINextButton;
            WinControl uINextButton1 = UIHouseholdRenewalsWindow.UINextWindow1.UINextButton;
            WinControl uINextButton2 = UIHouseholdRenewalsWindow.UINextWindow2.UINextButton;
            WinControl uINextButton3 = UIHouseholdRenewalsWindow.UINextWindow3.UINextButton;
            WinControl uINextButton4 = UIHouseholdRenewalsWindow.UINextWindow4.UINextButton;
            WinControl uINextButton5 = UIHouseholdRenewalsWindow.UINextWindow5.UINextButton;
            WinControl uINextButton6 = UIHouseholdRenewalsWindow.UINextWindow6.UINextButton;
            WinControl uIQuoteButton = UIHouseholdRenewalsWindow.UIQuoteWindow.UIQuoteButton;
            WinControl uIProceedButton = UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            Mouse.Click(uIAmendRiskButton, new Point(67, 17));

            uIItemEdit.Text = HomeAmendRiskParams.UIItemEditText;

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
            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton2 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton, new Point(74, 12));

            int timeout = Playback.PlaybackSettings.SearchTimeout;

            Playback.PlaybackSettings.SearchTimeout = 120000;

            Playback.PlaybackSettings.ContinueOnError = true;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIokButton1, new Point(47, 12));

            Playback.PlaybackSettings.ContinueOnError = false;

            Playback.PlaybackSettings.SearchTimeout = timeout;

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton2, new Point(48, 9));

            SelectTAMActivities3();
        }

        public void HomeAmendRenewFinish()
        {
            WinControl uIRenewPolicyButton = UIHouseholdRenewalsResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = UIConfirmWindow.UIYesWindow.UIYesButton;

            Mouse.Click(uIRenewPolicyButton, new Point(52, 9));

            Mouse.Click(uIYesButton, new Point(55, 11));

            CancelPrint();
        }

        public void HomeAmendRenew()
        {
            WinControl uIRenewPolicyButton = UIHouseholdRenewalsResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinControl uIYesButton = UIConfirmWindow.UIYesWindow.UIYesButton;
            WinControl uIokButton = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIokButton1 = UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIokButton3 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Playback.Wait(2000);

            Mouse.Click(uIRenewPolicyButton, new Point(36, 18));

            Mouse.Click(uIYesButton, new Point(50, 20));

            Mouse.Click(uIYesButton, new Point(65, 18));

            Mouse.Click(uIokButton, new Point(26, 16));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIokButton1, new Point(74, 19));

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIokButton2, new Point(64, 14));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIokButton3, new Point(60, 17));

            SelectTAMActivities3();
        }

        public void HomeAcceptQuote()
        {
            WinControl uIAcceptButton = UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(33, 15));

            Mouse.Click(uIYesButton, new Point(39, 13));
        }

        public void HomeStartDate()
        {
            WinEdit uIItemEdit = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow13.UIItemEdit;

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
        }

        public void HomeSiteRenewal(string policyNumber, string renewalPremium)
        {
            HtmlHyperlink uICreateaHouseholdTestHyperlink =
                UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaHouseholdTestHyperlink;
            HtmlComboBox uIInsurerIDComboBox = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPolicyNumberEdit;
            HtmlEdit uITxtRenewalDateEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtRenewalDateEdit;
            HtmlEdit uITxtAutoLapseDateEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtAutoLapseDateEdit;
            HtmlTextArea uITxtClientXmlEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtClientXmlEdit;
            HtmlInputButton uIGetXMLfromServerButton = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UIGetXMLfromServerButton;
            HtmlEdit uITxtPremiumEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UITxtPremiumEdit;

            HtmlInputButton uICreateRecordButton = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument1.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = UIInsurEcomSystemMaintWindow;

            Mouse.Click(uICreateaHouseholdTestHyperlink, new Point(48, 20));

            uIInsurerIDComboBox.SelectedItem = CommonParams.UIInsurerIDComboBoxSelectedItem;

            uITxtPolicyNumberEdit.Text = policyNumber;

            uITxtPremiumEdit.Text = renewalPremium;

            uITxtRenewalDateEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");

            uITxtAutoLapseDateEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");

            Mouse.Click(uITxtClientXmlEdit, new Point(284, 43));

            Mouse.Click(uIGetXMLfromServerButton, new Point(114, 9));

            Mouse.Click(uICreateRecordButton, new Point(102, 11));

            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        public void HomeRenewalConfirm()
        {
            WinControl uIYesButton = UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            Mouse.Click(uIYesButton, new Point(33, 10));
        }

        public void HomeRenewalCancelledCheck()
        {
            WinText uIMTAsuccessfullyproceText = UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            StringAssert.Contains(uIMTAsuccessfullyproceText.DisplayText, HomeRenewalCancelledCheckExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        public void HomeRenewalBeforeFinish()
        {
            WinControl uIOKButton = UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton1 = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton2 = UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            Mouse.Click(uIOKButton, new Point(49, 11));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(53, 18));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(33, 12));

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        public void HomeRenewalBeforeAccept()
        {
            WinClient uIQuotesResultsClient = UIQuotesResultsWindow.UIItemWindow.UIClient();
            WinControl uIAcceptButton = UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinControl uIokButton = UIConfirmMTAWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton1 = UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinControl uIokButton2 = UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            Mouse.Click(uIQuotesResultsClient, new Point(420, 229));

            Keyboard.SendKeys(uIQuotesResultsClient, CommonParams.SendEndKeys, ModifierKeys.None);

            Mouse.Move(new Point(500, 500));

            Mouse.Click(uIAcceptButton, new Point(75, 10));

            Mouse.Click(uIokButton, new Point(36, 16));

            Mouse.Click(uIokButton1, new Point(37, 19));

            Mouse.Click(uIokButton2, new Point(48, 14));
        }

        public void HomeRebrokeSelectPolicy(string withKeys)
        {
            WinClient uIHouseholdRebrokeResuClient = UIHouseholdRebrokeResuWindow.UIItemWindow.UIClient();

            Mouse.Click(uIHouseholdRebrokeResuClient, new Point(208, 85));

            // Keyboard.SendKeys(uIHouseholdRebrokeResuClient, withKeys, ModifierKeys.None);
        }

        public void HomeCheckPremium()
        {
            WinEdit uIItemEdit = UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            Assert.AreNotEqual(HomeCheckPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        private void HomeProposerFullStep1()
        {
            WinComboBox mortgageBuildingSociety = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow.UIItemComboBox;
            WinComboBox previousPaymentPeriod = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow1.UIItemComboBox;
            WinCheckBox uIIstheapplicationinjoCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIstheapplicationinjoWindow.UICheckBox("Is the application in joint names?");
            WinButton uIOtherpersonButton = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIOtherpersonWindow.UIButton("Other person...");
            WinComboBox secondApplicantTItle = UISecondApplicantDetaiWindow.UIItemWindow.UIItemComboBox;
            WinEdit secondApplicantFirstName = UISecondApplicantDetaiWindow.UIItemWindow1.UIItemEdit;
            WinEdit secondApplicantLastname = UISecondApplicantDetaiWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = UISecondApplicantDetaiWindow.UIItemWindow4.UIItemEdit;
            WinComboBox secondApplicantGender = UISecondApplicantDetaiWindow.UIItemWindow5.UIItemComboBox;
            WinComboBox secondApplicantRelationship = UISecondApplicantDetaiWindow.UIItemWindow6.UIItemComboBox;
            WinComboBox secondApplicantJobSector = UISecondApplicantDetaiWindow.UIItemWindow8.UIItemComboBox;
            WinComboBox secondApplicantJobTitle = UISecondApplicantDetaiWindow.UIItemWindow7.UIItemComboBox;
            WinButton uIOKButton = UISecondApplicantDetaiWindow.UIOKWindow.UIOKButton;
            WinEdit telephone = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow2.UIEdit("Occupants");
            WinEdit totalOccupants = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow3.UIItemEdit;
            WinEdit childen = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow4.UIItemEdit;
            WinButton uINextButton = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow.UINextButton;

            mortgageBuildingSociety.SelectedItem = HouseholdQuoteParams.MortgageBuildingSociety;

            previousPaymentPeriod.SelectedItem = HouseholdQuoteParams.PreviousPaymentPeriod;

            uIIstheapplicationinjoCheckBox.Checked = HouseholdQuoteParams.UIIstheapplicationinjoCheckBoxChecked;

            Mouse.Click(uIOtherpersonButton, new Point(45, 10));

            secondApplicantTItle.SelectedItem = HouseholdQuoteParams.SecondApplicantTItle;

            secondApplicantFirstName.Text = HouseholdQuoteParams.SecondApplicantFirstName;

            secondApplicantLastname.Text = HouseholdQuoteParams.SecondApplicantLastname;

            uIItemEdit2.Text = HouseholdQuoteParams.SecondApplicantDateOfBirth;

            secondApplicantGender.SelectedItem = HouseholdQuoteParams.SecondApplicantGender;

            secondApplicantRelationship.SelectedItem = HouseholdQuoteParams.SecondApplicantRelationship;

            secondApplicantJobTitle.SelectedItem = HouseholdQuoteParams.SecondApplicantJobTItle;

            secondApplicantJobSector.SelectedItem = HouseholdQuoteParams.SecondApplicantJobSector;

            Mouse.Click(uIOKButton, new Point(17, 13));

            telephone.Text = HouseholdQuoteParams.Telephone;

            totalOccupants.Text = HouseholdQuoteParams.TotalOccupants;

            childen.Text = HouseholdQuoteParams.Childen;

            Mouse.Click(uINextButton, new Point(33, 11));
        }

        private void HomeProposerFullStep2()
        {
            WinComboBox ownership = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow6.UIItemComboBox;
            WinComboBox mortgageCompany = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow7.UIItemComboBox;
            WinCheckBox uIAreyouafirsttimebuyeCheckBox = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIAreyouafirsttimebuyeWindow.UICheckBox("Are you a first time buyer?");
            WinEdit yearBuilt = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow8.UIItemEdit;
            WinComboBox buildingWallType = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow9.UIItemComboBox;
            WinComboBox buildingRoofType = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow10.UIItemComboBox;
            WinCheckBox uIDoesanypartofthepropCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesanypartofthepropWindow.UICheckBox("Does any part of the property have a flat roof?");
            WinEdit percentFlatRoof = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow11.UIItemEdit;
            WinButton uINextButton1 = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow1.UINextButton;

            ownership.SelectedItem = HouseholdQuoteParams.Ownership;

            mortgageCompany.SelectedItem = HouseholdQuoteParams.MortgageCompany;

            uIAreyouafirsttimebuyeCheckBox.Checked = HouseholdQuoteParams.UIAreyouafirsttimebuyeCheckBoxChecked;

            yearBuilt.Text = HouseholdQuoteParams.YearBuilt;

            buildingWallType.SelectedItem = HouseholdQuoteParams.BuildingWallType;

            buildingRoofType.SelectedItem = HouseholdQuoteParams.BuildingRoofType;

            uIDoesanypartofthepropCheckBox.Checked = HouseholdQuoteParams.UIDoesanypartofthepropCheckBoxChecked;

            percentFlatRoof.Text = HouseholdQuoteParams.PercentFlatRoof;

            Mouse.Click(uINextButton1, new Point(32, 17));
        }

        private void HomeProposerFullStep3()
        {
            WinCheckBox uIDoesthepropertyhaveaCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow.UICheckBox("Does the property have approved locks?");
            WinCheckBox uIArethereapprovedlockCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow.UICheckBox("Are there approved locks on the final exit doors?");
            WinCheckBox uIArethereapprovedlockCheckBox1 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow1.UICheckBox("Are there approved locks on the windows & skylights?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox1 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow1.UICheckBox("Does the property have any other external doors?");
            WinCheckBox uIArethereapprovedlockCheckBox2 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow2.UICheckBox("Are there approved locks on the other external doors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox2 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow2.UICheckBox("Does the property have any French or Double Doors?");
            WinCheckBox uIArethereapprovedlockCheckBox3 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow3.UICheckBox("Are there approved locks on the French or Double Doors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox3 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow3.UICheckBox("Does the property have any Patio or Sliding Doors?");
            WinCheckBox uIArethereapprovedlockCheckBox4 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIArethereapprovedlockWindow4.UICheckBox("Are there approved locks on the Patio or Sliding Doors?");
            WinButton uINextButton2 = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow2.UINextButton;
            WinCheckBox uIIncludedinaNeighbourCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIncludedinaNeighbourWindow.UICheckBox("Included in a Neighbourhood Watch scheme?");
            WinCheckBox uIDoesthepropertyhavesCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhavesWindow.UICheckBox("Does the property have smoke detectors?");
            WinCheckBox uIDoesthepropertyhaveaCheckBox4 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow4.UICheckBox("Does the property have a burglar alarm?");
            WinCheckBox uIIsthereanalarmmainteCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthereanalarmmainteWindow.UICheckBox("Is there an alarm maintenance agreement? ");
            WinCheckBox uIDoesthepropertyhaveaCheckBox5 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoesthepropertyhaveaWindow5.UICheckBox("Does the property have a safe?");
            WinComboBox alarmType = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow12.UIItemComboBox;
            WinComboBox safeType = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow13.UIItemComboBox;
            WinButton uINextButton3 = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow3.UINextButton;

            uIDoesthepropertyhaveaCheckBox.Checked = HouseholdQuoteParams.ApprovedLocks;

            uIArethereapprovedlockCheckBox.Checked = HouseholdQuoteParams.LocksFinalExitDoors;

            uIArethereapprovedlockCheckBox1.Checked = HouseholdQuoteParams.LocksWindow;

            uIDoesthepropertyhaveaCheckBox1.Checked = HouseholdQuoteParams.OtherExternalDoors;

            uIArethereapprovedlockCheckBox2.Checked = HouseholdQuoteParams.LocksOtherExternalDoors;

            uIDoesthepropertyhaveaCheckBox2.Checked = HouseholdQuoteParams.HaveFrenchDoors;

            uIArethereapprovedlockCheckBox3.Checked = HouseholdQuoteParams.LocksFrenchDoors;

            uIDoesthepropertyhaveaCheckBox3.Checked = HouseholdQuoteParams.HavePatioDoors;

            uIArethereapprovedlockCheckBox4.Checked = HouseholdQuoteParams.UIArethereapprovedlockCheckBoxChecked4;

            Mouse.Click(uINextButton2, new Point(53, 17));

            uIIncludedinaNeighbourCheckBox.Checked = HouseholdQuoteParams.UIIncludedinaNeighbourCheckBoxChecked;

            uIDoesthepropertyhavesCheckBox.Checked = HouseholdQuoteParams.UIDoesthepropertyhavesCheckBoxChecked;

            uIDoesthepropertyhaveaCheckBox4.Checked = HouseholdQuoteParams.UIDoesthepropertyhaveaCheckBoxChecked4;

            uIIsthereanalarmmainteCheckBox.Checked = HouseholdQuoteParams.UIIsthereanalarmmainteCheckBoxChecked;

            uIDoesthepropertyhaveaCheckBox5.Checked = HouseholdQuoteParams.UIDoesthepropertyhaveaCheckBoxChecked5;

            alarmType.SelectedItem = HouseholdQuoteParams.AlarmType;

            safeType.SelectedItem = HouseholdQuoteParams.SafeType;

            Mouse.Click(uINextButton3, new Point(51, 21));
        }

        private void HomeProposerFullStep4()
        {
            WinEdit coverRequired = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow14.UIItemEdit;
            WinComboBox volunataryExcess = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow15.UIItemComboBox;
            WinEdit ncdYears = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow16.UIItemEdit;
            WinComboBox uIItemComboBox15 = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow17.UIItemComboBox;
            WinGroup uIBuildingCoverDetailsGroup = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIBuildingCoverDetailsWindow.UIGroup("Building Cover Details");
            WinWindow uIItemWindow = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow18.UIClient("Building Cover Details").UIItemWindow;
            WinEdit contentsCoverReq = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow19.UIItemEdit;
            WinEdit totalAmountValuables = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow20.UIItemEdit;
            WinComboBox contentsExcess = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow21.UIItemComboBox;
            WinEdit contentsNcd = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow22.UIItemEdit;
            WinCheckBox uIAnyindividualitemswoCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIAnyindividualitemswoWindow.UICheckBox("Any individual items worth over £1000?");
            WinButton uIItemsButton = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemsWindow.UIButton("Items...");
            WinButton uINewButton = UISpecifiedItemsInsideWindow.UINewWindow.UINewButton;
            WinGroup uIItemGroup = UISpecifiedItemsInsideWindow.UIItemWindow.UIGroup();
            WinComboBox extraInsideItems = UISpecifiedItemsInsideWindow.UIItemWindow1.UIItemComboBox;
            WinEdit extraInsideItemsValue = UISpecifiedItemsInsideWindow.UIItemWindow2.UIItemEdit;
            WinEdit extraInsiteItemsFreeText = UISpecifiedItemsInsideWindow.UITxtDescriptionWindow.UIItemEdit;
            WinButton uISaveButton = UISpecifiedItemsInsideWindow.UISaveWindow.UISaveButton;
            WinButton uIOKButton1 = UISpecifiedItemsInsideWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDoyourequirecoverforCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow.UICheckBox("Do you require cover for Freezer Contents?");
            WinEdit freezerContents = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow23.UIItemEdit;
            WinButton coverDetailsNext = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow4.UINextButton;

            volunataryExcess.SelectedItem = HouseholdQuoteParams.VolunataryExcess;

            ncdYears.Text = HouseholdQuoteParams.NCDYears;

            Mouse.Click(uIItemComboBox15, new Point(16, 10));

            Mouse.Click(uIBuildingCoverDetailsGroup, new Point(480, 100));

            Mouse.Click(uIItemWindow, new Point(16, 20));

            Mouse.Click(contentsCoverReq, new Point(15, 11));

            coverRequired.Text = HouseholdQuoteParams.CoverRequired;

            contentsCoverReq.Text = HouseholdQuoteParams.ContentsCoverReq;

            totalAmountValuables.Text = HouseholdQuoteParams.TotalAmountValuables;

            contentsExcess.SelectedItem = HouseholdQuoteParams.ContentsExcess;

            contentsNcd.Text = HouseholdQuoteParams.ContentsNCD;

            uIAnyindividualitemswoCheckBox.Checked = HouseholdQuoteParams.UIAnyindividualitemswoCheckBoxChecked;

            Mouse.Click(uIItemsButton, new Point(56, 11));

            Mouse.Click(uINewButton, new Point(16, 17));

            Mouse.Click(uIItemGroup, new Point(115, 20));

            extraInsideItems.SelectedItem = HouseholdQuoteParams.ExtraInsideItems;

            extraInsideItemsValue.Text = HouseholdQuoteParams.ExtraInsideItemsValue;

            extraInsiteItemsFreeText.Text = HouseholdQuoteParams.ExtraInsiteItemsFreeText;

            Mouse.Click(uISaveButton, new Point(33, 11));

            Mouse.Click(uIOKButton1, new Point(33, 15));

            uIDoyourequirecoverforCheckBox.Checked = HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked;

            freezerContents.Text = HouseholdQuoteParams.FreezerContents;

            Mouse.Click(coverDetailsNext, new Point(19, 9));
        }

        private void HomeProposerFullStep5()
        {
            WinEdit itemsOutsideHomeValue = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow24.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox1 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow1.UICheckBox("Do you require cover for Pedal Cycles?");
            WinButton uICyclesButton = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UICyclesWindow.UIButton("Cycles...");
            WinComboBox pedalCycleType = UIPedalCyclesWindow.UIItemWindow.UIItemComboBox;
            WinButton pedalCyclesNew = UIPedalCyclesWindow.UINewWindow.UINewButton;
            WinEdit pedalCycleValue = UIPedalCyclesWindow.UIItemWindow1.UIItemEdit;
            WinEdit pedalCycleMake = UIPedalCyclesWindow.UITxtModelWindow.UIItemEdit;
            WinEdit pedalCycleSerial = UIPedalCyclesWindow.UITxtSerialNumberWindow.UIItemEdit;
            WinButton uISaveButton1 = UIPedalCyclesWindow.UISaveWindow.UISaveButton;
            WinButton uIOKButton2 = UIPedalCyclesWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDoyourequirecoverforCheckBox2 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow2.UICheckBox("Do you require cover for Money? (£)");
            WinEdit coverForMoneyAmount = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow26.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox3 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow3.UICheckBox("Do you require cover for Credit/Debit Cards? (£)");
            WinEdit coverForCreditCards = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIItemWindow27.UIItemEdit;
            WinCheckBox uIDoyourequirecoverforCheckBox4 =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIDoyourequirecoverforWindow4.UICheckBox("Do you require cover for Legal Expenses?");
            WinButton coverContNext = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow5.UINextButton;

            itemsOutsideHomeValue.Text = HouseholdQuoteParams.ItemsOutsideHomeValue;

            uIDoyourequirecoverforCheckBox1.Checked = HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked1;

            Mouse.Click(uICyclesButton, new Point(47, 15));

            Mouse.Click(pedalCyclesNew, new Point(31, 13));

            pedalCycleType.SelectedItem = HouseholdQuoteParams.PedalCycleType;

            pedalCycleValue.Text = HouseholdQuoteParams.PedalCycleValue;

            pedalCycleMake.Text = HouseholdQuoteParams.PedalCycleMake;

            pedalCycleSerial.Text = HouseholdQuoteParams.PedalCycleSerial;

            Mouse.Click(uISaveButton1, new Point(27, 16));

            Mouse.Click(uIOKButton2, new Point(24, 2));

            uIDoyourequirecoverforCheckBox2.Checked = HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked2;

            coverForMoneyAmount.Text = HouseholdQuoteParams.CoverForMoneyAmount;

            uIDoyourequirecoverforCheckBox3.Checked = HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked3;

            coverForCreditCards.Text = HouseholdQuoteParams.CoverForCreditCards;

            uIDoyourequirecoverforCheckBox4.Checked = HouseholdQuoteParams.UIDoyourequirecoverforCheckBoxChecked4;

            Mouse.Click(coverContNext, new Point(12, 10));
        }

        private void HomeProposerFullStep6()
        {
            WinCheckBox uIIsthepropertyusedforCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthepropertyusedforWindow.UICheckBox("Is the property used for business?");
            WinCheckBox uIIsthebusinessuseforcCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIIsthebusinessuseforcWindow.UICheckBox("Is the business use for clerical purposes only?");
            WinButton generalNext = UIPersonalLinesWindow.UIHouseholdQuoteWindow.UINextWindow6.UINextButton;
            WinCheckBox uIHavespecialconditionCheckBox =
                UIPersonalLinesWindow.UIHouseholdQuoteWindow.UIHavespecialconditionWindow.UICheckBox("Have special conditions  previously been applied?");

            uIIsthepropertyusedforCheckBox.Checked = HouseholdQuoteParams.UIIsthepropertyusedforCheckBoxChecked;

            uIIsthebusinessuseforcCheckBox.Checked = HouseholdQuoteParams.UIIsthebusinessuseforcCheckBoxChecked;

            Mouse.Click(generalNext, new Point(25, 9));

            uIHavespecialconditionCheckBox.Checked = HouseholdQuoteParams.UIHavespecialconditionCheckBoxChecked;
        }

        public void HomeSelectPolicy()
        {
            WinClient uIQuotesResultsClient = UIQuotesResultsWindow.UIItemWindow.UIClient();

            Mouse.Click(uIQuotesResultsClient, new Point(30, 30));

            Playback.Wait(1000);
            Mouse.Move(new Point(500, 500));
        }
    }
}