namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow73 : WinWindow
    {
        public UIItemWindow73(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ListView20WndClass";
            this.WindowTitles.Add("Household Renewals Amend Risk results");

            #endregion
        }

        #region Properties

        public WinClient UIHouseholdRenewalsAmeClient
        {
            get
            {
                if ((this.mUIHouseholdRenewalsAmeClient == null))
                {
                    this.mUIHouseholdRenewalsAmeClient = new WinClient(this);

                    #region Search Criteria

                    this.mUIHouseholdRenewalsAmeClient.WindowTitles.Add("Household Renewals Amend Risk results");

                    #endregion
                }
                return this.mUIHouseholdRenewalsAmeClient;
            }
        }

        #endregion

        #region Fields

        private WinClient mUIHouseholdRenewalsAmeClient;

        #endregion
    }
}