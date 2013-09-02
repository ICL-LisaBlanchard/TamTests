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

            this.SearchProperties[UITestControl.PropertyNames.Name] = WindowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIDeferPrintingWindow
        {
            get
            {
                if ((this.mUIDeferPrintingWindow == null))
                {
                    this.mUIDeferPrintingWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUIDeferPrintingWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIOKWindow;
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