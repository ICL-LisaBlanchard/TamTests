namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFolderViewWindow : WinWindow
    {
        
        public UIFolderViewWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public WinList UIDesktopList
        {
            get
            {
                if ((this.mUIDesktopList == null))
                {
                    this.mUIDesktopList = new WinList(this);
                    #region Search Criteria
                    this.mUIDesktopList.SearchProperties[WinList.PropertyNames.Name] = "Desktop";
                    this.mUIDesktopList.WindowTitles.Add("Program Manager");
                    #endregion
                }
                return this.mUIDesktopList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIDesktopList;
        #endregion
    }
}