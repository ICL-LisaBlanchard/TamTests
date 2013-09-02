namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

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

        public UITestControl UIOptionsWindow
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

        private UITestControl mUIOptionsWindow;

        private UIItemWindow mUIDetailWindow;

        #endregion
    }
}