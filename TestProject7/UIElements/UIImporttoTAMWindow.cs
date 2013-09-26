namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIImporttoTAMWindow : WinWindow
    {
        public UIImporttoTAMWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Import to TAM";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfImportToTam";
            WindowTitles.Add("Import to TAM");

            #endregion
        }

        #region Properties

        public UIClient UIImportOptionsClient
        {
            get
            {
                if ((mUIImportOptionsClient == null))
                {
                    mUIImportOptionsClient = new UIClient(this, "Import Options");
                }
                return mUIImportOptionsClient;
            }
        }

        public UIClient UIImporttoTAMClient
        {
            get
            {
                if ((mUIImporttoTAMClient == null))
                {
                    mUIImporttoTAMClient = new UIClient(this, "Import to TAM");
                }
                return mUIImporttoTAMClient;
            }
        }

        public UIClient UIPanel1Client
        {
            get
            {
                if ((mUIPanel1Client == null))
                {
                    mUIPanel1Client = new UIClient(this, "Panel1");
                }
                return mUIPanel1Client;
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