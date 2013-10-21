namespace AppliedSystems.Tam.Ui.Tests
{
    public class ExpectedAddress
    {
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }

        public ExpectedAddress(string addressLine1, string addressLine2)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
        }
    }
}
