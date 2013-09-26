namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UINewPolicyDetailWindow : WinWindow
    {
        public UINewPolicyDetailWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            WindowTitles.Add("New Policy: AUTOAU1");
            WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        private const string WindowTitle = "New Policy: AUTOAU1";

        private const string WindowTitle2 = "Policy: autotest autotest";

        public UITestControl UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, instance: "13", className: "ThunderRT6UserControlDC");
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
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "15");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "13");
                }
                return mUIOKWindow;
            }
        }

        public UITestControl UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "24");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow11
        {
            get
            {
                if ((mUIItemWindow11 == null))
                {
                    mUIItemWindow11 = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return mUIItemWindow11;
            }
        }

        public UITestControl UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlId: "3");
                }
                return mUICancelWindow;
            }
        }

        public UITestControl UIItemWindow12
        {
            get
            {
                if ((mUIItemWindow12 == null))
                {
                    mUIItemWindow12 = new UIItemWindow(this, className: "ThunderRT6UserControlDC");
                }
                return mUIItemWindow12;
            }
        }

        #endregion

        #region Fields

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIOKWindow;

        private UITestControl mUIItemWindow2;

        private UIItemWindow mUIItemWindow11;

        private UITestControl mUICancelWindow;

        private UITestControl mUIItemWindow12;

        #endregion
    }
}