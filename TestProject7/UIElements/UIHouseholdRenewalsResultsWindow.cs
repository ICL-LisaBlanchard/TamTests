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

            windowName = "Household Renewals Amend Risk results";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowName, PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow7 == null))
                {
                    mUIItemWindow7 = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return mUIItemWindow7;
            }
        }

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((mUIRenewPolicyWindow == null))
                {
                    mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIRenewPolicyWindow;
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