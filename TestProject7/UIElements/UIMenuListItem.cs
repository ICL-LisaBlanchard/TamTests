namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIMenuListItem : WinMenuItem
    {
        public UIMenuListItem(UITestControl searchLimitContainer, string name)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add(searchLimitContainer.WindowTitles[0]);
            this.WindowName = searchLimitContainer.WindowTitles[0];

            #endregion
        }

        public string WindowName { get; set; }

        public WinMenuItem UIQuoteSelectListMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Quote Select List");
            }
        }

        public WinMenuItem UICopyRiskMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Copy Risk");
            }
        }

        public WinMenuItem UIRenewalsLoaderMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Renewals Loader");
            }
        }

        public WinMenuItem UIRenewalsModuleMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Renewals Module");
            }
        }

        public WinMenuItem UIItem3rdPartyIntegratMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "3rd Party Integration");
            }
        }
    }
}