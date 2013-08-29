namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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

        public UIBillingScreenMotoWindow UIBillingScreenMotoWindow
        {
            get
            {
                if ((this.mUIBillingScreenMOTOWindow == null))
                {
                    this.mUIBillingScreenMOTOWindow = new UIBillingScreenMotoWindow(this);
                }
                return this.mUIBillingScreenMOTOWindow;
            }
        }

        public UIApplicationMenuBar UIApplicationMenuBar
        {
            get
            {
                if ((this.mUIApplicationMenuBar == null))
                {
                    this.mUIApplicationMenuBar = new UIApplicationMenuBar(this);
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

        public UIBillingScreenHomeWindow UIBillingScreenHomeWindow
        {
            get
            {
                if ((this.mUIBillingScreenHomeWindow == null))
                {
                    this.mUIBillingScreenHomeWindow = new UIBillingScreenHomeWindow(this);
                }
                return this.mUIBillingScreenHomeWindow;
            }
        }

        public UIItemWindow UIItemWindow1
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

        #endregion

        #region Fields

        private UIPolicyListWindow1 mUIPolicyListWindow;

        private UIItemWindow mUIItemWindow;

        private UIPolicyListWindow11 mUIPolicyListWindow1;

        private UIBillingScreenMotoWindow mUIBillingScreenMOTOWindow;

        private UIApplicationMenuBar mUIApplicationMenuBar;

        private WinTitleBar mUIPolicyautotestTitleBar;

        private UIBillingScreenHomeWindow mUIBillingScreenHomeWindow;

        private UIItemWindow mUIItemWindow1;

        private UICustomersWindow mUICustomersWindow;

        #endregion

        public UIPolicyautotestWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }
    }
}