namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemClient1 : WinClient
    {
        public UIItemClient1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "Internet Explorer_Server";
            this.WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public UIFileJAPPSIEOfficeDatDocument UIFileJAPPSIEOfficeDatDocument
        {
            get
            {
                if ((this.mUIFileJAPPSIEOfficeDatDocument == null))
                {
                    this.mUIFileJAPPSIEOfficeDatDocument = new UIFileJAPPSIEOfficeDatDocument(this);
                }
                return this.mUIFileJAPPSIEOfficeDatDocument;
            }
        }

        #endregion

        #region Fields

        private UIFileJAPPSIEOfficeDatDocument mUIFileJAPPSIEOfficeDatDocument;

        #endregion
    }
}