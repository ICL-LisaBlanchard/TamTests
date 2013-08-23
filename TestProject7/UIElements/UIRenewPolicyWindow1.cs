namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewPolicyWindow1 : WinWindow
    {
        public UIRenewPolicyWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "12";
            this.WindowTitles.Add("Amend Risk Results");

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
                    this.mUIRenewPolicyButton.WindowTitles.Add("Amend Risk Results");

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