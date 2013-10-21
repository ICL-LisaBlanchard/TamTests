namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UiAuto1Window : WinWindow
    {
        public UiAuto1Window()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "AUTO", PropertyExpressionOperator.Contains));
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "-1001", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("AUTO225-1001");

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