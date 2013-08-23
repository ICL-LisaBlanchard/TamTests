namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyautotestWindow : WinWindow
    {
        public UIPolicyautotestWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }

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

        public UIItemWindow30 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow30(this);
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

        public UIBillingScreenMOTOWindow UIBillingScreenMOTOWindow
        {
            get
            {
                if ((this.mUIBillingScreenMOTOWindow == null))
                {
                    this.mUIBillingScreenMOTOWindow = new UIBillingScreenMOTOWindow(this);
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

        public UIBillingScreenHOMEWindow1 UIBillingScreenHOMEWindow1
        {
            get
            {
                if ((this.mUIBillingScreenHOMEWindow1 == null))
                {
                    this.mUIBillingScreenHOMEWindow1 = new UIBillingScreenHOMEWindow1(this);
                }
                return this.mUIBillingScreenHOMEWindow1;
            }
        }

        public UIItemWindow115 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow115(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UICUSTOMERSWindow1 UICUSTOMERSWindow
        {
            get
            {
                if ((this.mUICUSTOMERSWindow == null))
                {
                    this.mUICUSTOMERSWindow = new UICUSTOMERSWindow1(this);
                }
                return this.mUICUSTOMERSWindow;
            }
        }

        #endregion

        #region Fields

        private UIPolicyListWindow1 mUIPolicyListWindow;

        private UIItemWindow30 mUIItemWindow;

        private UIPolicyListWindow11 mUIPolicyListWindow1;

        private UIBillingScreenMOTOWindow mUIBillingScreenMOTOWindow;

        private UIApplicationMenuBar1 mUIApplicationMenuBar;

        private WinTitleBar mUIPolicyautotestTitleBar;

        private UIWorkspaceClient mUIWorkspaceClient;

        private UIBillingScreenHOMEWindow1 mUIBillingScreenHOMEWindow1;

        private UIItemWindow115 mUIItemWindow1;

        private UICUSTOMERSWindow1 mUICUSTOMERSWindow;

        #endregion
    }
}