namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendRiskResultsWindow : WinWindow
    {
        public UIAmendRiskResultsWindow()
        {
            #region Search Criteria

            this.windowTitle = "Amend Risk Results";
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
                    this.mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "12");
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, instance: "8", className: "ListView20WndClass");
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIRenewPolicyWindow;

        private UIItemWindow mUIItemWindow;

        #endregion
    }
}