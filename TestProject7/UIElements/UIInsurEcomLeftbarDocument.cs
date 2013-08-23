namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEcomLeftbarDocument : HtmlDocument
    {
        public UIInsurEcomLeftbarDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Left bar";
            this.FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/leftbar.asp";
            this.FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/leftbar.asp";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlHyperlink UIRenewalsMaintenanceHyperlink
        {
            get
            {
                if ((this.mUIRenewalsMaintenanceHyperlink == null))
                {
                    this.mUIRenewalsMaintenanceHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    this.mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUIRenewalsMaintenanceHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Renewals Maintenance";
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/leftbar.asp";
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://www.insur-econnect.com/sysmaint/content/leftbar.asp#";
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "style=\"COLOR: white\" href=\"#\"";
                    this.mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "39";
                    this.mUIRenewalsMaintenanceHyperlink.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUIRenewalsMaintenanceHyperlink;
            }
        }

        #endregion

        #region Fields

        private HtmlHyperlink mUIRenewalsMaintenanceHyperlink;

        #endregion
    }
}