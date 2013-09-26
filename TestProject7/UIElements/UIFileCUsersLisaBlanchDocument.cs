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

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "False";
            FilterProperties[HtmlControl.PropertyNames.Title] = null;

            SearchProperties.Add(new PropertyExpression(PropertyNames.AbsolutePath, "Quot", PropertyExpressionOperator.Contains));
            SearchProperties.Add(new PropertyExpression(PropertyNames.PageUrl, "Quot", PropertyExpressionOperator.Contains));
            WindowTitles.Add("Quote.htm");

            #endregion
        }

        #region Properties

        public UIItemTable2 UIItemTable
        {
            get
            {
                if ((mUIItemTable == null))
                {
                    mUIItemTable = new UIItemTable2(this);
                }
                return mUIItemTable;
            }
        }

        #endregion

        #region Fields

        private UIItemTable2 mUIItemTable;

        #endregion
    }
}