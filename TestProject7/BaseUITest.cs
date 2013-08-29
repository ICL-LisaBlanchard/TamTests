namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Diagnostics;
    using System.Linq;

    using Meyn.TestLink;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class BaseUiTest
    {
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
    }
}