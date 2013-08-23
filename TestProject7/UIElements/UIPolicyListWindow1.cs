namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyListWindow1 : WinWindow
    {
        public UIPolicyListWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UICancelWindow5 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow5(this);
                }
                return this.mUICancelWindow;
            }
        }

        public UIOptionsWindow1 UIOptionsWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIOptionsWindow1(this);
                }
                return this.mUIOptionsWindow;
            }
        }

        public UIItemWindow29 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow29(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIDetailWindow1 UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIDetailWindow1(this);
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UICancelWindow5 mUICancelWindow;

        private UIOptionsWindow1 mUIOptionsWindow;

        private UIItemWindow29 mUIItemWindow;

        private UIDetailWindow1 mUIDetailWindow;

        #endregion
    }
}