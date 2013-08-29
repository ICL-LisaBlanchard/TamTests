namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewPolicyWindow3 : WinWindow
    {
        public UIRenewPolicyWindow3(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Household Renewals Amend Risk results");

            #endregion
        }

        #region Properties

        public WinButton UIRenewPolicyButton
        {
            get
            {
                if ((this.mUIRenewPolicyButton == null))
                {
                    this.mUIRenewPolicyButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIRenewPolicyButton.SearchProperties[UITestControl.PropertyNames.Name] = "Renew Policy";
                    this.mUIRenewPolicyButton.WindowTitles.Add("Household Renewals Amend Risk results");

                    #endregion
                }
                return this.mUIRenewPolicyButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIRenewPolicyButton;

        #endregion
    }
}