namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        private readonly HouseActions house = new HouseActions();

        private readonly MotoActions moto = new MotoActions();

        private readonly DocumentsList docs = new DocumentsList();

        [TestMethod]
        public void TestMethod1()
        {
            this.house.LapsePolicy("81588888002067");
            this.house.RenewalModuleClose();
            this.moto.CloseAndOpenPolicyList();
            this.house.RenewalCheckStatus("LAP");
            this.house.ClosePolicy();
        }
    }
}