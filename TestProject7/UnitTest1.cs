namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        private readonly HouseActions house = new HouseActions();

        private readonly MotoActions moto = new MotoActions();

        [TestMethod]
        public void TestMethod1()
        {
            WinClient uIQuotesResultsClient = this.house.UIQuotesResultsWindow.UIItemWindow.UIClient();

            UITestControlCollection x = uIQuotesResultsClient.GetChildren();

            UITestControlCollection y = x[0].GetChildren();
            UITestControl z = y[3];

            Console.Write(z.FilterProperties);

            foreach (UITestControl v in x[0].GetChildren())
            {
                Console.Write(v.Name);
            }
        }
    }
}