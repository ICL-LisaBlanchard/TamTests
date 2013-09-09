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

            this.SearchProperties[UITestControl.PropertyNames.Name] = WindowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowName);

            #endregion
        }

        #region Properties

        private const string WindowName = "Vehicle Lookup";

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "9");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIFilterWindow
        {
            get
            {
                if ((this.mUIFilterWindow == null))
                {
                    this.mUIFilterWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIFilterWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "18");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIItemWindow1;
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
                if ((this.mUIStandardLookupWindow == null))
                {
                    this.mUIStandardLookupWindow = new UIItemWindow(this, "6");
                }
                return this.mUIStandardLookupWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, "13");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow(this, "15");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow(this, "14");
                }
                return this.mUIItemWindow4;
            }
        }

        public UIItemWindow UIItemWindow5
        {
            get
            {
                if ((this.mUIItemWindow5 == null))
                {
                    this.mUIItemWindow5 = new UIItemWindow(this, "11");
                }
                return this.mUIItemWindow5;
            }
        }

        public UIItemWindow UIItemWindow6
        {
            get
            {
                if ((this.mUIItemWindow6 == null))
                {
                    this.mUIItemWindow6 = new UIItemWindow(this, "12");
                }
                return this.mUIItemWindow6;
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