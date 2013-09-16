namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyautotestWindow : WinWindow
    {
        private const string WindowTitle = "Customer: autotest";

        private const string WindowTitle2 = "Policy: autotest";

        #region Properties

        public UIPolicyListWindow1 UIPolicyListWindow
        {
            get
            {
                if ((this.mUIPolicyListWindow == null))
                {
                    this.mUIPolicyListWindow = new UIPolicyListWindow1(this);
                }
                return this.mUIPolicyListWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "32");
                }
                return this.mUIItemWindow;
            }
        }

        public UIPolicyListWindow11 UIPolicyListWindow1
        {
            get
            {
                if ((this.mUIPolicyListWindow1 == null))
                {
                    this.mUIPolicyListWindow1 = new UIPolicyListWindow11(this);
                }
                return this.mUIPolicyListWindow1;
            }
        }

        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((this.mUIApplicationMenuBar == null))
                {
                    this.mUIApplicationMenuBar = new UIApplicationMenuBar(this, "Application");
                }
                return this.mUIApplicationMenuBar;
            }
        }

        public WinTitleBar UIPolicyautotestTitleBar
        {
            get
            {
                if ((this.mUIPolicyautotestTitleBar == null))
                {
                    this.mUIPolicyautotestTitleBar = new WinTitleBar(this);

                    #region Search Criteria

                    this.mUIPolicyautotestTitleBar.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIPolicyautotestTitleBar;
            }
        }

        public UIBillingScreenWindow UIBillingScreenWindow
        {
            get
            {
                if ((this.mUIBillingScreenWindow == null))
                {
                    this.mUIBillingScreenWindow = new UIBillingScreenWindow(this);
                }
                return this.mUIBillingScreenWindow;
            }
        }

        public UITestControl UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "26");
                }
                return this.mUIItemWindow1;
            }
        }

        public UICustomersWindow UICustomersWindow
        {
            get
            {
                if ((this.mUICustomersWindow == null))
                {
                    this.mUICustomersWindow = new UICustomersWindow(this);
                }
                return this.mUICustomersWindow;
            }
        }

        public UIItemWindow UIInvoicesWindow
        {
            get
            {
                return new UIItemWindow(this, "26");
            }
        }

        public UITransactionListWindow UITransactionListWindow
        {
            get
            {
                if ((this.mUITransactionListWindow == null))
                {
                    this.mUITransactionListWindow = new UITransactionListWindow(this);
                }
                return this.mUITransactionListWindow;
            }
        }

        #endregion

        #region Fields

        private UIPolicyListWindow1 mUIPolicyListWindow;

        private UIItemWindow mUIItemWindow;

        private UIPolicyListWindow11 mUIPolicyListWindow1;

        private UIApplicationMenuBar mUIApplicationMenuBar;

        private WinTitleBar mUIPolicyautotestTitleBar;

        private UIBillingScreenWindow mUIBillingScreenWindow;

        private UITestControl mUIItemWindow1;

        private UICustomersWindow mUICustomersWindow;

        private UITransactionListWindow mUITransactionListWindow;

        #endregion

        public UIPolicyautotestWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }
    }
}