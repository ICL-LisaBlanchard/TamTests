namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIDivRenewalsPane : HtmlDiv
    {
        public UIDivRenewalsPane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = "divRenewals";
            SearchProperties[UITestControl.PropertyNames.Name] = null;
            FilterProperties[HtmlControl.PropertyNames.InnerText] = "Create a Motor Test Renewal Invitation\r\n";
            FilterProperties[HtmlControl.PropertyNames.Title] = null;
            FilterProperties[HtmlControl.PropertyNames.Class] = null;
            FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=divRenewals";
            FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";
            WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlHyperlink UICreateaMotorTestReneHyperlink
        {
            get
            {
                if ((mUICreateaMotorTestReneHyperlink == null))
                {
                    mUICreateaMotorTestReneHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUICreateaMotorTestReneHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = "content";
                    mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Create a Motor Test Renewal Invitation";
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/AddTestRenewalNotice.asp";
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                        "https://www.insur-econnect.com/sysmaint/content/AddTestRenewalNotice.asp";
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = "itemlink";
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=itemlink href=\"AddTestRenewalNotic";
                    mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    mUICreateaMotorTestReneHyperlink.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUICreateaMotorTestReneHyperlink;
            }
        }

        public HtmlHyperlink UICreateaHouseholdTestHyperlink
        {
            get
            {
                if ((mUICreateaHouseholdTestHyperlink == null))
                {
                    mUICreateaHouseholdTestHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUICreateaHouseholdTestHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = "content";
                    mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Create a Household Test Renewal Invitation";
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/AddHouseholdTestRenewalNotice.asp";
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                        "https://www.insur-econnect.com/sysmaint/content/AddHouseholdTestRenewalNotice.asp" + "";
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = "itemlink";
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=itemlink href=\"AddHouseholdTestRen";
                    mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
                    mUICreateaHouseholdTestHyperlink.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUICreateaHouseholdTestHyperlink;
            }
        }

        #endregion

        #region Fields

        private HtmlHyperlink mUICreateaMotorTestReneHyperlink;

        private HtmlHyperlink mUICreateaHouseholdTestHyperlink;

        #endregion
    }
}