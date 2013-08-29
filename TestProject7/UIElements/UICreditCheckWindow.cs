namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICreditCheckWindow : WinWindow
    {
        public UICreditCheckWindow()
        {
            #region Search Criteria

            this.windowTitle = "Credit Check";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, this.windowTitle, PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((this.mUINoWindow == null))
                {
                    this.mUINoWindow = new UIItemWindow(this, controlId: "1");
                }
                return this.mUINoWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUINoWindow;

        #endregion
    }
}