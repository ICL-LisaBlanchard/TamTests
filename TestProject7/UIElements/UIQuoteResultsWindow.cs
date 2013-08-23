namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuoteResultsWindow : WinWindow
    {
        public UIQuoteResultsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Quote Results";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public UIItemWindow18 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow18(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIAcceptWindow UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIAcceptWindow(this);
                }
                return this.mUIAcceptWindow;
            }
        }

        public WinTitleBar UIQuoteResultsTitleBar
        {
            get
            {
                if ((this.mUIQuoteResultsTitleBar == null))
                {
                    this.mUIQuoteResultsTitleBar = new WinTitleBar(this);

                    #region Search Criteria

                    this.mUIQuoteResultsTitleBar.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIQuoteResultsTitleBar;
            }
        }

        public WinClient UIQuoteResultsClient
        {
            get
            {
                if ((this.mUIQuoteResultsClient == null))
                {
                    this.mUIQuoteResultsClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIQuoteResultsClient.SearchProperties[UITestControl.PropertyNames.Name] = "Quote Results";
                    this.mUIQuoteResultsClient.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIQuoteResultsClient;
            }
        }

        public UIExitWindow2 UIExitWindow
        {
            get
            {
                if ((this.mUIExitWindow == null))
                {
                    this.mUIExitWindow = new UIExitWindow2(this);
                }
                return this.mUIExitWindow;
            }
        }

        public UIQuoteDetailsWindow UIQuoteDetailsWindow
        {
            get
            {
                if ((this.mUIQuoteDetailsWindow == null))
                {
                    this.mUIQuoteDetailsWindow = new UIQuoteDetailsWindow(this);
                }
                return this.mUIQuoteDetailsWindow;
            }
        }

        public UIPrintQuoteWindow UIPrintQuoteWindow
        {
            get
            {
                if ((this.mUIPrintQuoteWindow == null))
                {
                    this.mUIPrintQuoteWindow = new UIPrintQuoteWindow(this);
                }
                return this.mUIPrintQuoteWindow;
            }
        }

        public UIDemandsNeedsWindow UIDemandsNeedsWindow
        {
            get
            {
                if ((this.mUIDemandsNeedsWindow == null))
                {
                    this.mUIDemandsNeedsWindow = new UIDemandsNeedsWindow(this);
                }
                return this.mUIDemandsNeedsWindow;
            }
        }

        public UIPolicySummaryWindow UIPolicySummaryWindow
        {
            get
            {
                if ((this.mUIPolicySummaryWindow == null))
                {
                    this.mUIPolicySummaryWindow = new UIPolicySummaryWindow(this);
                }
                return this.mUIPolicySummaryWindow;
            }
        }

        public UIComprehensiveWindow UIComprehensiveWindow
        {
            get
            {
                if ((this.mUIComprehensiveWindow == null))
                {
                    this.mUIComprehensiveWindow = new UIComprehensiveWindow(this);
                }
                return this.mUIComprehensiveWindow;
            }
        }

        public UIItemWindow19 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow19(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIAWAPWindow UIAWAPWindow
        {
            get
            {
                if ((this.mUIAWAPWindow == null))
                {
                    this.mUIAWAPWindow = new UIAWAPWindow(this);
                }
                return this.mUIAWAPWindow;
            }
        }

        public UIPremiumWindow UIPremiumWindow
        {
            get
            {
                if ((this.mUIPremiumWindow == null))
                {
                    this.mUIPremiumWindow = new UIPremiumWindow(this);
                }
                return this.mUIPremiumWindow;
            }
        }

        public UIItemWindow25 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow25(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow33 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow33(this);
                }
                return this.mUIItemWindow3;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow18 mUIItemWindow;

        private UIAcceptWindow mUIAcceptWindow;

        private WinTitleBar mUIQuoteResultsTitleBar;

        private WinClient mUIQuoteResultsClient;

        private UIExitWindow2 mUIExitWindow;

        private UIQuoteDetailsWindow mUIQuoteDetailsWindow;

        private UIPrintQuoteWindow mUIPrintQuoteWindow;

        private UIDemandsNeedsWindow mUIDemandsNeedsWindow;

        private UIPolicySummaryWindow mUIPolicySummaryWindow;

        private UIComprehensiveWindow mUIComprehensiveWindow;

        private UIItemWindow19 mUIItemWindow1;

        private UIAWAPWindow mUIAWAPWindow;

        private UIPremiumWindow mUIPremiumWindow;

        private UIItemWindow25 mUIItemWindow2;

        private UIItemWindow33 mUIItemWindow3;

        #endregion
    }
}