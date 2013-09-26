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
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            string premium = CreateNewPolicy();
            House.OpenTransList(Transactions.GetTransactionDictionary(premium));
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHhNewBusinessQuote);
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeExitWithoutPolicy();
            House.HomeCloseOpenPolicy();
            House.HomeClickPremium();
            House.HomeCheckZeroPremium();
            House.HomeExitWithPolicy();
            House.HomeCheckPremium();
            House.HomePrintQuote();
            House.SelectMenu();
            House.HomePrintQuote1();
            House.HomeCheckPrint();
            House.HomeDemands();
            House.CloseDemands();
            House.HomeAcceptQuote();
            House.CancelPrint();
            House.HomeAcceptQuote1();
            House.HomeCloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.CheckPolicyPremium();
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            const int OverridePremium = 19999;
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeChangePremium(OverridePremium);
            SetPolicyDetails();
            House.HomeCheckNewPremium();

            House.OpenTransList(Transactions.GetTransactionDictionary("18866.98"));
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHhNewBusinessQuote, OverridePremium);
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            House.HomeCopyRisk();
            House.HomeCopyCheckData();
            House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeExitWithoutPolicy();
            House.HomeCloseOpenPolicyList();
            House.HomeCopyRisk();
            House.HomeCopyCheckData();
            House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTACancel();
            House.HomeOpenQuote();
            House.HomeMTACheckCancelled();
            House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseMTAAccept()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.HomeMTACoverDate();
            House.HomeMTASelectQuote();
            House.HomeOpenQuote();
            House.HomeMTACheckChanged();
            House.CheckCorrectNumberTrans(2);
            House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseCopyMTA()
        {
            SetOfficeRegKeys();
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.HomeMTACoverDate();
            House.HomeMTASelectQuote();
            House.HomeCopyRisk();
            House.HomeMTACopyCheck();
            House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAtoMTA()
        {
            SetOfficeRegKeys();
            // create new policy
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            //MTA
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            string coverDate = "HouseMTAtoMTA_" + House.HomeMTACoverDate();
            House.HomeMTASelectQuote();
            //new MTA
            House.HomeOpenQuote();
            House.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            House.HomeMTAChange();
            House.HomeMTAAccept(true, coverDate);

            House.HomeMTAEnterDate("30/09/12");
            House.HomeMTACoverDate();
            House.HomeMTACheckMessage();
            House.HomeMTACloseMessage();
            House.HomeMTAEnterDate();
            House.HomeMTACoverDate();
            House.HomeMTASelectQuote();
            House.HomeOpenQuote();
            House.HomeMTACheckChangedExpectedValues.UIItemEditText = "NewestMTA";
            House.HomeMTACheckChanged();
            House.HomeClosePolicy();
        }

        [TestMethod]
        public void HouseCancelExit()
        {
            SetOfficeRegKeys();
            //create policy
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            //cancel policy
            House.HomeOpenQuote();
            House.HomeCancelPolicy();
            House.HomeCancelPolicyQuote();

            House.HomeMTAEnterDate();
            House.HomeCancelPolicyQuote1();
            House.HomeCancelPolicyExit();
            //check status
            House.HomeCloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            House.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            SetOfficeRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            //cancel policy
            House.HomeOpenQuote();
            House.HomeCancelPolicy();
            House.HomeCancelPolicyQuote();
            House.HomeMTAEnterDate();
            House.HomeCancelPolicyQuote1();
            House.HomeCancelPolicyAccept();
            //check status
            House.HomeCloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            House.HomeCheckStatus();
            House.CheckCorrectNumberTrans(2);
            House.CheckCorrectDocumentPresent(Docs.DocumentsForHhAcceptQuoteCancel);
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();

            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            SetPolicyDetails();
            string originalPremium = House.CheckPolicyPremium();
            string policyNumber = Moto.GetPolicyNumber();

            //site for renewal
            House.OpenBrowser2();
            House.HomeSiteRenewal(policyNumber, RenewalPremium);
            Playback.Wait(5000);
            House.CloseBrowser();
            House.ChangeDatePolicy();

            //regress app
            string customerCode = RegressApp(PolicyType);

            //renewal loader
            RenewalLoader();

            //  renewal module
            RenewalModule(customerCode, PolicyType);
            RenewalsInvite(false);

            House.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("REN");
            var premium = House.CheckPolicyPremium();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHhRenewalBefore, originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalPremium));
            House.ClosePolicy();

            //mta1
            House.HomeOpenQuote();
            House.HomeMTABefore();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            House.HomeRenewalBeforeAccept();
            House.HomeRenewalCancelledCheck();
            House.HomeRenewalBeforeFinish();

            ////mta2
            House.HomeOpenQuote();
            House.HomeRenewalConfirm();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.MTACloseMessageBefore();

            House.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.MTACloseMessageAfter();
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();

            ////MTA1
            House.HomeOpenQuote();
            House.HomeMTAAfter();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            House.HomeMTASelectQuote();

            //MTA2
            House.HomeOpenQuote();
            House.HomeMTAAfter();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.MTACloseMessageBefore();
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();

            //MTA3
            House.HomeOpenQuote();
            House.HomeMTABefore();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);

            House.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.MTACloseMessageAfter();

            House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            House.HomeRenewalBeforeAccept();
            House.HomeRenewalBeforeFinish();

            //mta4
            House.HomeOpenQuote();
            House.HomeRenewalConfirm();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.MTACloseMessageBefore();
            House.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.MTACloseMessageAfter();
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();
            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeAmendRisk();
            House.PublicCreditCheckOk();
            House.HomeAmendSelecPolicy(false);
            House.HomeAmendRenew();
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            SetPolicyDetails();
            string originalpremium = House.CheckPolicyPremium();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeAmendRisk();
            House.PublicCreditCheckOk();
            House.HomeAmendSelecPolicy(true);
            House.HomeAmendRenewFinish();
            //house.EtamOk();
            House.ConfirmDocuments();
            House.RetrieveResponse();
            House.HomeAmendRenewFinish1();
            House.EtamOk();

            House.RenewalModuleClose();
            House.CloseAndOpenPolicyList();
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium();
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            House.RenewalCheckStatus("REW");
            House.ClosePolicy();

            //MTA1
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            House.AmendDateBeforeMessage();
            House.MTACloseMessageBefore();
            House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            House.HomeMTASelectQuote();

            //MTA2
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeMTAAccept(false);
            House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.MTACloseMessageBefore();
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();

            House.HomeStartDate();

            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeCurrent();
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            SetPolicyDetails();

            string policyNumber = Moto.GetPolicyNumber();
            string originalpremium = House.CheckPolicyPremium();
            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeSelectPolicy(House.CommonParams.SendHomeKeys);
            House.HomeRebrokeSelectAlternative();
            House.HomeRebrokeFinish();
            House.RenewalModuleInvite(false);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.RebrokeAlternativeRenew();
            House.EtamOk();
            //house.LapseOk();
            House.EtamYes();
            House.ConfirmDocuments();
            House.RetrieveResponse();
            House.RebrokeAlternativeRenew1();
            House.RenewalModuleClose();
            House.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("REW");
            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium();
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();

            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            string originalpremium = CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeSelectPolicy(House.CommonParams.SendEndKeys);
            House.HomeRebrokeSelectAlternative();
            House.HomeRebrokeFinish();
            House.RenewalModuleInvite(true);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.RebrokeAlternativeRenew();
            House.EtamOk();
            House.EtamYes();
            House.ConfirmDocuments();
            House.RetrieveResponse();
            House.RebrokeAlternativeRenew1();
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();

            House.CheckPremiumInQuoteDocument(Docs.DocumentsForHouseAmendRiskNewScheme, originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium();
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, originalpremium));
            House.RenewalCheckStatus("REW");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseLapsePolicy()
        {
            // change registry to ourhighway
            SetOurMMaRegKeys();
            //add policy
            House.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.RenewalModuleInvite(false);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.LapsePolicy(policyNumber);
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList();
            House.RenewalCheckStatus("LAP");
            House.ClosePolicy();
        }

        #region Private Functions

        private string CreateNewPolicy()
        {
            House.HomeSelectPolicy();
            SetPolicyDetails();
            string premium = House.CheckPolicyPremium();
            return premium;
        }

        private void SetPolicyDetails()
        {
            House.HomeAcceptPolicy();
            House.HomeFinishQuote();
            House.HomeCloseOpenPolicyList();
            House.HomeOpenPolicy();
        }

        private void CreatePolicy(bool full)
        {
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeProposer();
            if (full)
            {
                House.HomeProposerFull();
            }
            else
            {
                House.HomeAddressLookup();
                House.HomeCreatePolicy();
            }

            House.PublicCreditCheckOk();
        }

        #endregion
    }
}