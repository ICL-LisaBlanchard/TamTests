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

        public UIItemWindow UIItemWindowXxxXxx
        {
            get
            {
                if ((this.mUIItemWindowXXX == null))
                {
                    this.mUIItemWindowXXX = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return this.mUIItemWindowXXX;
            }
        }

        public UIItemWindow UIRenewPolicyWindowXxxXxx
        {
            get
            {
                if ((this.mUIRenewPolicyWindowXXX == null))
                {
                    this.mUIRenewPolicyWindowXXX = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIRenewPolicyWindowXXX;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIItemWindowXXX;

        private UIItemWindow mUIRenewPolicyWindowXXX;

        #endregion
    }
}