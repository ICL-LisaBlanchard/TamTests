namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow25 : WinWindow
    {
        public UIItemWindow25(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "10";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinClient UIQuoteResultsClient
        {
            get
            {
                if ((this.mUIQuoteResultsClient == null))
                {
                    this.mUIQuoteResultsClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIQuoteResultsClient.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIQuoteResultsClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIQuoteResultsClient;

        #endregion
    }
}