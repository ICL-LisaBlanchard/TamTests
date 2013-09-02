namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

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