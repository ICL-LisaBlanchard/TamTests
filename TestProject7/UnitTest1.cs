namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
    using System.Diagnostics;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        private readonly HouseActions House = new HouseActions();

        private readonly MotoActions moto = new MotoActions();

        private readonly DocumentsList Docs = new DocumentsList();

        [TestMethod]
        public void TestMethod1()
        {

            BaseUiTest.CloseProcess("AcroRd32");
        }
    }
}