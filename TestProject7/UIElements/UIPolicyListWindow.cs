namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyListWindow : WinWindow
    {
        public UIPolicyListWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((this.mUIOptionsWindow == null))
                {
                    this.mUIOptionsWindow = new UIItemWindow(this, "7");
                }
                return this.mUIOptionsWindow;
            }
        }

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIItemWindow(this, "6");
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOptionsWindow;

        private UIItemWindow mUIDetailWindow;

        #endregion
    }
}