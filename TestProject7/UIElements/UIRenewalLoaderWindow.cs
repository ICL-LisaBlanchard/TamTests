namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRenewalLoaderWindow : WinWindow
    {
        public UIRenewalLoaderWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Renewal Loader";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfUIMain";
            WindowTitles.Add("Renewal Loader");

            #endregion
        }

        #region Properties

        public UIClient UIRenewalLoaderClient
        {
            get
            {
                if ((mUIRenewalLoaderClient == null))
                {
                    mUIRenewalLoaderClient = new UIClient(this, "Renewal Loader");
                }
                return mUIRenewalLoaderClient;
            }
        }

        public UITitleBar UIRenewalLoaderTitleBar
        {
            get
            {
                if ((mUIRenewalLoaderTitleBar == null))
                {
                    mUIRenewalLoaderTitleBar = new UITitleBar(this);
                }
                return mUIRenewalLoaderTitleBar;
            }
        }

        public UITestControl UIItem1Window
        {
            get
            {
                if ((mUIItem1Window == null))
                {
                    mUIItem1Window = new UIItemWindow(this, "1");
                }
                return mUIItem1Window;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "TEdit", instance: "3");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, className: "TEdit", instance: "2");
                }
                return mUIItemWindow2;
            }
        }

        #endregion

        #region Fields

        private UIClient mUIRenewalLoaderClient;

        private UITitleBar mUIRenewalLoaderTitleBar;

        private UITestControl mUIItem1Window;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow2;

        #endregion
    }
}