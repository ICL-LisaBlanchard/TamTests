namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow91 : WinWindow
    {
        public UIItemWindow91(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "SSTabCtlWndClass";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinClient UIHouseholdQuoteClient
        {
            get
            {
                if ((this.mUIHouseholdQuoteClient == null))
                {
                    this.mUIHouseholdQuoteClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIHouseholdQuoteClient.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIHouseholdQuoteClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIHouseholdQuoteClient;

        #endregion
    }
}