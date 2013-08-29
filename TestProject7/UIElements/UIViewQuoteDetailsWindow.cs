namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIViewQuoteDetailsWindow : WinWindow
    {
        public UIViewQuoteDetailsWindow()
        {
            #region Search Criteria

            this.windowTitle = "View Quote Details";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemClient1 UIItemClient
        {
            get
            {
                if ((this.mUIItemClient == null))
                {
                    this.mUIItemClient = new UIItemClient1(this);
                }
                return this.mUIItemClient;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "5");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemClient1 mUIItemClient;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}