namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINewPolicyDetailWindow : WinWindow
    {
        public UINewPolicyDetailWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("New Policy: AUTOAU1");
            this.WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        private const string WindowTitle = "New Policy: AUTOAU1";

        private const string WindowTitle2 = "Policy: autotest autotest";

        public UITestControl UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, instance: "13", className: "ThunderRT6UserControlDC");
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
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "13");
                }
                return this.mUIOKWindow;
            }
        }

        public UITestControl UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "1", instance: "24");
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow UIItemWindow11
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return this.mUIItemWindow11;
            }
        }

        public UITestControl UICancelWindow
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

        public UITestControl UIItemWindow12
        {
            get
            {
                if ((this.mUIItemWindow12 == null))
                {
                    this.mUIItemWindow12 = new UIItemWindow(this, className: "ThunderRT6UserControlDC");
                }
                return this.mUIItemWindow12;
            }
        }

        #endregion

        #region Fields

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIOKWindow;

        private UITestControl mUIItemWindow2;

        private UIItemWindow mUIItemWindow11;

        private UITestControl mUICancelWindow;

        private UITestControl mUIItemWindow12;

        #endregion
    }
}