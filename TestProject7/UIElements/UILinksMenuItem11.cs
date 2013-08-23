namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UILinksMenuItem11 : WinMenuItem
    {
        public UILinksMenuItem11(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Links";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UIItem3rdPartyIntegratMenuItem2 UIItem3rdPartyIntegratMenuItem
        {
            get
            {
                if ((this.mUIItem3rdPartyIntegratMenuItem == null))
                {
                    this.mUIItem3rdPartyIntegratMenuItem = new UIItem3rdPartyIntegratMenuItem2(this);
                }
                return this.mUIItem3rdPartyIntegratMenuItem;
            }
        }

        #endregion

        #region Fields

        private UIItem3rdPartyIntegratMenuItem2 mUIItem3rdPartyIntegratMenuItem;

        #endregion
    }
}