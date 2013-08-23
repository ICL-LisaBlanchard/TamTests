namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuotesResultsWindow : WinWindow
    {
        public UIQuotesResultsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Quotes Results";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Quotes Results");

            #endregion
        }

        #region Properties

        public UIItemWindow43 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow43(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIAcceptWindow1 UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIAcceptWindow1(this);
                }
                return this.mUIAcceptWindow;
            }
        }

        public UIExitWindow3 UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIExitWindow3(this);
                }
                return this.mUIExitWindow;
            }
        }

        public UIPrintQuoteWindow1 UIPrintQuoteWindow
        {
            get
            {
                if ((this.mUIPrintQuoteWindow == null))
                {
                    this.mUIPrintQuoteWindow = new UIPrintQuoteWindow1(this);
                }
                return this.mUIPrintQuoteWindow;
            }
        }

        public UIDemandsNeedsWindow1 UIDemandsNeedsWindow
        {
            get
            {
                if ((this.mUIDemandsNeedsWindow == null))
                {
                    this.mUIDemandsNeedsWindow = new UIDemandsNeedsWindow1(this);
                }
                return this.mUIDemandsNeedsWindow;
            }
        }

        public UIPremiumWindow1 UIPremiumWindow
        {
            get
            {
                if ((this.mUIPremiumWindow == null))
                {
                    this.mUIPremiumWindow = new UIPremiumWindow1(this);
                }
                return this.mUIPremiumWindow;
            }
        }

        public UIItemWindow118 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow118(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow212 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow212(this);
                }
                return this.mUIItemWindow2;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow43 mUIItemWindow;

        private UIAcceptWindow1 mUIAcceptWindow;

        private UIExitWindow3 mUIExitWindow;

        private UIPrintQuoteWindow1 mUIPrintQuoteWindow;

        private UIDemandsNeedsWindow1 mUIDemandsNeedsWindow;

        private UIPremiumWindow1 mUIPremiumWindow;

        private UIItemWindow118 mUIItemWindow1;

        private UIItemWindow212 mUIItemWindow2;

        #endregion
    }
}