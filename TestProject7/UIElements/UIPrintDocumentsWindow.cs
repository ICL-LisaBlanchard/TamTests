namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPrintDocumentsWindow : WinWindow
    {
        public UIPrintDocumentsWindow()
        {
            #region Search Criteria

            this.windowTitle = "Print Documents";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIDeferPrintingWindow
        {
            get
            {
                if ((this.mUIDeferPrintingWindow == null))
                {
                    this.mUIDeferPrintingWindow = new UIItemWindow(this, controlId: "4");
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

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIDeferPrintingWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}