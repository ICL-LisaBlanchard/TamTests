namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewPolicyWindow4 : WinWindow
    {
        public UIRenewPolicyWindow4(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "25";
            this.WindowTitles.Add("AUTO231-1001");

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

                    this.mUIRenewPolicyButton.SearchProperties[UITestControl.PropertyNames.Name] = "Renew Policy...";
                    this.mUIRenewPolicyButton.WindowTitles.Add("AUTO231-1001");

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