namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Linq;

    using Meyn.TestLink;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Setup
    {
        private const string PlanName = "Ver. 1205";
        private const string ProjectName = "TAM";

        private static string buildName = DateTime.Now.Date.ToShortDateString();
        //private static string buildName = "test build";
        private static TestLink tl;
        private static int testPlanId;
        private static int buildId;
        public TestContext TestContext { get; set; }
        public string TestName { get; set; }



        [TestCleanup]
        public virtual void Teardown()
        {
            try
            {
                if (this.TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
                {
                    this.PostTestResult(TestCaseResultStatus.Fail);
                }
                else
                {
                    this.PostTestResult(TestCaseResultStatus.Pass);
                }
            }
            catch (Exception)
            {
                // do nothing
            }
        }

        protected void PostTestResult(TestCaseResultStatus status)
        {
            try
            {
                tl.ReportTCResult(
                    tl.GetTestCaseIDByName(this.TestName)[0].id,
                    testPlanId,
                    status,
                    buildid: buildId); // it posts result for testcase.
            }
            catch (Exception ex)
            {
                //
            }
        }

        protected void TestLinkInitialize()
        {
            try
            {
                tl = new TestLink("f71e80e4c23bba99dfedf1b442bb42f5", "http://172.30.2.44/testlink/lib/api/xmlrpc.php");
                testPlanId = tl.getTestPlanByName(ProjectName, PlanName).id;

                if (tl.GetBuildsForTestPlan(testPlanId).FirstOrDefault(x => x.name == buildName) == null)
                {
                    tl.CreateBuild(testPlanId, buildName, "Build created by script");
                }

                buildId = tl.GetBuildsForTestPlan(testPlanId).FirstOrDefault(x => x.name == buildName).id;
            }
            catch (Exception ex)
            {
                //
            }
        }

    }
}
