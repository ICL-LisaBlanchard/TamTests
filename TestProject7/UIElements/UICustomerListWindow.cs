namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICustomerListWindow : WinWindow
    {
        public UICustomerListWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";

            #endregion
        }

        #region Properties

        public UIItemWindow UICustomersWindow
        {
            get
            {
                if ((mUICustomersWindow == null))
                {
                    mUICustomersWindow = new UIItemWindow(this, controlId: "32768");
                }
                return mUICustomersWindow;
            }
        }

        public UIItemWindow UIAddWindow
        {
            get
            {
                if ((mUIAddWindow == null))
                {
                    mUIAddWindow = new UIItemWindow(this, controlId: "14", instance: "2");
                }
                return mUIAddWindow;
            }
        }

        public UINewCustomerDetailWindow UINewCustomerDetailWindow
        {
            get
            {
                if ((mUINewCustomerDetailWindow == null))
                {
                    mUINewCustomerDetailWindow = new UINewCustomerDetailWindow(this);
                }
                return mUINewCustomerDetailWindow;
            }
        }

        public UIItemWindow UIPoliciesWindow
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

        public UINewPolicyDetailWindow UINewPolicyDetailWindow
        {
            get
            {
                if ((mUINewPolicyDetailWindow == null))
                {
                    mUINewPolicyDetailWindow = new UINewPolicyDetailWindow(this);
                }
                return mUINewPolicyDetailWindow;
            }
        }

        public UIPolicyListWindow UIPolicyListWindow
        {
            get
            {
                if ((mUIPolicyListWindow == null))
                {
                    mUIPolicyListWindow = new UIPolicyListWindow(this);
                }
                return mUIPolicyListWindow;
            }
        }

        public UIItemWindow UISearchWindow
        {
            get
            {
                return new UIItemWindow("17");
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