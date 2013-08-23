﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow122 : WinWindow
    {
        public UIItemWindow122(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "msvb_lib_header";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinClient UIInsurETAMRenewalsClient
        {
            get
            {
                if ((this.mUIInsurETAMRenewalsClient == null))
                {
                    this.mUIInsurETAMRenewalsClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIInsurETAMRenewalsClient.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIInsurETAMRenewalsClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIInsurETAMRenewalsClient;

        #endregion
    }
}