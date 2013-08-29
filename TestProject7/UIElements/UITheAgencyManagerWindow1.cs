namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheAgencyManagerWindow1 : WinWindow
    {
        private const string WindowTitle = "The Agency Manager";

        #region Properties

        public UIItemWindow UIClientsFilesWindow
        {
            get
            {
                if ((this.mUIClientsFilesWindow == null))
                {
                    this.mUIClientsFilesWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIClientsFilesWindow;
            }
        }

        public UITestControl UITheAgencyManagerTitleBar
        {
            get
            {
                if ((this.mUITheAgencyManagerTitleBar == null))
                {
                    this.mUITheAgencyManagerTitleBar = new UIItemWindow(this);
                }
                return this.mUITheAgencyManagerTitleBar;
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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Applied TAM 12";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("The Agency Manager");

            #endregion
        }
    }
}