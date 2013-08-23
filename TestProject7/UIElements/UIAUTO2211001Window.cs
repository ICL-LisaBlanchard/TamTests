namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2211001Window : WinWindow
    {
        public UIAUTO2211001Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO221-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO221-1001");

            #endregion
        }

        #region Properties

        public UIRenewPolicyWindow2 UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIRenewPolicyWindow2(this);
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIRenewPolicyWindow2 mUIRenewPolicyWindow;

        #endregion
    }
}