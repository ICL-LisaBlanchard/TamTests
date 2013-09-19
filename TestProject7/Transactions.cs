namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Collections.Generic;

    public class Transactions
    {
        public static List<Transaction> GetTransactionDictionary(string premium, string originalPremium = "")
        {
            var dict = new List<Transaction>();
            double tax = double.Parse(premium) * 0.06;

            dict.Add(new Transaction { TransType = "TAX", Premium = tax.ToString("0.00") });
            dict.Add(new Transaction { TransType = "NEW", Premium = premium });

            if (!string.IsNullOrEmpty(originalPremium))
            {
                double oTax = double.Parse(originalPremium) / 100 * 6;

                dict.Add(new Transaction { TransType = "TAX", Premium = oTax.ToString("0.00") });
                dict.Add(new Transaction { TransType = "NEW", Premium = originalPremium });
            }
            return dict;
        }
    }

    public class Transaction
    {
        public string TransType { get; set; }

        public string Premium { get; set; }
    }
}