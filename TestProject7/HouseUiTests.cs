namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class HouseUiTests : BaseUiTest
    {
        private readonly MotoActions moto = new MotoActions();

        private readonly HomeActions home = new HomeActions();

        private readonly CustomerActions customer = new CustomerActions();

        [TestMethod]
        public void HouseCreateQuote()
        {
            Playback.PlaybackSettings.SearchTimeout = 15000;
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            this.home.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeExitWithoutPolicy();
            this.home.HomeCloseOpenPolicy();
            this.home.HomeClickPremium();
            this.home.HomeCheckZeroPremium();
            this.home.HomeExitWithPolicy();
            this.home.HomeCheckPremium();
            this.home.HomePrintQuote();
            this.home.SelectMenu();
            this.home.HomePrintQuote1();
            this.home.HomeCheckPrint();
            this.home.HomeDemands();
            this.home.CloseDemandsMoto();
            this.home.HomeAcceptQuote();
            this.home.CancelPrint();
            this.home.HomeAcceptQuote1();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            this.home.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeChangePremium();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            this.home.HomeCheckNewPremium();
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeCopyRisk();
            this.home.HomeCopyCheckData();
            this.home.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeExitWithoutPolicy();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeCopyRisk();
            this.home.HomeCopyCheckData();
            this.home.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTACancel();
            this.home.HomeOpenQuote();
            this.home.HomeMTACheckCancelled();
            this.home.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.HomeMTACoverDate();
            this.home.HomeMTASelectQuote();
            this.home.HomeOpenQuote();
            this.home.HomeMTACheckChanged();
            this.home.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            this.SetOfficeRegKeys();
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.HomeMTACoverDate();
            this.home.HomeMTASelectQuote();
            this.home.HomeCopyRisk();
            this.home.HomeMTACopyCheck();
            this.home.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            this.SetOfficeRegKeys();
            // create new policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            //MTA
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.HomeMTACoverDate();
            this.home.HomeMTASelectQuote();
            //new MTA
            this.home.HomeOpenQuote();
            this.home.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.HomeMTAEnterDateParams.UIItemEditText = "30/09/12";
            this.home.HomeMTAEnterDate();
            this.home.HomeMTACoverDate();
            this.home.HomeMTACheckMessage();
            this.home.HomeMTACloseMessage();
            this.home.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.home.HomeMTAEnterDate();
            this.home.HomeMTACoverDate();
            this.home.HomeMTASelectQuote();
            this.home.HomeOpenQuote();
            this.home.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.home.HomeMTACheckChanged();
            this.home.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            this.SetOfficeRegKeys();
            //create policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            //cancel policy
            this.home.HomeOpenQuote();
            this.home.HomeCancelPolicy();
            this.home.HomeCancelPolicyQuote();
            this.home.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.home.HomeMTAEnterDate();
            this.home.HomeCancelPolicyQuote1();
            this.home.HomeCancelPolicyExit();
            //check status
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            this.home.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            this.home.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            this.SetOfficeRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeProposer();
            this.home.HomeAddressLookup();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            //cancel policy
            this.home.HomeOpenQuote();
            this.home.HomeCancelPolicy();
            this.home.HomeCancelPolicyQuote();
            this.home.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.home.HomeMTAEnterDate();
            this.home.HomeCancelPolicyQuote1();
            this.home.HomeCancelPolicyAccept();
            //check status
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            this.home.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            this.home.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            //  renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.RenewalModuleInvite();
            this.home.RenewConfirmInvite();
            this.home.RenewalModuleInvite1();
            this.home.RenewalModuleRenew();
            this.home.RetrieveResponse();
            this.home.RenewalModuleRenew1();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
            //mta1
            this.home.HomeOpenQuote();
            this.home.HomeMTABefore();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.HomeRenewalBeforeAccept();
            this.home.HomeRenewalCancelledCheck();
            this.home.HomeRenewalBeforeFinish();
            ////mta2
            this.home.HomeOpenQuote();
            this.home.HomeRenewalConfirm();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.MTAMessageBeforeCurrent();
            this.home.MTACloseMessageBefore();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.home.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.home.MTACloseMessageAfter();
            this.home.MTAEffectiveDatesCancel();
            this.home.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.RenewalModuleInvite();
            this.home.RenewConfirmInvite();
            this.home.RenewalModuleInvite1();
            this.home.RenewalModuleRenew();
            this.home.RetrieveResponse();
            this.home.RenewalModuleRenew1();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
            ////MTA1
            this.home.HomeOpenQuote();
            this.home.HomeMTAAfter();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.HomeMTASelectQuote();
            //MTA2
            this.home.HomeOpenQuote();
            this.home.HomeMTAAfter();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.MTAMessageBeforeCurrent();
            this.home.MTACloseMessageBefore();
            this.home.MTAEffectiveDatesCancel();
            this.home.HomeMTACancel1();
            //MTA3
            this.home.HomeOpenQuote();
            this.home.HomeMTABefore();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.home.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.home.MTACloseMessageAfter();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.HomeRenewalBeforeAccept();
            this.home.HomeRenewalBeforeFinish();
            //mta4
            this.home.HomeOpenQuote();
            this.home.HomeRenewalConfirm();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.MTAMessageBeforeCurrent();
            this.home.MTACloseMessageBefore();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.home.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.home.MTACloseMessageAfter();
            this.home.MTAEffectiveDatesCancel();
            this.home.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.HomeAmendRisk();
            this.home.PublicCreditCheckOk();
            this.home.HomeAmendSelecPolicy();
            this.home.HomeAmendRenew();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.HomeAmendRisk();
            this.home.PublicCreditCheckOk();
            this.home.HomeAmendSelecPolicyParams.UIHouseholdRenewalsAmeClientSendKeys = "{End}";
            this.home.HomeAmendSelecPolicy();
            this.home.HomeAmendRenewFinish();
            this.home.EtamOk();
            this.home.ConfirmDocuments();
            this.home.RetrieveResponse();
            this.home.HomeAmendRenewFinish1();
            this.home.EtamOk();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
            //MTA1
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.AmendDateBeforeMessage();
            this.home.MTACloseMessageBefore();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.HomeMTASelectQuote();
            //MTA2
            this.home.HomeOpenQuote();
            this.home.HomeMTAChange();
            this.home.HomeMTAAccept();
            this.home.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.home.MTADate();
            this.home.MTAMessageBeforeCurrent();
            this.home.MTACloseMessageBefore();
            this.home.MTAEffectiveDatesCancel();
            this.home.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.HomeRebroke();
            this.home.PublicCreditCheckOk();
            this.home.HomeRebrokeCurrent();
            this.home.RenewalModuleInvite();
            this.home.RenewConfirmInvite();
            this.home.RenewalModuleInvite1();
            this.home.RenewalModuleRenew();
            this.home.RetrieveResponse();
            this.home.RenewalModuleRenew1();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.HomeRebroke();
            this.home.PublicCreditCheckOk();
            this.home.HomeRebrokeSelectPolicy();
            this.home.HomeRebrokeSelectAlternative();
            this.home.HomeRebrokeFinish();
            this.home.RenewalModuleInvite();
            this.home.RenewConfirmInvite();
            this.home.RenewalModuleInvite1();
            this.home.RebrokeAlternativeRenew();
            this.home.EtamOk();
            this.home.EtamYes();
            this.home.ConfirmDocuments();
            this.home.RetrieveResponse();
            this.home.RebrokeAlternativeRenew1();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.home.RenewalCheckStatus();
            this.home.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.customer.AddPolicy();
            this.home.SelectHomeType();
            this.home.SelectMenu();
            this.home.Links();
            this.home.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.HomeStartDate();
            this.home.HomeProposerParams.Postcode = "BN16BN";
            this.home.HomeProposer();
            this.home.HomeCreatePolicy();
            this.home.PublicCreditCheckOk();
            this.home.HomeSelectPolicy1();
            this.home.HomeAcceptPolicy();
            this.home.HomeFinishQuote();
            this.home.HomeCloseOpenPolicyList();
            this.home.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.home.OpenBrowser2();
            this.home.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.home.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.home.HomeSiteRenewal();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.ChangeDatePolicy();
            //regress app
            this.home.HighlightCustomer();
            string customerCode = this.home.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.home.HouseRegressApp();
            this.home.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.home.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.home.CloseRegressApp();
            //renewal loader
            this.home.RenewalLoaderOpen();
            this.home.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.home.RenewalLoaderRun();
            Playback.Wait(5000);
            this.home.CloseBrowser();
            this.home.RenewalLoaderClose();
            // renewal module
            this.home.RenewalModuleEDI();
            this.home.RenewalModuleConfirm();
            this.home.RenewalModuleEdi1();
            this.home.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.home.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.home.RenewalModuleFilterMoto();
            this.home.RenewalModuleSort();
            this.home.RenewalModuleDisplayParams.UIInsurETAMRenewalsClientSendKeys = "{Home}";
            this.home.RenewalModuleDisplay();
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord();
            this.home.HomeRebroke();
            this.home.PublicCreditCheckOk();
            this.home.HomeRebrokeSelectPolicyParams.UIHouseholdRebrokeResuClientSendKeys = "{END}";
            this.home.HomeRebrokeSelectPolicy();
            this.home.HomeRebrokeSelectAlternative();
            this.home.HomeRebrokeFinish();
            this.home.RenewalModuleInvite();
            this.home.RenewConfirmInvite();
            this.home.RenewalModuleInvite1();
            this.home.RebrokeAlternativeRenew();
            this.home.EtamOk();
            this.home.EtamYes();
            this.home.ConfirmDocuments();
            this.home.RetrieveResponse();
            this.home.RebrokeAlternativeRenew1();
            this.home.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.home.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.home.ClosePolicy();
        }
    }
}