namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIFileCUsersLisaBlanchDocument : HtmlDocument
    {
        public UIFileCUsersLisaBlanchDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = null;

            this.SearchProperties.Add(new PropertyExpression(PropertyNames.AbsolutePath, "HHQuot", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(PropertyNames.PageUrl, "HHQuot", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("\\HHQuote.htm");

            #endregion
        }

        #region Properties

        public UIItemTable2 UIItemTable
        {
            get
            {
                if ((this.mUIItemTable == null))
                {
                    this.mUIItemTable = new UIItemTable2(this);
                }
                return this.mUIItemTable;
            }
        }

        #endregion

        #region Fields

        private UIItemTable2 mUIItemTable;

        #endregion
    }
}