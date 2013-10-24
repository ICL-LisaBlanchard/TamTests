
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;

    [CodedUITest]
    public class UnitTest1
    {
        protected readonly MotoActions Moto = new MotoActions();
        protected readonly HouseActions House = new HouseActions();
        protected readonly UIMap UiMap = new UIMap();
        protected readonly DocumentsList Docs = new DocumentsList();

        [TestMethod]
        public void TestMethod1()
        {
            UiMap.RenewalModuleEDI();
            UiMap.RenewalModuleConfirm();
            UiMap.RenewalModuleEdi1(false);
            UiMap.RenewalModuleFilter("Household");
            UiMap.RenewalModuleSort();
            UiMap.RenewalModuleDisplay(UiMap.CommonParams.SendHomeKeys);
            UiMap.RenewalCheckRecord(1, "AUTO201");
        }

        private TestContext testContextInstance;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
    }
}
