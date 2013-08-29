namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Drawing;
    using System.Windows.Input;

    using AppliedSystems.Tam.Ui.Tests.Params;
    using AppliedSystems.Tam.Ui.Tests.UIElements;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    internal class MotoActions : UIMap
    {
        private readonly UIMap map = new UIMap();

        private MotoAWAPParams mMotoAwapParams;

        private MotoAmendRiskRenewParams mMotoAmendRiskRenewParams;

        private MotoAmendRiskNew_1Params mMotoAmendRiskNew1Params;

        private MotoCopyCheckProposerExpectedValues mMotoCopyCheckProposerExpectedValues;

        private MotoCopyCheckCarExpectedValues mMotoCopyCheckCarExpectedValues;

        private MotoCheckPolicyStatusExpectedValues mMotoCheckPolicyStatusExpectedValues;

        private MotoCheckChangedPremiumExpectedValues mMotoCheckChangedPremiumExpectedValues;

        private MotoCheckAWAPpremiumExpectedValues mMotoCheckAWAPpremiumExpectedValues;

        private MotoCancelPolicyParams mMotoCancelPolicyParams;

        private MotoAWAPCheckTAXExpectedValues mMotoAWAPCheckTAXExpectedValues;

        private MotoAWAPCheckNEWExpectedValues mMotoAWAPCheckNEWExpectedValues;

        private MotoAmendRiskParams mMotoAmendRiskParams;

        private MotoSelectHighwayPolicyParams mMotoSelectHighwayPolicyParams;

        private MotoSearchCarParams mMotoSearchCarParams;

        private MotoRenewalCheckRecordExpectedValues mMotoRenewalCheckRecordExpectedValues;

        private MotoRegressAppParams mMotoRegressAppParams;

        private MotoRebrokeSelectSchemeParams mMotoRebrokeSelectSchemeParams;

        private MotoPostcodeLookupParams mMotoPostcodeLookupParams;

        private MotoPolicyPersonParams mMotoPolicyPersonParams;

        private MotoMTANoSaveParams mMotoMTANoSaveParams;

        private MotoMTAMessageCancelledExpectedValues mMotoMTAMessageCancelledExpectedValues;

        private MotoMTAMessageAfterDateExpectedValues mMotoMTAMessageAfterDateExpectedValues;

        private MotoMTAConfirmPolicyParams mMotoMTAConfirmPolicyParams;

        private MotoMTACheckNewValueExpectedValues mMotoMTACheckNewValueExpectedValues;

        private MotoMTACheckCarExpectedValues mMotoMTACheckCarExpectedValues;

        private MotoMTABeforeFinishParams mMotoMTABeforeFinishParams;

        private MotoMTABeforeAcceptParams mMotoMTABeforeAcceptParams;

        private MotoMTABefore2Params mMotoMTABefore2Params;

        private MotoMTABeforeParams mMotoMTABeforeParams;

        private MotoMTAAcceptParams mMotoMTAAcceptParams;

        private MotoInceptionDateParams mMotoInceptionDateParams;

        private MotoFinishMTAParams mMotoFinishMTAParams;

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

        public virtual MotoAmendRiskRenewParams MotoAmendRiskRenewParams
        {
            get
            {
                if ((this.mMotoAmendRiskRenewParams == null))
                {
                    this.mMotoAmendRiskRenewParams = new MotoAmendRiskRenewParams();
                }
                return this.mMotoAmendRiskRenewParams;
            }
        }

        public virtual MotoAmendRiskNew_1Params MotoAmendRiskNew1Params
        {
            get
            {
                if ((this.mMotoAmendRiskNew1Params == null))
                {
                    this.mMotoAmendRiskNew1Params = new MotoAmendRiskNew_1Params();
                }
                return this.mMotoAmendRiskNew1Params;
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

        public virtual MotoCancelPolicyParams MotoCancelPolicyParams
        {
            get
            {
                if ((this.mMotoCancelPolicyParams == null))
                {
                    this.mMotoCancelPolicyParams = new MotoCancelPolicyParams();
                }
                return this.mMotoCancelPolicyParams;
            }
        }

        public virtual MotoAWAPCheckTAXExpectedValues MotoAWAPCheckTAXExpectedValues
        {
            get
            {
                if ((this.mMotoAWAPCheckTAXExpectedValues == null))
                {
                    this.mMotoAWAPCheckTAXExpectedValues = new MotoAWAPCheckTAXExpectedValues();
                }
                return this.mMotoAWAPCheckTAXExpectedValues;
            }
        }

        public virtual MotoAWAPCheckNEWExpectedValues MotoAWAPCheckNEWExpectedValues
        {
            get
            {
                if ((this.mMotoAWAPCheckNEWExpectedValues == null))
                {
                    this.mMotoAWAPCheckNEWExpectedValues = new MotoAWAPCheckNEWExpectedValues();
                }
                return this.mMotoAWAPCheckNEWExpectedValues;
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

        public virtual MotoSelectHighwayPolicyParams MotoSelectHighwayPolicyParams
        {
            get
            {
                if ((this.mMotoSelectHighwayPolicyParams == null))
                {
                    this.mMotoSelectHighwayPolicyParams = new MotoSelectHighwayPolicyParams();
                }
                return this.mMotoSelectHighwayPolicyParams;
            }
        }

        public virtual MotoSearchCarParams MotoSearchCarParams
        {
            get
            {
                if ((this.mMotoSearchCarParams == null))
                {
                    this.mMotoSearchCarParams = new MotoSearchCarParams();
                }
                return this.mMotoSearchCarParams;
            }
        }

        public virtual MotoRenewalCheckRecordExpectedValues MotoRenewalCheckRecordExpectedValues
        {
            get
            {
                if ((this.mMotoRenewalCheckRecordExpectedValues == null))
                {
                    this.mMotoRenewalCheckRecordExpectedValues = new MotoRenewalCheckRecordExpectedValues();
                }
                return this.mMotoRenewalCheckRecordExpectedValues;
            }
        }

        public virtual MotoRegressAppParams MotoRegressAppParams
        {
            get
            {
                if ((this.mMotoRegressAppParams == null))
                {
                    this.mMotoRegressAppParams = new MotoRegressAppParams();
                }
                return this.mMotoRegressAppParams;
            }
        }

        public virtual MotoRebrokeSelectSchemeParams MotoRebrokeSelectSchemeParams
        {
            get
            {
                if ((this.mMotoRebrokeSelectSchemeParams == null))
                {
                    this.mMotoRebrokeSelectSchemeParams = new MotoRebrokeSelectSchemeParams();
                }
                return this.mMotoRebrokeSelectSchemeParams;
            }
        }

        public virtual MotoPostcodeLookupParams MotoPostcodeLookupParams
        {
            get
            {
                if ((this.mMotoPostcodeLookupParams == null))
                {
                    this.mMotoPostcodeLookupParams = new MotoPostcodeLookupParams();
                }
                return this.mMotoPostcodeLookupParams;
            }
        }

        public virtual MotoPolicyPersonParams MotoPolicyPersonParams
        {
            get
            {
                if ((this.mMotoPolicyPersonParams == null))
                {
                    this.mMotoPolicyPersonParams = new MotoPolicyPersonParams();
                }
                return this.mMotoPolicyPersonParams;
            }
        }

        public virtual MotoMTANoSaveParams MotoMTANoSaveParams
        {
            get
            {
                if ((this.mMotoMTANoSaveParams == null))
                {
                    this.mMotoMTANoSaveParams = new MotoMTANoSaveParams();
                }
                return this.mMotoMTANoSaveParams;
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

        public virtual MotoMTAConfirmPolicyParams MotoMTAConfirmPolicyParams
        {
            get
            {
                if ((this.mMotoMTAConfirmPolicyParams == null))
                {
                    this.mMotoMTAConfirmPolicyParams = new MotoMTAConfirmPolicyParams();
                }
                return this.mMotoMTAConfirmPolicyParams;
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

        public virtual MotoMTABeforeFinishParams MotoMTABeforeFinishParams
        {
            get
            {
                if ((this.mMotoMTABeforeFinishParams == null))
                {
                    this.mMotoMTABeforeFinishParams = new MotoMTABeforeFinishParams();
                }
                return this.mMotoMTABeforeFinishParams;
            }
        }

        public virtual MotoMTABeforeAcceptParams MotoMTABeforeAcceptParams
        {
            get
            {
                if ((this.mMotoMTABeforeAcceptParams == null))
                {
                    this.mMotoMTABeforeAcceptParams = new MotoMTABeforeAcceptParams();
                }
                return this.mMotoMTABeforeAcceptParams;
            }
        }

        public virtual MotoMTABefore2Params MotoMTABefore2Params
        {
            get
            {
                if ((this.mMotoMTABefore2Params == null))
                {
                    this.mMotoMTABefore2Params = new MotoMTABefore2Params();
                }
                return this.mMotoMTABefore2Params;
            }
        }

        public virtual MotoMTABeforeParams MotoMTABeforeParams
        {
            get
            {
                if ((this.mMotoMTABeforeParams == null))
                {
                    this.mMotoMTABeforeParams = new MotoMTABeforeParams();
                }
                return this.mMotoMTABeforeParams;
            }
        }

        public virtual MotoMTAAcceptParams MotoMTAAcceptParams
        {
            get
            {
                if ((this.mMotoMTAAcceptParams == null))
                {
                    this.mMotoMTAAcceptParams = new MotoMTAAcceptParams();
                }
                return this.mMotoMTAAcceptParams;
            }
        }

        public virtual MotoInceptionDateParams MotoInceptionDateParams
        {
            get
            {
                if ((this.mMotoInceptionDateParams == null))
                {
                    this.mMotoInceptionDateParams = new MotoInceptionDateParams();
                }
                return this.mMotoInceptionDateParams;
            }
        }

        public virtual MotoFinishMTAParams MotoFinishMTAParams
        {
            get
            {
                if ((this.mMotoFinishMTAParams == null))
                {
                    this.mMotoFinishMTAParams = new MotoFinishMTAParams();
                }
                return this.mMotoFinishMTAParams;
            }
        }

        /// <summary>
        ///     MotoGetPolicyNumber
        /// </summary>
        public string MotoGetPolicyNumber()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Click 'Unknown Name' text box
            return uIItemEdit.GetProperty("Text").ToString();
        }

        /// <summary>
        ///     MotoCreateSiteRenewal - Use 'MotoCreateSiteRenewalParams' to pass parameters into this method.
        /// </summary>
        public void MotoCreateSiteRenewal()
        {
            #region Variable Declarations

            HtmlHyperlink uICreateaMotorTestReneHyperlink =
                this.map.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument1.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uiInsurerIdComboBox = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.map.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = this.map.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;

            #endregion

            // Click 'Create a Motor Test Renewal Invitation' link
            Mouse.Click(uICreateaMotorTestReneHyperlink, new Point(50, 22));

            // Select 'Highway Insurance' in 'InsurerID' combo box
            uiInsurerIdComboBox.SelectedItem = this.map.MotoCreateSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            // Type '7071000841' in 'txtPolicyNumber' text box
            uITxtPolicyNumberEdit.Text = this.map.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText;

            // Type '12/11/2012' in 'txtAutoLapseDate' text box
            uITxtAutoLapseDateEdit1.Text = uITxtRenewalDateEdit.GetProperty("Text").ToString();

            // Click 'Create Record' button
            Mouse.Click(uICreateRecordButton, new Point(112, 11));

            // Click 'Ok' button in the browser dialog window
            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
        }

        /// <summary>
        ///     MotoAWAP - Use 'MotoAWAPParams' to pass parameters into this method.
        /// </summary>
        public void MotoAwap()
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
            WinButton uIOKButton3 = this.map.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinButton uIOKButton4 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&AWAP' button
            Mouse.Click(uIawapButton, new Point(50, 14));

            // Select 'AIG' in 'Unknown Name' combo box
            uIItemComboBox.SelectedItem = this.MotoAWAPParams.UIItemComboBoxSelectedItem;

            // Type 'test' in 'Unknown Name' text box
            uIItemEdit.Text = this.MotoAWAPParams.UIItemEditText;

            // Type '12345' in 'Unknown Name' text box
            uIItemEdit1.Text = this.MotoAWAPParams.UIItemEditText1;

            // Type '10000' in 'Unknown Name' text box
            uIItemEdit2.Text = this.MotoAWAPParams.UIItemEditText2;

            // Click 'Unknown Name' text box
            Mouse.Click(uIItemEdit3, new Point(31, 6));

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(49, 9));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(45, 11));

            // The recording for the application under test '\\Pc-pez\APPLIED\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAWAPParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(44, 7));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(56, 6));
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton3, new Point(56, 6));
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(47, 13));
        }

        /// <summary>
        ///     MotoAmendRiskRenew - Use 'MotoAmendRiskRenewParams' to pass parameters into this method.
        /// </summary>
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
            WinButton uIOKButton4 = this.map.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.map.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton5 = this.map.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinButton uIOKButton6 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton1 = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(53, 14));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(54, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(62, 10));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(42, 10));

            this.map.RetrieveResponse();

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoAmendRiskRenewParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(58, 18));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(48, 11));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAmendRiskRenewParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(54, 5));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(45, 10));

            // Select 'AG Administrator General' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MotoAmendRiskRenewParams.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton5, new Point(52, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton6, new Point(49, 16));

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(48, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton1, new Point(19, 10));
        }

        /// <summary>
        ///     MotoAmendRiskNew_1 - Use 'MotoAmendRiskNew_1Params' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRiskNew1()
        {
            #region Variable Declarations

            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.map.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.map.UITransactiontoinsertWindow.UIItemWindow.UIClient.UIOKButton;
            WinList uIItemList = this.map.UIPleaseSelectWhoToFolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.map.UIPleaseSelectWhoToFolWindow.UIItemWindow.UIClient.UIOKButton;
            WinButton uIOKButton5 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoAmendRiskNew1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(59, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(54, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(50, 20));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAmendRiskNew1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(47, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(55, 14));

            // Select 'AG Administrator General' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MotoAmendRiskNew1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(56, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(48, 12));

            this.map.EtamOk();

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(47, 18));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 7));
        }

        /// <summary>
        ///     MotoCopyCheckProposer - Use 'MotoCopyCheckProposerExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCopyCheckProposer()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIProposerDetailsWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.map.UIProposerDetailsWindow.UIItemWindow4.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'Test'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '16 Apr 1985'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText1, uIItemEdit1.Text);

            // Verify that the 'Text' property of text box equals 'B33 8TH'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText2, uIItemEdit2.Text);

            // Verify that the 'Text' property of text box equals '533 Yardley Green Road'
            Assert.AreEqual(this.MotoCopyCheckProposerExpectedValues.UIItemEditText3, uIItemEdit3.Text);
        }

        /// <summary>
        ///     MotoCopyCheckCar - Use 'MotoCopyCheckCarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCopyCheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'RF53OXL'
            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '1000'
            Assert.AreEqual(this.MotoCopyCheckCarExpectedValues.UIItemEditText1, uIItemEdit1.Text);
        }

        /// <summary>
        ///     MotoCloseDetails
        /// </summary>
        public void MotoCloseDetails()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.map.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UICancelWindow.UICancelButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(32, 12));
        }

        /// <summary>
        ///     MotoCloseAndOpenPolicyList
        /// </summary>
        public void MotoCloseAndOpenPolicyList()
        {
            #region Variable Declarations

            WinButton uICancelButton = this.map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.map.UICustomertxt1tdsfsWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.map.UICustomertxt1tdsfsWindow.UIPolicyListWindow.UIDetailWindow.UIDetailButton;

            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(31, 15));

            // Click button
            Mouse.Click(uIItemButton, new Point(27, 23));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(52, 11));
        }

        /// <summary>
        ///     MotoCheckPolicyStatus - Use 'MotoCheckPolicyStatusExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckPolicyStatus()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow1.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'NEW'
            Assert.AreEqual(this.MotoCheckPolicyStatusExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCheckChangedPremium - Use 'MotoCheckChangedPremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckChangedPremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '9433.96'
            Assert.AreEqual(this.MotoCheckChangedPremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCheckAWAPpremium - Use 'MotoCheckAWAPpremiumExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoCheckAWAPpremium()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIPolicyautotestWindow.UIBillingScreenMotoWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '10000.00'
            Assert.AreEqual(this.MotoCheckAWAPpremiumExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoCancelPolicy_1
        /// </summary>
        public void MotoCancelPolicy1()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;
            WinButton uINOButton = this.map.UIClaimsWindow.UINoWindow.UINoButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(39, 9));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(22, 18));
        }

        /// <summary>
        ///     MotoCancelPolicy - Use 'MotoCancelPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoCancelPolicy()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Select 'Cancel Cover' in combo box
            uIItemComboBox.SelectedItem = this.MotoCancelPolicyParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(34, 12));

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(67, 12));
        }

        /// <summary>
        ///     MotoCalculate
        /// </summary>
        public void MotoCalculate()
        {
            #region Variable Declarations

            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(69, 13));
        }

        /// <summary>
        ///     MotoAmendRiskNew
        /// </summary>
        public void MotoAmendRiskNew()
        {
            #region Variable Declarations

            WinButton uIRenewPolicyButton = this.map.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.map.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uICancelButton = this.map.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click '&Renew Policy' button
            Mouse.Click(uIRenewPolicyButton, new Point(51, 9));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(60, 14));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(62, 15));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(37, 9));
        }

        /// <summary>
        ///     MotoAmendRisk - Use 'MotoAmendRiskParams' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRisk()
        {
            #region Variable Declarations

            WinButton uIAmendRiskButton = this.map.UIAUTO2081001Window.UIAmendRiskWindow.UIAmendRiskButton;
            WinEdit uIItemEdit = this.map.UIAmendRiskWindow.UIItemWindow.UIItemEdit;
            WinButton uIProposerDetailsButton = this.map.UIAmendRiskWindow.UIProposerDetailsWindow.UIProposerDetailsButton;
            WinEdit uIItemEdit1 = this.map.UIProposerDetailsWindow.UIItemWindow.UIItemEdit;
            WinButton uIOKButton = this.map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinButton uICalculateQuoteButton = this.map.UIAmendRiskWindow.UICalculateQuoteWindow.UICalculateQuoteButton;
            WinButton uINOButton = this.map.UICreditCheckWindow.UINoWindow.UINoButton;
            WinButton uICancelButton = this.map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;

            #endregion

            // Click '&Amend Risk...' button
            Mouse.Click(uIAmendRiskButton, new Point(80, 11));

            // Type '1500' in text box
            uIItemEdit.Text = this.MotoAmendRiskParams.UIItemEditText;

            // Click '&Proposer Details...' button
            Mouse.Click(uIProposerDetailsButton, new Point(66, 12));

            // Type 'NewTest' in text box
            uIItemEdit1.Text = this.MotoAmendRiskParams.UIItemEditText1;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(50, 11));

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(58, 6));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(50, 0));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(14, 18));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     MotoSelectHighwayPolicy - Use 'MotoSelectHighwayPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoSelectHighwayPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient;

            #endregion

            // The recording for the application under test '\\ICLVDEVAP01\J-Drive\APPS\IEOffice\DATA\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(405, 217));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoSelectHighwayPolicyParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // The recording for the application under test '\\ICLVDEVAP01\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.
        }

        /// <summary>
        ///     MotoSearchCar - Use 'MotoSearchCarParams' to pass parameters into this method.
        /// </summary>
        public void MotoSearchCar()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIProposerDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox = this.map.UIDriverDetailsWindow.UIItemWindow.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.map.UIDriverDetailsWindow.UIItemWindow1.UIItemComboBox;
            WinEdit uIItemEdit = this.map.UIDriverDetailsWindow.UIItemWindow2.UIItemEdit;
            WinButton uIOKButton1 = this.map.UIDriverDetailsWindow.UIOKWindow.UIOKButton;
            WinComboBox uIItemComboBox2 = this.map.UIVehicleLookupWindow.UIItemWindow1.UIItemComboBox;
            WinComboBox uIItemComboBox3 = this.map.UIVehicleLookupWindow.UIItemWindow11.UIItemComboBox;
            WinButton uIFilterButton = this.map.UIVehicleLookupWindow.UIFilterWindow1.UIFilterButton;
            WinButton uIOKButton2 = this.map.UIVehicleLookupWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(40, 9));

            // Select 'Account Executive' in combo box
            uIItemComboBox.SelectedItem = this.MotoSearchCarParams.UIItemComboBoxSelectedItem;

            // Select 'Aerial Manufacturer' in combo box
            uIItemComboBox1.SelectedItem = this.MotoSearchCarParams.UIItemComboBoxSelectedItem1;

            // Type '151208' in text box
            uIItemEdit.Text = this.MotoSearchCarParams.UIItemEditText;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(45, 18));

            // Select 'FORD' in combo box
            uIItemComboBox2.EditableItem = this.MotoSearchCarParams.UIItemComboBoxEditableItem;

            // Select 'KA' in combo box
            uIItemComboBox3.EditableItem = this.MotoSearchCarParams.UIItemComboBoxEditableItem1;

            // Click '&Filter' button
            Mouse.Click(uIFilterButton, new Point(29, 9));

            // Click '&OK' button
            Mouse.Click(uIOKButton2, new Point(24, 10));

            // Type '123434' in text box
            uIItemEdit1.Text = this.MotoSearchCarParams.UIItemEditText1;

            // Type '1000' in text box
            uIItemEdit2.Text = this.MotoSearchCarParams.UIItemEditText2;
        }

        /// <summary>
        ///     MotoRenewalCheckRecord - Use 'MotoRenewalCheckRecordExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoRenewalCheckRecord()
        {
            #region Variable Declarations

            WinWindow uIauto1871001Window = this.map.UIAUTO1871001Window;

            #endregion

            // Verify that the 'Name' property of 'AUTO187-1001' window contains 'AUTO187'
            StringAssert.Contains(uIauto1871001Window.Name, this.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName);
        }

        /// <summary>
        ///     MotoRegressAppFinish
        /// </summary>
        public void MotoRegressAppFinish()
        {
            #region Variable Declarations

            WinButton uIRegressButton = this.map.UIRegressIETamPolicyWindow.UIRegressWindow.UIRegressButton;

            #endregion

            // Click 'Regress' button
            Mouse.Click(uIRegressButton, new Point(47, 22));
        }

        /// <summary>
        ///     MotoRegressApp - Use 'MotoRegressAppParams' to pass parameters into this method.
        /// </summary>
        public void MotoRegressApp()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIRegressIETamPolicyWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIRegressIETamPolicyWindow.UIItemWindow2.UIItemEdit;

            #endregion

            // Launch 'C:\TestProject7\Regress_IETam_Policy.exe'
            ApplicationUnderTest.Launch(this.MotoRegressAppParams.ExePath, this.MotoRegressAppParams.AlternateExePath);

            // Type 'AUTO182' in text box
            uIItemEdit.Text = this.MotoRegressAppParams.UIItemEditText;

            // Type '-1001' in text box
            uIItemEdit1.Text = this.MotoRegressAppParams.UIItemEditText1;
        }

        /// <summary>
        ///     MotoRebrokeSelectScheme - Use 'MotoRebrokeSelectSchemeParams' to pass parameters into this method.
        /// </summary>
        public void MotoRebrokeSelectScheme()
        {
            #region Variable Declarations

            WinClient uIItemClient = this.map.UIRebrokeResultsScreenWindow.UIItemWindow1.UIClient;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click client
            Mouse.Click(uIItemClient, new Point(271, 102));

            // Type '{Home}' in client
            Keyboard.SendKeys(uIItemClient, this.MotoRebrokeSelectSchemeParams.UIItemClientSendKeys, ModifierKeys.None);
        }

        /// <summary>
        ///     MotoRebrokeCurrent
        /// </summary>
        public void MotoRebrokeCurrent()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIRebrokeResultsScreenWindow.UIOKWindow.UIOKButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;

            #endregion

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(50, 10));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(43, 11));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        ///     MotoRebroke
        /// </summary>
        public void MotoRebroke()
        {
            #region Variable Declarations

            WinButton uIRebrokeButton = this.map.UIAUTO2081001Window.UIRebrokeWindow.UIRebrokeButton;
            WinButton uICancelButton = this.map.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            WinButton uINOButton = this.map.UICreditCheckWindow.UINoWindow.UINoButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Re&broke...' button
            Mouse.Click(uIRebrokeButton, new Point(86, 12));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Cancel' button
            Mouse.Click(uICancelButton, new Point(48, 17));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click '&No' button
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

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(41, 13));

            // Type 'test' in text box
            uIItemEdit.Text = this.MotoPostcodeLookupParams.UIItemEditText;

            // Type 'test' in text box
            uIItemEdit1.Text = this.MotoPostcodeLookupParams.UIItemEditText1;

            // Type '160486' in text box
            uIItemEdit2.Text = this.MotoPostcodeLookupParams.UIItemEditText2;

            // Type 'BN16BN' in text box
            uIItemEdit3.Text = this.MotoPostcodeLookupParams.UIItemEditText3;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(9, 12));

            // Click '&Ok' button
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

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(52, 17));

            // Type 'Test' in text box
            uIItemEdit.Text = this.MotoPolicyPersonParams.UIItemEditText;

            // Type '{Tab}' in text box
            Keyboard.SendKeys(uIItemEdit, this.MotoPolicyPersonParams.UIItemEditSendKeys, ModifierKeys.None);

            // Type 'test' in text box
            uIItemEdit1.Text = this.MotoPolicyPersonParams.UIItemEditText1;

            // Type '160485' in text box
            uIItemEdit2.Text = this.MotoPolicyPersonParams.UIItemEditText2;

            // Type 'B338TH' in text box
            uIItemEdit3.Text = this.MotoPolicyPersonParams.UIItemEditText3;

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(34, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(38, 12));
        }

        /// <summary>
        ///     MotoMTAOpenQuote
        /// </summary>
        public void MotoMTAOpenQuote()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.PolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegrateMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(33, 12));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(116, 15));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(29, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.
        }

        /// <summary>
        ///     MotoMTANoSave - Use 'MotoMTANoSaveParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTANoSave()
        {
            #region Variable Declarations

            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton1 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Select 'Change of Driver' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTANoSaveParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(42, 16));

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(70, 10));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 13));

            // Click 'OK' button
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

            // Verify that the 'DisplayText' property of 'MTA successfully processed on a previously renewed...' label contains 'RENEWAL EDI HAS BEEN CANCELLED'
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

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(37, 25));
        }

        /// <summary>
        ///     MotoMTAConfirmPolicy - Use 'MotoMTAConfirmPolicyParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTAConfirmPolicy()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient;
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(362, 176));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoMTAConfirmPolicyParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(54, 8));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(40, 12));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(50, 19));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(32, 8));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoMTAConfirmPolicyParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(42, 12));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoMTAConfirmPolicyParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(24, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(37, 10));
        }

        /// <summary>
        ///     MotoMTAConfirmDate
        /// </summary>
        public void MotoMTAConfirmDate()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIMTAEffectiveDatesWindow.UIOKWindow.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(21, 17));
        }

        /// <summary>
        ///     MotoMTACloseMessage
        /// </summary>
        public void MotoMTACloseMessage()
        {
            #region Variable Declarations

            WinButton uIOKButton = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(56, 8));
        }

        /// <summary>
        ///     MotoMTACheckNewValue - Use 'MotoMTACheckNewValueExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTACheckNewValue()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals '2000'
            Assert.AreEqual(this.MotoMTACheckNewValueExpectedValues.UIItemEditText, uIItemEdit.Text);
        }

        /// <summary>
        ///     MotoMTACheckCar - Use 'MotoMTACheckCarExpectedValues' to pass parameters into this method.
        /// </summary>
        public void MotoMTACheckCar()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;

            #endregion

            // Verify that the 'Text' property of text box equals 'RF53OXL'
            Assert.AreEqual(this.MotoMTACheckCarExpectedValues.UIItemEditText, uIItemEdit.Text);

            // Verify that the 'Text' property of text box equals '2000'
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
            WinButton uIOKButton3 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(28, 8));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoMTABeforeFinishParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(69, 14));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoMTABeforeFinishParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 21));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(39, 8));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(24, 10));
        }

        /// <summary>
        ///     MotoMTABeforeAccept - Use 'MotoMTABeforeAcceptParams' to pass parameters into this method.
        /// </summary>
        public void MotoMTABeforeAccept()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient;
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(401, 181));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoMTABeforeAcceptParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(56, 12));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 11));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(31, 21));

            // Click 'OK' button
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
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(44, 11));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(57, 12));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(53, 9));

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTABefore2Params.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(36, 16));

            // Type '23423' in text box
            uIItemEdit.Text = this.MotoMTABefore2Params.UIItemEditText;

            // Click 'Calculate &Quote' button
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
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;
            WinComboBox uIItemComboBox = this.map.UIMidTermAdjustmentsWindow.UIItemWindow.UIItemComboBox;
            WinButton uIOKButton1 = this.map.UIMidTermAdjustmentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow1.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(35, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Before' button
            Mouse.Click(uIBeforeButton, new Point(19, 16));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(44, 11));

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTABeforeParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton1, new Point(44, 21));

            // Type '77777' in text box
            uIItemEdit.Text = this.MotoMTABeforeParams.UIItemEditText;

            // Click 'Calculate &Quote' button
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
            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow.UIItemEdit;
            WinButton uICalculateQuoteButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UICalculateQuoteWindow.UICalculateQuoteButton;

            #endregion

            // Select 'Change of Vehicle' in combo box
            uIItemComboBox.SelectedItem = this.MotoMTAAcceptParams.UIItemComboBoxSelectedItem;

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(28, 12));

            // Type '2000' in text box
            uIItemEdit.Text = this.MotoMTAAcceptParams.UIItemEditText;

            // Click 'Calculate &Quote' button
            Mouse.Click(uICalculateQuoteButton, new Point(68, 4));
        }

        /// <summary>
        ///     MotoMTA
        /// </summary>
        public void MotoMTA()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.PolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegrateMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.map.UICurrentOrFutureWindow.UIClient.UIOKButton;
            WinButton uIMTAButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIMTAWindow.UIMTAButton;

            #endregion

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(37, 10));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(80, 15));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(41, 10));

            // Click '&MTA...' button
            Mouse.Click(uIMTAButton, new Point(67, 11));
        }

        /// <summary>
        ///     MotoInceptionDate - Use 'MotoInceptionDateParams' to pass parameters into this method.
        /// </summary>
        public void MotoInceptionDate()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIItemWindow13.UIItemEdit;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '13/11/12' in text box
            uIItemEdit.Text = this.MotoInceptionDateParams.UIItemEditText;
        }

        /// <summary>
        ///     MotoFinishMTA - Use 'MotoFinishMTAParams' to pass parameters into this method.
        /// </summary>
        public void MotoFinishMTA()
        {
            #region Variable Declarations

            WinClient uIQuoteResultsClient = this.map.UIQuoteResultsWindow.UIItemWindow2.UIClient;
            WinButton uIAcceptButton = this.map.UIQuoteResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.map.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinClient uIPointOfSaleClient = this.map.UIPointOfSaleWindow.UIPointOfSaleClient;
            WinCheckBox uIDeferPrintingCheckBox = this.map.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.map.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.map.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.map.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click 'Quote Results' client
            Mouse.Click(uIQuoteResultsClient, new Point(371, 177));

            // Type '{Home}' in 'Quote Results' client
            Keyboard.SendKeys(uIQuoteResultsClient, this.MotoFinishMTAParams.UIQuoteResultsClientSendKeys, ModifierKeys.None);

            // Click 'A&ccept' button
            Mouse.Click(uIAcceptButton, new Point(51, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(57, 13));

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(38, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(59, 17));

            // Click 'Point Of Sale' client
            Mouse.Click(uIPointOfSaleClient, new Point(477, 239));

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoFinishMTAParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(54, 19));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoFinishMTAParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(43, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(48, 14));

            // Click 'OK' button
            Mouse.Click(uIOKButton4, new Point(38, 12));
        }

        /// <summary>
        ///     MotoExitMTA
        /// </summary>
        public void MotoExitMTA()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.map.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(51, 10));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(13, 9));

            // Click 'OK' button
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

            // Click '&OK' button
            Mouse.Click(uIOKButton, new Point(44, 7));
        }

        /// <summary>
        ///     MotoCopyRiskExit
        /// </summary>
        public void MotoCopyRiskExit()
        {
            #region Variable Declarations

            WinButton uIExitButton = this.map.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow.UIExitButton;
            WinButton uINOButton = this.map.UIInsurEtamWindow1.UINoWindow.UINoButton;
            WinButton uIOKButton = this.map.UITamxml7Window.UITamxml7Client.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Exit' button
            Mouse.Click(uIExitButton, new Point(66, 10));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(47, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(34, 11));
        }

        /// <summary>
        ///     MotoCopyFinishedRisk
        /// </summary>
        public void MotoCopyFinishedRisk()
        {
            #region Variable Declarations

            WinButton uIOptionsButton = this.map.UIPolicyautotestWindow.PolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uICopyRiskMenuItem =
                this.map.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3RdPartyIntegrateMenuItem.UICopyRiskMenuItem;
            WinButton uIOKButton = this.map.UIWhichpolicywouldyoulWindow.UIItemWindow.UIClient.UIOKButton;
            WinButton uIOKButton1 = this.map.UIProductSelectionWindow.UIOKWindow.UIOKButton;

            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(29, 12));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Copy Risk' menu item
            Mouse.Click(uICopyRiskMenuItem, new Point(79, 13));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(57, 15));

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&OK' button
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

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(59, 16));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(66, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton, new Point(53, 10));
        }
    }
}