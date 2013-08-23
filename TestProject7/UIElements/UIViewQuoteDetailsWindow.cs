namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIViewQuoteDetailsWindow : WinWindow
    {
        public UIViewQuoteDetailsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "View Quote Details";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("View Quote Details");

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

        public UIOKWindow18 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow18(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemClient1 mUIItemClient;

        private UIOKWindow18 mUIOKWindow;

        #endregion
    }
}