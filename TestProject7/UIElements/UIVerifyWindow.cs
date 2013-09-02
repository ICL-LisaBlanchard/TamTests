namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIVerifyWindow : WinWindow
    {
        #region Properties

        public UIItemWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIYesWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIYesWindow;

        #endregion

        public UIVerifyWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Verify";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Verify");

            #endregion
        }
    }
}