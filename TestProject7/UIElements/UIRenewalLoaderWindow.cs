namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

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

        public UIRenewalLoaderClient UIRenewalLoaderClient
        {
            get
            {
                if ((this.mUIRenewalLoaderClient == null))
                {
                    this.mUIRenewalLoaderClient = new UIRenewalLoaderClient(this);
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

        public UIItem1Window UIItem1Window
        {
            get
            {
                if ((this.mUIItem1Window == null))
                {
                    this.mUIItem1Window = new UIItem1Window(this);
                }
                return this.mUIItem1Window;
            }
        }

        public UIItem12122012Window UIItem12122012Window
        {
            get
            {
                if ((this.mUIItem12122012Window == null))
                {
                    this.mUIItem12122012Window = new UIItem12122012Window(this);
                }
                return this.mUIItem12122012Window;
            }
        }

        public UIItem13122012Window UIItem13122012Window
        {
            get
            {
                if ((this.mUIItem13122012Window == null))
                {
                    this.mUIItem13122012Window = new UIItem13122012Window(this);
                }
                return this.mUIItem13122012Window;
            }
        }

        #endregion

        #region Fields

        private UIRenewalLoaderClient mUIRenewalLoaderClient;

        private UIRenewalLoaderTitleBar mUIRenewalLoaderTitleBar;

        private UIItem1Window mUIItem1Window;

        private UIItem12122012Window mUIItem12122012Window;

        private UIItem13122012Window mUIItem13122012Window;

        #endregion
    }
}