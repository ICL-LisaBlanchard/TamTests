namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIETAMRenewalsWindow : WinWindow
    {
        public UIIETAMRenewalsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines Renewals";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.windowName = "IETAM Renewals";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}