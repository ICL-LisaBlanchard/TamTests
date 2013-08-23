namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEcomLeftbarDocument1 : HtmlDocument
    {
        public UIInsurEcomLeftbarDocument1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Left bar";
            this.FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/leftbar.asp";
            this.FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/leftbar.asp#";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public UIDivRenewalsPane UIDivRenewalsPane
        {
            get
            {
                if ((this.mUIDivRenewalsPane == null))
                {
                    this.mUIDivRenewalsPane = new UIDivRenewalsPane(this);
                }
                return this.mUIDivRenewalsPane;
            }
        }

        #endregion

        #region Fields

        private UIDivRenewalsPane mUIDivRenewalsPane;

        #endregion
    }
}