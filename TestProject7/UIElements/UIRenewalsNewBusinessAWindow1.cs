namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRenewalsNewBusinessAWindow1 : WinWindow
    {
        public UIRenewalsNewBusinessAWindow1()
        {
            #region Search Criteria

            windowTitle = "Renewals: New Business Accept";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties



        public UIItemWindow UIAcceptWindow
        {
            get
            {
                if ((mUIAcceptWindow == null))
                {
                    mUIAcceptWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIAcceptWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIAcceptWindow;

        #endregion
    }
}