namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPaymentMethodsWindow : WinWindow
    {
        public UIPaymentMethodsWindow()
        {
            #region Search Criteria

            windowTitle = "Payment Methods";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIDirectDebitWindow
        {
            get
            {
                if ((this.mUIDirectDebitWindow == null))
                {
                    this.mUIDirectDebitWindow = new UIItemWindow(this, controlId:"9");
                }
                return this.mUIDirectDebitWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIDirectDebitWindow;

        #endregion
    }
}