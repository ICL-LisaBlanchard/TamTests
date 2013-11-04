namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Diagnostics;
    using System.Drawing;
    using System.Threading;
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

            Mouse.Click(uICreateRecordButton);

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

            Mouse.Click(uIawapButton);

            uIItemComboBox.SelectedIndex = 0;

            uIItemEdit.Text = MotoAWAPParams.ProductDescription;

            uIItemEdit1.Text = MotoAWAPParams.PolicyNumber;

            uIItemEdit2.Text = revisedPremium;

            uIItemEdit3.Text = MotoAWAPParams.VolExcess;

            Mouse.Click(uIOKButton);

            PaymentMethod("cash");

            ImportToTam();

            Mouse.Click(uIOKButton3, new Point(56, 6));

            SelectTAMActivities1();
        }

        public void MotoAmendRiskRenew()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;

            RenewPolicy();

            try
            {
                //PaymentMethod("cash");
                Mouse.Click(uIYesButton);
            }
            catch
            {
            }

            ConfirmDocuments();

            this.ContinueToRetrieveResponse();

            DeferPrinting();

            this.EtamOk(true);

            ImportToTam();
            SelectTAMActivities3();

            Mouse.Click(uIExitButton);

            EtamYes();
        }

        public void MotoAmendRiskNew1()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow1.UIExitButton;

            DeferPrinting();

            this.EtamOk(true);

            ImportToTam();

            SelectTAMActivities2();

            map.EtamOk(true);

            Mouse.Click(uIExitButton);

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

            Mouse.Click(uICancelButton);
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

            Mouse.Click(uIItemEdit);
            Assert.AreEqual(expectedPremium, uIItemEdit.Text);
        }

        public void MotoCancelPolicy1()
        {
            WinButton uIOKButton = map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = map.UIClaimsWindow.UINoWindow.UINoButton;

            Mouse.Click(uIOKButton);

            Mouse.Click(uINOButton);
        }

        public void MotoCancelPolicy()
        {
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            uIItemComboBox.SelectedItem = CancelPolicyParams.UIItemComboBoxSelectedItem;

            Mouse.Click(uIOKButton);

            Mouse.Click(uICalculateQuoteButton);
        }

        public void MotoCalculate()
        {
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void MotoAmendRiskNew(string paymentMethod)
        {
            this.RenewPolicy();

            //PaymentMethod(paymentMethod);

            CancelPrint();

            ConfirmDocuments();
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

            Mouse.Click(uIAmendRiskButton);

            uIItemEdit.Text = MotoAmendRiskParams.VehicleCostNew;

            Mouse.Click(uIProposerDetailsButton);

            uIItemEdit1.Text = MotoAmendRiskParams.SurnameNew;

            Mouse.Click(uIOKButton);

            Mouse.Click(uICalculateQuoteButton);

            Mouse.Click(uIProceedButton);
        }

        public void MotoSelectHighwayPolicy(bool firstChoice)
        {
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIPolicySummaryButton = this.UIQuoteResultsWindow.UIPolicySummaryWindow.UIPolicySummaryButton;
            WinButton uIOKButton = this.UIPersonalLinesDialogWindow.UIOKWindow.UIOKButton;

            Mouse.DoubleClick(uIQuoteResultsClient);

            Mouse.Click(uIQuoteResultsClient, new Point(30, 30));
            Playback.Wait(2000);
            Mouse.Move(new Point(500, 500));

            //if (firstChoice)
            //{
            //    for (int i = 25; i < 150; i = i + 18)
            //    {
            //        Mouse.Click(uIQuoteResultsClient, new Point(30, i));
            //        Playback.Wait(2000);
            //        Mouse.Move(new Point(500, 500));
            //        Mouse.Click(uIPolicySummaryButton);

            //        bool isTest = true;
            //        for (int j = 0; j < 5; j++)
            //        {
            //            Process[] pname = Process.GetProcessesByName("splwow64");

            //            if (pname.Length > 0)
            //            {
            //                isTest = false;
            //                break;
            //            }
            //            Thread.Sleep(1000);
            //        }

            //        if (isTest)
            //        {

            //            uIOKButton.WaitForControlExist(5000);
            //            Mouse.Click(uIOKButton);
            //        }
            //        else
            //        {
            //            BaseUiTest.CloseProcess("splwow64");
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Mouse.Click(uIQuoteResultsClient, new Point(30, 30));
            //    Playback.Wait(2000);
            //    Mouse.Move(new Point(500, 500));
            //}
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

            Mouse.Click(uIOKButton);

            uIItemComboBox.SelectedItem = QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = QuoteResultsParams.JobSector;

            uIItemEdit.Text = QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(45, 18));

            uIItemComboBox2.EditableItem = VehicleLookupParams.CarMake;

            uIItemComboBox3.EditableItem = VehicleLookupParams.CarModel;

            Mouse.Click(uIFilterButton);

            Mouse.Click(uIOKButton2, new Point(24, 10));

            uIItemEdit1.Text = QuoteResultsParams.CarRegFordFiesta;

            uIItemEdit2.Text = QuoteResultsParams.VehicleCost;
        }

        public void MotoRebrokeSelectScheme(string withSendKeys)
        {
            WinClient uIItemClient = map.UIRebrokeResultsScreenWindow.UIItemWindow1.UIClient();


            Mouse.Click(uIItemClient, new Point(271, 102));

            Keyboard.SendKeys(uIItemClient, withSendKeys, ModifierKeys.None);
        }

        public void MotoRebrokeCurrent(bool withYesButton)
        {
            WinButton uIOKButton = map.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton);

            try
            {
                ImportToTamOptionsOnce("");

            }
            catch
            {
            }

            if (withYesButton)
            {
                EtamYes();
            }
        }

        public void MotoRebroke(bool withCancel, bool withConfim)
        {
            WinButton uIProceedButton = this.UICreditCheckAtRenewalWindow.UIProceedWindow.UIProceedButton;
            WinButton uIRebrokeButton = map.Uiautoxxx1000Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton = UIConfirmWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIRebrokeButton);

            if (withCancel)
            {
                Mouse.Click(uICancelButton);
            }

            if (withConfim)
            {
                Mouse.Click(uIOKButton);
            }

            Mouse.Click(uIProceedButton);
        }

        public void MotoPostcodeLookup()
        {
            WinButton uIOKButton = map.UIProposerTypeWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = map.UIProposerDetailsWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit3 = map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinButton uILookupButton = map.UIProposerDetailsWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton1 = map.UISearchResultForBN16BWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton);

            uIItemEdit.Text = ProposerParams.Firstname;

            uIItemEdit1.Text = ProposerParams.Lastname;

            uIItemEdit2.Text = ProposerParams.DateOfBirth;

            uIItemEdit3.Text = ProposerParams.Postcode;

            Mouse.Click(uILookupButton);

            Mouse.Click(uIOKButton1, new Point(37, 9));
        }

        public void MotoMTAOpenQuote()
        {
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(116, 15));

            Mouse.Click(uIOKButton);
        }

        public void MotoMTANoSave()
        {
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;

            WinButton uIOKButton1 = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton);

            Mouse.Click(uIExitButton);

            EtamYes();

            Mouse.Click(uIOKButton1, new Point(39, 15));
        }

        public void MotoMTAMessageCancelled()
        {
            WinText uImtAsuccessfullyproceText = map.UIMTASuccessfulWindow.UIMtaSuccessfullyProcessedWindow.UIMtaSuccessfullyProcessedText;

            StringAssert.Contains(uImtAsuccessfullyproceText.DisplayText, MotoMTAMessageCancelledExpectedValues.UIMTAsuccessfullyproceTextDisplayText);
        }

        public void MotoMTAMessageAfterDate()
        {
            WinText uIAdjustmentdatetimecaText = map.UIInsurEtamWindow1.UIAcceptthisquoteNotOvWindow.UIAdjustmentdatetimecaText;

            StringAssert.Contains(uIAdjustmentdatetimecaText.DisplayText, MotoMTAMessageAfterDateExpectedValues.UIAdjustmentdatetimecaTextDisplayText);
        }

        public void MotoMTAConfirmPolicy1()
        {
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIOKButton);
        }

        public void MotoMTAConfirmPolicy(string action)
        {
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton);

            this.CancelTestNoPolicyDocsDialog();

            EtamYes();

            ConfirmDocuments();

            this.EtamOk(true);

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

            Mouse.Click(uIOKButton);
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

        public void MotoMTABeforeFinish()
        {
            WinButton uIOKButton = map.UIMTASuccessfulWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton);

            DeferPrinting();

            ImportToTam();

            SelectTamInsurersAndActivity(selectListItems1: 0, selectListItems2: 0);
        }

        public void MotoMTABeforeAccept()
        {
            WinClient uIQuoteResultsClient = map.UIQuoteResultsWindow.UIItemWindow2.UIClient();
            WinButton uIAcceptButton = map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;

            Mouse.Click(uIQuoteResultsClient, new Point(10, 10));

            Keyboard.SendKeys(uIQuoteResultsClient, CommonParams.SendHomeKeys, ModifierKeys.None);

            Mouse.Click(uIAcceptButton);

            this.CancelTestNoPolicyDocsDialog();

            EtamYes();

            ConfirmDocuments();

            this.EtamOk(true);
        }

        public void MotoMTABefore2()
        {
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uIOKButton);

            EtamYes();

            Mouse.Click(uIMTAButton);

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(36, 16));

            uIItemEdit.Text = MotoMTAParams.VehicleRegistration1;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void MotoMTABefore()
        {
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIBeforeButton = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIBeforeButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UICarRegistrationWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            Mouse.Click(uIOKButton);

            Mouse.Click(uIBeforeButton);

            Mouse.Click(uIMTAButton);

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton1, new Point(44, 21));

            uIItemEdit.Text = MotoMTAParams.VehicleRegistration2;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void MotoMTAAccept()
        {
            WinComboBox uIItemComboBox = map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = map.UIInsurEtamWindow.UIQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = map.UIInsurEtamWindow.UIQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            uIItemComboBox.SelectedItem = MotoMTAParams.UIChangeOfVehicle;

            Mouse.Click(uIOKButton);

            uIItemEdit.Text = MotoMTAParams.CostOfVehicle;

            Mouse.Click(uICalculateQuoteButton);
        }

        public void MotoMTA()
        {
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = map.UIInsurEtamWindow.UIQuotesWindow.UIMTAWindow.UIMTAButton;

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uIQuoteSelectListMenuItem, new Point(80, 15));

            Mouse.Click(uIOKButton);

            Mouse.Click(uIMTAButton);
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

            this.MotoSelectHighwayPolicy(false);

            Mouse.Click(uIAcceptButton);

            this.CancelTestNoPolicyDocsDialog();

            EtamYes();

            ConfirmDocuments();

            this.EtamOk(true);

            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            DeferPrinting();

            ImportToTam();

            SelectTamInsurersAndActivity(selectListItems1: 1, selectListItems2: 1);
        }

        public void MotoExitMTA()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton);

            EtamYes();
            Mouse.Click(uIOKButton);
        }

        public void MotoCopyRiskProposerOk()
        {
            WinButton uIOKButton = map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOKButton);
        }

        public void MotoCopyRiskExit()
        {
            WinButton uIExitButton = map.UIInsurEtamWindow.UIQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = map.UIInsurEtamWindow1.UINoWindow.UINoButton;
            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton);

            Mouse.Click(uINOButton);

            Mouse.Click(uIOKButton);
        }

        public void MotoCopyFinishedRisk()
        {
            WinButton uIOptionsButton = map.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem = map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegratMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = map.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient().UIOKButton;
            WinButton uIOKButton1 = map.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            Mouse.Click(uIOptionsButton);

            Mouse.Click(uICopyRiskMenuItem, new Point(79, 13));

            Mouse.Click(uIOKButton);

            Mouse.Click(uIOKButton1, new Point(31, 15));
        }

        /// <summary>
        ///     MotoCancelExit
        /// </summary>
        public void MotoCancelExit()
        {
            WinButton uIExitButton = map.UIQuoteResultsWindow.UIExitWindow.UIExitButton;

            WinButton uIOKButton = map.UITamxml7Window.UITamxml7Client.UIOKButton;

            Mouse.Click(uIExitButton);
            EtamYes();

            Mouse.Click(uIOKButton);
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

            Mouse.Click(uIOKButton);

            uIItemComboBox.SelectedItem = QuoteResultsParams.JobTitle;

            uIItemComboBox1.SelectedItem = QuoteResultsParams.JobSector;

            uIItemEdit.Text = QuoteResultsParams.LicenceDate;

            Mouse.Click(uIOKButton1, new Point(38, 4));

            VehicleLookup();

            uIItemEdit2.Text = QuoteResultsParams.VehicleCost;

            uIItemEdit3.Text = QuoteResultsParams.CarRegFordFiesta;

            Mouse.Click(uICalculateQuoteButton);
        }

        /// <summary>
        ///     QuoteResults_1
        /// </summary>
        public void QuoteResults1()
        {
            WinControl uINOButton = UICreditCheckWindow.UINoWindow.UINoButton;

            Mouse.Click(uINOButton);
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
            Mouse.Click(uIFilterButton);
            Mouse.Click(uIOKButton);
        }

        public void MotoFinishQuote(int importToTam)
        {
            DeferPrinting();

            ImportToTam();

            switch (importToTam)
            {
                case 2: 
                    SelectTAMActivities2();
                    break;
                case 3: 
                    SelectTAMActivities3();
                    break;
                default:
                    SelectTAMActivities3();
                    break;
            }
        }

        public void CreateMTA()
        {
            MotoMTA();
            MotoMTAAccept();
            MotoMTAConfirmDate();
            MotoMTAConfirmPolicy("mta");
        }

        public void AcceptAndFinishQuote(string paymentType, int importToTam)
        {
            AcceptQuote();
            this.FinishQuote(paymentType);
            CancelPrint();
            this.MotoFinishQuote(importToTam);
        }

        public void CreateNewBusinessPolicy(ExpectedAddress expectedAddress)
        {
            MotoPostcodeLookup();
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

        private void RenewPolicy()
        {
            WinButton uIRenewPolicyButton = this.map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;

            Mouse.Click(uIRenewPolicyButton);

            Mouse.Click(uIYesButton);

            this.CancelTestNoPolicyDocsDialog();
        }
    }
}