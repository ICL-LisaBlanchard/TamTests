namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIHouseholdRenewalsResultsWindow : WinWindow
    {
        public UIHouseholdRenewalsResultsWindow()
        {
            #region Search Criteria

            this.windowName = "Household Renewals Amend Risk results";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, this.windowName, PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow7 == null))
                {
                    this.mUIItemWindow7 = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return this.mUIItemWindow7;
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

        private readonly string windowName;

        private UIItemWindow mUIItemWindow7;

        private UIItemWindow mUIRenewPolicyWindow;

        #endregion
    }
}