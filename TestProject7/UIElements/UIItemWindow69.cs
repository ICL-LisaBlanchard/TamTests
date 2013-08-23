namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow69 : WinWindow
    {
        public UIItemWindow69(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.SearchProperties[UITestControl.PropertyNames.Instance] = "8";
            this.WindowTitles.Add("Amend Risk Results");

            #endregion
        }

        #region Properties

        public WinClient UIAmendRiskResultsClient
        {
            get
            {
                if ((this.mUIAmendRiskResultsClient == null))
                {
                    this.mUIAmendRiskResultsClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIAmendRiskResultsClient.WindowTitles.Add("Amend Risk Results");

                    #endregion
                }
                return this.mUIAmendRiskResultsClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIAmendRiskResultsClient;

        #endregion
    }
}