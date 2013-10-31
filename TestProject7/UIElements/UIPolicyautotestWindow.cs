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
                if ((mUIPolicyListWindow == null))
                {
                    mUIPolicyListWindow = new UIPolicyListWindow1(this);
                }
                return mUIPolicyListWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "32");
                }
                return mUIItemWindow;
            }
        }

        public UIPolicyListWindow11 UIPolicyListWindow1
        {
            get
            {
                if ((mUIPolicyListWindow1 == null))
                {
                    mUIPolicyListWindow1 = new UIPolicyListWindow11(this);
                }
                return mUIPolicyListWindow1;
            }
        }

        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((mUIApplicationMenuBar == null))
                {
                    mUIApplicationMenuBar = new UIApplicationMenuBar(this, "Application");
                }
                return mUIApplicationMenuBar;
            }
        }

        public WinTitleBar UIPolicyautotestTitleBar
        {
            get
            {
                if ((mUIPolicyautotestTitleBar == null))
                {
                    mUIPolicyautotestTitleBar = new WinTitleBar(this);

                    #region Search Criteria

                    mUIPolicyautotestTitleBar.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return mUIPolicyautotestTitleBar;
            }
        }

        public UIBillingScreenWindow UIBillingScreenWindow
        {
            get
            {
                return new UIBillingScreenWindow(this);
            }
        }

        public UITestControl UIItemWindow1
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "26");
                }
                return mUIItemWindow1;
            }
        }

        public UICustomersWindow UICustomersWindow
        {
            get
            {
                if ((mUICustomersWindow == null))
                {
                    mUICustomersWindow = new UICustomersWindow(this);
                }
                return mUICustomersWindow;
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
                if ((mUITransactionListWindow == null))
                {
                    mUITransactionListWindow = new UITransactionListWindow(this);
                }
                return mUITransactionListWindow;
            }
        }

        #endregion

        #region Fields

        private UIPolicyListWindow1 mUIPolicyListWindow;

        private UIItemWindow mUIItemWindow;

        private UIPolicyListWindow11 mUIPolicyListWindow1;

        private UIApplicationMenuBar mUIApplicationMenuBar;

        private WinTitleBar mUIPolicyautotestTitleBar;

        private UITestControl mUIItemWindow1;

        private UICustomersWindow mUICustomersWindow;

        private UITransactionListWindow mUITransactionListWindow;

        #endregion

        public UIPolicyautotestWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }
    }
}