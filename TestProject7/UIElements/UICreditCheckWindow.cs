namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICreditCheckWindow : WinWindow
    {
        public UICreditCheckWindow()
        {
            #region Search Criteria

            windowTitle = "Credit Check";
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, windowTitle, PropertyExpressionOperator.Contains));
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((mUINoWindow == null))
                {
                    mUINoWindow = new UIItemWindow(this, controlId: "1");
                }
                return mUINoWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUINoWindow;

        #endregion
    }
}