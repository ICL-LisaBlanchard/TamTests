namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIClaimsWindow : WinWindow
    {
        public UIClaimsWindow()
        {
            #region Search Criteria

            windowTitle = "Claims";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((mUINoWindow == null))
                {
                    mUINoWindow = new UIItemWindow(this, controlId: "7");
                }
                return mUINoWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUINoWindow;

        #endregion
    }
}