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
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            string premium = House.CreateNewPolicy();

            var passed = House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash"));
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHhNewBusinessQuote, "cash");

            Assert.IsTrue(passed, "Failed on getting premium");
        }

        [TestMethod]
        public void HouseSaveQuoteWithoutPremium()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeExitWithoutPolicy();
            House.CloseOpenPolicy();
            House.HomeClickPremium();
            House.HomeCheckZeroPremium();
            House.HomeExitWithPolicy();
            House.HomeCheckPremium();
            House.HomePrintQuote();
            House.SelectMenu();
            House.HomePrintQuote1();
            House.HomeAcceptQuote();
            House.CancelPrint();
            House.HomeAcceptQuote1();
            House.CloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.CheckPolicyPremium("cash");
        }

        [TestMethod]
        public void HouseOverridePremium()
        {
            const int OverridePremium = 19999;
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeChangePremium(OverridePremium);
            House.SetPolicyDetails();
            House.HomeCheckNewPremium();

            House.OpenTransList(Transactions.GetTransactionDictionary("18866.98", "cash"));
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHhNewBusinessQuote, "cash", OverridePremium);
        }

        [TestMethod]
        public void HouseCopyRiskNew()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            House.HomeCopyRisk();
            House.HomeCopyCheckData();
            House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseCopyRiskQTE()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeExitWithoutPolicy();
            House.CloseOpenPolicyList();
            House.HomeCopyRisk();
            House.HomeCopyCheckData();
            House.HomeCancelCopy();
        }

        [TestMethod]
        public void HouseMTAExit()
        {
            SetOfficeRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
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
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
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
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
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
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            //MTA
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            string coverDate = "HouseMTAtoMTA_" + House.HomeMTACoverDate();
            House.HomeMTASelectQuote();
            //new MTA
            House.HomeOpenQuote();
            House.HomeMTAChangeParams.UIItemEditText = "NewestMTA";
            House.HomeMTAChange();
            House.HomeResubmitQuote(true, coverDate);

            House.HomeMTAEnterDate("30/09/12");
            House.HomeMTACoverDate();
            House.HomeMTACheckMessage();
            House.EtamOk(true);
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
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            //cancel policy
            House.HomeOpenQuote();
            House.HomeCancelPolicy();
            House.HomeCancelPolicyQuote();

            House.HomeMTAEnterDate();
            House.HomeCancelPolicyQuote1();
            House.HomeCancelPolicyExit();
            //check status
            House.CloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.HomeCheckStatusExpectedValues.UIItemEditText = "NEW";
            House.HomeCheckStatus();
        }

        [TestMethod]
        public void HouseCancelAccept()
        {
            SetOfficeRegKeys();
            //add policy
            UiMap.CustomerCode = Customer.AddPolicy();
            House.CreatePolicy(false);
            House.HomeSelectPolicy();
            House.HomeAcceptPolicy("cash");
            House.HomeFinishQuote();
            House.CloseOpenPolicyList();
            //cancel policy
            House.HomeOpenQuote();
            House.HomeCancelPolicy();
            House.HomeCancelPolicyQuote();
            House.HomeMTAEnterDate();
            House.HomeCancelPolicyQuote1();
            House.HomeCancelPolicyAccept();
            //check status
            House.CloseOpenPolicyList();
            House.HomeOpenPolicy();
            House.HomeCheckStatusExpectedValues.UIItemEditText = "CAN";
            House.HomeCheckStatus();
            House.CheckCorrectNumberTrans(2);
            House.CheckCorrectDocumentPresent(Docs.DocumentsForHhAcceptQuoteCancel);
        }

        [TestMethod]
        public void HouseRenewalBefore()
        {
            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();

            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            House.SetPolicyDetails();
            string originalPremium = House.CheckPolicyPremium("cash");
            string policyNumber = Moto.GetPolicyNumber();

            //site for renewal
            House.OpenBrowser();
            House.HomeSiteRenewal(policyNumber, RenewalPremium, InsurerName);
            Playback.Wait(5000);
            House.CloseBrowser();
            House.ChangeDatePolicy();

            //regress app
            RegressApp(PolicyType);

            //renewal loader
            RenewalLoader();

            //  renewal module
            RenewalModule(UiMap.CustomerCode, PolicyType);
            RenewalsInvite(false);

            House.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REN");
            var premium = House.CheckPolicyPremium("cash");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHhRenewalBefore, "cash", originalPremium: double.Parse(originalPremium));
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalPremium));
            House.ClosePolicy();

            //mta1
            House.HomeOpenQuote();
            House.HomeMTABefore();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.AddDays(2).ToString("dd/MM/yy"));
            House.HomeRenewalBeforeAccept();
            House.HomeRenewalCancelledCheck();
            House.HomeRenewalBeforeFinish();

            ////mta2
            House.HomeOpenQuote();
            House.EtamYes();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.EtamOk(true);

            House.MTADate(DateTime.Now.AddDays(10).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.EtamOk(true);
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRenewalAfter()
        {
            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();

            ////MTA1
            House.HomeOpenQuote();
            House.HomeMTAAfter();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            House.HomeMTASelectQuote();

            //MTA2
            House.HomeOpenQuote();
            House.HomeMTAAfter();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.EtamOk(true);
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();

            //MTA3
            House.HomeOpenQuote();
            House.HomeMTABefore();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);

            House.MTADate(DateTime.Now.AddDays(9).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.EtamOk(true);

            House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            House.HomeRenewalBeforeAccept();
            House.HomeRenewalBeforeFinish();

            //mta4
            House.HomeOpenQuote();
            House.EtamYes();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.EtamOk(true);
            House.MTADate(DateTime.Now.AddDays(11).ToString("dd/MM/yy"));
            Moto.MotoMTAMessageAfterDate();
            House.EtamOk(true);
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseAmendRiskExistingScheme()
        {
            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            House.CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();
            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeAmendRisk();
            House.PublicCreditCheckOk();
            House.HomeAmendSelecPolicy(false);
            House.HomeAmendRenew();
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseAmendRiskNewScheme()
        {
            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            House.SetPolicyDetails();
            string originalpremium = House.CheckPolicyPremium("cash");
            string policyNumber = House.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeAmendRisk();
            House.PublicCreditCheckOk();
            House.HomeAmendSelecPolicy(true);
            House.HomeAmendRenewFinish();

            Playback.Wait(60000);

            House.LapseOk();

            Playback.Wait(60000);


            House.RenewalModuleClose();


            House.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium("cash");
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalpremium));
            House.RenewalCheckStatus("REW");
            House.ClosePolicy();

            //MTA1
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.AddDays(1).ToString("dd/MM/yy"));
            House.AmendDateBeforeMessage();
            House.EtamOk(true);
            House.MTADate(DateTime.Now.AddDays(14).ToString("dd/MM/yy"));
            House.HomeMTASelectQuote();

            //MTA2
            House.HomeOpenQuote();
            House.HomeMTAChange();
            House.HomeResubmitQuote(false);
            House.MTADate(DateTime.Now.AddDays(13).ToString("dd/MM/yy"));
            House.MTAMessageBeforeCurrent();
            House.EtamOk(true);
            House.MTAEffectiveDatesCancel();
            House.HomeMTACancel1();
        }

        [TestMethod]
        public void HouseRebrokeRenewCurrent()
        {

            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();

            House.HomeStartDate();

            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeCurrent();
            RenewalsInvite(false);
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REN");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewExistingScheme()
        {
            // change registry to ourhighway
            SetOurAxaRegKeys();
            //add policy
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();
            House.HomeSelectPolicy();
            House.SetPolicyDetails();

            string policyNumber = Moto.GetPolicyNumber();
            string originalpremium = House.CheckPolicyPremium("cash");
            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeSelectPolicy(House.CommonParams.SendHomeKeys);
            House.HomeRebrokeSelectAlternative();
            House.HomeRebrokeFinish();
            House.ImportToTamOptionsOnce("");
            House.RenewalModuleInvite(false);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();

            House.RebrokeAlternativeRenew("cash");
            //House.EtamOk(true);
            //house.LapseOk();
            House.EtamYes();
            House.ConfirmDocuments();
            House.ContinueToRetrieveResponse();
            House.RebrokeAlternativeRenew1();
            House.RenewalModuleClose();
            House.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("REW");
            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium("cash");
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalpremium));
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseRebrokeRenewNewScheme()
        {
            // change registry to ourhighway
            SetOurAxaRegKeys();

            //add policy
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            string originalpremium = House.CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.HomeRebroke();
            House.PublicCreditCheckOk();
            House.HomeRebrokeSelectPolicy(House.CommonParams.SendEndKeys);
            House.HomeRebrokeSelectAlternative();
            House.HomeRebrokeFinish();
            House.ImportToTamOptionsOnce("");
            House.RenewalModuleInvite(false);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.RebrokeAlternativeRenew("cash");
            House.EtamOk(true);
            House.EtamYes();
            House.ConfirmDocuments();
            House.ContinueToRetrieveResponse();
            House.RebrokeAlternativeRenew1();
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);

            House.CheckPremiumInQuoteDocument(this.Docs.DocumentsForHouseAmendRiskNewScheme, "cash", originalPremium: double.Parse(originalpremium));
            string premium = House.CheckPolicyPremium("cash");
            House.OpenTransList(Transactions.GetTransactionDictionary(premium, "cash", originalpremium));
            House.RenewalCheckStatus("REW");
            House.ClosePolicy();
        }

        [TestMethod]
        public void HouseLapsePolicy()
        {
            SetOurAxaRegKeys();
            UiMap.CustomerCode = Customer.AddPolicy();
            House.SelectHomeType();
            House.SelectMenu();
            House.Links();
            House.HomeStartDate();
            House.HomeProposer();
            House.HomeCreatePolicy();
            House.PublicCreditCheckOk();

            House.CreateNewPolicy();
            string policyNumber = Moto.GetPolicyNumber();

            Renewals(policyNumber, PolicyType, RenewalPremium);

            House.RenewalModuleInvite(false);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.LapsePolicy(policyNumber);
            House.RenewalModuleClose();
            Moto.CloseAndOpenPolicyList(UiMap.CustomerCode);
            House.RenewalCheckStatus("LAP");
            House.ClosePolicy();
        }
    }
}