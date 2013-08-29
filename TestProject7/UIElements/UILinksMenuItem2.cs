namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILinksMenuItem2 : WinMenuItem
    {
        private const string WindowName = "Policy: autotest";

        #region Properties

        public UIMenuListItem UIItem3RdPartyIntegratMenuItem
        {
            get
            {
                if ((this.mUIItem3rdPartyIntegratMenuItem == null))
                {
                    this.mUIItem3rdPartyIntegratMenuItem = new UIMenuListItem(this, "3rd Party Integration");
                }
                return this.mUIItem3rdPartyIntegratMenuItem;
            }
        }

        #endregion

        #region Fields

        private UIMenuListItem mUIItem3rdPartyIntegratMenuItem;

        #endregion

        public UILinksMenuItem2(UITestControl searchLimitContainer)
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