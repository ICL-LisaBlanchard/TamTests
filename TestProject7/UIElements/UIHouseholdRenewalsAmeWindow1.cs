namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdRenewalsAmeWindow1 : WinWindow
    {
        public UIHouseholdRenewalsAmeWindow1()
        {
            #region Search Criteria

            this.windowTitle = "Household Renewals Amend Risk results";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((this.mUIRenewPolicyWindow == null))
                {
                    this.mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIRenewPolicyWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}