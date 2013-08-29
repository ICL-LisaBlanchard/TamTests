namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicyListWindow11 : WinWindow
    {
        public UIPolicyListWindow11(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add(WindowTitle);

            #endregion
        }

        private const string WindowTitle = "Policy: autotest";

        #region Properties

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

        private UIItemWindow mUIDetailWindow;

        #endregion
    }
}