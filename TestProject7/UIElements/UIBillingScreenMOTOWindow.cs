namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBillingScreenMotoWindow : WinWindow
    {
        private const string WindowName = "Policy: autotest";

        private const string WindowName2 = "Transaction: autotest";

        #region Properties

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUICancelWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return this.mUIItemWindow;
            }
        }

        public UITestControl UICancelWindow1
        {
            get
            {
                if ((this.mUICancelWindow1 == null))
                {
                    this.mUICancelWindow1 = new UIItemWindow(this, controlId: "8");
                }
                return this.mUICancelWindow1;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "1", instance: "13");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "18");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow(this, controlId: "2", instance: "3");
                }
                return this.mUIItemWindow3;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "13");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUICancelWindow1;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow2;

        private UIItemWindow mUIItemWindow3;

        private UIItemWindow mUIOKWindow;

        #endregion

        public UIBillingScreenMotoWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("Policy: autotest");
            this.WindowTitles.Add("Transaction: autotest");

            #endregion
        }
    }
}