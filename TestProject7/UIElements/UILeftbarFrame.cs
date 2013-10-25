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

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[UITestControl.PropertyNames.Name] = "leftbar";
            FilterProperties[PropertyNames.AbsolutePath] = null;
            FilterProperties[PropertyNames.PageUrl] = "content/leftbar.asp";
            FilterProperties[HtmlControl.PropertyNames.Title] = null;
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "noResize src=\"content/leftbar.asp\" name=";
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
            WindowTitles.Add("Applied Systems UK - System Maintenance");

            #endregion
        }

        #region Properties

        public UIInsurEcomLeftbarDocument UIInsurEcomLeftbarDocument
        {
            get
            {
                if ((mUIInsurEcomLeftbarDocument == null))
                {
                    mUIInsurEcomLeftbarDocument = new UIInsurEcomLeftbarDocument(this);
                }
                return mUIInsurEcomLeftbarDocument;
            }
        }

        #endregion

        #region Fields

        private UIInsurEcomLeftbarDocument mUIInsurEcomLeftbarDocument;

        #endregion
    }
}