namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIUpdateGeneralTransacWindow : WinWindow
    {
        public UIUpdateGeneralTransacWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Update General Transactions";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Update General Transactions");

            #endregion
        }

        #region Properties

        public UICancelWindow9 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow9(this);
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UICancelWindow9 mUICancelWindow;

        #endregion
    }
}