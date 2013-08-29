namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewalLoaderWindow : WinWindow
    {
        public UIRenewalLoaderWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Renewal Loader";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfUIMain";
            this.WindowTitles.Add("Renewal Loader");

            #endregion
        }

        #region Properties

        public UIClient UIRenewalLoaderClient
        {
            get
            {
                if ((this.mUIRenewalLoaderClient == null))
                {
                    this.mUIRenewalLoaderClient = new UIClient(this, "Renewal Loader");
                }
                return this.mUIRenewalLoaderClient;
            }
        }

        public UIRenewalLoaderTitleBar UIRenewalLoaderTitleBar
        {
            get
            {
                if ((this.mUIRenewalLoaderTitleBar == null))
                {
                    this.mUIRenewalLoaderTitleBar = new UIRenewalLoaderTitleBar(this);
                }
                return this.mUIRenewalLoaderTitleBar;
            }
        }

        public UIItemWindow UIItem1Window
        {
            get
            {
                if ((this.mUIItem1Window == null))
                {
                    this.mUIItem1Window = new UIItemWindow(this, "1");
                }
                return this.mUIItem1Window;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "TEdit", instance: "3");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, className: "TEdit", instance: "2");
                }
                return this.mUIItemWindow2;
            }
        }

        #endregion

        #region Fields

        private UIClient mUIRenewalLoaderClient;

        private UIRenewalLoaderTitleBar mUIRenewalLoaderTitleBar;

        private UIItemWindow mUIItem1Window;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow2;

        #endregion
    }
}