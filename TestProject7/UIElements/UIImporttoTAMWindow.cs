namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

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

        public UIImportOptionsClient UIImportOptionsClient
        {
            get
            {
                if ((this.mUIImportOptionsClient == null))
                {
                    this.mUIImportOptionsClient = new UIImportOptionsClient(this);
                }
                return this.mUIImportOptionsClient;
            }
        }

        public UIImporttoTAMClient UIImporttoTAMClient
        {
            get
            {
                if ((this.mUIImporttoTAMClient == null))
                {
                    this.mUIImporttoTAMClient = new UIImporttoTAMClient(this);
                }
                return this.mUIImporttoTAMClient;
            }
        }

        public UIPanel1Client UIPanel1Client
        {
            get
            {
                if ((this.mUIPanel1Client == null))
                {
                    this.mUIPanel1Client = new UIPanel1Client(this);
                }
                return this.mUIPanel1Client;
            }
        }

        #endregion

        #region Fields

        private UIImportOptionsClient mUIImportOptionsClient;

        private UIImporttoTAMClient mUIImporttoTAMClient;

        private UIPanel1Client mUIPanel1Client;

        #endregion
    }
}