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

        public string CustomerCode { get; set; }

        public virtual MotoAWAPParams MotoAWAPParams
        {
            get
            {
                if ((this.mMotoAwapParams == null))
                {
                    this.mMotoAwapParams = new MotoAWAPParams();
                }
                return this.mMotoAwapParams;
            }
        }

        public virtual MotoCopyCheckProposerExpectedValues MotoCopyCheckProposerExpectedValues
        {
            get
            {
                if ((this.mMotoCopyCheckProposerExpectedValues == null))
                {
                    this.mMotoCopyCheckProposerExpectedValues = new MotoCopyCheckProposerExpectedValues();
                }
                return this.mMotoCopyCheckProposerExpectedValues;
            }
        }

        public virtual MotoCopyCheckCarExpectedValues MotoCopyCheckCarExpectedValues
        {
            get
            {
                if ((this.mMotoCopyCheckCarExpectedValues == null))
                {
                    this.mMotoCopyCheckCarExpectedValues = new MotoCopyCheckCarExpectedValues();
                }
                return this.mMotoCopyCheckCarExpectedValues;
            }
        }

        public virtual MotoCheckPolicyStatusExpectedValues MotoCheckPolicyStatusExpectedValues
        {
            get
            {
                if ((this.mMotoCheckPolicyStatusExpectedValues == null))
                {
                    this.mMotoCheckPolicyStatusExpectedValues = new MotoCheckPolicyStatusExpectedValues();
                }
                return this.mMotoCheckPolicyStatusExpectedValues;
            }
        }

        public virtual MotoCheckChangedPremiumExpectedValues MotoCheckChangedPremiumExpectedValues
        {
            get
            {
                if ((this.mMotoCheckChangedPremiumExpectedValues == null))
                {
                    this.mMotoCheckChangedPremiumExpectedValues = new MotoCheckChangedPremiumExpectedValues();
                }
                return this.mMotoCheckChangedPremiumExpectedValues;
            }
        }

        public virtual MotoCheckAWAPpremiumExpectedValues MotoCheckAWAPpremiumExpectedValues
        {
            get
            {
                if ((this.mMotoCheckAWAPpremiumExpectedValues == null))
                {
                    this.mMotoCheckAWAPpremiumExpectedValues = new MotoCheckAWAPpremiumExpectedValues();
                }
                return this.mMotoCheckAWAPpremiumExpectedValues;
            }
        }

        public virtual MotoAmendRiskParams MotoAmendRiskParams
        {
            get
            {
                if ((this.mMotoAmendRiskParams == null))
                {
                    this.mMotoAmendRiskParams = new MotoAmendRiskParams();
                }
                return this.mMotoAmendRiskParams;
            }
        }

        public virtual MotoMTAMessageCancelledExpectedValues MotoMTAMessageCancelledExpectedValues
        {
            get
            {
                if ((this.mMotoMTAMessageCancelledExpectedValues == null))
                {
                    this.mMotoMTAMessageCancelledExpectedValues = new MotoMTAMessageCancelledExpectedValues();
                }
                return this.mMotoMTAMessageCancelledExpectedValues;
            }
        }

        public virtual MotoMTAMessageAfterDateExpectedValues MotoMTAMessageAfterDateExpectedValues
        {
            get
            {
                if ((this.mMotoMTAMessageAfterDateExpectedValues == null))
                {
                    this.mMotoMTAMessageAfterDateExpectedValues = new MotoMTAMessageAfterDateExpectedValues();
                }
                return this.mMotoMTAMessageAfterDateExpectedValues;
            }
        }

        public virtual MotoMTACheckNewValueExpectedValues MotoMTACheckNewValueExpectedValues
        {
            get
            {
                if ((this.mMotoMTACheckNewValueExpectedValues == null))
                {
                    this.mMotoMTACheckNewValueExpectedValues = new MotoMTACheckNewValueExpectedValues();
                }
                return this.mMotoMTACheckNewValueExpectedValues;
            }
        }

        public virtual MotoMTACheckCarExpectedValues MotoMTACheckCarExpectedValues
        {
            get
            {
                if ((this.mMotoMTACheckCarExpectedValues == null))
                {
                    this.mMotoMTACheckCarExpectedValues = new MotoMTACheckCarExpectedValues();
                }
                return this.mMotoMTACheckCarExpectedValues;
            }
        }

        public string MotoGetPolicyNumber()
        {


            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIPolicyrtyertWindow.UIBillingScreenMotoTestWindow.UIItemWindow.UIItemEdit;

            var policyNo =  uIItemEdit.GetProperty("Text").ToString();

            Mouse.Click(uIItemEdit2, new Point(45, 4));

            return policyNo;
        }

        public void MotoCreateSiteRenewal(string policyNumber, string renewalPremium)
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaMotorTestReneHyperlink =
                this.map.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uiInsurerIdComboBox = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            HtmlEdit uITxtPremiumEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPremiumEdit;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.map.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;

            #endregion

            Mouse.Click(uICreateaMotorTestReneHyperlink, new Point(50, 22));

            uiInsurerIdComboBox.SelectedItem = this.map.MotoCreateSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            uITxtPolicyNumberEdit.Text = policyNumber;

            uITxtPremiumEdit.Text = renewalPremium;

            uITxtAutoLapseDateEdit1.Text = uITxtRenewalDateEdit.GetProperty("Text").ToString();

            Mouse.Click(uICreateRecordButton, new Point(112, 11));

            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        public void MotoAwap(string revisedPremium)
        {
            #region Variable Declarations

            WinButton uIawapButton = this.map.UIQuoteResultsWindow.UIAWAPWindow.UIAWAPButton;
            WinComboBox uIItemComboBox = this.map.UIAcceptWithAnotherProWindow.UIItemWindow.UIItemComboBox;
            WinEdit uIItemEdit = this.map.UIAcceptWithAnotherProWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIAcceptWithAnotherProWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIAcceptWithAnotherProWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.map.UIAcceptWithAnotherProWindow.UIItemWindow4.UIItemEdit;
            WinButton uIOKButton = this.map.UIAcceptWithAnotherProWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.map.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton3 = this.map.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            #endregion

            Mouse.Click(uIawapButton, new Point(50, 14));

            uIItemComboBox.SelectedItem = this.MotoAWAPParams.InsurerSelect;

            uIItemEdit.Text = this.MotoAWAPParams.ProductDescription;

            uIItemEdit1.Text = this.MotoAWAPParams.PolicyNumber;

            uIItemEdit2.Text = revisedPremium;

            uIItemEdit3.Text = this.MotoAWAPParams.VolExcess;

            Mouse.Click(uIOKButton, new Point(49, 9));

            Mouse.Click(uIOKButton1, new Point(45, 11));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(44, 7));

            Mouse.Click(uIOKButton3, new Point(56, 6));

            this.SelectTamInsurersAndActivity(selectListItems1:1);
        }

        public void MotoAmendRiskRenew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.map.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.map.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton1 = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(53, 14));

            Mouse.Click(uIYesButton, new Point(54, 13));

            Mouse.Click(uIYesButton, new Point(62, 10));

            Mouse.Click(uIOKButton, new Point(42, 10));

            this.map.RetrieveResponse();

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(58, 18));

            Mouse.Click(uIOKButton2, new Point(48, 11));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton3, new Point(54, 5));

            Mouse.Click(uIOKButton4, new Point(45, 10));

            this.SelectTamInsurersAndActivity(selectListItems1:2);

            Mouse.Click(uIExitButton, new Point(48, 12));

            Mouse.Click(uIYesButton1, new Point(19, 10));
        }

        public void MotoAmendRiskNew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.map.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton, new Point(59, 11));

            Mouse.Click(uIOKButton1, new Point(54, 6));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(47, 13));

            this.SelectTamInsurersAndActivity(selectListItems1: 3);

            this.map.EtamOk();

            Mouse.Click(uIExitButton, new Point(47, 18));

            Mouse.Click(uIYesButton, new Point(51, 7));
        }

        public void MotoCopyCheckProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.map.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;

            #endregion

            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.Firstname, uIItemEdit.Text);

            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.DateOfBirth, uIItemEdit1.Text);

            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.Postcode, uIItemEdit2.Text);

            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.AddressLine1, uIItemEdit3.Text);
        }

        public void MotoCopyCheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        public void MotoCloseDetails()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.map.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            #endregion

            Mouse.Click(uICancelButton, new Point(32, 12));
        }

        public void MotoCheckPolicyStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            #endregion

            Assert.AreEqual(this.MotoCheckPolicyStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void MotoCheckChangedPremium(string overridePremium)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(overridePremium, uIItemEdit.Text);
        }

        public void MotoCheckAWAPpremium(string expectedPremium)
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(expectedPremium, uIItemEdit.Text);
        }

        public void MotoCancelPolicy1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = this.map.UIClaimsWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(39, 9));

            Mouse.Click(uINOButton, new Point(22, 18));
        }

        public void MotoCancelPolicy()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            uIItemComboBox.SelectedItem = this.CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(34, 12));

            Mouse.Click(uICalculateQuoteButton, new Point(67, 12));
        }

        public void MotoCalculate()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uICalculateQuoteButton, new Point(69, 13));
        }

        public void MotoAmendRiskNew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIRenewPolicyButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(60, 14));

            this.CancelPrint();

            Mouse.Click(uIOKButton, new Point(37, 9));
        }

        public void MotoAmendRisk()
        {
            #region Variable Declarations

            WinButton uIAmendRiskButton = this.map.Uiautoxxx1000Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.map.UIAmendRiskWindow.UIItemWindow.UIItemEdit;
            WinButton uIProposerDetailsButton = this.map.UIAmendRiskWindow.UIProposerDetailsWindow.UIProposerDetailsButton;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.map.UIAmendRiskWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinButton uINOButton = this.map.UICreditCheckWindow.UINoWindow.UINoButton;

            #endregion

            Mouse.Click(uIAmendRiskButton, new Point(80, 11));

            uIItemEdit.Text = this.MotoAmendRiskParams.VehicleCostNew;

            Mouse.Click(uIProposerDetailsButton, new Point(66, 12));

            uIItemEdit1.Text = this.MotoAmendRiskParams.SurnameNew;

            Mouse.Click(uIOKButton, new Point(50, 11));

            Mouse.Click(uICalculateQuoteButton, new Point(58, 6));

            Mouse.Click(uINOButton, new Point(50, 0));
        }

        public void MotoSelectHighwayPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient();

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(405, 217));

            Keyboard.SendKeys(uIQuoteResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);
        }

        public void MotoSearchCar()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.map.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.map.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.map.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinButton uIOKButton1 = this.map.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox3 = this.map.UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox2 = this.map.UIVehicleLookupWindow.UIItemWindow2.UIItemComboBox;
            WinButton uIFilterButton = this.map.UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinButton uIOKButton2 = this.map.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIOKButton, new Point(40, 9));

            uIItemComboBox.SelectedItem = this.QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = this.QuoteResultsParams.JobSector;

            uIItemEdit.Text = this.QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(45, 18));

            uIItemComboBox2.EditableItem = this.VehicleLookupParams.CarMake;

            uIItemComboBox3.EditableItem = this.VehicleLookupParams.CarModel;

            Mouse.Click(uIFilterButton, new Point(29, 9));

            Mouse.Click(uIOKButton2, new Point(24, 10));

            uIItemEdit1.Text = this.QuoteResultsParams.CarRegFordFiesta;

            uIItemEdit2.Text = this.QuoteResultsParams.VehicleCost;
        }


        public void MotoRebrokeSelectScheme(string withSendKeys)
        {
            #region Variable Declarations

            WinClient uIItemClient = this.map.UIRebrokeResultsScreenWindow.UIItemWindow1.UIClient();

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

            WinButton uIOKButton = this.map.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(50, 10));

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

            WinButton uIRebrokeButton = this.map.Uiautoxxx1000Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = this.map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uINOButton = this.map.UICreditCheckWindow.UINoWindow.UINoButton;
            WinButton uIOKButton = this.UIConfirmWindow.UIOKWindow.UIOKButton;

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

            Mouse.Click(uINOButton, new Point(48, 11));
        }

        /// <summary>
        ///     MotoPostcodeLookup - Use 'MotoPostcodeLookupParams' to pass parameters into this method.
        /// </summary>
        public void MotoPostcodeLookup()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = this.map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = this.map.UISearchResultForBN16BWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(41, 13));

            uIItemEdit.Text = this.ProposerParams.Firstname;

            uIItemEdit1.Text = this.ProposerParams.Lastname;

            uIItemEdit2.Text = this.ProposerParams.DateOfBirth;

            uIItemEdit3.Text = this.ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(9, 12));

            Mouse.Click(uIOKButton1, new Point(37, 9));
        }

        /// <summary>
        ///     MotoPolicyPerson - Use 'MotoPolicyPersonParams' to pass parameters into this method.
        /// </summary>
        public void MotoPolicyPerson()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = this.map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = this.map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = this.map.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(52, 17));

            uIItemEdit.Text = this.ProposerParams.Firstname;

            uIItemEdit1.Text = this.ProposerParams.Lastname;

            uIItemEdit2.Text = this.ProposerParams.DateOfBirth;

            uIItemEdit3.Text = this.ProposerParams.Postcode;

            Mouse.Click(uILookupButton, new Point(34, 13));

            Mouse.Click(uIOKButton1, new Point(38, 12));
        }

        /// <summary>
        ///     MotoMTAOpenQuote
        /// </summary>
        public void MotoMTAOpenQuote()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;

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

            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton1 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

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

            WinText uImtAsuccessfullyproceText = this.map.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            #endregion

            StringAssert.Contains(uImtAsuccessfullyproceText.DisplayText, this.MotoMTAMessageCancelledExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAMessageAfterDate - Use 'MotoMTAMessageAfterDateExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageAfterDate()
        {
            #region Variable Declarations

            WinText uIAdjustmentdatetimecaText = this.map.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIAdjustmentdatetimecaText;

            #endregion

            // Verify that the 'DisplayText' property of 'Adjustment date/time cannot be after the policy ef...' label contains 'Adjustment date/time cannot be after the policy effective end date/time'
            StringAssert.Contains(uIAdjustmentdatetimecaText.DisplayText, this.MotoMTAMessageAfterDateExpectedValues.UIAdjustmentdatetimecaTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy_1
        /// </summary>
        public void MotoMTAConfirmPolicy1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

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

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(362, 176));

            Keyboard.SendKeys(uIQuoteResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(54, 8));

            Mouse.Click(uIYesButton, new Point(40, 12));

            Mouse.Click(uIOKButton, new Point(50, 19));

            Mouse.Click(uIOKButton1, new Point(32, 8));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(42, 12));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton3, new Point(24, 14));

            if (action == "cancel")
            {
                this.SelectTamInsurersAndActivity(selectListItems1: 2);
            }
            else
            {
                this.SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
            }
            
        }

        public void MotoMTAConfirmDate()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(21, 17));
        }

        public void MotoMTACloseMessage()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(56, 8));
        }

        public void MotoMTACheckNewValue(bool needScreenshot, string expectedDate = "")
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.MotoMTACheckNewValueExpectedValues.UIItemEditText, uIItemEdit.Text);

            if (needScreenshot)
            {
                this.CreateScreenshot(expectedDate);
            }
        }

        public void MotoMTACheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            Assert.AreEqual(this.MotoMTACheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(this.MotoMTACheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoMTABeforeFinish - Use 'MotoMTABeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeFinish()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(28, 8));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton1, new Point(69, 14));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(46, 21));

            this.SelectTamInsurersAndActivity(selectListItems1:1, selectListItems2:1);
        }

        /// <summary>
        ///     MotoMTABeforeAccept - Use 'MotoMTABeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(401, 181));

            Keyboard.SendKeys(uIQuoteResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

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

            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 11));

            Mouse.Click(uIYesButton, new Point(57, 12));

            Mouse.Click(uIMTAButton, new Point(53, 9));

            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(36, 16));

            uIItemEdit.Text = this.MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton, new Point(59, 11));
        }

        /// <summary>
        ///     MotoMTABefore - Use 'MotoMTABeforeParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIBeforeButton = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(35, 10));

            Mouse.Click(uIBeforeButton, new Point(19, 16));

            Mouse.Click(uIMTAButton, new Point(44, 11));

            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(44, 21));

            uIItemEdit.Text = this.MotoMTAParams.VehicleRegistration2;

            Mouse.Click(uICalculateQuoteButton, new Point(61, 15));
        }

        /// <summary>
        ///     MotoMTAAccept - Use 'MotoMTAAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTAAccept()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            uIItemComboBox.SelectedItem = this.MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton, new Point(28, 12));

            uIItemEdit.Text = this.MotoMTAParams.CostOfVehicle;

            Mouse.Click(uICalculateQuoteButton, new Point(68, 4));
        }

        /// <summary>
        ///     MotoMTA
        /// </summary>
        public void MotoMTA()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;

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

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
        }

        /// <summary>
        ///     MotoFinishMTA - Use 'MotoFinishMTAParams' to pass parameters into this method.
        /// </summary>
        public void MotoFinishMTA()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinClient uIPointOfSaleClient = this.map.UIPointOfSaleWindow.UIPointOfSaleClient;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;

            #endregion

            Mouse.Click(uIQuoteResultsClient, new Point(371, 177));

            Keyboard.SendKeys(uIQuoteResultsClient, this.CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(51, 11));

            Mouse.Click(uIYesButton, new Point(57, 13));

            Mouse.Click(uIOKButton, new Point(38, 11));

            Mouse.Click(uIOKButton1, new Point(59, 17));

            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            uIDeferPrintingCheckBox.Checked = this.CommonParams.UIDeferPrintingCheckBoxChecked;

            Mouse.Click(uIOKButton2, new Point(54, 19));

            uIAddActivityCheckBox.Checked = this.CommonParams.UIAddActivityCheckBoxChecked;

            Playback.Wait(2000);
            Mouse.Click(uIOKButton3, new Point(43, 6));

            this.SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        /// <summary>
        ///     MotoExitMTA
        /// </summary>
        public void MotoExitMTA()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

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

            WinButton uIOKButton = this.map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 7));
        }

        /// <summary>
        ///     MotoCopyRiskExit
        /// </summary>
        public void MotoCopyRiskExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = this.map.UIInsurEtamWindow1.UINoWindow.UINoButton;
            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

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

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = this.map.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinButton uIOKButton1 = this.map.UIProductSelectionWindow.UIOKWindow.UIOKButton;

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

            WinButton uIExitButton = this.map.UIQuoteResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

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

            WinControl uIOKButton = this.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinControl uIOKButton1 = this.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit2 = this.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = this.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinEdit uIItemEdit3 = this.map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;

            #endregion

            Mouse.Click(uIOKButton, new Point(44, 12));

            uIItemComboBox.SelectedItem = this.QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = this.QuoteResultsParams.JobSector;

            uIItemEdit.Text = this.QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(38, 4));

            //insert standard lookup here
            //uIItemEdit1.Text = this.QuoteResultsParams.UIItemEditText1;

            //Mouse.Click(uIFilterButton, new Point(59, 14));
            this.VehicleLookup();

            uIItemEdit2.Text = this.QuoteResultsParams.VehicleCost;

            uIItemEdit3.Text = this.QuoteResultsParams.CarRegFordFiesta;

            Mouse.Click(uICalculateQuoteButton, new Point(25, 13));
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

        public void VehicleLookup()
        {
            #region Variable Declarations

            WinRadioButton uIStandardLookupRadioButton = this.UIVehicleLookupWindow.UIStandardLookupWindow.UIRadioButton("Standard Lookup:");
            WinComboBox uIItemComboBox = this.UIVehicleLookupWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.UIVehicleLookupWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIVehicleLookupWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIVehicleLookupWindow.UIItemWindow4.UIItemEdit;
            WinComboBox uIItemComboBox2 = this.UIVehicleLookupWindow.UIItemWindow5.UIItemComboBox;
            WinComboBox uIItemComboBox3 = this.UIVehicleLookupWindow.UIItemWindow6.UIItemComboBox;
            WinButton uIFilterButton = this.UIVehicleLookupWindow.UIFilterWindow.UIFilterButton;
            WinButton uIOKButton = this.UIVehicleLookupWindow.UIOKWindow.UIOKButton;

            #endregion

            uIStandardLookupRadioButton.Selected = this.VehicleLookupParams.StandardLookupRadioButton;
            uIItemComboBox.EditableItem = this.VehicleLookupParams.CarMake;
            uIItemComboBox1.EditableItem = this.VehicleLookupParams.CarModel;
            uIItemEdit.Text = this.VehicleLookupParams.EngineCapacity;
            uIItemEdit1.Text = this.VehicleLookupParams.Doors;
            uIItemEdit2.Text = this.VehicleLookupParams.YearBuilt;
            uIItemComboBox2.SelectedItem = this.VehicleLookupParams.FuelType;
            uIItemComboBox3.SelectedItem = this.VehicleLookupParams.TransmissionType;
            Mouse.Click(uIFilterButton, new Point(29, 16));
            Mouse.Click(uIOKButton, new Point(17, 7));
        }

        public void MotoFinishQuote()
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

            this.SelectTamInsurersAndActivity(selectListItems1:2);
        }
    }
}