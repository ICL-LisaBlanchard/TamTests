namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UiAuto1Window : WinWindow
    {
        public UiAuto1Window(string customerCode)
        {
            #region Search Criteria

            var windowName = customerCode + "-1001";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowName, PropertyExpressionOperator.Contains));

            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIAmendRiskWindow
        {
            get
            {
                if ((mUIAmendRiskWindow == null))
                {
                    mUIAmendRiskWindow = new UIItemWindow(this, "29");
                }
                return mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIAmendRiskWindow;

        #endregion
    }
}