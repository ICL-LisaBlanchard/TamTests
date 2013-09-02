namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIFileJAPPSIEOfficeDatDocument : HtmlDocument
    {
        public UIFileJAPPSIEOfficeDatDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = null;
            this.FilterProperties[PropertyNames.AbsolutePath] = "J:/APPS/IEOffice/Data/Xsl/QuoteDetails.htm";
            this.FilterProperties[PropertyNames.PageUrl] = "file://J:\\APPS\\IEOffice\\Data\\Xsl\\QuoteDetails.htm";
            this.WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public UIItemTable UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable(this);
                }
                return this.mUIItemTable;
            }
        }

        public UIItemTable1 UIItemTable1
        {
            get
            {
                if ((this.mUIItemTable1 == null))
                {
                    this.mUIItemTable1 = new UIItemTable1(this);
                }
                return this.mUIItemTable1;
            }
        }

        #endregion

        #region Fields

        private UIItemTable mUIItemTable;

        private UIItemTable1 mUIItemTable1;

        #endregion
    }
}