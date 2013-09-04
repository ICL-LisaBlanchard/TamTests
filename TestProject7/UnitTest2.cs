namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest2 : BaseUiTest
    {
        private readonly HouseActions house = new HouseActions();

        [TestMethod]
        public void TestMethod()
        {
            Playback.PlaybackSettings.SearchTimeout = 15000;
            this.house.HomeAcceptPolicy();
        }
    }
}