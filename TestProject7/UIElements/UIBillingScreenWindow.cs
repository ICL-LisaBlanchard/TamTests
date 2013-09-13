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

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.windowName1 = "Policy: autotest";
            this.WindowTitles.Add(this.windowName1);
            this.windowName2 = "Transaction: autotest";
            this.WindowTitles.Add(this.windowName2);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return this.mUIItemWindow;
            }
        }

        public UITestControl UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIDetailWindow;
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
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUICancelWindow;
            }
        }

        public UITestControl UICancelWindow1
        {
            get
            {
                if ((this.mUICancelWindow1 == null))
                {
                    this.mUICancelWindow1 = new UIItemWindow(this, controlId: "8");
                }
                return this.mUICancelWindow1;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "13");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "18");
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
                    this.mUIItemWindow3 = new UIItemWindow(this, controlId: "2", instance: "3");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "13");
                }
                return this.mUIOKWindow;
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