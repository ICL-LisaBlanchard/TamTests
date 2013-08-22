namespace Ver1
{
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;


    public partial class UIMap
    {

        /// <summary>
        /// MTAEffectiveDate - Use 'MTAEffectiveDateParams' to pass parameters into this method.
        /// </summary>
        public void MTAEffectiveDate()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIMTAEffectiveDatesWindow.UIItemWindow.UIItemEdit;
            #endregion

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // The recording for the application under test '\\Pc-pez\J-Drive\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Type '31/10/12' in 'Unknown Name' text box
            uIItemEdit.Text = this.MTAEffectiveDateParams.UIItemEditText;
        }

        public virtual MTAEffectiveDateParams MTAEffectiveDateParams
        {
            get
            {
                if ((this.mMTAEffectiveDateParams == null))
                {
                    this.mMTAEffectiveDateParams = new MTAEffectiveDateParams();
                }
                return this.mMTAEffectiveDateParams;
            }
        }

        private MTAEffectiveDateParams mMTAEffectiveDateParams;

        /// <summary>
        /// MotoGetPolicyNumber
        /// </summary>
        public string MotoGetPolicyNumber()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UIItemWindow2.UIItemEdit;
            #endregion

            // Click 'Unknown Name' text box
            return uIItemEdit.GetProperty("Text").ToString();

        }

        /// <summary>
        /// SiteGetRenewalDate
        /// </summary>
        public string SiteGetRenewalDate()
        {
            #region Variable Declarations
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;
            #endregion

            // Click 'txtRenewalDate' text box
            //Mouse.Click(uITxtRenewalDateEdit, new Point(88, 10));
            return uITxtRenewalDateEdit.GetProperty("Text").ToString();
        }

        //public void test()
        //{
        //    WinWindow win = this.UIWindowsSecurityWindow2;

        //    if (!win.Exists)
        //        Assert.Fail("no window");
        //    Keyboard.SendKeys(win, "Bus Sys");
        //    Keyboard.SendKeys(win, "{Tab}");
        //    Keyboard.SendKeys(win, Playback.EncryptText("Tottenham1"));

        //    Keyboard.SendKeys(win, "Tottenham1");
        //    Playback.EncryptText("{Enter}");

        //}

        /// <summary>
        /// MotoCreateSiteRenewal - Use 'MotoCreateSiteRenewalParams' to pass parameters into this method.
        /// </summary>
        public void MotoCreateSiteRenewal()
        {
            #region Variable Declarations
            HtmlHyperlink uICreateaMotorTestReneHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument1.UIDivRenewalsPane.UICreateaMotorTestReneHyperlink;
            HtmlComboBox uIInsurerIDComboBox = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UIInsurerIDComboBox;
            HtmlEdit uITxtPolicyNumberEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtPolicyNumberEdit;
            HtmlEdit uITxtAutoLapseDateEdit1 = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtAutoLapseDateEdit1;
            HtmlInputButton uICreateRecordButton = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UICreateRecordButton;
            BrowserWindow uIInsurEcomSystemMaintWindow = this.UIInsurEcomSystemMaintWindow;
            HtmlEdit uITxtRenewalDateEdit = this.UIInsurEcomSystemMaintWindow.UIContentFrame.UIInsurEcomMainPageDocument.UITxtRenewalDateEdit;
            #endregion

            // Click 'Create a Motor Test Renewal Invitation' link
            Mouse.Click(uICreateaMotorTestReneHyperlink, new Point(50, 22));

            // Select 'Highway Insurance' in 'InsurerID' combo box
            uIInsurerIDComboBox.SelectedItem = this.MotoCreateSiteRenewalParams.UIInsurerIDComboBoxSelectedItem;

            // Type '7071000841' in 'txtPolicyNumber' text box
            uITxtPolicyNumberEdit.Text = this.MotoCreateSiteRenewalParams.UITxtPolicyNumberEditText;

            // Type '12/11/2012' in 'txtAutoLapseDate' text box
            uITxtAutoLapseDateEdit1.Text = uITxtRenewalDateEdit.GetProperty("Text").ToString();

            // Click 'Create Record' button
            Mouse.Click(uICreateRecordButton, new Point(112, 11));

            // Click 'Ok' button in the browser dialog window
            uIInsurEcomSystemMaintWindow.PerformDialogAction(BrowserDialogAction.Ok);
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

        private MotoCreateSiteRenewalParams mMotoCreateSiteRenewalParams;

        /// <summary>_
        /// GetCustomerCode
        /// </summary>
        public string GetCustomerCode()
        {
            #region Variable Declarations
            WinButton uICancelButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UICUSTOMERSWindow.UIItemWindow.UIItemEdit;
            #endregion


            // Click 'Cancel' button
            //  Mouse.Click(uICancelButton, new Point(42, 10));

            return uIItemEdit.GetProperty("Text").ToString();

            // Click 'Unknown Name' text box
            //Mouse.Click(uIItemEdit, new Point(83, 7));
        }

        /// <summary>
        /// RecordedMethod7
        /// </summary>
        public void RecordedMethod7()
        {
            #region Variable Declarations
            WinList uIDesktopList = this.UIProgramManagerWindow.UIFolderViewWindow.UIDesktopList;
            WinListItem uITestProject7ListItem = this.UIProgramManagerWindow.UIDesktopList.UITestProject7ListItem;
            #endregion

            // Click 'Desktop' list box
            Mouse.Click(uIDesktopList, new Point(598, 455));

            // Click 'TestProject7' list item
            Mouse.Click(uITestProject7ListItem, new Point(12, 35));
        }

        /// <summary>
        /// CloseDemandsMoto
        /// </summary>
        public void CloseDemandsMoto()
        {
            #region Variable Declarations
            WinClient UIDemandsNeedsMotorComClient = this.UIDemandsNeedsMotorComWindow.UIDemandsNeedsMotorComClient;
            #endregion

            // Click 'Close' button
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(UIDemandsNeedsMotorComClient, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void etam_ok()
        {
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIOKButton1, new Point(47, 12));
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        public void QuoteSelectListCancel()
        {
            WinButton uICancelButton = this.UIQuoteSelectListWindow.UICancelWindow.UICancelButton;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uICancelButton, new Point(14, 18));
            Playback.PlaybackSettings.ContinueOnError = false;
        }
        /// <summary>
        /// OpenBrowser2 - Use 'OpenBrowser2Params' to pass parameters into this method.
        /// </summary>
        public void OpenBrowser2()
        {
            #region Variable Declarations

            WinButton ok_but_xp = this.UIWindowsSecurityWindow1.UIWindowsSecurityPane.UIOKButton;
            HtmlHyperlink uIRenewalsMaintenanceHyperlink = this.UIInsurEcomSystemMaintWindow.UILeftbarFrame.UIInsurEcomLeftbarDocument.UIRenewalsMaintenanceHyperlink;
            WinWindow w_xp = this.UIWindowsSecurityWindow1;
            WinButton ok_but_7 = this.UIWindowsSecurityWindow.UIWindowsSecurityPane.UIOKButton;
            WinWindow w_7 = this.UIWindowsSecurityWindow;
            WinButton ok_but;
            WinWindow w;
            #endregion

            // Go to web page 'https://www.insur-econnect.com/sysmaint/default.asp?mode=1' using new browser instance
            this.UIInsurEcomSystemMaintWindow.LaunchUrl(new System.Uri(this.OpenBrowser2Params.UIInsurEcomSystemMaintWindowUrl));

            if (w_xp.Exists)
            {
                ok_but = ok_but_xp;
                w = w_xp;
            }
            else
            {
                ok_but = ok_but_7;
                w = w_7;
            }


            Playback.PlaybackSettings.ContinueOnError = true;

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Keyboard.SendKeys(w, "Bus Sys{Tab}Tottenham1");



            // Click 'OK' button
            Mouse.Click(ok_but, new Point(31, 14));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Renewals Maintenance' link
            Mouse.Click(uIRenewalsMaintenanceHyperlink, new Point(39, 7));
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

        private OpenBrowser2Params mOpenBrowser2Params;

        /// <summary>
        /// SiteClose
        /// </summary>
        public void SiteClose()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIInsurEcomSystemMaintWindow.UIInsurEcomSystemMaintTitleBar.UICloseButton;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'Close' button
            Mouse.Click(uICloseButton, new Point(28, 2));

            // The recording for the application under test '\\Pc-pez\J-Drive\WINTAM\clntfile.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }

        /// <summary>
        /// CloseBrowser
        /// </summary>
        public void CloseBrowser()
        {
            #region Variable Declarations
            WinButton uICloseButton = this.UIBlankPageMicrosoftInWindow.UIBlankPageWindowsInteTitleBar.UICloseButton;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)


            // Click 'Close' button
            // Mouse.Click(uICloseButton, new Point(31, 0));
            Playback.PlaybackSettings.ContinueOnError = true;
            Keyboard.SendKeys(this.UIBlankPageMicrosoftInWindow, "{F4}", ModifierKeys.Alt);
            Playback.PlaybackSettings.ContinueOnError = false;
            // Reset flag to ensure that play back stops if there is an error.

        }

        /// <summary>
        /// HomeFinishQuote - Use 'HomeFinishQuoteParams' to pass parameters into this method.
        /// </summary>
        public void HomeFinishQuote()
        {
            #region Variable Declarations
            WinButton uILookupButton = this.UIPolicyDetailConfirmaWindow.UILookupWindow.UILookupButton;
            WinButton uIOKButton = this.UISearchResultForB338TWindow.UIOKWindow.UIOKButton;
            WinButton uIConfirmButton = this.UIPolicyDetailConfirmaWindow.UIConfirmWindow.UIConfirmButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPointOfSaleWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton2 = this.UIPointOfSaleWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            #endregion

            // Click '&Lookup...' button
            Mouse.Click(uILookupButton, new Point(23, 12));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(46, 14));

            // Click '&Confirm' button
            Mouse.Click(uIConfirmButton, new Point(25, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(27, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.HomeFinishQuoteParams.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(61, 11));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeFinishQuoteParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton3, new Point(51, 10));

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(50, 10));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(50, 10));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(44, 10));
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

        private HomeFinishQuoteParams mHomeFinishQuoteParams;

        /// <summary>
        /// MotoAWAP - Use 'MotoAWAPParams' to pass parameters into this method.
        /// </summary>
        public void MotoAWAP()
        {
            #region Variable Declarations
            WinButton uIAWAPButton = this.UIQuoteResultsWindow.UIAWAPWindow.UIAWAPButton;
            WinComboBox uIItemComboBox = this.UIAcceptWithAnotherProWindow.UIItemWindow.UIItemComboBox;
            WinEdit uIItemEdit = this.UIAcceptWithAnotherProWindow.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit1 = this.UIAcceptWithAnotherProWindow.UIItemWindow2.UIItemEdit;
            WinEdit uIItemEdit2 = this.UIAcceptWithAnotherProWindow.UIItemWindow3.UIItemEdit;
            WinEdit uIItemEdit3 = this.UIAcceptWithAnotherProWindow.UIItemWindow4.UIItemEdit;
            WinButton uIOKButton = this.UIAcceptWithAnotherProWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinButton uIOKButton4 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            #endregion

            // The recording for the application under test '\\Pc-pez\APPLIED\APPS\IEOffice\Data\InsureTam.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Click '&AWAP' button
            Mouse.Click(uIAWAPButton, new Point(50, 14));

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

        public virtual MotoAWAPParams MotoAWAPParams
        {
            get
            {
                if ((this.mMotoAWAPParams == null))
                {
                    this.mMotoAWAPParams = new MotoAWAPParams();
                }
                return this.mMotoAWAPParams;
            }
        }

        private MotoAWAPParams mMotoAWAPParams;

        /// <summary>
        /// MotoAmendRiskRenew - Use 'MotoAmendRiskRenewParams' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRiskRenew()
        {
            #region Variable Declarations
            WinButton uIRenewPolicyButton = this.UIAmendRiskResultsWindow.UIRenewPolicyWindow.UIRenewPolicyButton;
            WinButton uIYesButton = this.UIConfirmWindow.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton3 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton4 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton5 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton6 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton1 = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
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

            RetrieveResponse();

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

        private MotoAmendRiskRenewParams mMotoAmendRiskRenewParams;

        /// <summary>
        /// MotoAmendRiskNew_1 - Use 'MotoAmendRiskNew_1Params' to pass parameters into this method.
        /// </summary>
        public void MotoAmendRiskNew_1()
        {
            #region Variable Declarations
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton1 = this.UIInsurEtamWindow1.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITransactiontoinsertWindow.UIItemWindow.UITransactiontoinsertClient.UIOKButton;
            WinList uIItemList = this.UIPleaseselectWHOtofolWindow.UIItemWindow1.UIItemList;
            WinButton uIOKButton4 = this.UIPleaseselectWHOtofolWindow.UIItemWindow.UIPleaseselectWHOtofolClient.UIOKButton;
            WinButton uIOKButton5 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uIExitButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIExitWindow1.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.MotoAmendRiskNew_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(59, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(54, 6));

            // Click 'OK' button
            Mouse.Click(uIOKButton1, new Point(50, 20));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.MotoAmendRiskNew_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(47, 13));

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(55, 14));

            // Select 'AG Administrator General' in 'Unknown Name' list box
            uIItemList.SelectedItemsAsString = this.MotoAmendRiskNew_1Params.UIItemListSelectedItemsAsString;

            // Click '&Ok' button
            Mouse.Click(uIOKButton4, new Point(56, 11));

            // Click 'OK' button
            Mouse.Click(uIOKButton5, new Point(48, 12));

            etam_ok();

            // Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(47, 18));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 7));
        }

        public virtual MotoAmendRiskNew_1Params MotoAmendRiskNew_1Params
        {
            get
            {
                if ((this.mMotoAmendRiskNew_1Params == null))
                {
                    this.mMotoAmendRiskNew_1Params = new MotoAmendRiskNew_1Params();
                }
                return this.mMotoAmendRiskNew_1Params;
            }
        }

        private MotoAmendRiskNew_1Params mMotoAmendRiskNew_1Params;

        /// <summary>
        /// RenewalModuleInvite_1 - Use 'RenewalModuleInvite_1Params' to pass parameters into this method.
        /// </summary>
        public void RenewalModuleInvite_1()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIDeferPrintingCheckBox = this.UIPrintDocumentsWindow.UIDeferPrintingWindow.UIDeferPrintingCheckBox;
            WinButton uIOKButton1 = this.UIPrintDocumentsWindow.UIOKWindow.UIOKButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton2 = this.UIImporttoTAMWindow.UIPanel1Client.UIOKButton;
            WinButton uIOKButton3 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            #endregion

            // Click 'Ok' button
            Mouse.Click(uIOKButton, new Point(50, 16));

            RetrieveResponse();

            // Select '&Defer Printing?' check box
            uIDeferPrintingCheckBox.Checked = this.RenewalModuleInvite_1Params.UIDeferPrintingCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(72, 10));

            // The recording for the application under test '\\Pc-pez\J-Drive\TamXML\TamXML7.exe' may not be correct as it is located on a network share. Please install the application on a local path.

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.RenewalModuleInvite_1Params.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(24, 12));

            // Click 'OK' button
            Mouse.Click(uIOKButton3, new Point(35, 10));
        }

        public virtual RenewalModuleInvite_1Params RenewalModuleInvite_1Params
        {
            get
            {
                if ((this.mRenewalModuleInvite_1Params == null))
                {
                    this.mRenewalModuleInvite_1Params = new RenewalModuleInvite_1Params();
                }
                return this.mRenewalModuleInvite_1Params;
            }
        }

        private RenewalModuleInvite_1Params mRenewalModuleInvite_1Params;

        /// <summary>
        /// HighlightCustomer
        /// </summary>
        public void HighlightCustomer()
        {
            #region Variable Declarations
            WinClient uICUSTOMERSClient = this.UIPolicyautotestWindow.UICUSTOMERSWindow.UIItemWindow1.UICUSTOMERSClient;
            #endregion

            // Click 'CUSTOMERS' client
            Mouse.Click(uICUSTOMERSClient, new Point(31, 25));
            Mouse.Click(uICUSTOMERSClient, new Point(31, 25));
        }

        /// <summary>
        /// HomePrintQuote_1 - Use 'HomePrintQuote_1Params' to pass parameters into this method.
        /// </summary>
        public void HomePrintQuote_1()
        {
            #region Variable Declarations
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIQuotesResultsClient;
            WinButton uIPrintQuoteButton = this.UIQuotesResultsWindow.UIPrintQuoteWindow.UIPrintQuoteButton;
            #endregion

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(40, 5));

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(31, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(39, 17));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(39, 17));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(39, 17));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(9, 9));

            this.PublicCreditCheckOk();

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(526, 161));

            // Type '{End}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomePrintQuote_1Params.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Click '&Print Quote..' button
            Mouse.Click(uIPrintQuoteButton, new Point(65, 11));
        }

        public virtual HomePrintQuote_1Params HomePrintQuote_1Params
        {
            get
            {
                if ((this.mHomePrintQuote_1Params == null))
                {
                    this.mHomePrintQuote_1Params = new HomePrintQuote_1Params();
                }
                return this.mHomePrintQuote_1Params;
            }
        }

        private HomePrintQuote_1Params mHomePrintQuote_1Params;

        /// <summary>
        /// HomeExitWithPolicy - Use 'HomeExitWithPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeExitWithPolicy()
        {
            #region Variable Declarations
            WinButton uICancelButton = this.UIPolicyautotestWindow.UIBillingScreenMOTOWindow.UICancelWindow.UICancelButton;
            WinButton uIOptionsButton = this.UIPolicyautotestWindow.UIPolicyListWindow.UIOptionsWindow.UIOptionsButton;
            WinMenuItem uIQuoteSelectListMenuItem = this.UIPolicyautotestWindow.UIApplicationMenuBar.UIOptionsMenuItem.UILinksMenuItem.UIItem3rdPartyIntegratMenuItem.UIQuoteSelectListMenuItem;
            WinButton uIOKButton = this.UICurrentOrFutureWindow.UICurrentOrFutureClient.UIOKButton;
            WinButton uINextButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow.UINextButton;
            WinButton uINextButton1 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow1.UINextButton;
            WinButton uINextButton2 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow2.UINextButton;
            WinButton uINextButton3 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow3.UINextButton;
            WinButton uINextButton4 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow4.UINextButton;
            WinButton uINextButton5 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow5.UINextButton;
            WinButton uINextButton6 = this.UIInsurEtamWindow.UIMotorQuotesWindow.UINextWindow6.UINextButton;
            WinButton uIQuoteButton = this.UIInsurEtamWindow.UIMotorQuotesWindow.UIQuoteWindow.UIQuoteButton;
            WinButton uINOButton = this.UICreditCheckWindow.UINOWindow.UINOButton;
            WinClient uIQuotesResultsClient = this.UIQuotesResultsWindow.UIItemWindow.UIQuotesResultsClient;
            WinButton uIExitButton = this.UIQuotesResultsWindow.UIExitWindow.UIExitButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinCheckBox uIAddActivityCheckBox = this.UIImporttoTAMWindow.UIImportOptionsClient.UIAddActivityCheckBox;
            WinButton uIOKButton1 = this.UIImporttoTAMWindow.UIImporttoTAMClient.UIOKButton;
            WinButton uIOKButton2 = this.UITamxml7Window.UITamxml7Client.UIOKButton;
            WinButton uICancelButton1 = this.UIPolicyautotestWindow.UIPolicyListWindow.UICancelWindow.UICancelButton;
            WinButton uIItemButton = this.UIPolicyautotestWindow.UIItemWindow.UIItemButton;
            WinButton uIDetailButton = this.UIPolicyautotestWindow.UIPolicyListWindow1.UIDetailWindow.UIDetailButton;
            WinEdit uIItemEdit = this.UIPolicyautotestWindow.UIBillingScreenHOMEWindow1.UIItemWindow.UIItemEdit;
            WinButton uIOKButton3 = this.UISelectTaminsurerforiWindow.UIItemWindow1.UISelectTaminsurerforiClient.UIOKButton;
            #endregion

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(41, 14));

            // Click 'Options' button
            Mouse.Click(uIOptionsButton, new Point(49, 4));

            // Click 'Options' -> 'Links' -> '3rd Party Integration' -> 'Quote Select List' menu item
            Mouse.Click(uIQuoteSelectListMenuItem, new Point(89, 11));

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(33, 10));

            // Click '&Next >' button
            Mouse.Click(uINextButton, new Point(38, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton1, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton2, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton3, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton4, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton5, new Point(46, 13));

            // Click '&Next >' button
            Mouse.Click(uINextButton6, new Point(46, 13));

            // Click '&Quote' button
            Mouse.Click(uIQuoteButton, new Point(46, 13));

            // Click '&No' button
            Mouse.Click(uINOButton, new Point(48, 3));

            this.PublicCreditCheckOk();

            // Click 'Quotes Results' client
            Mouse.Click(uIQuotesResultsClient, new Point(500, 164));

            // Type '{Home}' in 'Quotes Results' client
            Keyboard.SendKeys(uIQuotesResultsClient, this.HomeExitWithPolicyParams.UIQuotesResultsClientSendKeys, ModifierKeys.None);

            // Double-Click 'E&xit' button
            Mouse.Click(uIExitButton, new Point(46, 13));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(51, 13));

            // Clear 'Add Activity' check box
            uIAddActivityCheckBox.Checked = this.HomeExitWithPolicyParams.UIAddActivityCheckBoxChecked;

            // Click 'Ok' button
            Mouse.Click(uIOKButton1, new Point(45, 15));

            

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton3, new Point(42, 10));

            // Click 'OK' button
            Mouse.Click(uIOKButton2, new Point(55, 7));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;

            // Click 'Cancel' button
            Mouse.Click(uICancelButton1, new Point(37, 17));

            // Click 'Unknown Name' button
            Mouse.Click(uIItemButton, new Point(28, 18));

            // Click 'Detail' button
            Mouse.Click(uIDetailButton, new Point(29, 11));

            // Click 'Unknown Name' text box
            Mouse.Click(uIItemEdit, new Point(22, 8));
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

        private HomeExitWithPolicyParams mHomeExitWithPolicyParams;

        /// <summary>
        /// HomeAcceptPolicy - Use 'HomeAcceptPolicyParams' to pass parameters into this method.
        /// </summary>
        public void HomeAcceptPolicy()
        {
            #region Variable Declarations
            WinButton uIAcceptButton = this.UIQuotesResultsWindow.UIAcceptWindow.UIAcceptButton;
            WinButton uIYesButton = this.UIInsurEtamWindow1.UIYesWindow.UIYesButton;
            WinButton uIOKButton = this.UIBrokerAddonsWindow.UIOKWindow.UIOKButton;
            WinButton uICancelButton = this.UISavethefileasWindow.UICancelWindow.UICancelButton;
            WinButton uIOKButton1 = this.UIPaymentMethodsWindow.UIOKWindow.UIOKButton;
            WinButton uIOKButton2 = this.UIConfirmDocumentsWindow.UIOKWindow.UIOKButton;
            WinEdit uIItemEdit = this.UIPolicyDetailConfirmaWindow.UIItemWindow.UIItemEdit;
            #endregion

            // Click 'Accept' button
            Mouse.Click(uIAcceptButton, new Point(47, 11));

            // Click '&Yes' button
            Mouse.Click(uIYesButton, new Point(49, 11));

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click '&Ok' button
            Mouse.Click(uIOKButton, new Point(30, 14));

            // Click 'Cancel' button
            Mouse.Click(uICancelButton, new Point(41, 9));

            // Reset flag to ensure that play back stops if there is an error.
            
            Playback.PlaybackSettings.ContinueOnError = false;

            this.etam_ok();

            // Click '&Ok' button
            Mouse.Click(uIOKButton1, new Point(47, 22));

            // Click 'Ok' button
            Mouse.Click(uIOKButton2, new Point(46, 11));

            // Type 'B338TH' in 'Unknown Name' text box
            uIItemEdit.Text = this.HomeAcceptPolicyParams.UIItemEditText;
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

        private HomeAcceptPolicyParams mHomeAcceptPolicyParams;
    }
    /// <summary>
    /// Parameters to be passed into 'MTAEffectiveDate'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class MTAEffectiveDateParams
    {

        #region Fields
        /// <summary>
        /// Type '31/10/12' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "31/10/12";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MotoCreateSiteRenewal'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.40219.1")]
    public class MotoCreateSiteRenewalParams
    {

        #region Fields
        /// <summary>
        /// Select 'Highway Insurance' in 'InsurerID' combo box
        /// </summary>
        public string UIInsurerIDComboBoxSelectedItem = "Highway Insurance";

        /// <summary>
        /// Type '7071000841' in 'txtPolicyNumber' text box
        /// </summary>
        public string UITxtPolicyNumberEditText = "7071000841";

        /// <summary>
        /// Type '12/11/2012' in 'txtAutoLapseDate' text box
        /// </summary>
        public string UITxtAutoLapseDateEdit1Text = "12/11/2012";
        #endregion
    }

    public class UIWindowsSecurityWindow2 : WinWindow
    {

        public UIWindowsSecurityWindow2()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Connect to www.insur-econnect.com";
            //this.WindowTitles.Add("Windows Security");
            #endregion

        }


    }

    /// <summary>
    /// Parameters to be passed into 'OpenBrowser2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class OpenBrowser2Params
    {

        #region Fields
        /// <summary>
        /// Go to web page 'https://www.insur-econnect.com/sysmaint/default.asp?mode=1' using new browser instance
        /// </summary>
        public string UIInsurEcomSystemMaintWindowUrl = "https://www.insur-econnect.com/sysmaint/default.asp?mode=1";

        /// <summary>
        /// Type 'Bus sys' in 'User name' text box
        /// </summary>
        public string UIUsernameEditText = "Bus sys";

        /// <summary>
        /// Type '********' in 'Password' text box
        /// </summary>
        public string UIPasswordEditSendKeys = "bAXj9upnjswSKjBKX1xP7w7j09QL9Z1L";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'HomeFinishQuote'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class HomeFinishQuoteParams
    {

        #region Fields
        /// <summary>
        /// Select '&Defer Printing?' check box
        /// </summary>
        public bool UIDeferPrintingCheckBoxChecked = true;

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MotoAWAP'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class MotoAWAPParams
    {

        #region Fields
        /// <summary>
        /// Select 'AIG' in 'Unknown Name' combo box
        /// </summary>
        public string UIItemComboBoxSelectedItem = "AIG";

        /// <summary>
        /// Type 'test' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "test";

        /// <summary>
        /// Type '12345' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText1 = "12345";

        /// <summary>
        /// Type '10000' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText2 = "10000";

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MotoAmendRiskRenew'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class MotoAmendRiskRenewParams
    {

        #region Fields
        /// <summary>
        /// Select '&Defer Printing?' check box
        /// </summary>
        public bool UIDeferPrintingCheckBoxChecked = true;

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;

        /// <summary>
        /// Select 'AG Administrator General' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "AG Administrator General";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'MotoAmendRiskNew_1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class MotoAmendRiskNew_1Params
    {

        #region Fields
        /// <summary>
        /// Select '&Defer Printing?' check box
        /// </summary>
        public bool UIDeferPrintingCheckBoxChecked = true;

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;

        /// <summary>
        /// Select 'AG Administrator General' in 'Unknown Name' list box
        /// </summary>
        public string UIItemListSelectedItemsAsString = "AG Administrator General";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'RenewalModuleInvite_1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class RenewalModuleInvite_1Params
    {

        #region Fields
        /// <summary>
        /// Select '&Defer Printing?' check box
        /// </summary>
        public bool UIDeferPrintingCheckBoxChecked = true;

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'HomePrintQuote_1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class HomePrintQuote_1Params
    {

        #region Fields
        /// <summary>
        /// Type '{End}' in 'Quotes Results' client
        /// </summary>
        public string UIQuotesResultsClientSendKeys = "{End}";
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'HomeExitWithPolicy'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class HomeExitWithPolicyParams
    {

        #region Fields
        /// <summary>
        /// Type '{Home}' in 'Quotes Results' client
        /// </summary>
        public string UIQuotesResultsClientSendKeys = "{Home}";

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;
        #endregion
    }
    /// <summary>
    /// Parameters to be passed into 'HomeAcceptPolicy'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "10.0.30319.1")]
    public class HomeAcceptPolicyParams
    {

        #region Fields
        /// <summary>
        /// Type 'B338TH' in 'Unknown Name' text box
        /// </summary>
        public string UIItemEditText = "B338TH";
        #endregion
}
}
