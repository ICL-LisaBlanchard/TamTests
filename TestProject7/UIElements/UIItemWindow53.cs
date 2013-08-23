namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow53 : WinWindow
    {
        public UIItemWindow53(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TPanel";
            this.WindowTitles.Add("TamXML Import Customer");

            #endregion
        }

        #region Properties

        public UITamXMLImportCustomerClient UITamXMLImportCustomerClient
        {
            get
            {
                if ((this.mUITamXMLImportCustomerClient == null))
                {
                    this.mUITamXMLImportCustomerClient = new UITamXMLImportCustomerClient(this);
                }
                return this.mUITamXMLImportCustomerClient;
            }
        }

        #endregion

        #region Fields

        private UITamXMLImportCustomerClient mUITamXMLImportCustomerClient;

        #endregion
    }
}