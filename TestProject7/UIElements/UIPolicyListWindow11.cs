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

        public UIPolicyListWindow11(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "32769";
            this.WindowTitles.Add(WindowTitle);

            #endregion
        }
    }
}