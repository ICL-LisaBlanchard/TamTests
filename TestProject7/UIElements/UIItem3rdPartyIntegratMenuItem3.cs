﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItem3rdPartyIntegratMenuItem3 : WinMenuItem
    {
        public UIItem3rdPartyIntegratMenuItem3(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "3rd Party Integration";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public WinMenuItem UIQuoteSelectListMenuItem
        {
            get
            {
                if ((this.mUIQuoteSelectListMenuItem == null))
                {
                    this.mUIQuoteSelectListMenuItem = new WinMenuItem(this);

                    #region Search Criteria

                    this.mUIQuoteSelectListMenuItem.SearchProperties[UITestControl.PropertyNames.Name] = "Quote Select List";
                    this.mUIQuoteSelectListMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIQuoteSelectListMenuItem.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIQuoteSelectListMenuItem;
            }
        }

        public WinMenuItem UIRenewalsModuleMenuItem
        {
            get
            {
                if ((this.mUIRenewalsModuleMenuItem == null))
                {
                    this.mUIRenewalsModuleMenuItem = new WinMenuItem(this);

                    #region Search Criteria

                    this.mUIRenewalsModuleMenuItem.SearchProperties[UITestControl.PropertyNames.Name] = "Renewals Module";
                    this.mUIRenewalsModuleMenuItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIRenewalsModuleMenuItem.WindowTitles.Add("Policy: autotest");

                    #endregion
                }
                return this.mUIRenewalsModuleMenuItem;
            }
        }

        #endregion

        #region Fields

        private WinMenuItem mUIQuoteSelectListMenuItem;

        private WinMenuItem mUIRenewalsModuleMenuItem;

        #endregion
    }
}