﻿namespace AppliedSystems.Tam.Ui.Tests
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [CodedUITest]
    public class UnitTest1
    {
        private readonly HouseActions house = new HouseActions();

        private readonly MotoActions moto = new MotoActions();

        [TestMethod]
        public void TestMethod1()
        {
            this.moto.MotoAwap();
            this.moto.MotoCloseAndOpenPolicyList();
            this.moto.HighlightBillingScreen();
            this.moto.MotoCheckAWAPpremium();
        }
    }
}