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
            HtmlHyperlink uICreateaMotorTestReneHyperlink =
                map.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uiInsurerIdComboBox = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            HtmlEdit uITxtPremiumEdit = UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPremiumEdit;
            BrowserWindow uIInsurEcomSystemMaintWindow = map.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;

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
            WinButton uIawapButton = map.UIQuoteResultsWindow.UIAWAPWindow.UIAWAPButton;
            WinComboBox uIItemComboBox = map.UIAcceptWithAnotherProWindow.UIItemWindow.UIItemComboBox;
            WinEdit uIItemEdit = map.UIAcceptWithAnotherProWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIAcceptWithAnotherProWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIAcceptWithAnotherProWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIAcceptWithAnotherProWindow.UIItemWindow4.UIItemEdit;
            WinButton uIOKButton = map.UIAcceptWithAnotherProWindow.UIOKWindow.UIOKButton;

            WinButton uIOKButton3 = map.UITransactiontoinsertWindow.UIItemWindow.UIClient().UIOKButton;

            Mouse.Click(uIawapButton, new Point(50, 14));

            uIItemComboBox.SelectedIndex = 0;

            uIItemEdit.Text = MotoAWAPParams.ProductDescription;

            uIItemEdit1.Text = MotoAWAPParams.PolicyNumber;

            uIItemEdit2.Text = revisedPremium;

            uIItemEdit3.Text = MotoAWAPParams.VolExcess;

            Mouse.Click(uIOKButton, new Point(49, 9));

            PaymentMethod("cash");

            ImportToTam();

            Mouse.Click(uIOKButton3, new Point(56, 6));

            SelectTAMActivities1();
        }

        public void MotoAmendRiskRenew()
        {

 
            
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;


   RenewPolicy();

            ConfirmDocuments();

            RetrieveResponse();

DeferPrinting();

            EtamOk();

            ImportToTam();
            SelectTAMActivities3();

            Mouse.Click(uIExitButton, new Point(48, 12));

            EtamYes();
        }

        public void MotoAmendRiskNew1()
        {
            
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;

DeferPrinting();

            EtamOk();

            ImportToTam();

            SelectTAMActivities2();

            map.EtamOk();

            Mouse.Click(uIExitButton, new Point(47, 18));

            EtamYes();
        }

        public void MotoCopyCheckProposer()
        {
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.Firstname, uIItemEdit.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.DateOfBirth, uIItemEdit1.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.Postcode, uIItemEdit2.Text);

            Assert.AreEqual(MotoCopyCheckProposerExpectedValues.AddressLine1, uIItemEdit3.Text);
        }

        public void MotoCopyCheckCar()
        {
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(MotoCopyCheckCarExpectedValues.VehicleReg, uIItemEdit.Text);

            Assert.AreEqual(MotoCopyCheckCarExpectedValues.VehicleCost, uIItemEdit1.Text);
        }

        public void MotoCloseDetails()
        {
            WinButton uICancelButton = map.UIPolicyautotestWindow.UIBillingScreenWindow.UICancelWindow.UICancelButton;

            Mouse.Click(uICancelButton, new Point(32, 12));
        }

        public void MotoCheckPolicyStatus()
        {
            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindow1.UIItemEdit;

            Assert.AreEqual(MotoCheckPolicyStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        public void MotoCheckChangedPremium(string overridePremium)
        {
            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            Mouse.Click(uIItemEdit);
            Assert.AreEqual(overridePremium, uIItemEdit.Text);
        }

        public void MotoCheckAWAPpremium(string expectedPremium)
        {
            WinEdit uIItemEdit = map.UIPolicyautotestWindow.UIBillingScreenWindow.UIItemWindowCashBilling.UIItemEdit;

            Assert.AreEqual(expectedPremium, uIItemEdit.Text);
        }

        public void MotoCancelPolicy1()
        {
            WinButton uIOKButton = map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = map.UIClaimsWindow.UINoWindow.UINoButton;

            Mouse.Click(uIOKButton, new Point(39, 9));

            Mouse.Click(uINOButton, new Point(22, 18));
        }

        public void MotoCancelPolicy()
        {
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            uIItemComboBox.SelectedItem = CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton, new Point(34, 12));

            Mouse.Click(uICalculateQuoteButton, new Point(67, 12));
        }

        public void MotoCalculate()
        {
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uICalculateQuoteButton, new Point(69, 13));
        }

        public void MotoAmendRiskNew(string paymentMethod)
        {
            this.RenewPolicy();

            PaymentMethod(paymentMethod);

            CancelPrint();

            ConfirmDocuments();
        }

        private void RenewPolicy()
        {
            WinButton uIRenewPolicyButton = this.map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;

            Mouse.Click(uIRenewPolicyButton, new Point(51, 9));

            Mouse.Click(uIYesButton, new Point(60, 14));
        }

        public void MotoAmendRisk()
        {
            WinButton uIAmendRiskButton = map.Uiautoxxx1000Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = map.UIAmendRiskWindow.UIItemWindow.UIItemEdit;
            WinButton uIProposerDetailsButton = map.UIAmendRiskWindow.UIProposerDetailsWindow.UIProposerDetailsButton;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = map.UIAmendRiskWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;

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
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();

            Mouse.DoubleClick(uIQuoteResultsClient);

            Mouse.Click(uIQuoteResultsClient, new Point(30, 30));

            Mouse.Move(new Point(500, 500));
        }

        public void MotoSearchCar()
        {
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
            WinClient uIItemClient = map.UIRebrokeResultsScreenWindow.UIItemWindow1.UIClient();

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
            WinButton uIOKButton = map.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;


            Mouse.Click(uIOKButton, new Point(50, 10));

            try
            {
                ImportToTamOptionsOnce("");
                WriteToReport("MotoRebrokeCurrent line 583: " + TestContext.TestName);
            }
            catch
            {
            }

            if (withYesButton)
            {
                EtamYes();
            }
        }

        /// <summary>
        ///     MotoRebroke
        /// </summary>
        /// <param name="withCancel"></param>
        /// <param name="withConfim"></param>
        public void MotoRebroke(bool withCancel, bool withConfim)
        {
            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;
            WinButton uIRebrokeButton = map.Uiautoxxx1000Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton = UIConfirmWindow.UIOKWindow.UIOKButton;

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
            WinButton uIOKButton = map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = map.UISearchResultForBN16BWindow.UIOKWindow.UIOKButton;

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
            WinButton uIOKButton = map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = map.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;

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
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOptionsButton, new Point(33, 12));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(116, 15));

            Mouse.Click(uIOKButton, new Point(29, 10));
        }

        /// <summary>
        ///     MotoMTANoSave - Use 'MotoMTANoSaveParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTANoSave()
        {
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;

            WinButton uIOKButton1 = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton, new Point(42, 16));

            Mouse.Click(uIExitButton, new Point(70, 10));

           EtamYes();

            Mouse.Click(uIOKButton1, new Point(39, 15));
        }

        /// <summary>
        ///     MotoMTAMessageCancelled - Use 'MotoMTAMessageCancelledExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageCancelled()
        {
            WinText uImtAsuccessfullyproceText = map.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            StringAssert.Contains(uImtAsuccessfullyproceText.DisplayText, MotoMTAMessageCancelledExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAMessageAfterDate - Use 'MotoMTAMessageAfterDateExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTAMessageAfterDate()
        {
            WinText uIAdjustmentdatetimecaText = map.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIAdjustmentdatetimecaText;

            // Verify that the 'DisplayText' property of 'Adjustment date/time cannot be after the policy ef...' label contains 'Adjustment date/time cannot be after the policy effective end date/time'
            StringAssert.Contains(uIAdjustmentdatetimecaText.DisplayText, MotoMTAMessageAfterDateExpectedValues.UIAdjustmentdatetimecaTextDisplayText);
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy_1
        /// </summary>
        public void MotoMTAConfirmPolicy1()
        {
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIOKButton, new Point(37, 25));
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy - Use 'MotoMTAConfirmPolicyParams' to pass parameters into this method.
        /// </summary>
        /// <param name="action"></param>
        public void MotoMTAConfirmPolicy(string action)
        {
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            
            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(54, 8));

           EtamYes();

            ConfirmDocuments();

            EtamOk();

            DeferPrinting();

            ImportToTam();

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
            WinButton uIOKButton = map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton, new Point(21, 17));
        }

  
        public void MotoMTACheckNewValue(bool needScreenshot, string expectedDate = "")
        {
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(MotoMTACheckNewValueExpectedValues.UIItemEditText, uIItemEdit.Text);

            if (needScreenshot)
            {
                CreateScreenshot(expectedDate);
            }
        }

        public void MotoMTACheckCar()
        {
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;

            Assert.AreEqual(MotoMTACheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            Assert.AreEqual(MotoMTACheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoMTABeforeFinish - Use 'MotoMTABeforeFinishParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeFinish()
        {
            WinButton uIOKButton = map.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton, new Point(28, 8));

            DeferPrinting();

            ImportToTam();

            SelectTamInsurersAndActivity(selectListItems1: 0, selectListItems2: 0);
        }

        /// <summary>
        ///     MotoMTABeforeAccept - Use 'MotoMTABeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeAccept()
        {
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
          
            
            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton, new Point(56, 12));

            EtamYes();

            ConfirmDocuments();

            EtamOk();
        }

        /// <summary>
        ///     MotoMTABefore2 - Use 'MotoMTABefore2Params' to pass parameters into this method.
        /// </summary>
        public void MotoMTABefore2()
        {
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
             WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uIOKButton, new Point(44, 11));

            EtamYes();

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
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIBeforeButton = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

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
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton, new Point(28, 12));

            uIItemEdit.Text = MotoMTAParams.CostOfVehicle;

            Mouse.Click(uICalculateQuoteButton, new Point(68, 4));
        }


        public void MotoMTA()
        {
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;

            Mouse.Click(uIOptionsButton, new Point(37, 10));

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(80, 15));

            Mouse.Click(uIOKButton, new Point(41, 10));

            Mouse.Click(uIMTAButton, new Point(67, 11));
        }

 
        public void MotoInceptionDate()
        {
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow13.UIItemEdit;

            uIItemEdit.Text = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
        }

        public void MotoFinishMTA()
        {
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
  
            WinClient uIPointOfSaleClient = map.UIPointOfSaleWindow.UIPointOfSaleClient;

            MotoSelectHighwayPolicy();

            Mouse.Click(uIAcceptButton, new Point(51, 11));

           EtamYes();

            ConfirmDocuments();

            EtamOk();

            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            DeferPrinting();

            ImportToTam();

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        /// <summary>
        ///     MotoExitMTA
        /// </summary>
        public void MotoExitMTA()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton, new Point(51, 10));

           EtamYes();
            Mouse.Click(uIOKButton, new Point(55, 12));
        }

        /// <summary>
        ///     MotoCopyRiskProposerOk
        /// </summary>
        public void MotoCopyRiskProposerOk()
        {
            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton, new Point(44, 7));
        }

        /// <summary>
        ///     MotoCopyRiskExit
        /// </summary>
        public void MotoCopyRiskExit()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = map.UIInsurEtamWindow1.UINoWindow.UINoButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton, new Point(66, 10));

            Mouse.Click(uINOButton, new Point(47, 10));

            Mouse.Click(uIOKButton, new Point(34, 11));
        }

        /// <summary>
        ///     MotoCopyFinishedRisk
        /// </summary>
        public void MotoCopyFinishedRisk()
        {
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = map.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinButton uIOKButton1 = map.UIProductSelectionWindow.UIOKWindow.UIOKButton;

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
            WinButton uIExitButton = map.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton, new Point(59, 16));
            EtamYes();

            Mouse.Click(uIOKButton, new Point(53, 10));
        }

        /// <summary>
        ///     QuoteResults - Use 'QuoteResultsParams' to pass parameters into this method.
        /// </summary>
        public void QuoteResults()
        {
            WinControl uIOKButton = UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinControl uIOKButton1 = UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit2 = UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinControl uICalculateQuoteButton = UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinEdit uIItemEdit3 = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;

            Mouse.Click(uIOKButton, new Point(44, 12));

            uIItemComboBox.SelectedItem = QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = QuoteResultsParams.JobSector;

            uIItemEdit.Text = QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(38, 4));

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
            WinControl uINOButton = UICreditCheckWindow.UINoWindow.UINoButton;

            Mouse.Click(uINOButton, new Point(28, 10));
        }

        public void VehicleLookup()
        {
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
            //Playback.Wait(2000);

            DeferPrinting();

            ImportToTam();

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
            WinEdit uIItemEdit = UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;
            WinEdit uIItemEdit1 = UIProposerDetailsWindow.UIItemWindow5.UIItemEdit;

            Assert.AreEqual(expectedAddress.AddressLine1, uIItemEdit.Text);

            Assert.AreEqual(expectedAddress.AddressLine2, uIItemEdit1.Text);
        }
    }
}