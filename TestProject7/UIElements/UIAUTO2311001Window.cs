namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2311001Window : WinWindow
    {
        public UIAUTO2311001Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO231-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO231-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIItemWindow(this, "25");
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}