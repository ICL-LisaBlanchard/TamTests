namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdRenewalsAmeWindow1 : WinWindow
    {
        public UIHouseholdRenewalsAmeWindow1()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Household Renewals Amend Risk results";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Household Renewals Amend Risk results");

            #endregion
        }

        #region Properties

        public UIItemWindow73 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow73(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIRenewPolicyWindow3 UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIRenewPolicyWindow3(this);
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow73 mUIItemWindow;

        private UIRenewPolicyWindow3 mUIRenewPolicyWindow;

        #endregion
    }
}