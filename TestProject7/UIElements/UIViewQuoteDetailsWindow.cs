namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIViewQuoteDetailsWindow : WinWindow
    {
        public UIViewQuoteDetailsWindow()
        {
            #region Search Criteria

            windowTitle = "View Quote Details";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemClient1 UIItemClient
        {
            get
            {
                if ((mUIItemClient == null))
                {
                    mUIItemClient = new UIItemClient1(this);
                }
                return mUIItemClient;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "5");
                }
                return mUIOKWindow;
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