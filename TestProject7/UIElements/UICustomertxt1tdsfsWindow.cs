namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICustomertxt1TdsfsWindow : WinWindow
    {
        public UICustomertxt1TdsfsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }

        #region Properties

        public UIItemWindow UICustomersWindow
        {
            get
            {
                if ((this.mUICustomersWindow == null))
                {
                    this.mUICustomersWindow = new UIItemWindow(this, controlId: "32768");
                }
                return this.mUICustomersWindow;
            }
        }

        public UIItemWindow UIAddWindow
        {
            get
            {
                if ((this.mUIAddWindow == null))
                {
                    this.mUIAddWindow = new UIItemWindow(this, controlId: "14", instance: "2");
                }
                return this.mUIAddWindow;
            }
        }

        public UINewCustomerDetailWindow UINewCustomerDetailWindow
        {
            get
            {
                if ((this.mUINewCustomerDetailWindow == null))
                {
                    this.mUINewCustomerDetailWindow = new UINewCustomerDetailWindow(this);
                }
                return this.mUINewCustomerDetailWindow;
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

        public UINewPolicyDetailWindow UINewPolicyDetailWindow
        {
            get
            {
                if ((this.mUINewPolicyDetailWindow == null))
                {
                    this.mUINewPolicyDetailWindow = new UINewPolicyDetailWindow(this);
                }
                return this.mUINewPolicyDetailWindow;
            }
        }

        public UIPolicyListWindow UIPolicyListWindow
        {
            get
            {
                if ((this.mUIPolicyListWindow == null))
                {
                    this.mUIPolicyListWindow = new UIPolicyListWindow(this);
                }
                return this.mUIPolicyListWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICustomersWindow;

        private UIItemWindow mUIAddWindow;

        private UINewCustomerDetailWindow mUINewCustomerDetailWindow;

        private UIItemWindow mUIItemWindow;

        private UINewPolicyDetailWindow mUINewPolicyDetailWindow;

        private UIPolicyListWindow mUIPolicyListWindow;

        #endregion
    }
}