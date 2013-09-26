namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class Uiautoxxx1000Window : WinWindow
    {
        public Uiautoxxx1000Window()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "-1001", PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            //WindowTitles.Add("AUTO208-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((mUIRebrokeWindow == null))
                {
                    mUIRebrokeWindow = new UIItemWindow(this, "5");
                }
                return mUIRebrokeWindow;
            }
        }

        public UIItemWindow UIAmendRiskWindow
        {
            get
            {
                if ((mUIAmendRiskWindow == null))
                {
                    mUIAmendRiskWindow = new UIItemWindow(this, "6");
                }
                return mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        private UIItemWindow mUIAmendRiskWindow;

        #endregion
    }
}