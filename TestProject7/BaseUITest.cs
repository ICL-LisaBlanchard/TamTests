namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;

    using Meyn.TestLink;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class BaseUiTest
    {
        protected readonly MotoActions Moto = new MotoActions();

        protected readonly HouseActions House = new HouseActions();

        protected readonly CustomerActions Customer = new CustomerActions();

        protected readonly DocumentsList Docs = new DocumentsList();

        protected const string PlanName = "Ver. 12.05";

        protected const string ProjectName = "TAM";

        //private static string buildName = DateTime.Now.Date.ToShortDateString();

        //private const int PlatformId = 3;  // WIN XP
        //private const int PlatformId = 4;   // Win7 32
        protected const int PlatformId = 5; // Win7 64

        protected static string BuildName = "InsureTam.exe v4.0.8 May";

        protected static TestLink Tl;

        protected static int TestPlanId;

        protected static int BuildId;

        protected string TestName;

        protected TestContext TestContextInstance;

        protected UIMap Map;

        public TestContext TestContext
        {
            get
            {
                return this.TestContextInstance;
            }
            set
            {
                this.TestContextInstance = value;
            }
        }

        public UIMap UiMap
        {
            get
            {
                if ((this.Map == null))
                {
                    this.Map = new UIMap();
                }

                return this.Map;
            }
        }

        [TestInitialize]
        [DeploymentItem(@"RegistrySettings")]
        public void StartTest()
        {
            this.UiMap.CleanDocuments();
            Playback.PlaybackSettings.SearchTimeout = 30000;
            this.TestName = this.TestContext.TestName;
            this.TestLinkInitialize();

            var login = new Login();
            login.LoginParams.TabKey = Playback.EncryptText("PLUS");
            login.LoginParams.ExePath = "J:\\WINTAM\\HOMEBASE.EXE";
            login.LoginParams.AlternateExePath = "J:\\WINTAM\\HOMEBASE.EXE";
            login.DoLogin();
            login.LoginEnterDate();
            login.WarningOk();
            this.UiMap.AppStartedExpectedValues.UITheAgencyManagerWindow1Name = "The Agency Manager";
        }

        [TestCleanup]
        public void FinishTest()
        {
            try
            {
                this.PostTestResult(this.TestContext.CurrentTestOutcome != UnitTestOutcome.Passed ? TestCaseResultStatus.Fail : TestCaseResultStatus.Pass);
            }
            catch
            {
                // do nothing
            }
            CloseProcess("TamXML7");
            CloseProcess("InsureTam");
            CloseProcess("clntfile");
            CloseProcess("Homebase");
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
                process.Kill();
                process.WaitForExit();
            }
        }

        protected void TestLinkInitialize()
        {
            try
            {
                Tl = new TestLink("f71e80e4c23bba99dfedf1b442bb42f5", "http://172.30.2.44/testlink/lib/api/xmlrpc.php");
                TestPlanId = Tl.getTestPlanByName(ProjectName, PlanName).id;

                if (Tl.GetBuildsForTestPlan(TestPlanId).FirstOrDefault(x => x.name == BuildName) == null)
                {
                    Tl.CreateBuild(TestPlanId, BuildName, "Build created by script");
                }

                Build firstOrDefault = Tl.GetBuildsForTestPlan(TestPlanId).FirstOrDefault(x => x.name == BuildName);
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
                Tl.ReportTCResult(Tl.GetTestCaseIDByName(this.TestName)[0].id, TestPlanId, status, PlatformId, buildid: BuildId); // it posts result for testcase.
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
            this.UiMap.RenewalModuleEDI();
            this.UiMap.RenewalModuleConfirm();
            this.UiMap.RenewalModuleEdi1(false);
            this.UiMap.RenewalModuleFilter(policyType);
            this.UiMap.RenewalModuleSort();
            this.UiMap.RenewalModuleDisplay(this.UiMap.CommonParams.SendHomeKeys);
            this.UiMap.RenewalCheckRecord(1, customerCode);
        }

        protected string RegressApp(string policyType)
        {
            this.UiMap.HighlightCustomer();
            string customerCode = this.UiMap.GetCustomerCode();
            this.UiMap.RegressApp(customerCode);
            this.UiMap.RegressAppPolicyTypeSelection(policyType);
            this.UiMap.RegressAppDate();
            this.UiMap.RegressAppFinish();
            this.UiMap.CloseRegressApp();
            return customerCode;
        }

        protected void RenewalLoader()
        {
            this.UiMap.RenewalLoaderOpen();
            this.UiMap.RenewalLoaderRun();
            this.UiMap.CloseBrowser();
            this.UiMap.RenewalLoaderClose();
        }

        protected void SiteForRenewal(string policyNumber, string policyType, string renewalPremium)
        {
            this.UiMap.OpenBrowser2();
            if (policyType == "Household")
            {
                this.House.HomeSiteRenewal(policyNumber, renewalPremium);
            }
            else
            {
                this.Moto.MotoCreateSiteRenewal(policyNumber, renewalPremium);
            }
            
            Playback.Wait(5000);
            this.UiMap.CloseBrowser();
            this.UiMap.ChangeDatePolicy();
        }

        protected void Renewals(string policyNumber, string policyType, string renewalPremium)
        {
            //site for renewal
            this.SiteForRenewal(policyNumber, policyType, renewalPremium);

            //regress app
            string customerCode = this.RegressApp(policyType);

            //renewal loader
            this.RenewalLoader();   

            // renewal module
            this.RenewalModule(customerCode, policyType);
        }

        protected void RenewalsInvite(bool selectAlternative)
        {
            this.House.RenewalModuleInvite(selectAlternative);
            this.House.RenewConfirmInvite();
            this.House.RenewalModuleInvite1();
            this.House.RenewalModuleRenew();
            this.House.RetrieveResponse();
            this.House.RenewalModuleRenew1();
            this.House.RenewalModuleClose();
        }
    }
}