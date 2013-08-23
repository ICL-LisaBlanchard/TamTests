namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class HouseUiTests : BaseUiTest
    {
        [TestMethod]
        public void HouseCreateQuote()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeExitWithoutPolicy();
            this.UiMap.HomeCloseOpenPolicy();
            this.UiMap.HomeClickPremium();
            this.UiMap.HomeCheckZeroPremium();
            this.UiMap.HomeExitWithPolicy();
            this.UiMap.HomeCheckPremium();
            this.UiMap.HomePrintQuote();
            this.UiMap.SelectMenu();
            this.UiMap.HomePrintQuote1();
            this.UiMap.HomeCheckPrint();
            this.UiMap.HomeDemands();
            this.UiMap.CloseDemandsMoto();
            this.UiMap.HomeAcceptQuote();
            this.UiMap.CancelPrint();
            this.UiMap.HomeAcceptQuote1();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeChangePremium();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckNewPremium();
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeCopyCheckData();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeExitWithoutPolicy();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeCopyCheckData();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTACancel();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckCancelled();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckChanged();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeCopyRisk();
            this.UiMap.HomeMTACopyCheck();
            this.UiMap.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            // create new policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //MTA
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            //new MTA
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = "30/09/12";
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTACheckMessage();
            this.UiMap.HomeMTACloseMessage();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeMTACoverDate();
            this.UiMap.HomeMTASelectQuote();
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.UiMap.HomeMTACheckChanged();
            this.UiMap.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            //create policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //cancel policy
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeCancelPolicy();
            this.UiMap.HomeCancelPolicyQuote();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeCancelPolicyQuote1();
            this.UiMap.HomeCancelPolicyExit();
            //check status
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            this.UiMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\office.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeProposer();
            this.UiMap.HomeAddressLookup();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            //cancel policy
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeCancelPolicy();
            this.UiMap.HomeCancelPolicyQuote();
            this.UiMap.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.HomeMTAEnterDate();
            this.UiMap.HomeCancelPolicyQuote1();
            this.UiMap.HomeCancelPolicyAccept();
            //check status
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            this.UiMap.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            this.UiMap.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            //  renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //mta1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTABefore();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeRenewalBeforeAccept();
            this.UiMap.HomeRenewalCancelledCheck();
            this.UiMap.HomeRenewalBeforeFinish();
            ////mta2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeRenewalConfirm();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            ////MTA1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAAfter();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeMTASelectQuote();
            //MTA2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAAfter();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
            //MTA3
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTABefore();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeRenewalBeforeAccept();
            this.UiMap.HomeRenewalBeforeFinish();
            //mta4
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeRenewalConfirm();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MotoMTAMessageAfterDate();
            this.UiMap.MTACloseMessageAfter();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeAmendSelecPolicy();
            this.UiMap.HomeAmendRenew();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeAmendRisk();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys = "{End}";
            this.UiMap.HomeAmendSelecPolicy();
            this.UiMap.HomeAmendRenewFinish();
            this.UiMap.EtamOk();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.HomeAmendRenewFinish1();
            this.UiMap.EtamOk();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
            //MTA1
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.AmendDateBeforeMessage();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.HomeMTASelectQuote();
            //MTA2
            this.UiMap.HomeOpenQuote();
            this.UiMap.HomeMTAChange();
            this.UiMap.HomeMTAAccept();
            this.UiMap.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.UiMap.MTADate();
            this.UiMap.MTAMessageBeforeCurrent();
            this.UiMap.MTACloseMessageBefore();
            this.UiMap.MTAEffectiveDatesCancel();
            this.UiMap.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeCurrent();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite1();
            this.UiMap.RenewalModuleRenew();
            this.UiMap.RetrieveResponse();
            this.UiMap.RenewalModuleRenew1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeSelectPolicy();
            this.UiMap.HomeRebrokeSelectAlternative();
            this.UiMap.HomeRebrokeFinish();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite1();
            this.UiMap.RebrokeAlternativeRenew();
            this.UiMap.EtamOk();
            this.UiMap.EtamYes();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.RebrokeAlternativeRenew1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.RenewalCheckStatus();
            this.UiMap.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            this.UiMap.RegistryHighwayParams.UIOpenComboBoxEditableItem = "c:\\TestProject7\\ourmma.reg";
            this.UiMap.RegistryHighway();
            //add policy
            this.UiMap.AddPolicy();
            this.UiMap.SelectHomeType();
            this.UiMap.SelectMenu();
            this.UiMap.Links1();
            this.UiMap.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.HomeStartDate();
            this.UiMap.HomeProposerParams.UIItemEditText4 = "BN16BN";
            this.UiMap.HomeProposer();
            this.UiMap.HomeCreatePolicy();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeSelectPolicy1();
            this.UiMap.HomeAcceptPolicy();
            this.UiMap.HomeFinishQuote();
            this.UiMap.HomeCloseOpenPolicyList();
            this.UiMap.HomeOpenPolicy();
            string policyNumber = this.UiMap.MotoGetPolicyNumber();
            //site for renewal
            this.UiMap.OpenBrowser2();
            this.UiMap.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.UiMap.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.HomeSiteRenewal();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.ChangeDatePolicy();
            //regress app
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.MotoRegressAppParams.UIItemEditText = customerCode;
            this.UiMap.MotoRegressApp();
            this.UiMap.HouseRegressApp();
            this.UiMap.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.UiMap.RegressAppDate();
            this.UiMap.MotoRegressAppFinish();
            this.UiMap.CloseRegressApp();
            //renewal loader
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.UiMap.RenewalLoaderRun();
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
            // renewal module
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1();
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.UiMap.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.UiMap.RenewalModuleFilterMoto();
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.UiMap.RenewalModuleDisplay();
            this.UiMap.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.UiMap.MotoRenewalCheckRecord();
            this.UiMap.HomeRebroke();
            this.UiMap.PublicCreditCheckOk();
            this.UiMap.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys = "{END}";
            this.UiMap.HomeRebrokeSelectPolicy();
            this.UiMap.HomeRebrokeSelectAlternative();
            this.UiMap.HomeRebrokeFinish();
            this.UiMap.RenewalModuleInvite();
            this.UiMap.RenewConfirmInvite();
            this.UiMap.RenewalModuleInvite1();
            this.UiMap.RebrokeAlternativeRenew();
            this.UiMap.EtamOk();
            this.UiMap.EtamYes();
            this.UiMap.ConfirmDocuments();
            this.UiMap.RetrieveResponse();
            this.UiMap.RebrokeAlternativeRenew1();
            this.UiMap.RenewalModuleClose();
            this.UiMap.MotoCloseAndOpenPolicyList();
            this.UiMap.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.UiMap.ClosePolicy();
        }
    }
}