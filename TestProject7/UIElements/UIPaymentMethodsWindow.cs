namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPaymentMethodsWindow : WinWindow
    {
        public UIPaymentMethodsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Payment Methods";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Payment Methods");

            #endregion
        }

        #region Properties

        public UIOKWindow14 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow14(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow14 mUIOKWindow;

        #endregion
    }
}