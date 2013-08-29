namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyautotestWindow : WinWindow
    {
        private const string WindowTitle = "Customer: autotest";

        private const string WindowTitle2 = "Policy: autotest";

        #region Properties

        public PolicyListWindow1 PolicyListWindow
        {
            get
            {
                if ((this.mPolicyListWindow == null))
                {
                    this.mPolicyListWindow = new PolicyListWindow1(this);
                }
                return this.mPolicyListWindow;
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

        public UIApplicationMenuBar1 UIApplicationMenuBar
        {
            get
            {
                if ((this.mUIApplicationMenuBar == null))
                {
                    this.mUIApplicationMenuBar = new UIApplicationMenuBar1(this);
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

        public UIWorkspaceClient UIWorkspaceClient
        {
            get
            {
                if ((this.mUIWorkspaceClient == null))
                {
                    this.mUIWorkspaceClient = new UIWorkspaceClient(this);
                }
                return this.mUIWorkspaceClient;
            }
        }

        public UIBillingScreenHomeWindow1 UIBillingScreenHomeWindow1
        {
            get
            {
                if ((this.mUIBillingScreenHOMEWindow1 == null))
                {
                    this.mUIBillingScreenHOMEWindow1 = new UIBillingScreenHomeWindow1(this);
                }
                return this.mUIBillingScreenHOMEWindow1;
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

        public UICustomersWindow1 UICustomersWindow
        {
            get
            {
                if ((this.mUICustomersWindow == null))
                {
                    this.mUICustomersWindow = new UICustomersWindow1(this);
                }
                return this.mUICustomersWindow;
            }
        }

        #endregion

        #region Fields

        private PolicyListWindow1 mPolicyListWindow;

        private UIItemWindow mUIItemWindow;

        private UIPolicyListWindow11 mUIPolicyListWindow1;

        private UIBillingScreenMotoWindow mUIBillingScreenMOTOWindow;

        private UIApplicationMenuBar1 mUIApplicationMenuBar;

        private WinTitleBar mUIPolicyautotestTitleBar;

        private UIWorkspaceClient mUIWorkspaceClient;

        private UIBillingScreenHomeWindow1 mUIBillingScreenHOMEWindow1;

        private UIItemWindow mUIItemWindow1;

        private UICustomersWindow1 mUICustomersWindow;

        #endregion

        public UIPolicyautotestWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }
    }
}