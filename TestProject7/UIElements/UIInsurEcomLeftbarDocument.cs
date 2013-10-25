namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIInsurEcomLeftbarDocument : HtmlDocument
    {
        public UIInsurEcomLeftbarDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "True";
            FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Left bar";
            FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/leftbar.asp";
            FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/leftbar.asp";
            WindowTitles.Add("Applied Systems UK - System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlHyperlink UIRenewalsMaintenanceHyperlink
        {
            get
            {
                if ((mUIRenewalsMaintenanceHyperlink == null))
                {
                    mUIRenewalsMaintenanceHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUIRenewalsMaintenanceHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    mUIRenewalsMaintenanceHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Renewals Maintenance";
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/leftbar.asp";
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "https://www.insur-econnect.com/sysmaint/content/leftbar.asp#";
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "style=\"COLOR: white\" href=\"#\"";
                    mUIRenewalsMaintenanceHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "39";
                    mUIRenewalsMaintenanceHyperlink.WindowTitles.Add("Applied Systems UK - System Maintenance");

                    #endregion
                }
                return mUIRenewalsMaintenanceHyperlink;
            }
        }

        public UIDivRenewalsPane UIDivRenewalsPane
        {
            get
            {
                if ((mUIDivRenewalsPane == null))
                {
                    mUIDivRenewalsPane = new UIDivRenewalsPane(this);
                }
                return mUIDivRenewalsPane;
            }
        }

        #endregion

        #region Fields

        private HtmlHyperlink mUIRenewalsMaintenanceHyperlink;

        private UIDivRenewalsPane mUIDivRenewalsPane;

        #endregion
    }
}