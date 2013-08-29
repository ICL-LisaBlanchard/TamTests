namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPaymentMethodsWindow : WinWindow
    {
        public UIPaymentMethodsWindow()
        {
            #region Search Criteria

            this.windowTitle = "Payment Methods";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

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

        private UIItemWindow mUIOKWindow;

        private string windowTitle;

        #endregion
    }
}