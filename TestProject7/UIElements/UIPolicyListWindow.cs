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

            SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            WindowTitles.Add("Policy: autotest autotest");

            #endregion
        }

        #region Properties

        public UITestControl UIOptionsWindow
        {
            get
            {
                if ((mUIOptionsWindow == null))
                {
                    mUIOptionsWindow = new UIItemWindow(this, "7");
                }
                return mUIOptionsWindow;
            }
        }

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((mUIDetailWindow == null))
                {
                    mUIDetailWindow = new UIItemWindow(this, "6");
                }
                return mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UITestControl mUIOptionsWindow;

        private UIItemWindow mUIDetailWindow;

        #endregion
    }
}