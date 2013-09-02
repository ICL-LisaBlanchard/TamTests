namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        private readonly HomeActions home = new HomeActions();

        [TestMethod]
        public void TestMethod1()
        {
            this.home.HomeProposer();
        }
    }
}