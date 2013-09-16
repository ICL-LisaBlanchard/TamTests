namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Collections.Generic;

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
            string premium = this.moto.CheckPolicyPremium();
            this.moto.OpenTransList(GetTransactionDictionary(premium));
            this.moto.CheckPremiumInQuoteDocument(this.docs.DocumentsForMotoNewBusinessQuote);
        }

        protected static Dictionary<string, string> GetTransactionDictionary(string premium)
        {
            double tax = double.Parse(premium) * 0.06;
            var dict = new Dictionary<string, string>();
            dict.Add("NEW", premium);
            dict.Add("TAX", tax.ToString("0.00"));
            return dict;
        }
    }
}