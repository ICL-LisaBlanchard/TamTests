namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow29 : WinWindow
    {
        public UIItemWindow29(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public WinClient UIItemClient
        {
            get
            {
                if ((this.mUIItemClient == null))
                {
                    this.mUIItemClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIItemClient.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIItemClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIItemClient;

        #endregion
    }
}