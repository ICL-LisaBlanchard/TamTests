namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIProposerDetailsWindow : WinWindow
    {
        private const string WindowName = "Proposer Details";

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
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "2", instance: "2");
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
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "4");
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
                    mUIItemWindow3 = new UIItemWindow(this, controlId: "1");
                }
                return mUIItemWindow3;
            }
        }

        public UIItemWindow UILookupWindow
        {
            get
            {
                if ((mUILookupWindow == null))
                {
                    mUILookupWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUILookupWindow;
            }
        }

        public UIItemWindow UIItemWindow4
        {
            get
            {
                if ((mUIItemWindow4 == null))
                {
                    mUIItemWindow4 = new UIItemWindow(this, controlId: "7");
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
                    mUIItemWindow5 = new UIItemWindow(this, controlId: "5");
                }
                return mUIItemWindow5;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "12");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUILookupWindow;

        private UIItemWindow mUIItemWindow4;

        private UIItemWindow mUIItemWindow5;

        private UIItemWindow mUIOKWindow;

        #endregion

        public UIProposerDetailsWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Proposer Details";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(WindowName);

            #endregion
        }
    }
}