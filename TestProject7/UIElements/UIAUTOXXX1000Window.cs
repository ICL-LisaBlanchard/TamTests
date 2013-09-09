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

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "-1001", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            //this.WindowTitles.Add("AUTO208-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((this.mUIRebrokeWindow == null))
                {
                    this.mUIRebrokeWindow = new UIItemWindow(this, "5");
                }
                return this.mUIRebrokeWindow;
            }
        }

        public UIItemWindow UIAmendRiskWindow
        {
            get
            {
                if ((this.mUIAmendRiskWindow == null))
                {
                    this.mUIAmendRiskWindow = new UIItemWindow(this, "6");
                }
                return this.mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        private UIItemWindow mUIAmendRiskWindow;

        #endregion
    }
}