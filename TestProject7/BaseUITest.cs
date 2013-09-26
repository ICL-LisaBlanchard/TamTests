﻿namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;

    using Meyn.TestLink;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class BaseUiTest
    {
        protected static TestLink Tl;

        protected static int TestPlanId;

        protected static int BuildId;

        protected readonly MotoActions Moto = new MotoActions();

        protected readonly HouseActions House = new HouseActions();

        protected readonly CustomerActions Customer = new CustomerActions();

        protected readonly DocumentsList Docs = new DocumentsList();

        protected string TestName;

        protected TestContext TestContextInstance;

        protected UIMap Map;

        public TestContext TestContext
        {
            get
            {
                return TestContextInstance;
            }
            set
            {
                TestContextInstance = value;
            }
        }

        public UIMap UiMap
        {
            get
            {
                if ((Map == null))
                {
                    Map = new UIMap();
                }

                return Map;
            }
        }

        [TestInitialize]
        [DeploymentItem(@"RegistrySettings")]
        public void StartTest()
        {
            // make sure everything is closed before another test is started
            CloseProcess("TamXML7");
            CloseProcess("InsureTam");
            CloseProcess("clntfile");
            CloseProcess("Homebase");
            CloseProcess("AcroRd32");
            CloseProcess("iexplore");
            CloseProcess("Regress_IETam_Policy");
            CloseProcess("RLoader");

            UiMap.CleanDocuments();
            Playback.PlaybackSettings.SearchTimeout = Configs.SearchTimeout;
            //Playback.PlaybackSettings.DelayBetweenActions = 700;
            TestName = TestContext.TestName;
            TestLinkInitialize();

            var login = new Login();
            login.LoginParams.ExePath = "J:\\WINTAM\\HOMEBASE.EXE";
            login.LoginParams.AlternateExePath = "J:\\WINTAM\\HOMEBASE.EXE";
            login.DoLogin();
            login.LoginEnterDate();
            login.WarningOk();
            UiMap.AppStartedExpectedValues.UITheAgencyManagerWindow1Name = "The Agency Manager";
        }

        [TestCleanup]
        public void FinishTest()
        {
            try
            {
                PostTestResult(TestContext.CurrentTestOutcome != UnitTestOutcome.Passed ? TestCaseResultStatus.Fail : TestCaseResultStatus.Pass);
            }
            catch
            {
                // do nothing
            }
            CloseProcess("TamXML7");
            CloseProcess("InsureTam");
            CloseProcess("clntfile");
            CloseProcess("Homebase");
            CloseProcess("AcroRd32");
            CloseProcess("iexplore");
            CloseProcess("Regress_IETam_Policy");
            CloseProcess("RLoader");
            CloseProcess("AppliedSystems.TAM.Client.Accounting.TransactionsUP");
        }

        public void SetOurHighwayRegKeys()
        {
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerLogin", "ourhighway");
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerPassword", "ourhighway");
        }

        public void SetOurMMaRegKeys()
        {
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerLogin", "ourmma");
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerPassword", "ourmma");
        }

        public void SetOfficeRegKeys()
        {
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerLogin", "office");
            RegistrySettings.WriteToRegistry("Software\\VB and VBA Program Settings\\WorkCentre\\Settings", "BrokerPassword", "office");
        }

        public static void CloseProcess(string name)
        {
            Process[] processes = Process.GetProcessesByName(name);
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                    process.WaitForExit();
                }
                catch (Exception)
                {
                }
            }
        }

        protected void TestLinkInitialize()
        {
            try
            {
                Tl = new TestLink("f71e80e4c23bba99dfedf1b442bb42f5", "http://172.30.2.44/testlink/lib/api/xmlrpc.php");
                TestPlanId = Tl.getTestPlanByName(Configs.ProjectName, Configs.PlanName).id;

                if (Tl.GetBuildsForTestPlan(TestPlanId).FirstOrDefault(x => x.name == Configs.BuildName) == null)
                {
                    Tl.CreateBuild(TestPlanId, Configs.BuildName, "Build created by script");
                }

                Build firstOrDefault = Tl.GetBuildsForTestPlan(TestPlanId).FirstOrDefault(x => x.name == Configs.BuildName);
                if (firstOrDefault != null)
                {
                    BuildId = firstOrDefault.id;
                }
            }
            catch
            {
                //
            }
        }

        protected void PostTestResult(TestCaseResultStatus status)
        {
            try
            {
                if (status == TestCaseResultStatus.Fail)
                {
                    long expectedDate = DateTime.Now.ToFileTimeUtc();
                    Image image = UITestControl.Desktop.CaptureImage();
                    image.Save(Configs.ScreenshotPath + expectedDate + ".jpg");
                    TestContextInstance.AddResultFile(Configs.ScreenshotPath + expectedDate + ".jpg");
                }
                Tl.ReportTCResult(Tl.GetTestCaseIDByName(TestName)[0].id, TestPlanId, status, Configs.PlatformId, buildid: BuildId); // it posts result for testcase.
            }
            catch
            {
                //
            }
        }

        protected static NameValueCollection GetTransactionDictionary(string premium, string originalPremium = "")
        {
            var dict = new NameValueCollection();
            if (!string.IsNullOrEmpty(originalPremium))
            {
                double oTax = double.Parse(originalPremium) * 0.06;
                dict.Add("NEW", originalPremium);
                dict.Add("TAX", oTax.ToString("0.00"));
            }
            double tax = double.Parse(premium) * 0.06;
            dict.Add("NEW", premium);
            dict.Add("TAX", tax.ToString("0.00"));
            return dict;
        }

        protected void RenewalModule(string customerCode, string policyType)
        {
            UiMap.RenewalModuleEDI();
            UiMap.RenewalModuleConfirm();
            UiMap.RenewalModuleEdi1(false);
            UiMap.RenewalModuleFilter(policyType);
            UiMap.RenewalModuleSort();
            UiMap.RenewalModuleDisplay(UiMap.CommonParams.SendHomeKeys);
            UiMap.RenewalCheckRecord(1, customerCode);
        }

        protected string RegressApp(string policyType)
        {
            UiMap.HighlightCustomer();
            string customerCode = UiMap.GetCustomerCode();
            UiMap.RegressApp(customerCode);
            UiMap.RegressAppPolicyTypeSelection(policyType);
            UiMap.RegressAppDate();
            UiMap.RegressAppFinish();
            UiMap.CloseRegressApp();
            return customerCode;
        }

        protected void RenewalLoader()
        {
            UiMap.RenewalLoaderOpen();
            UiMap.RenewalLoaderRun();
            UiMap.CloseBrowser();
            UiMap.RenewalLoaderClose();
        }

        protected void SiteForRenewal(string policyNumber, string policyType, string renewalPremium)
        {
            UiMap.OpenBrowser2();
            if (policyType == "Household")
            {
                House.HomeSiteRenewal(policyNumber, renewalPremium);
            }
            else
            {
                Moto.MotoCreateSiteRenewal(policyNumber, renewalPremium);
            }

            Playback.Wait(5000);
            UiMap.CloseBrowser();
            UiMap.ChangeDatePolicy();
        }

        protected void Renewals(string policyNumber, string policyType, string renewalPremium)
        {
            //site for renewal
            SiteForRenewal(policyNumber, policyType, renewalPremium);

            //regress app
            string customerCode = RegressApp(policyType);

            //renewal loader
            RenewalLoader();

            // renewal module
            RenewalModule(customerCode, policyType);
        }

        protected void RenewalsInvite(bool selectAlternative)
        {
            House.RenewalModuleInvite(selectAlternative);
            House.RenewConfirmInvite();
            House.RenewalModuleInvite1();
            House.RenewalModuleRenew();
            House.RetrieveResponse();
            House.RenewalModuleRenew1();
            House.RenewalModuleClose();
        }
    }
}