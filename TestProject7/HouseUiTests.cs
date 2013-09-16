namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class HouseUiTests : BaseUiTest
    {
        private const string PolicyType = "Household";

        private readonly MotoActions moto = new MotoActions();

        private readonly HouseActions house = new HouseActions();

        private readonly CustomerActions customer = new CustomerActions();

        private readonly DocumentsList docs = new DocumentsList();

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
            string premium = this.house.CheckPolicyPremium();
            this.house.OpenTransList(GetTransactionDictionary(premium));
            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhNewBusinessQuote);
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
            this.house.CloseDemands();
            this.house.HomeAcceptQuote();
            this.house.CancelPrint();
            this.house.HomeAcceptQuote1();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.CheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            const int OverridePremium = 19999;
            this.SetOfficeRegKeys();
            this.house.CustomerCode = this.customer.AddPolicy();
            this.CreatePolicy(false);
            this.house.HomeSelectPolicy();
            this.house.HomeChangePremium(OverridePremium);
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
            this.house.HomeCheckNewPremium();

            this.house.OpenTransList(GetTransactionDictionary("18866.98"));
            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhNewBusinessQuote, OverridePremium);
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
            this.house.HomeClosePolicy();
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
            this.house.CheckCorrectNumberTrans(2);
            this.house.HomeClosePolicy();
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

            this.house.HomeMTAEnterDate("30/09/12");
            this.house.HomeMTACoverDate();
            this.house.HomeMTACheckMessage();
            this.house.HomeMTACloseMessage();
            this.house.HomeMTAEnterDate();
            this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            this.house.HomeOpenQuote();
            this.house.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.house.HomeMTACheckChanged();
            this.house.HomeClosePolicy();
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

            this.house.HomeStartDate();
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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(1000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            //  renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);

            this.house.RenewalCheckRecord(1, this.house.CustomerCode);
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            //mta1
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            this.house.HomeRenewalBeforeAccept();
            this.house.HomeRenewalCancelledCheck();
            this.house.HomeRenewalBeforeFinish();
            ////mta2
            this.house.HomeOpenQuote();
            this.house.HomeRenewalConfirm();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();
            this.house.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();

            this.house.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
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

            this.house.HomeStartDate();

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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            ////MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.house.HomeMTASelectQuote();
            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();
            //MTA3
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            this.moto.MotoMTAMessageAfterDate();
            this.house.MTACloseMessageAfter();

            this.house.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.house.HomeRenewalBeforeAccept();
            this.house.HomeRenewalBeforeFinish();
            //mta4
            this.house.HomeOpenQuote();
            this.house.HomeRenewalConfirm();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();

            this.house.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
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
            this.house.HomeStartDate();
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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
            this.house.HomeAmendRisk();
            this.house.PublicCreditCheckOk();
            this.house.HomeAmendSelecPolicy();
            this.house.HomeAmendRenew();
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
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

            this.house.HomeStartDate();

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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
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
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus();
            this.house.ClosePolicy();
            //MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.house.AmendDateBeforeMessage();
            this.house.MTACloseMessageBefore();

            this.house.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.house.HomeMTASelectQuote();
            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept();

            this.house.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
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

            this.house.HomeStartDate();

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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(true);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
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
            this.moto.CloseAndOpenPolicyList();
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

            this.house.HomeStartDate();

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

            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
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
            this.moto.CloseAndOpenPolicyList();
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

            this.house.HomeStartDate();

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
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
            //regress app
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            //renewal loader
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
            // renewal module
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.moto.RenewalCheckRecordExpectedValues.UIWindowName = customerCode;
            this.moto.RenewalCheckRecord(1, this.house.CustomerCode);
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
            this.moto.CloseAndOpenPolicyList();
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