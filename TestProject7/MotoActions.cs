namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Drawing;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Assertions;
    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class MotoActions : UIMap
    {
        private readonly UIMap map = new UIMap();

        private MotoAWAPParams mMotoAwapParams;

        private MotoCopyCheckProposerExpectedValues mMotoCopyCheckProposerExpectedValues;

        private MotoCopyCheckCarExpectedValues mMotoCopyCheckCarExpectedValues;

        private MotoCheckPolicyStatusExpectedValues mMotoCheckPolicyStatusExpectedValues;

        private MotoCheckChangedPremiumExpectedValues mMotoCheckChangedPremiumExpectedValues;

        private MotoCheckAWAPpremiumExpectedValues mMotoCheckAWAPpremiumExpectedValues;

        private MotoAmendRiskParams mMotoAmendRiskParams;

        private MotoMTAMessageCancelledExpectedValues mMotoMTAMessageCancelledExpectedValues;

        private MotoMTAMessageAfterDateExpectedValues mMotoMTAMessageAfterDateExpectedValues;

        private MotoMTACheckNewValueExpectedValues mMotoMTACheckNewValueExpectedValues;

        private MotoMTACheckCarExpectedValues mMotoMTACheckCarExpectedValues;

        public virtual MotoAWAPParams MotoAWAPParams
        {
            get
            {
                if ((mMotoAwapParams == null))
                {
                    mMotoAwapParams = new MotoAWAPParams();
                }
                return mMotoAwapParams;
            }
        }

        public virtual MotoCopyCheckProposerExpectedValues MotoCopyCheckProposerExpectedValues
        {
            get
            {
                if ((mMotoCopyCheckProposerExpectedValues == null))
                {
                    mMotoCopyCheckProposerExpectedValues = new MotoCopyCheckProposerExpectedValues();
                }
                return mMotoCopyCheckProposerExpectedValues;
            }
        }

        public virtual MotoCopyCheckCarExpectedValues MotoCopyCheckCarExpectedValues
        {
            get
            {
                if ((mMotoCopyCheckCarExpectedValues == null))
                {
                    mMotoCopyCheckCarExpectedValues = new MotoCopyCheckCarExpectedValues();
                }
                return mMotoCopyCheckCarExpectedValues;
            }
        }

        public virtual MotoCheckPolicyStatusExpectedValues MotoCheckPolicyStatusExpectedValues
        {
            get
            {
                if ((mMotoCheckPolicyStatusExpectedValues == null))
                {
                    mMotoCheckPolicyStatusExpectedValues = new MotoCheckPolicyStatusExpectedValues();
                }
                return mMotoCheckPolicyStatusExpectedValues;
            }
        }

        public virtual MotoCheckChangedPremiumExpectedValues MotoCheckChangedPremiumExpectedValues
        {
            get
            {
                if ((mMotoCheckChangedPremiumExpectedValues == null))
                {
                    mMotoCheckChangedPremiumExpectedValues = new MotoCheckChangedPremiumExpectedValues();
                }
                return mMotoCheckChangedPremiumExpectedValues;
            }
        }

        public virtual MotoCheckAWAPpremiumExpectedValues MotoCheckAWAPpremiumExpectedValues
        {
            get
            {
                if ((mMotoCheckAWAPpremiumExpectedValues == null))
                {
                    mMotoCheckAWAPpremiumExpectedValues = new MotoCheckAWAPpremiumExpectedValues();
                }
                return mMotoCheckAWAPpremiumExpectedValues;
            }
        }

        public virtual MotoAmendRiskParams MotoAmendRiskParams
        {
            get
            {
                if ((mMotoAmendRiskParams == null))
                {
                    mMotoAmendRiskParams = new MotoAmendRiskParams();
                }
                return mMotoAmendRiskParams;
            }
        }

        public virtual MotoMTAMessageCancelledExpectedValues MotoMTAMessageCancelledExpectedValues
        {
            get
            {
                if ((mMotoMTAMessageCancelledExpectedValues == null))
                {
                    mMotoMTAMessageCancelledExpectedValues = new MotoMTAMessageCancelledExpectedValues();
                }
                return mMotoMTAMessageCancelledExpectedValues;
            }
        }

        public virtual MotoMTAMessageAfterDateExpectedValues MotoMTAMessageAfterDateExpectedValues
        {
            get
            {
                if ((mMotoMTAMessageAfterDateExpectedValues == null))
                {
                    mMotoMTAMessageAfterDateExpectedValues = new MotoMTAMessageAfterDateExpectedValues();
                }
                return mMotoMTAMessageAfterDateExpectedValues;
            }
        }

        public virtual MotoMTACheckNewValueExpectedValues MotoMTACheckNewValueExpectedValues
        {
            get
            {
                if ((mMotoMTACheckNewValueExpectedValues == null))
                {
                    mMotoMTACheckNewValueExpectedValues = new MotoMTACheckNewValueExpectedValues();
                }
                return mMotoMTACheckNewValueExpectedValues;
            }
        }

        public virtual MotoMTACheckCarExpectedValues MotoMTACheckCarExpectedValues
        {
            get
            {
                if ((mMotoMTACheckCarExpectedValues == null))
                {
                    mMotoMTACheckCarExpectedValues = new MotoMTACheckCarExpectedValues();
                }
                return mMotoMTACheckCarExpectedValues;
            }
        }

        public void MotoCreateSiteRenewal(string policyNumber, string renewalPremium, string insurer = "")
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaMotorTestReneHyperlink =
                map.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uiInsurerIdComboBox = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            HtmlEdit uITxtPremiumEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPremiumEdit;
            BrowserWindow uIInsurEcomSystemMaintWindow = map.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;

            #endregion

            Mouse.Click(uICreateaMotorTestReneHyperlink, new Point(50, 22));

            uiInsurerIdComboBox.SelectedItem = insurer == "" ? this.map.MotoCreateSiteRenewalParams.UIInsurerIDComboBoxSelectedItem : insurer;
     
            uITxtPolicyNumberEdit.Text = policyNumber;

            uITxtPremiumEdit.Text = renewalPremium;

            uITxtAutoLapseDateEdit1.Text = uITxtRenewalDateEdit.GetProperty("Text").ToString();

            Mouse.Click(uICreateRecordButton, new Point(112, 11));

            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        public void MotoAwap(string revisedPremium)
        {
            #region Variable Declarations

            WinButton uIawapButton = map.UIQuoteResultsWindow.UIAWAPWindow.UIAWAPButton;
            WinComboBox uIItemComboBox = map.UIAcceptWithAnotherProWindow.UIItemWindow.UIItemComboBox;
            WinEdit uIItemEdit = map.UIAcceptWithAnotherProWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIAcceptWithAnotherProWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIAcceptWithAnotherProWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIAcceptWithAnotherProWindow.UIItemWindow4.UIItemEdit;
            WinButton uIOKButton = map.UIAcceptWithAnotherProWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = map.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton3 = map.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            #endregion

            Mouse.Click(uIawapButton, new Point(50, 14));

            uIItemComboBox.SelectedIndex = 0;

            uIItemEdit.Text = MotoAWAPParams.ProductDescription;

            uIItemEdit1.Text = MotoAWAPParams.PolicyNumber;

            uIItemEdit2.Text = revisedPremium;

            uIItemEdit3.Text = MotoAWAPParams.VolExcess;

            Mouse.Click(uIOKButton, new Point(49, 9));

            PaymentMethod("cash");

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(44, 7));

            Mouse.Click(uIOKButton3, new Point(56, 6));

            SelectTAMActivities1();
        }

        public void MotoAmendRiskRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = map.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = map.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = map.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton1 = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(53, 14));

            Mouse.Click(uIYesButton, new Point(54, 13));

            Mouse.Click(uIYesButton, new Point(62, 10));

            Mouse.Click(uIOKButton, new Point(42, 10));

            map.RetrieveResponse();

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(58, 18));

            Mouse.Click(uIOKButton2, new Point(48, 11));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton3, new Point(54, 5));

            SelectTAMActivities3();

            Mouse.Click(uIExitButton, new Point(48, 12));

            Mouse.Click(uIYesButton1, new Point(19, 10));
        }

        public void MotoAmendRiskNew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = map.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = map.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(59, 11));

            Mouse.Click(uIOKButton1, new Point(54, 6));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(47, 13));

            SelectTAMActivities2();

            map.EtamOk();

            Mouse.Click(uIExitButton, new Point(47, 18));

            Mouse.Click(uIYesButton, new Point(51, 7));
        }

        public void MotoCopyCheckProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;

            #endregion

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.Firstname, uIItemEdit.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.DateOfBirth, uIItemEdit1.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.Postcode, uIItemEdit2.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.AddressLine1, uIItemEdit3.Text);
        }

        public void MotoCopyCheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(MotoCopyCheckCarExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(MotoCopyCheckCarExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        public void MotoCloseDetails()
        {
            #region Variable Declarations

            WinButton uICancelButton = map.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(32, 12));
        }

        public void MotoCheckPolicyStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            #endregion

            Assert.AreEqual(MotoCheckPolicyStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void MotoCheckChangedPremium(string overridePremium)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            #endregion

            Mouse.Click(uIItemEdit);
            Assert.AreEqual(overridePremium, uIItemEdit.Text);
        }

        public void MotoCheckAWAPpremium(string expectedPremium)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            #endregion

            Assert.AreEqual(expectedPremium, uIItemEdit.Text);
        }

        public void MotoCancelPolicy1()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = map.UIClaimsWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(39, 9));

            Mouse.Click(uINOButton, new Point(22, 18));
        }

        public void MotoCancelPolicy()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            uIItemComboBox.SelectedItem = CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(34, 12));

            Mouse.Click(uICalculateQuoteButton, new Point(67, 12));
        }

        public void MotoCalculate()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uICalculateQuoteButton, new Point(69, 13));
        }

        public void MotoAmendRiskNew(string paymentMethod)
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = map.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(60, 14));

            PaymentMethod(paymentMethod);

            CancelPrint();

            Mouse.Click(uIOKButton, new Point(37, 9));
        }

        public void MotoAmendRisk()
        {
            #region Variable Declarations

            WinButton uIAmendRiskButton = map.Uiautoxxx1000Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = map.UIAmendRiskWindow.UIItemWindow.UIItemEdit;
            WinButton uIProposerDetailsButton = map.UIAmendRiskWindow.UIProposerDetailsWindow.UIProposerDetailsButton;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = map.UIAmendRiskWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
             WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

            #endregion

            Mouse.Click(uIAmendRiskButton, new Point(80, 11));

            uIItemEdit.Text = MotoAmendRiskParams.VehicleCostNew;

            Mouse.Click(uIProposerDetailsButton, new Point(66, 12));

            uIItemEdit1.Text = MotoAmendRiskParams.SurnameNew;

            Mouse.Click(uIOKButton, new Point(50, 11));

            Mouse.Click(uICalculateQuoteButton, new Point(58, 6));

            Mouse.Click(uIProceedButton, new Point(50, 0));
        }

        public void MotoSelectHighwayPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();

            #endregion

            Mouse.DoubleClick(uIQuoteResultsClient);

            Mouse.Click(uIQuoteResultsClient, new Point(30, 30));

            Mouse.Move(new Point(500, 500));
        }

        public void MotoSearchCar()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = map.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = map.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = map.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinButton uIOKButton1 = map.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox3 = map.UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox2 = map.UIVehicleLookupWindow.UIItemWindow2.UIItemComboBox;
            WinButton uIFilterButton = map.UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinButton uIOKButton2 = map.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIOKButton, new Point(40, 9));

            uIItemComboBox.SelectedItem = QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = QuoteResultsParams.JobSector;

            uIItemEdit.Text = QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(45, 18));

            uIItemComboBox2.EditableItem = VehicleLookupParams.CarMake;

            uIItemComboBox3.EditableItem = VehicleLookupParams.CarModel;

            Mouse.Click(uIFilterButton, new Point(29, 9));

            Mouse.Click(uIOKButton2, new Point(24, 10));

            uIItemEdit1.Text = QuoteResultsParams.CarRegFordFiesta;

            uIItemEdit2.Text = QuoteResultsParams.VehicleCost;
        }

        public void MotoRebrokeSelectScheme(string withSendKeys)
        {
            #region Variable Declarations

            WinClient uIItemClient = map.UIRebrokeResultsScreenWindow.UIItemWindow1.UIClient();

            #endregion

            // Click client
            Mouse.Click(uIItemClient, new Point(271, 102));

            // Type '{Home}' in client
            Keyboard.SendKeys(uIItemClient, withSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     MotoRebrokeCurrent
        /// </summary>
        /// <param name="withYesButton"></param>
        public void MotoRebrokeCurrent(bool withYesButton)
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(50, 10));

            try
            {
                ImportToTamOptionsOnce("");
            }
            catch
            {
            }

            if (withYesButton)
            {
                Mouse.Click(uIYesButton, new Point(43, 11));
            }
        }

        /// <summary>
        ///     MotoRebroke
        /// </summary>
        /// <param name="withCancel"></param>
        /// <param name="withConfim"></param>
        public void MotoRebroke(bool withCancel, bool withConfim)
        {
            #region Variable Declarations

            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;
            WinButton uIRebrokeButton = map.Uiautoxxx1000Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton = UIConfirmWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRebrokeButton, new Point(86, 12));

            if (withCancel)
            {
                Mouse.Click(uICancelButton, new Point(48, 17));
            }

            if (withConfim)
            {
                Mouse.Click(uIOKButton);
            }

            Mouse.Click(uIProceedButton);
        }

        /// <summary>
        ///     MotoPostcodeLookup - Use 'MotoPostcodeLookupParams' to pass parameters into this method.
        /// </summary>
        public void MotoPostcodeLookup()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = map.UISearchResultForBN16BWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(41, 13));

            uIItemEdit.Text = ProposerParams.Firstname;

            uIItemEdit1.Text = ProposerParams.Lastname;

            uIItemEdit2.Text = ProposerParams.DateOfBirth;

            uIItemEdit3.Text = ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(9, 12));

            Mouse.Click(uIOKButton1, new Point(37, 9));
        }

        /// <summary>
        ///     MotoPolicyPerson - Use 'MotoPolicyPersonParams' to pass parameters into this method.
        /// </summary>
        public void MotoPolicyPerson()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = map.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(52, 17));

            uIItemEdit.Text = ProposerParams.Firstname;

            uIItemEdit1.Text = ProposerParams.Lastname;

            uIItemEdit2.Text = ProposerParams.DateOfBirth;

            uIItemEdit3.Text = ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(34, 13));

            Mouse.Click(uIOKButton1, new Point(38, 12));
        }

        /// <summary>
        ///     MotoMTAOpenQuote
        /// </summary>
        public void MotoMTAOpenQuote()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(33, 12));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(116, 15));

            Mouse.Click(uIOKButton, new Point(29, 10));
        }

        /// <summary>
        ///     MotoMTANoSave - Use 'MotoMTANoSaveParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTANoSave()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton1 = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton, new Point(42, 16));

            Mouse.Click(uIExitButton, new Point(70, 10));

            Mouse.Click(uIYesButton, new Point(51, 13));

            Mouse.Click(uIOKButton1, new Point(39, 15));
        }

        /// <summary>
        ///     MotoMTAMessageCancelled - Use 'MotoMTAMessageCancelledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageCancelled()
        {
            #region Variable Declarations

            WinText uImtAsuccessfullyproceText = map.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            #endregion

            StringAssert.Contains(uImtAsuccessfullyproceText.DisplayText, MotoMTAMessageCancelledExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAMessageAfterDate - Use 'MotoMTAMessageAfterDateExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageAfterDate()
        {
            #region Variable Declarations

            WinText uIAdjustmentdatetimecaText = map.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIAdjustmentdatetimecaText;

            #endregion

            // Verify that the 'DisplayText' property of 'Adjustment date/time cannot be after the policy ef...' label contains 'Adjustment date/time cannot be after the policy effective end date/time'
            StringAssert.Contains(uIAdjustmentdatetimecaText.DisplayText, MotoMTAMessageAfterDateExpectedValues.UIAdjustmentdatetimecaTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy_1
        /// </summary>
        public void MotoMTAConfirmPolicy1()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(37, 25));
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy - Use 'MotoMTAConfirmPolicyParams' to pass parameters into this method.
        /// </summary>
        /// <param name="action"></param>
        public void MotoMTAConfirmPolicy(string action)
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(54, 8));

            Mouse.Click(uIYesButton, new Point(40, 12));

            Mouse.Click(uIOKButton, new Point(50, 19));

            Mouse.Click(uIOKButton1, new Point(32, 8));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(42, 12));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton3, new Point(24, 14));

            if (action == "cancel")
            {
                SelectTAMActivities2();
            }
            else
            {
                SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
            }
        }

        public void MotoMTAConfirmDate()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(21, 17));
        }

        public void MotoMTACloseMessage()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(56, 8));
        }

        public void MotoMTACheckNewValue(bool needScreenshot, string expectedDate = "")
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(MotoMTACheckNewValueExpectedValues.UIItemEditText, uIItemEdit.Text);

            if (needScreenshot)
            {
                CreateScreenshot(expectedDate);
            }
        }

        public void MotoMTACheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(MotoMTACheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(MotoMTACheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoMTABeforeFinish - Use 'MotoMTABeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeFinish()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(28, 8));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(69, 14));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 21));

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        /// <summary>
        ///     MotoMTABeforeAccept - Use 'MotoMTABeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(56, 12));

            Mouse.Click(uIYesButton, new Point(51, 11));

            Mouse.Click(uIOKButton, new Point(31, 21));

            Mouse.Click(uIOKButton1, new Point(38, 19));
        }

        /// <summary>
        ///     MotoMTABefore2 - Use 'MotoMTABefore2Params' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore2()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 11));

            Mouse.Click(uIYesButton, new Point(57, 12));

            Mouse.Click(uIMTAButton, new Point(53, 9));

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(36, 16));

            uIItemEdit.Text = MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton, new Point(59, 11));
        }

        /// <summary>
        ///     MotoMTABefore - Use 'MotoMTABeforeParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIBeforeButton = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(35, 10));

            Mouse.Click(uIBeforeButton, new Point(19, 16));

            Mouse.Click(uIMTAButton, new Point(44, 11));

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(44, 21));

            uIItemEdit.Text = MotoMTAParams.VehicleRegistration2;

            Mouse.Click(uICalculateQuoteButton, new Point(61, 15));
        }

        /// <summary>
        ///     MotoMTAAccept - Use 'MotoMTAAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTAAccept()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton, new Point(28, 12));

            uIItemEdit.Text = MotoMTAParams.CostOfVehicle;

            Mouse.Click(uICalculateQuoteButton, new Point(68, 4));
        }

        /// <summary>
        ///     MotoMTA
        /// </summary>
        public void MotoMTA()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(37, 10));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(80, 15));

            Mouse.Click(uIOKButton, new Point(41, 10));

            Mouse.Click(uIMTAButton, new Point(67, 11));
        }

        /// <summary>
        ///     MotoInceptionDate - Use 'MotoInceptionDateParams' to pass parameters into this method.
        /// </summary>
        public void MotoInceptionDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
        }

        /// <summary>
        ///     MotoFinishMTA - Use 'MotoFinishMTAParams' to pass parameters into this method.
        /// </summary>
        public void MotoFinishMTA()
        {
            #region Variable Declarations

            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinClient uIPointOfSaleClient = map.UIPointOfSaleWindow.UIPointOfSaleClient;
            WinCheckBox uIDeferPrintingCheckBox = map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            MotoSelectHighwayPolicy();

            Mouse.Click(uIAcceptButton, new Point(51, 11));

            Mouse.Click(uIYesButton, new Point(57, 13));

            Mouse.Click(uIOKButton, new Point(38, 11));

            Mouse.Click(uIOKButton1, new Point(59, 17));

            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(54, 19));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);
            Mouse.Click(uIOKButton3, new Point(43, 6));

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        /// <summary>
        ///     MotoExitMTA
        /// </summary>
        public void MotoExitMTA()
        {
            #region Variable Declarations

            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(51, 10));

            Mouse.Click(uIYesButton, new Point(13, 9));

            Mouse.Click(uIOKButton, new Point(55, 12));
        }

        /// <summary>
        ///     MotoCopyRiskProposerOk
        /// </summary>
        public void MotoCopyRiskProposerOk()
        {
            #region Variable Declarations

            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 7));
        }

        /// <summary>
        ///     MotoCopyRiskExit
        /// </summary>
        public void MotoCopyRiskExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = map.UIInsurEtamWindow1.UINoWindow.UINoButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(66, 10));

            Mouse.Click(uINOButton, new Point(47, 10));

            Mouse.Click(uIOKButton, new Point(34, 11));
        }

        /// <summary>
        ///     MotoCopyFinishedRisk
        /// </summary>
        public void MotoCopyFinishedRisk()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = map.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinButton uIOKButton1 = map.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOptionsButton, new Point(29, 12));

            Mouse.Click(uICopyRiskMenuItem, new Point(79, 13));

            Mouse.Click(uIOKButton, new Point(57, 15));

            Mouse.Click(uIOKButton1, new Point(31, 15));
        }

        /// <summary>
        ///     MotoCancelExit
        /// </summary>
        public void MotoCancelExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = map.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            Mouse.Click(uIExitButton, new Point(59, 16));

            Mouse.Click(uIYesButton, new Point(66, 12));

            Mouse.Click(uIOKButton, new Point(53, 10));
        }

        /// <summary>
        ///     QuoteResults - Use 'QuoteResultsParams' to pass parameters into this method.
        /// </summary>
        public void QuoteResults()
        {
            #region Variable Declarations

            WinControl uIOKButton = UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinControl uIOKButton1 = UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit2 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinEdit uIItemEdit3 = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 12));

            uIItemComboBox.SelectedItem = QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = QuoteResultsParams.JobSector;

            uIItemEdit.Text = QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(38, 4));

            //insert standard lookup here
            //uIItemEdit1.Text = QuoteResultsParams.UIItemEditText1;

            //Mouse.Click(uIFilterButton, new Point(59, 14));
            VehicleLookup();

            uIItemEdit2.Text = QuoteResultsParams.VehicleCost;

            uIItemEdit3.Text = QuoteResultsParams.CarRegFordFiesta;

            Mouse.Click(uICalculateQuoteButton, new Point(25, 13));
        }

        /// <summary>
        ///     QuoteResults_1
        /// </summary>
        public void QuoteResults1()
        {
            #region Variable Declarations

            WinControl uINOButton = UICreditCheckWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uINOButton, new Point(28, 10));
        }

        public void VehicleLookup()
        {
            #region Variable Declarations

            WinRadioButton uIStandardLookupRadioButton = UIVehicleLookupWindow.UIStandardLookupWindow.UIRadioButton("Standard Lookup:");
            WinComboBox uIItemComboBox = UIVehicleLookupWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = UIVehicleLookupWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = UIVehicleLookupWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit2 = UIVehicleLookupWindow.UIItemWindow4.UIItemEdit;
            WinComboBox uIItemComboBox2 = UIVehicleLookupWindow.UIItemWindow5.UIItemComboBox;
            WinComboBox uIItemComboBox3 = UIVehicleLookupWindow.UIItemWindow6.UIItemComboBox;
            WinButton uIFilterButton = UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinButton uIOKButton = UIVehicleLookupWindow.UIOKWindow.UIOKButton;

            #endregion

            uIStandardLookupRadioButton.Selected = VehicleLookupParams.StandardLookupRadioButton;
            uIItemComboBox.EditableItem = VehicleLookupParams.CarMake;
            uIItemComboBox1.EditableItem = VehicleLookupParams.CarModel;
            uIItemEdit.Text = VehicleLookupParams.EngineCapacity;
            uIItemEdit1.Text = VehicleLookupParams.Doors;
            uIItemEdit2.Text = VehicleLookupParams.YearBuilt;
            uIItemComboBox2.SelectedItem = VehicleLookupParams.FuelType;
            uIItemComboBox3.SelectedItem = VehicleLookupParams.TransmissionType;
            Mouse.Click(uIFilterButton, new Point(29, 16));
            Mouse.Click(uIOKButton, new Point(17, 7));
        }

        public void MotoFinishQuote()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinControl uIOKButton = UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinControl uIOKButton1 = UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;

            #endregion

            Playback.Wait(2000);

            uIDeferPrintingCheckBox.Checked = CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(51, 7));

            uIAddActivityCheckBox.Checked = CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);

            Mouse.Click(uIOKButton1, new Point(41, 15));

            SelectTAMActivities2();
        }

        public void CreateMTA()
        {
            MotoMTA();
            MotoMTAAccept();
            MotoMTAConfirmDate();
            MotoMTAConfirmPolicy("mta");
        }

        public void AcceptAndFinishQuote(string paymentType)
        {
            AcceptQuote();
            this.FinishQuote(paymentType);
            CancelPrint();
            MotoFinishQuote();
        }

        public void CreateNewBusinessPolicy(ExpectedAddress expectedAddress)
        {
            MotoPolicyPerson();
            this.PostcodeLookup(expectedAddress);
            QuoteResults();
            QuoteResults1();
            PublicCreditCheckOk();
        }

        public string TamMotorSteps(CustomerActions customer)
        {
            CustomerCode = customer.AddPolicy();
            SelectMotoPolicy();
            SelectMenu();
            Links();
            return CustomerCode;
        }


        public void PostcodeLookup(ExpectedAddress expectedAddress)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = UIProposerDetailsWindow.UIItemWindow5.UIItemEdit;

            #endregion

            Assert.AreEqual(expectedAddress.AddressLine1, uIItemEdit.Text);

            Assert.AreEqual(expectedAddress.AddressLine2, uIItemEdit1.Text);
        }
    }
}