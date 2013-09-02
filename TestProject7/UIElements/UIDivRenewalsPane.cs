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

            this.SearchProperties[HtmlControl.PropertyNames.Id] = "divRenewals";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties[HtmlControl.PropertyNames.InnerText] = "Create a Motor Test Renewal Invitation\r\n";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = null;
            this.FilterProperties[HtmlControl.PropertyNames.Class] = null;
            this.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=divRenewals";
            this.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "14";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlHyperlink UICreateaMotorTestReneHyperlink
        {
            get
            {
                if ((this.mUICreateaMotorTestReneHyperlink == null))
                {
                    this.mUICreateaMotorTestReneHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    this.mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUICreateaMotorTestReneHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = "content";
                    this.mUICreateaMotorTestReneHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Create a Motor Test Renewal Invitation";
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/AddTestRenewalNotice.asp";
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                        "https://www.insur-econnect.com/sysmaint/content/AddTestRenewalNotice.asp";
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = "itemlink";
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=itemlink href=\"AddTestRenewalNotic";
                    this.mUICreateaMotorTestReneHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    this.mUICreateaMotorTestReneHyperlink.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUICreateaMotorTestReneHyperlink;
            }
        }

        public HtmlHyperlink UICreateaHouseholdTestHyperlink
        {
            get
            {
                if ((this.mUICreateaHouseholdTestHyperlink == null))
                {
                    this.mUICreateaHouseholdTestHyperlink = new HtmlHyperlink(this);

                    #region Search Criteria

                    this.mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUICreateaHouseholdTestHyperlink.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = "content";
                    this.mUICreateaHouseholdTestHyperlink.SearchProperties[HtmlControl.PropertyNames.InnerText] = "Create a Household Test Renewal Invitation";
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/sysmaint/content/AddHouseholdTestRenewalNotice.asp";
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] =
                        "https://www.insur-econnect.com/sysmaint/content/AddHouseholdTestRenewalNotice.asp" + "";
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.Class] = "itemlink";
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "class=itemlink href=\"AddHouseholdTestRen";
                    this.mUICreateaHouseholdTestHyperlink.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
                    this.mUICreateaHouseholdTestHyperlink.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUICreateaHouseholdTestHyperlink;
            }
        }

        #endregion

        #region Fields

        private HtmlHyperlink mUICreateaMotorTestReneHyperlink;

        private HtmlHyperlink mUICreateaHouseholdTestHyperlink;

        #endregion
    }
}