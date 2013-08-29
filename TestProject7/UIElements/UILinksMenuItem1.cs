namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILinksMenuItem1 : WinMenuItem
    {
        public UILinksMenuItem1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Links";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        private const string WindowName = "Policy: autotest";

        public UIMenuListItem UIItem3RdPartyIntegrateMenuItem
        {
            get
            {
                if ((this.mUIItem3RdPartyIntegrateMenuItem == null))
                {
                    this.mUIItem3RdPartyIntegrateMenuItem = new UIMenuListItem(this, "3rd Party Integration");
                }
                return this.mUIItem3RdPartyIntegrateMenuItem;
            }
        }

        #endregion

        #region Fields

        private UIMenuListItem mUIItem3RdPartyIntegrateMenuItem;

        #endregion
    }
}