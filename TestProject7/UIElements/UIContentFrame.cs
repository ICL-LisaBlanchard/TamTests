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

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[UITestControl.PropertyNames.Name] = "content";
            this.FilterProperties[PropertyNames.AbsolutePath] = "content/home.asp";
            this.FilterProperties[PropertyNames.PageUrl] = "content/home.asp?store=";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = null;
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "noResize marginHeight=0 src=\"content/hom";
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "3";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public UIInsurEcomMainPageDocument UIInsurEcomMainPageDocument
        {
            get
            {
                if ((this.mUIInsurEcomMainPageDocument == null))
                {
                    this.mUIInsurEcomMainPageDocument = new UIInsurEcomMainPageDocument(this);
                }
                return this.mUIInsurEcomMainPageDocument;
            }
        }

        public UIInsurEcomMainPageDocument1 UIInsurEcomMainPageDocument1
        {
            get
            {
                if ((this.mUIInsurEcomMainPageDocument1 == null))
                {
                    this.mUIInsurEcomMainPageDocument1 = new UIInsurEcomMainPageDocument1(this);
                }
                return this.mUIInsurEcomMainPageDocument1;
            }
        }

        #endregion

        #region Fields

        private UIInsurEcomMainPageDocument mUIInsurEcomMainPageDocument;

        private UIInsurEcomMainPageDocument1 mUIInsurEcomMainPageDocument1;

        #endregion
    }
}