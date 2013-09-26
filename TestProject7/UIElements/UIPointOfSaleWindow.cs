namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPointOfSaleWindow : WinWindow
    {
        public UIPointOfSaleWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = WindowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(WindowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIDeferPrintingWindow
        {
            get
            {
                if ((mUIDeferPrintingWindow == null))
                {
                    mUIDeferPrintingWindow = new UIItemWindow(this, controlId: "3");
                }
                return mUIDeferPrintingWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIOKWindow;
            }
        }

        public UIClient UIPointOfSaleClient
        {
            get
            {
                return new UIClient(this, WindowTitle);
            }
        }

        #endregion

        #region Fields

        private const string WindowTitle = "Point Of Sale";

        private UIItemWindow mUIDeferPrintingWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}