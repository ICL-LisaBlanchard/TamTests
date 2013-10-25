namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIContentFrame : HtmlFrame
    {
        public UIContentFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[UITestControl.PropertyNames.Name] = "content";
            FilterProperties[PropertyNames.AbsolutePath] = "content/home.asp";
            FilterProperties[PropertyNames.PageUrl] = "content/home.asp?store=";
            FilterProperties[HtmlControl.PropertyNames.Title] = null;
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "noResize marginHeight=0 src=\"content/hom";
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "3";
            WindowTitles.Add("Applied Systems UK - System Maintenance");

            #endregion
        }

        #region Properties

        public UIInsurEcomMainPageDocument UIInsurEcomMainPageDocument
        {
            get
            {
                if ((mUIInsurEcomMainPageDocument == null))
                {
                    mUIInsurEcomMainPageDocument = new UIInsurEcomMainPageDocument(this);
                }
                return mUIInsurEcomMainPageDocument;
            }
        }

        public UIInsurEcomMainPageDocument1 UIInsurEcomMainPageDocument1
        {
            get
            {
                if ((mUIInsurEcomMainPageDocument1 == null))
                {
                    mUIInsurEcomMainPageDocument1 = new UIInsurEcomMainPageDocument1(this);
                }
                return mUIInsurEcomMainPageDocument1;
            }
        }

        #endregion

        #region Fields

        private UIInsurEcomMainPageDocument mUIInsurEcomMainPageDocument;

        private UIInsurEcomMainPageDocument1 mUIInsurEcomMainPageDocument1;

        #endregion
    }
}