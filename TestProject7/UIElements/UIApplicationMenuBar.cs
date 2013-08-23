namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIApplicationMenuBar : WinMenuBar
    {
        
        public UIApplicationMenuBar(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenu.PropertyNames.Name] = "Application";
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UIOptionsMenuItem UIOptionsMenuItem
        {
            get
            {
                if ((this.mUIOptionsMenuItem == null))
                {
                    this.mUIOptionsMenuItem = new UIOptionsMenuItem(this);
                }
                return this.mUIOptionsMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIOptionsMenuItem mUIOptionsMenuItem;
        #endregion
    }
}