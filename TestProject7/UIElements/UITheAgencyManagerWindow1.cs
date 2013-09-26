namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITheAgencyManagerWindow1 : WinWindow
    {
        #region Properties

        public UIItemWindow UIClientsFilesWindow
        {
            get
            {
                if ((mUIClientsFilesWindow == null))
                {
                    mUIClientsFilesWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIClientsFilesWindow;
            }
        }

        public UITestControl UITheAgencyManagerTitleBar
        {
            get
            {
                if ((mUITheAgencyManagerTitleBar == null))
                {
                    mUITheAgencyManagerTitleBar = new UIItemWindow(this);
                }
                return mUITheAgencyManagerTitleBar;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIClientsFilesWindow;

        private UITestControl mUITheAgencyManagerTitleBar;

        #endregion

        public UITheAgencyManagerWindow1()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Applied TAM 12";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("The Agency Manager");

            #endregion
        }
    }
}