namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheAgencyManagerWindow1 : WinWindow
    {
        
        public UITheAgencyManagerWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Applied TAM 12";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("The Agency Manager");
            #endregion
        }
        
        #region Properties
        public UIClientsFilesWindow UIClientsFilesWindow
        {
            get
            {
                if ((this.mUIClientsFilesWindow == null))
                {
                    this.mUIClientsFilesWindow = new UIClientsFilesWindow(this);
                }
                return this.mUIClientsFilesWindow;
            }
        }
        
        public UITheAgencyManagerTitleBar UITheAgencyManagerTitleBar
        {
            get
            {
                if ((this.mUITheAgencyManagerTitleBar == null))
                {
                    this.mUITheAgencyManagerTitleBar = new UITheAgencyManagerTitleBar(this);
                }
                return this.mUITheAgencyManagerTitleBar;
            }
        }
        #endregion
        
        #region Fields
        private UIClientsFilesWindow mUIClientsFilesWindow;
        
        private UITheAgencyManagerTitleBar mUITheAgencyManagerTitleBar;
        #endregion
    }
}