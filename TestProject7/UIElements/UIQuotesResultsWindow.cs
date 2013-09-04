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

            this.windowName = "Quotes Results";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, instance: "2", className: "ListView20WndClass");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIAcceptWindow;
            }
        }

        public UIItemWindow UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIExitWindow;
            }
        }

        public UIItemWindow UIPrintQuoteWindow
        {
            get
            {
                if ((this.mUIPrintQuoteWindow == null))
                {
                    this.mUIPrintQuoteWindow = new UIItemWindow(this, controlId: "4");
                }
                return this.mUIPrintQuoteWindow;
            }
        }

        public UIItemWindow UIDemandsNeedsWindow
        {
            get
            {
                if ((this.mUIDemandsNeedsWindow == null))
                {
                    this.mUIDemandsNeedsWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIDemandsNeedsWindow;
            }
        }

        public UIItemWindow UIPremiumWindow
        {
            get
            {
                if ((this.mUIPremiumWindow == null))
                {
                    this.mUIPremiumWindow = new UIItemWindow(this, controlId: "15");
                }
                return this.mUIPremiumWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, className: "ListView20WndClass");
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
                    this.mUIItemWindow2 = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return this.mUIItemWindow2;
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

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        #endregion
    }
}