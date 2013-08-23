namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILinksMenuItem : WinMenuItem
    {
        
        public UILinksMenuItem(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinMenuItem.PropertyNames.Name] = "Links";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Policy: autotest autotest");
            #endregion
        }
        
        #region Properties
        public UIItem3rdPartyIntegratMenuItem UIItem3rdPartyIntegratMenuItem
        {
            get
            {
                if ((this.mUIItem3rdPartyIntegratMenuItem == null))
                {
                    this.mUIItem3rdPartyIntegratMenuItem = new UIItem3rdPartyIntegratMenuItem(this);
                }
                return this.mUIItem3rdPartyIntegratMenuItem;
            }
        }
        #endregion
        
        #region Fields
        private UIItem3rdPartyIntegratMenuItem mUIItem3rdPartyIntegratMenuItem;
        #endregion
    }
}