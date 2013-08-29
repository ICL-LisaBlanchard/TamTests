namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewCustomerDetailWindow : WinWindow
    {
        public UINewCustomerDetailWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("New Customer: AUTOAU1");
            this.WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "14");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "15");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "23");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUICancelWindow;
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