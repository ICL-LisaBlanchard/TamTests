namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow54 : WinWindow
    {
        public UIItemWindow54(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TPanel";
            this.WindowTitles.Add("Please select WHO to follow up");

            #endregion
        }

        #region Properties

        public UIPleaseselectWHOtofolClient UIPleaseselectWHOtofolClient
        {
            get
            {
                if ((this.mUIPleaseselectWHOtofolClient == null))
                {
                    this.mUIPleaseselectWHOtofolClient = new UIPleaseselectWHOtofolClient(this);
                }
                return this.mUIPleaseselectWHOtofolClient;
            }
        }

        #endregion

        #region Fields

        private UIPleaseselectWHOtofolClient mUIPleaseselectWHOtofolClient;

        #endregion
    }
}