namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow118 : WinWindow
    {
        public UIItemWindow118(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Quotes Results");

            #endregion
        }

        #region Properties

        public WinClient UIClient
        {
            get
            {
                if ((this.mUIQuotesResultsClient == null))
                {
                    this.mUIQuotesResultsClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIQuotesResultsClient.WindowTitles.Add("Quotes Results");

                    #endregion
                }
                return this.mUIQuotesResultsClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIQuotesResultsClient;

        #endregion
    }
}