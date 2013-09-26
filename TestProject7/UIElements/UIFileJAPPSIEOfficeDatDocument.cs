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

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "False";
            FilterProperties[HtmlControl.PropertyNames.Title] = null;
            FilterProperties[PropertyNames.AbsolutePath] = "J:/APPS/IEOffice/Data/Xsl/QuoteDetails.htm";
            FilterProperties[PropertyNames.PageUrl] = "file://J:\\APPS\\IEOffice\\Data\\Xsl\\QuoteDetails.htm";
            WindowTitles.Add("View Quote Details");

            #endregion
        }

        #region Properties

        public UIItemTable UIItemTable
        {
            get
            {
                if ((mUIItemTable == null))
                {
                    mUIItemTable = new UIItemTable(this);
                }
                return mUIItemTable;
            }
        }

        public UIItemTable1 UIItemTable1
        {
            get
            {
                if ((mUIItemTable1 == null))
                {
                    mUIItemTable1 = new UIItemTable1(this);
                }
                return mUIItemTable1;
            }
        }

        #endregion

        #region Fields

        private UIItemTable mUIItemTable;

        private UIItemTable1 mUIItemTable1;

        #endregion
    }
}