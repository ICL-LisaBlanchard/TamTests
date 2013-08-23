namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIClientsFilesWindow : WinWindow
    {
        
        public UIClientsFilesWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "8";
            this.WindowTitles.Add("The Agency Manager");
            #endregion
        }
        
        #region Properties
        public WinButton UIClientsFilesButton
        {
            get
            {
                if ((this.mUIClientsFilesButton == null))
                {
                    this.mUIClientsFilesButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIClientsFilesButton.SearchProperties[WinButton.PropertyNames.Name] = "Clients & Files";
                    this.mUIClientsFilesButton.WindowTitles.Add("The Agency Manager");
                    #endregion
                }
                return this.mUIClientsFilesButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIClientsFilesButton;
        #endregion
    }
}