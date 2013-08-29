namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyListWindow1 : WinWindow
    {
        private const string WindowTitle = "Policy: autotest";

        #region Properties

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

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIItemWindow(this, controlId: "7");
                }
                return this.mUIOptionsWindow;
            }
        }

        public UITestControl UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUICancelWindow;

        private UIItemWindow mUIOptionsWindow;

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIDetailWindow;

        #endregion

        public UIPolicyListWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add(WindowTitle);

            #endregion
        }
    }
}