namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIFilterRenewalRecordsWindow : WinWindow
    {
        public UIFilterRenewalRecordsWindow()
        {
            #region Search Criteria

            windowName = "Filter Renewal Records";
            SearchProperties[UITestControl.PropertyNames.Name] = windowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "3");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "16");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "7");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}