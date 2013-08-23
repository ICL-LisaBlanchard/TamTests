namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBillingScreenMOTOWindow : WinWindow
    {
        public UIBillingScreenMOTOWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            this.WindowTitles.Add("Policy: autotest");
            this.WindowTitles.Add("Transaction: autotest");

            #endregion
        }

        #region Properties

        public UICancelWindow6 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow6(this);
                }
                return this.mUICancelWindow;
            }
        }

        public UIItemWindow34 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow34(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UICancelWindow12 UICancelWindow1
        {
            get
            {
                if ((this.mUICancelWindow1 == null))
                {
                    this.mUICancelWindow1 = new UICancelWindow12(this);
                }
                return this.mUICancelWindow1;
            }
        }

        public UIItemWindow114 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow114(this);
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow210 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow210(this);
                }
                return this.mUIItemWindow2;
            }
        }

        public UIItemWindow35 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow35(this);
                }
                return this.mUIItemWindow3;
            }
        }

        public UIOKWindow17 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow17(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UICancelWindow6 mUICancelWindow;

        private UIItemWindow34 mUIItemWindow;

        private UICancelWindow12 mUICancelWindow1;

        private UIItemWindow114 mUIItemWindow1;

        private UIItemWindow210 mUIItemWindow2;

        private UIItemWindow35 mUIItemWindow3;

        private UIOKWindow17 mUIOKWindow;

        #endregion
    }
}