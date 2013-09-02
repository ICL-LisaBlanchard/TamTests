namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UILeftbarFrame : HtmlFrame
    {
        public UILeftbarFrame(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[UITestControl.PropertyNames.Name] = "leftbar";
            this.FilterProperties[PropertyNames.AbsolutePath] = null;
            this.FilterProperties[PropertyNames.PageUrl] = "content/leftbar.asp";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = null;
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "noResize src=\"content/leftbar.asp\" name=";
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public UIInsurEcomLeftbarDocument UIInsurEcomLeftbarDocument
        {
            get
            {
                if ((this.mUIInsurEcomLeftbarDocument == null))
                {
                    this.mUIInsurEcomLeftbarDocument = new UIInsurEcomLeftbarDocument(this);
                }
                return this.mUIInsurEcomLeftbarDocument;
            }
        }

        #endregion

        #region Fields

        private UIInsurEcomLeftbarDocument mUIInsurEcomLeftbarDocument;

        #endregion
    }
}