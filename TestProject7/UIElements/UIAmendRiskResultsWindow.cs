namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendRiskResultsWindow : WinWindow
    {
        public UIAmendRiskResultsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Amend Risk Results";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Amend Risk Results");

            #endregion
        }

        #region Properties

        public UIRenewPolicyWindow1 UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIRenewPolicyWindow1(this);
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        public UIItemWindow69 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow69(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIRenewPolicyWindow1 mUIRenewPolicyWindow;

        private UIItemWindow69 mUIItemWindow;

        #endregion
    }
}