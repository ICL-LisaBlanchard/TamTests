namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIVehicleLookupWindow : WinWindow
    {
        public UIVehicleLookupWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = WindowName;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(WindowName);

            #endregion
        }

        #region Properties

        private const string WindowName = "Vehicle Lookup";

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "9");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIFilterWindow
        {
            get
            {
                if ((mUIFilterWindow == null))
                {
                    mUIFilterWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIFilterWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "18");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "10");
                }
                return mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIFilterWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow1;

        #endregion

        #region Properties

        public UIItemWindow UIStandardLookupWindow
        {
            get
            {
                if ((mUIStandardLookupWindow == null))
                {
                    mUIStandardLookupWindow = new UIItemWindow(this, "6");
                }
                return mUIStandardLookupWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, "13");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((mUIItemWindow3 == null))
                {
                    mUIItemWindow3 = new UIItemWindow(this, "15");
                }
                return mUIItemWindow3;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((mUIItemWindow4 == null))
                {
                    mUIItemWindow4 = new UIItemWindow(this, "14");
                }
                return mUIItemWindow4;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((mUIItemWindow5 == null))
                {
                    mUIItemWindow5 = new UIItemWindow(this, "11");
                }
                return mUIItemWindow5;
            }
        }

        public UIItemWindow UIItemWindow6
        {
            get
            {
                if ((mUIItemWindow6 == null))
                {
                    mUIItemWindow6 = new UIItemWindow(this, "12");
                }
                return mUIItemWindow6;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIStandardLookupWindow;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIItemWindow4;

        private UIItemWindow mUIItemWindow5;

        private UIItemWindow mUIItemWindow6;

        #endregion
    }
}