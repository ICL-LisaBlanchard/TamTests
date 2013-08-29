namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIImporttoTAMWindow : WinWindow
    {
        public UIImporttoTAMWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Import to TAM";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfImportToTam";
            this.WindowTitles.Add("Import to TAM");

            #endregion
        }

        #region Properties

        public UIClient UIImportOptionsClient
        {
            get
            {
                if ((this.mUIImportOptionsClient == null))
                {
                    this.mUIImportOptionsClient = new UIClient(this, "Import Options");
                }
                return this.mUIImportOptionsClient;
            }
        }

        public UIClient UIImporttoTAMClient
        {
            get
            {
                if ((this.mUIImporttoTAMClient == null))
                {
                    this.mUIImporttoTAMClient = new UIClient(this, "Import to TAM");
                }
                return this.mUIImporttoTAMClient;
            }
        }

        public UIClient UIPanel1Client
        {
            get
            {
                if ((this.mUIPanel1Client == null))
                {
                    this.mUIPanel1Client = new UIClient(this, "Panel1");
                }
                return this.mUIPanel1Client;
            }
        }

        #endregion

        #region Fields

        private UIClient mUIImportOptionsClient;

        private UIClient mUIImporttoTAMClient;

        private UIClient mUIPanel1Client;

        #endregion
    }
}