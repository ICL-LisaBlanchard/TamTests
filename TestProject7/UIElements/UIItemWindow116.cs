namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow116 : WinWindow
    {
        public UIItemWindow116(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";

            #endregion
        }

        #region Properties

        public WinClient UIClient
        {
            get
            {
                if ((this.mUICUSTOMERSClient == null))
                {
                    this.mUICUSTOMERSClient = new WinClient(this);
                }
                return this.mUICUSTOMERSClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUICUSTOMERSClient;

        #endregion
    }
}