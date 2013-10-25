namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UINewCustomerDetailWindow : WinWindow
    {
        public UINewCustomerDetailWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            WindowTitles.Add("New Customer: AUTOAU1");
            WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow14
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "14");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow15
        {
            get
            {
                if ((mUIItemWindow1 == null))
                {
                    mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "15");
                }
                return mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow(string instanceId)
        {
            return new UIItemWindow(this, controlId: "1", instance: instanceId);
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "23");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUICancelWindow;

        #endregion
    }
}