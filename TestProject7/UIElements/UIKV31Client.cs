namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIKV31Client : WinClient
    {
        public UIKV31Client(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.WindowTitles.Add("KV31");

            #endregion
        }

        #region Properties

        public WinClient UIЗапоClient
        {
            get
            {
                if ((this.mUIЗапоClient == null))
                {
                    this.mUIЗапоClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIЗапоClient.SearchProperties[UITestControl.PropertyNames.Name] = "запо";
                    this.mUIЗапоClient.WindowTitles.Add("KV31");

                    #endregion
                }
                return this.mUIЗапоClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIЗапоClient;

        #endregion
    }
}