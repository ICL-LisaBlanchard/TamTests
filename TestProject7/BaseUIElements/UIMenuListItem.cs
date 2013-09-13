namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
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
            foreach (string windowTitle in searchLimitContainer.WindowTitles)
            {
                this.WindowTitles.Add(windowTitle);
            }

            #endregion
        }

        public UIMenuListItem UIQuoteSelectListMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Quote Select List");
            }
        }

        public UIMenuListItem UICopyRiskMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Copy Risk");
            }
        }

        public UIMenuListItem UIRenewalsLoaderMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Renewals Loader");
            }
        }

        public UIMenuListItem UIRenewalsModuleMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Renewals Module");
            }
        }

        public UIMenuListItem UIItem3RdPartyIntegratMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "3rd Party Integration");
            }
        }

        public UIMenuListItem UILinksMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Links");
            }
        }

        public UIMenuListItem UIPrintaBarcodeMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Print a Barcode");
            }
        }

        public UIMenuListItem UIPropertiesCtrlDMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Properties...\tCtrl+D");
            }
        }

        public UIMenuListItem UIFindMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Find...");
            }
        }
    }
}