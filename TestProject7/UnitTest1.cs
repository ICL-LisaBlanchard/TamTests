
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UITesting;

    [CodedUITest]
    public class UnitTest1
    {
        protected readonly MotoActions Moto = new MotoActions();
        [TestMethod]
        public void TestMethod1()
        {
            Moto.CustomerCode = "AUTO120";
            Moto.CloseAndOpenPolicyList();
        }
    }
}
