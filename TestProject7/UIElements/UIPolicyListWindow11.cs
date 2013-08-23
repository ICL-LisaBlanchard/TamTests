namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

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
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UIDetailWindow2 UIDetailWindow
        {
            get
            {
                if ((this.mUIDetailWindow == null))
                {
                    this.mUIDetailWindow = new UIDetailWindow2(this);
                }
                return this.mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIDetailWindow2 mUIDetailWindow;

        #endregion
    }
}