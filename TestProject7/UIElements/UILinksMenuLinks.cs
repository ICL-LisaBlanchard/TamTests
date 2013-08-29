namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILinksMenuLinks : WinMenuItem
    {
        private const string WindowName = "Policy: autotest";

        #region Properties

        public UIMenuListItem UIItem3RdPartyIntegratMenuItem
        {
            get
            {
                if ((this.mUIItem3RdPartyIntegratMenuItem == null))
                {
                    this.mUIItem3RdPartyIntegratMenuItem = new UIMenuListItem(this, "3rd Party Integration");
                }
                return this.mUIItem3RdPartyIntegratMenuItem;
            }
        }

        #endregion

        #region Fields

        private UIMenuListItem mUIItem3RdPartyIntegratMenuItem;

        #endregion

        public UILinksMenuLinks(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Links";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }
    }
}