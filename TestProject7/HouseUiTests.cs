namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class HouseUiTests : BaseUiTest
    {
        private readonly MotoActions moto = new MotoActions();

        private readonly HouseActions house = new HouseActions();

        private readonly CustomerActions customer = new CustomerActions();

        [TestMethod]
        public void HouseCreateQuote()
        {
            Playback.PlaybackSettings.SearchTimeout = 15000;
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);

            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeExitWithoutPolicy();
            this.house.HomeCloseOpenPolicy();
            this.house.HomeClickPremium();
            this.house.HomeCheckZeroPremium();
            this.house.HomeExitWithPolicy();
            this.house.HomeCheckPremium();
            this.house.HomePrintQuote();
            this.house.SelectMenu();
            this.house.HomePrintQuote1();
            this.house.HomeCheckPrint();
            this.house.HomeDemands();
            this.house.CloseDemandsMoto();
            this.house.HomeAcceptQuote();
            this.house.CancelPrint();
            this.house.HomeAcceptQuote1();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeChangePremium();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckNewPremium();
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeCopyRisk();
            this.house.HomeCopyCheckData();
            this.house.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeExitWithoutPolicy();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeCopyRisk();
            this.house.HomeCopyCheckData();
            this.house.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTACancel();
            this.house.HomeOpenQuote();
            this.house.HomeMTACheckCancelled();
            this.house.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            this.house.HomeOpenQuote();
            this.house.HomeMTACheckChanged();
            this.house.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            this.house.HomeCopyRisk();
            this.house.HomeMTACopyCheck();
            this.house.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            this.SetOfficeRegKeys();
            // create new policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            //MTA
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            //new MTA
            this.house.HomeOpenQuote();
            this.house.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.HomeMTAEnterDateParams.UIItemEditText = "30/09/12";
            this.house.HomeMTAEnterDate();
            this.house.HomeMTACoverDate();
            this.house.HomeMTACheckMessage();
            this.house.HomeMTACloseMessage();
            this.house.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.house.HomeMTAEnterDate();
            this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            this.house.HomeOpenQuote();
            this.house.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.house.HomeMTACheckChanged();
            this.house.HomeClosePilicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            this.SetOfficeRegKeys();
            //create policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            //cancel policy
            this.house.HomeOpenQuote();
            this.house.HomeCancelPolicy();
            this.house.HomeCancelPolicyQuote();
            this.house.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.house.HomeMTAEnterDate();
            this.house.HomeCancelPolicyQuote1();
            this.house.HomeCancelPolicyExit();
            //check status
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            this.house.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            this.SetOfficeRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            //cancel policy
            this.house.HomeOpenQuote();
            this.house.HomeCancelPolicy();
            this.house.HomeCancelPolicyQuote();
            this.house.HomeMTAEnterDateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.house.HomeMTAEnterDate();
            this.house.HomeCancelPolicyQuote1();
            this.house.HomeCancelPolicyAccept();
            //check status
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            this.house.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            //  renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);

            this.house.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            //mta1
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(2).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.HomeRenewalBeforeAccept();
            this.house.HomeRenewalCancelledCheck();
            this.house.HomeRenewalBeforeFinish();
            ////mta2
            this.house.HomeOpenQuote();
            this.house.HomeRenewalConfirm();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(10).ToString("dd/MM/yy");
            this.house.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.house.MTACloseMessageAfter();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            ////MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.HomeMTASelectQuote();
            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();
            //MTA3
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(9).ToString("dd/MM/yy");
            this.house.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.house.MTACloseMessageAfter();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.HomeRenewalBeforeAccept();
            this.house.HomeRenewalBeforeFinish();
            //mta4
            this.house.HomeOpenQuote();
            this.house.HomeRenewalConfirm();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(11).ToString("dd/MM/yy");
            this.house.MTADate();
            this.moto.MotoMTAMessageAfterDate();
            this.house.MTACloseMessageAfter();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeAmendRisk();
            this.house.PublicCreditCheckOk();
            this.house.HomeAmendSelecPolicy();
            this.house.HomeAmendRenew();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeAmendRisk();
            this.house.PublicCreditCheckOk();
            this.house.HomeAmendSelecPolicy();
            this.house.HomeAmendRenewFinish();
            this.house.EtamOk();
            this.house.ConfirmDocuments();
            this.house.RetrieveResponse();
            this.house.HomeAmendRenewFinish1();
            this.house.EtamOk();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            //MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(1).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.AmendDateBeforeMessage();
            this.house.MTACloseMessageBefore();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(14).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.HomeMTASelectQuote();
            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADateParams.UIItemEditText = DateTime.Now.AddDays(13).ToString("dd/MM/yy");
            this.house.MTADate();
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeRebroke();
            this.house.PublicCreditCheckOk();
            this.house.HomeRebrokeCurrent();
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeRebroke();
            this.house.PublicCreditCheckOk();
            this.house.HomeRebrokeSelectPolicy(this.house.CommonParams.SendHomeKeys);
            this.house.HomeRebrokeSelectAlternative();
            this.house.HomeRebrokeFinish();
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RebrokeAlternativeRenew();
            this.house.EtamOk();
            this.house.EtamYes();
            this.house.ConfirmDocuments();
            this.house.RetrieveResponse();
            this.house.RebrokeAlternativeRenew1();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.house.CustomerCode = this.customer.AddPolicy();
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeStartDateParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.HomeStartDate();
            this.house.HomeProposerParams.Postcode = "BN16BN";
            this.house.HomeProposer();
            this.house.HomeCreatePolicy();
            this.house.PublicCreditCheckOk();
            this.house.HomeSelectPolicy1();
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewalParams.UITxtPolicyNumberEditText = policyNumber;
            this.house.HomeSiteRenewalParams.UITxtRenewalDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewalParams.UITxtAutoLapseDateEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy");
            this.house.HomeSiteRenewal();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicyParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.MotoRegressAppParams.UIItemEditText = customerCode;
            this.moto.MotoRegressApp();
            this.house.HouseRegressApp();
            this.house.RegressAppDateParams.UIItemEditText = DateTime.Now.AddYears(-1).AddDays(7).ToString("dd/MM/yyyy");
            this.house.RegressAppDate();
            this.moto.MotoRegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRunParams.UIItemEditText = DateTime.Now.ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRunParams.UIItemEditText1 = DateTime.Now.AddDays(14).ToString("dd/MM/yyyy");
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilterMotoParams.UIItemEditText = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemEditText1 = DateTime.Now.AddDays(7).ToString("dd/MM/yy");
            this.house.RenewalModuleFilterMotoParams.UIItemComboBoxSelectedItem = "Household";
            this.house.RenewalModuleFilterMoto();
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.MotoRenewalCheckRecordExpectedValues.UIAUTO1871001WindowName = customerCode;
            this.moto.MotoRenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeRebroke();
            this.house.PublicCreditCheckOk();
            this.house.HomeRebrokeSelectPolicy(this.house.CommonParams.SendEndKeys);
            this.house.HomeRebrokeSelectAlternative();
            this.house.HomeRebrokeFinish();
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RebrokeAlternativeRenew();
            this.house.EtamOk();
            this.house.EtamYes();
            this.house.ConfirmDocuments();
            this.house.RetrieveResponse();
            this.house.RebrokeAlternativeRenew1();
            this.house.RenewalModuleClose();
            this.moto.MotoCloseAndOpenPolicyList();
            this.house.RenewalCheckStatusExpectedValues.UIItemEditText = "REW";
            this.house.ClosePolicy();
        }

        private void CreatePolicy(bool full)
        {
            this.house.SelectHomeType();
            this.house.SelectMenu();
            this.house.Links();
            this.house.HomeProposer();
            if (full)
            {
                this.house.HomeProposerFull();
            }
            else
            {
                this.house.HomeAddressLookup();
                this.house.HomeCreatePolicy();
            }

            this.house.PublicCreditCheckOk();
        }
    }
}