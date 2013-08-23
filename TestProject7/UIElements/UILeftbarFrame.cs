namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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

        public UIInsurEcomLeftbarDocument1 UIInsurEcomLeftbarDocument1
        {
            get
            {
                if ((this.mUIInsurEcomLeftbarDocument1 == null))
                {
                    this.mUIInsurEcomLeftbarDocument1 = new UIInsurEcomLeftbarDocument1(this);
                }
                return this.mUIInsurEcomLeftbarDocument1;
            }
        }

        #endregion

        #region Fields

        private UIInsurEcomLeftbarDocument mUIInsurEcomLeftbarDocument;

        private UIInsurEcomLeftbarDocument1 mUIInsurEcomLeftbarDocument1;

        #endregion
    }
}