namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIBillingScreenWindow : WinWindow
    {
        public UIBillingScreenWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            windowName1 = "Policy: autotest";
            WindowTitles.Add(windowName1);
            windowName2 = "Transaction: autotest";
            WindowTitles.Add(windowName2);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return mUIItemWindow;
            }
        }

        public UITestControl UIDetailWindow
        {
            get
            {
                if ((mUIDetailWindow == null))
                {
                    mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIDetailWindow;
            }
        }

        public UIItemWindow UIPolicyDocumentsWindow
        {
            get
            {
                return new UIItemWindow(this, "2");
            }
        }

        public UIItemWindow UICancelWindow
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

        public UITestControl UICancelWindow1
        {
            get
            {
                if ((mUICancelWindow1 == null))
                {
                    mUICancelWindow1 = new UIItemWindow(this, controlId: "8");
                }
                return mUICancelWindow1;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "13");
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
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "18");
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
                    mUIItemWindow3 = new UIItemWindow(this, controlId: "2", instance: "3");
                }
                return mUIItemWindow3;
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

        #endregion

        #region Fields

        private readonly string windowName1;

        private readonly string windowName2;

        private UIItemWindow mUIItemWindow;

        private UITestControl mUIDetailWindow;

        private UIItemWindow mUICancelWindow;

        private UITestControl mUICancelWindow1;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}