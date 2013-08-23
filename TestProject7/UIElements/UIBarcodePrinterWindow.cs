namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIBarcodePrinterWindow : WinWindow
    {
        public UIBarcodePrinterWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Barcode Printer";
            this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Barcode Printer");

            #endregion
        }

        #region Properties

        public UICancelWindow7 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow7(this);
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UICancelWindow7 mUICancelWindow;

        #endregion
    }
}