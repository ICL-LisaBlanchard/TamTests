namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

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
            string premium = this.CreateNewPolicy();
            this.house.OpenTransList(Transactions.GetTransactionDictionary(premium));
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
            this.SetPolicyDetails();
            this.house.HomeCheckNewPremium();

            this.house.OpenTransList(Transactions.GetTransactionDictionary("18866.98"));
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
            this.house.HomeMTAAccept(false);
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
            this.house.HomeMTAAccept(false);
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
            this.house.HomeMTAAccept(false);
            string coverDate = "HouseMTAtoMTA_" + this.house.HomeMTACoverDate();
            this.house.HomeMTASelectQuote();
            //new MTA
            this.house.HomeOpenQuote();
            this.house.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(true, coverDate);

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
            this.house.CheckCorrectNumberTrans(2);
            this.house.CheckCorrectDocumentPresent(this.docs.DocumentsForHhAcceptQuoteCancel);
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
            this.house.HomeSelectPolicy();
            this.SetPolicyDetails();
            string originalPremium = this.house.CheckPolicyPremium();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            //site for renewal
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();

            //regress app
            string customerCode = this.RegressApp();

            //renewal loader
            this.RenewalLoader();

            //  renewal module
            this.RenewalModule(customerCode);

            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();

            this.house.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("REN");
            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhRenewalBefore, originalPremium: double.Parse(originalPremium));
            this.house.ClosePolicy();

            //mta1
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
            this.house.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            this.house.HomeRenewalBeforeAccept();
            this.house.HomeRenewalCancelledCheck();
            this.house.HomeRenewalBeforeFinish();

            ////mta2
            this.house.HomeOpenQuote();
            this.house.HomeRenewalConfirm();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
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

            this.CreateNewPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber);

            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.RenewalModuleRenew();
            this.house.RetrieveResponse();
            this.house.RenewalModuleRenew1();
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("REN");
            this.house.ClosePolicy();

            ////MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
            this.house.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.house.HomeMTASelectQuote();

            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTAAfter();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
            this.house.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.house.MTAMessageBeforeCurrent();
            this.house.MTACloseMessageBefore();
            this.house.MTAEffectiveDatesCancel();
            this.house.HomeMTACancel1();

            //MTA3
            this.house.HomeOpenQuote();
            this.house.HomeMTABefore();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);

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
            this.house.HomeMTAAccept(false);
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

            this.CreateNewPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();
            this.Renewals(policyNumber);

            this.house.HomeAmendRisk();
            this.house.PublicCreditCheckOk();
            this.house.HomeAmendSelecPolicy(false);
            this.house.HomeAmendRenew();
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("REN");
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
            this.house.HomeSelectPolicy();
            this.SetPolicyDetails();
            string originalpremium = this.house.CheckPolicyPremium();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber);

            this.house.HomeAmendRisk();
            this.house.PublicCreditCheckOk();
            this.house.HomeAmendSelecPolicy(true);
            this.house.HomeAmendRenewFinish();
            //this.house.EtamOk();
            this.house.ConfirmDocuments();
            this.house.RetrieveResponse();
            this.house.HomeAmendRenewFinish1();
            this.house.EtamOk();

            this.house.RenewalModuleClose();
            this.house.CloseAndOpenPolicyList();
            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhRenewalBefore, originalPremium: double.Parse(originalpremium));
            string premium = this.house.CheckPolicyPremium();
            this.house.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            this.house.RenewalCheckStatus("REW");
            this.house.ClosePolicy();

            //MTA1
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
            this.house.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.house.AmendDateBeforeMessage();
            this.house.MTACloseMessageBefore();
            this.house.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.house.HomeMTASelectQuote();

            //MTA2
            this.house.HomeOpenQuote();
            this.house.HomeMTAChange();
            this.house.HomeMTAAccept(false);
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
            this.CreateNewPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber);

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
            this.house.RenewalCheckStatus("REN");
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
            this.house.HomeSelectPolicy();
            this.SetPolicyDetails();

            string policyNumber = this.moto.MotoGetPolicyNumber();
            string originalpremium = this.house.CheckPolicyPremium();
            this.Renewals(policyNumber);

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
            //this.house.LapseOk();
            this.house.EtamYes();
            this.house.ConfirmDocuments();
            this.house.RetrieveResponse();
            this.house.RebrokeAlternativeRenew1();
            this.house.RenewalModuleClose();
            this.house.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("REW");
            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhRenewalBefore, originalPremium: double.Parse(originalpremium));
            string premium = this.house.CheckPolicyPremium();
            this.house.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
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

            string originalpremium = this.CreateNewPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber);

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

            this.house.CheckPremiumInQuoteDocument(this.docs.DocumentsForHhRenewalBefore, originalPremium: double.Parse(originalpremium));
            string premium = this.house.CheckPolicyPremium();
            this.house.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            this.house.RenewalCheckStatus("REW");
            this.house.ClosePolicy();
        }

        [TestMethod]
        public void HouseLapsePolicy()
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

            this.CreateNewPolicy();
            string policyNumber = this.moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber);

            this.house.RenewalModuleInvite();
            this.house.RenewConfirmInvite();
            this.house.RenewalModuleInvite1();
            this.house.LapsePolicy(policyNumber);
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("LAP");
            this.house.ClosePolicy();
        }

        #region Private Functions

        private void RenewalModule(string customerCode)
        {
            this.house.RenewalModuleEDI();
            this.house.RenewalModuleConfirm();
            this.house.RenewalModuleEdi1(false);
            this.house.RenewalModuleFilter(PolicyType);
            this.house.RenewalModuleSort();
            this.house.RenewalModuleDisplay(this.moto.CommonParams.SendHomeKeys);
            this.house.RenewalCheckRecord(1, customerCode);
        }

        private string RegressApp()
        {
            this.house.HighlightCustomer();
            string customerCode = this.house.GetCustomerCode();
            this.moto.RegressApp(customerCode);
            this.house.HouseRegressApp(PolicyType);
            this.house.RegressAppDate();
            this.moto.RegressAppFinish();
            this.house.CloseRegressApp();
            return customerCode;
        }

        private void RenewalLoader()
        {
            this.house.RenewalLoaderOpen();
            this.house.RenewalLoaderRun();
            this.house.CloseBrowser();
            this.house.RenewalLoaderClose();
        }

        private string CreateNewPolicy()
        {
            this.house.HomeSelectPolicy();
            this.SetPolicyDetails();
            string premium = this.house.CheckPolicyPremium();
            return premium;
        }

        private void SetPolicyDetails()
        {
            this.house.HomeAcceptPolicy();
            this.house.HomeFinishQuote();
            this.house.HomeCloseOpenPolicyList();
            this.house.HomeOpenPolicy();
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

        #endregion

        private void Renewals(string policyNumber)
        {
            //site for renewal
            this.SiteForRenewal(policyNumber);

            //regress app
            string customerCode = this.RegressApp();

            //renewal loader
            this.RenewalLoader();

            // renewal module
            this.RenewalModule(customerCode);
        }

        private void SiteForRenewal(string policyNumber)
        {
            this.house.OpenBrowser2();
            this.house.HomeSiteRenewal(policyNumber);
            Playback.Wait(5000);
            this.house.CloseBrowser();
            this.house.ChangeDatePolicy();
        }
    }
}