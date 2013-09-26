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
                if ((mUIYesWindow == null))
                {
                    mUIYesWindow = new UIItemWindow(this, controlId: "6");
                }
                return mUIYesWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIYesWindow;

        #endregion

        public UIVerifyWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Verify";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add("Verify");

            #endregion
        }
    }
}