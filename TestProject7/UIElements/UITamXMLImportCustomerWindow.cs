namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITamXMLImportCustomerWindow : WinWindow
    {
        public UITamXMLImportCustomerWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "TamXML Import Customer";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfImport";
            this.WindowTitles.Add("TamXML Import Customer");

            #endregion
        }

        #region Properties

        public UIItemWindow53 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow53(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow53 mUIItemWindow;

        #endregion
    }
}