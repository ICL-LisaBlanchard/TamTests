namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyListWindow11 : WinWindow
    {
        private const string WindowTitle = "Policy: autotest";

        #region Properties

        public UIItemWindow UIDetailWindow
        {
            get
            {
                if ((mUIDetailWindow == null))
                {
                    mUIDetailWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIDetailWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIDetailWindow;

        #endregion

        public UIPolicyListWindow11(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            WindowTitles.Add(WindowTitle);

            #endregion
        }
    }
}