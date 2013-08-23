namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDesktopList : WinList
    {
        
        public UIDesktopList(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinList.PropertyNames.Name] = "Desktop";
            this.WindowTitles.Add("Program Manager");
            #endregion
        }
        
        #region Properties
        public WinListItem UITestProject7ListItem
        {
            get
            {
                if ((this.mUITestProject7ListItem == null))
                {
                    this.mUITestProject7ListItem = new WinListItem(this);
                    #region Search Criteria
                    this.mUITestProject7ListItem.SearchProperties[WinListItem.PropertyNames.Name] = "TestProject7";
                    this.mUITestProject7ListItem.WindowTitles.Add("Program Manager");
                    #endregion
                }
                return this.mUITestProject7ListItem;
            }
        }
        #endregion
        
        #region Fields
        private WinListItem mUITestProject7ListItem;
        #endregion
    }
}