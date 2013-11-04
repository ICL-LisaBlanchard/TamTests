namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIQuoteResultsWindow : WinWindow
    {
        private const string WindowName = "Quote Results";

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, instance: "11", className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIAcceptWindow
        {
            get
            {
                if ((mUIAcceptWindow == null))
                {
                    mUIAcceptWindow = new UIItemWindow(this, controlId: "5");
                }
                return mUIAcceptWindow;
            }
        }

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((mUIExitWindow == null))
                {
                    mUIExitWindow = new UIItemWindow(this, controlId: "4");
                }
                return mUIExitWindow;
            }
        }

        public UIItemWindow UIPrintQuoteWindow
        {
            get
            {
                if ((mUIPrintQuoteWindow == null))
                {
                    mUIPrintQuoteWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIPrintQuoteWindow;
            }
        }

        public UIItemWindow UIDemandsNeedsWindow
        {
            get
            {
                if ((mUIDemandsNeedsWindow == null))
                {
                    mUIDemandsNeedsWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIDemandsNeedsWindow;
            }
        }

        public UIItemWindow UIAWAPWindow
        {
            get
            {
                if ((mUIAWAPWindow == null))
                {
                    mUIAWAPWindow = new UIItemWindow(this, controlId: "3");
                }
                return mUIAWAPWindow;
            }
        }

        public UIItemWindow UIPremiumWindow
        {
            get
            {
                if ((mUIPremiumWindow == null))
                {
                    mUIPremiumWindow = new UIItemWindow(this, controlId: "15");
                }
                return mUIPremiumWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, instance: "10", className: "ListView20WndClass");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UIPolicySummaryWindow
        {
            get
            {
                return new UIItemWindow(this, "9");
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIAcceptWindow;

        private UIItemWindow mUIExitWindow;

        private UIItemWindow mUIPrintQuoteWindow;

        private UIItemWindow mUIDemandsNeedsWindow;

        private UIItemWindow mUIAWAPWindow;

        private UIItemWindow mUIPremiumWindow;

        private UIItemWindow mUIItemWindow2;

        #endregion

        public UIQuoteResultsWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Quote Results";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(WindowName);

            #endregion
        }
    }
}