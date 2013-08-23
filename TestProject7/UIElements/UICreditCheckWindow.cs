namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICreditCheckWindow : WinWindow
    {
        public UICreditCheckWindow()
        {
            #region Search Criteria

            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, "Credit Check", PropertyExpressionOperator.Contains));
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Credit Check");

            #endregion
        }

        #region Properties

        public UINOWindow UINOWindow
        {
            get
            {
                if ((this.mUINOWindow == null))
                {
                    this.mUINOWindow = new UINOWindow(this);
                }
                return this.mUINOWindow;
            }
        }

        #endregion

        #region Fields

        private UINOWindow mUINOWindow;

        #endregion
    }
}