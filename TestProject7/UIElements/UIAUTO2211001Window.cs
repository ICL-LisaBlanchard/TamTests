namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2211001Window : WinWindow
    {
        public UIAUTO2211001Window()
        {
            #region Search Criteria

            this.windowTitle = "AUTO221-1001";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}