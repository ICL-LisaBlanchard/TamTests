namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class HouseUiTests : BaseUiTest
    {
        private const string PolicyType = "Household";

        private const string RenewalPremium = "1232";

        [TestMethod]
        public void HouseCreateQuote()
        {
            Playback.PlaybackSettings.SearchTimeout = 15000;
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            string premium = this.CreateNewPolicy();
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium));
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHhNewBusinessQuote);
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeExitWithoutPolicy();
            this.House.HomeCloseOpenPolicy();
            this.House.HomeClickPremium();
            this.House.HomeCheckZeroPremium();
            this.House.HomeExitWithPolicy();
            this.House.HomeCheckPremium();
            this.House.HomePrintQuote();
            this.House.SelectMenu();
            this.House.HomePrintQuote1();
            this.House.HomeCheckPrint();
            this.House.HomeDemands();
            this.House.CloseDemands();
            this.House.HomeAcceptQuote();
            this.House.CancelPrint();
            this.House.HomeAcceptQuote1();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenPolicy();
            this.House.CheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            const int OverridePremium = 19999;
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeChangePremium(OverridePremium);
            this.SetPolicyDetails();
            this.House.HomeCheckNewPremium();

            this.House.OpenTransList(Transactions.GetTransactionDictionary("18866.98"));
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHhNewBusinessQuote, OverridePremium);
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeCopyRisk();
            this.House.HomeCopyCheckData();
            this.House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeExitWithoutPolicy();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeCopyRisk();
            this.House.HomeCopyCheckData();
            this.House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTACancel();
            this.House.HomeOpenQuote();
            this.House.HomeMTACheckCancelled();
            this.House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.HomeMTACoverDate();
            this.House.HomeMTASelectQuote();
            this.House.HomeOpenQuote();
            this.House.HomeMTACheckChanged();
            this.House.CheckCorrectNumberTrans(2);
            this.House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            this.SetOfficeRegKeys();
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.HomeMTACoverDate();
            this.House.HomeMTASelectQuote();
            this.House.HomeCopyRisk();
            this.House.HomeMTACopyCheck();
            this.House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            this.SetOfficeRegKeys();
            // create new policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            //MTA
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            string coverDate = "HouseMTAtoMTA_" + this.House.HomeMTACoverDate();
            this.House.HomeMTASelectQuote();
            //new MTA
            this.House.HomeOpenQuote();
            this.House.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(true, coverDate);

            this.House.HomeMTAEnterDate("30/09/12");
            this.House.HomeMTACoverDate();
            this.House.HomeMTACheckMessage();
            this.House.HomeMTACloseMessage();
            this.House.HomeMTAEnterDate();
            this.House.HomeMTACoverDate();
            this.House.HomeMTASelectQuote();
            this.House.HomeOpenQuote();
            this.House.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            this.House.HomeMTACheckChanged();
            this.House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            this.SetOfficeRegKeys();
            //create policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            //cancel policy
            this.House.HomeOpenQuote();
            this.House.HomeCancelPolicy();
            this.House.HomeCancelPolicyQuote();

            this.House.HomeMTAEnterDate();
            this.House.HomeCancelPolicyQuote1();
            this.House.HomeCancelPolicyExit();
            //check status
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenPolicy();
            this.House.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            this.House.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            this.SetOfficeRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.CreatePolicy(false);
            this.House.HomeSelectPolicy();
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            //cancel policy
            this.House.HomeOpenQuote();
            this.House.HomeCancelPolicy();
            this.House.HomeCancelPolicyQuote();
            this.House.HomeMTAEnterDate();
            this.House.HomeCancelPolicyQuote1();
            this.House.HomeCancelPolicyAccept();
            //check status
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenPolicy();
            this.House.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            this.House.HomeCheckStatus();
            this.House.CheckCorrectNumberTrans(2);
            this.House.CheckCorrectDocumentPresent(this.Docs.DocumentsForHhAcceptQuoteCancel);
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();

            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();
            this.House.HomeSelectPolicy();
            this.SetPolicyDetails();
            string originalPremium = this.House.CheckPolicyPremium();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            //site for renewal
            this.House.OpenBrowser2();
            this.House.HomeSiteRenewal(policyNumber, RenewalPremium);
            Playback.Wait(5000);
            this.House.CloseBrowser();
            this.House.ChangeDatePolicy();

            //regress app
            string customerCode = this.RegressApp(PolicyType);

            //renewal loader
            this.RenewalLoader();

            //  renewal module
            this.RenewalModule(customerCode, PolicyType);
            this.RenewalsInvite(false);

            this.House.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("REN");
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForMotoRenewalBefore, originalPremium: double.Parse(originalPremium));
            this.House.OpenTransList(Transactions.GetTransactionDictionary(RenewalPremium, originalPremium));
            this.House.ClosePolicy();

            //mta1
            this.House.HomeOpenQuote();
            this.House.HomeMTABefore();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            this.House.HomeRenewalBeforeAccept();
            this.House.HomeRenewalCancelledCheck();
            this.House.HomeRenewalBeforeFinish();

            ////mta2
            this.House.HomeOpenQuote();
            this.House.HomeRenewalConfirm();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.House.MTAMessageBeforeCurrent();
            this.House.MTACloseMessageBefore();

            this.House.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.House.MTACloseMessageAfter();
            this.House.MTAEffectiveDatesCancel();
            this.House.HomeMTACancel1();
        }


        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();

            this.CreateNewPolicy();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.RenewalsInvite(false);
            this.Moto.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("REN");
            this.House.ClosePolicy();

            ////MTA1
            this.House.HomeOpenQuote();
            this.House.HomeMTAAfter();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.House.HomeMTASelectQuote();

            //MTA2
            this.House.HomeOpenQuote();
            this.House.HomeMTAAfter();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.House.MTAMessageBeforeCurrent();
            this.House.MTACloseMessageBefore();
            this.House.MTAEffectiveDatesCancel();
            this.House.HomeMTACancel1();

            //MTA3
            this.House.HomeOpenQuote();
            this.House.HomeMTABefore();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);

            this.House.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.House.MTACloseMessageAfter();

            this.House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.House.HomeRenewalBeforeAccept();
            this.House.HomeRenewalBeforeFinish();

            //mta4
            this.House.HomeOpenQuote();
            this.House.HomeRenewalConfirm();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            this.House.MTAMessageBeforeCurrent();
            this.House.MTACloseMessageBefore();
            this.House.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            this.Moto.MotoMTAMessageAfterDate();
            this.House.MTACloseMessageAfter();
            this.House.MTAEffectiveDatesCancel();
            this.House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();

            this.CreateNewPolicy();
            string policyNumber = this.Moto.MotoGetPolicyNumber();
            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.HomeAmendRisk();
            this.House.PublicCreditCheckOk();
            this.House.HomeAmendSelecPolicy(false);
            this.House.HomeAmendRenew();
            this.House.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("REN");
            this.House.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();
            this.House.HomeSelectPolicy();
            this.SetPolicyDetails();
            string originalpremium = this.House.CheckPolicyPremium();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.HomeAmendRisk();
            this.House.PublicCreditCheckOk();
            this.House.HomeAmendSelecPolicy(true);
            this.House.HomeAmendRenewFinish();
            //this.house.EtamOk();
            this.House.ConfirmDocuments();
            this.House.RetrieveResponse();
            this.House.HomeAmendRenewFinish1();
            this.House.EtamOk();

            this.House.RenewalModuleClose();
            this.House.CloseAndOpenPolicyList();
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = this.House.CheckPolicyPremium();
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            this.House.RenewalCheckStatus("REW");
            this.House.ClosePolicy();

            //MTA1
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            this.House.AmendDateBeforeMessage();
            this.House.MTACloseMessageBefore();
            this.House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            this.House.HomeMTASelectQuote();

            //MTA2
            this.House.HomeOpenQuote();
            this.House.HomeMTAChange();
            this.House.HomeMTAAccept(false);
            this.House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            this.House.MTAMessageBeforeCurrent();
            this.House.MTACloseMessageBefore();
            this.House.MTAEffectiveDatesCancel();
            this.House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();

            this.House.HomeStartDate();

            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();
            this.CreateNewPolicy();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.HomeRebroke();
            this.House.PublicCreditCheckOk();
            this.House.HomeRebrokeCurrent();
            this.RenewalsInvite(false);
            this.Moto.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("REN");
            this.House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();
            this.House.HomeSelectPolicy();
            this.SetPolicyDetails();

            string policyNumber = this.Moto.MotoGetPolicyNumber();
            string originalpremium = this.House.CheckPolicyPremium();
            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.HomeRebroke();
            this.House.PublicCreditCheckOk();
            this.House.HomeRebrokeSelectPolicy(this.House.CommonParams.SendHomeKeys);
            this.House.HomeRebrokeSelectAlternative();
            this.House.HomeRebrokeFinish();
            this.House.RenewalModuleInvite(false);
            this.House.RenewConfirmInvite();
            this.House.RenewalModuleInvite1();
            this.House.RebrokeAlternativeRenew();
            this.House.EtamOk();
            //this.house.LapseOk();
            this.House.EtamYes();
            this.House.ConfirmDocuments();
            this.House.RetrieveResponse();
            this.House.RebrokeAlternativeRenew1();
            this.House.RenewalModuleClose();
            this.House.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("REW");
            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = this.House.CheckPolicyPremium();
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            this.House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();

            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();

            string originalpremium = this.CreateNewPolicy();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.HomeRebroke();
            this.House.PublicCreditCheckOk();
            this.House.HomeRebrokeSelectPolicy(this.House.CommonParams.SendEndKeys);
            this.House.HomeRebrokeSelectAlternative();
            this.House.HomeRebrokeFinish();
            this.House.RenewalModuleInvite(false);
            this.House.RenewConfirmInvite();
            this.House.RenewalModuleInvite1();
            this.House.RebrokeAlternativeRenew();
            this.House.EtamOk();
            this.House.EtamYes();
            this.House.ConfirmDocuments();
            this.House.RetrieveResponse();
            this.House.RebrokeAlternativeRenew1();
            this.House.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();

            this.House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = this.House.CheckPolicyPremium();
            this.House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            this.House.RenewalCheckStatus("REW");
            this.House.ClosePolicy();
        }

        [TestMethod]
        public void HouseLapsePolicy()
        {
            // change registry to ourhighway
            this.SetOurMMaRegKeys();
            //add policy
            this.House.CustomerCode = this.Customer.AddPolicy();
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeStartDate();
            this.House.HomeProposer();
            this.House.HomeCreatePolicy();
            this.House.PublicCreditCheckOk();

            this.CreateNewPolicy();
            string policyNumber = this.Moto.MotoGetPolicyNumber();

            this.Renewals(policyNumber, PolicyType, RenewalPremium);

            this.House.RenewalModuleInvite(false);
            this.House.RenewConfirmInvite();
            this.House.RenewalModuleInvite1();
            this.House.LapsePolicy(policyNumber);
            this.House.RenewalModuleClose();
            this.Moto.CloseAndOpenPolicyList();
            this.House.RenewalCheckStatus("LAP");
            this.House.ClosePolicy();
        }

        #region Private Functions

        private string CreateNewPolicy()
        {
            this.House.HomeSelectPolicy();
            this.SetPolicyDetails();
            string premium = this.House.CheckPolicyPremium();
            return premium;
        }

        private void SetPolicyDetails()
        {
            this.House.HomeAcceptPolicy();
            this.House.HomeFinishQuote();
            this.House.HomeCloseOpenPolicyList();
            this.House.HomeOpenPolicy();
        }

        private void CreatePolicy(bool full)
        {
            this.House.SelectHomeType();
            this.House.SelectMenu();
            this.House.Links();
            this.House.HomeProposer();
            if (full)
            {
                this.House.HomeProposerFull();
            }
            else
            {
                this.House.HomeAddressLookup();
                this.House.HomeCreatePolicy();
            }

            this.House.PublicCreditCheckOk();
        }

        #endregion
    }
}