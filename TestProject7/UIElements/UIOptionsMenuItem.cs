namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOptionsMenuItem : WinMenuItem
    {
        
        public UIOptionsMenuItem(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Options";
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UILinksMenuItem UILinksMenuItem
        {
            get
            {
                if ((this.mUILinksMenuItem == null))
                {
                    this.mUILinksMenuItem = new UILinksMenuItem(this);
                }
                return this.mUILinksMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UILinksMenuItem mUILinksMenuItem;
        #endregion
    }
}