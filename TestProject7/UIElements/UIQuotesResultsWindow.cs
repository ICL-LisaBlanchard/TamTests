namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIQuotesResultsWindow : WinWindow
    {
        public UIQuotesResultsWindow()
        {
            #region Search Criteria

            windowName = "Quotes Results";
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
                    mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
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
                    mUIAcceptWindow = new UIItemWindow(this, controlId: "2");
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
                    mUIExitWindow = new UIItemWindow(this, controlId: "6");
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
                    mUIPrintQuoteWindow = new UIItemWindow(this, controlId: "4");
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

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIAcceptWindow;

        private UIItemWindow mUIExitWindow;

        private UIItemWindow mUIPrintQuoteWindow;

        private UIItemWindow mUIDemandsNeedsWindow;

        private UIItemWindow mUIPremiumWindow;

        #endregion
    }
}