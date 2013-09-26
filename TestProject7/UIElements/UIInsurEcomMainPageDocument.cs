namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIInsurEcomMainPageDocument : HtmlDocument
    {
        public UIInsurEcomMainPageDocument(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "True";
            FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Main Page";
            FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/AddTestRenewalNotice.asp";
            FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/AddTestRenewalNotice.asp";
            WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlComboBox UIInsurerIDComboBox
        {
            get
            {
                if ((mUIInsurerIDComboBox == null))
                {
                    mUIInsurerIDComboBox = new HtmlComboBox(this);

                    #region Search Criteria

                    mUIInsurerIDComboBox.SearchProperties[HtmlControl.PropertyNames.Id] = "InsurerID";
                    mUIInsurerIDComboBox.SearchProperties[UITestControl.PropertyNames.Name] = "InsurerID";
                    mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = null;
                    mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "54";
                    mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=InsurerID onchange=selectInsurer() na";
                    mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    mUIInsurerIDComboBox.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUIInsurerIDComboBox;
            }
        }

        public HtmlEdit UITxtPremiumEdit
        {
            get
            {
                if ((mUITxtPremiumEdit == null))
                {
                    mUITxtPremiumEdit = new HtmlEdit(this);
                    #region Search Criteria
                    mUITxtPremiumEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = null;
                    mUITxtPremiumEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "txtPremium";
                    mUITxtPremiumEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtPremiumEdit.SearchProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = null;
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=txtPremium align=left value=500.00 ";
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    mUITxtPremiumEdit.WindowTitles.Add("insurE-com System Maintenance");
                    #endregion
                }
                return mUITxtPremiumEdit;
            }
        }

        public HtmlEdit UITxtPolicyNumberEdit
        {
            get
            {
                if ((mUITxtPolicyNumberEdit == null))
                {
                    mUITxtPolicyNumberEdit = new HtmlEdit(this);

                    #region Search Criteria

                    mUITxtPolicyNumberEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUITxtPolicyNumberEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtPolicyNumber";
                    mUITxtPolicyNumberEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtPolicyNumberEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtPolicyNumber align=left size=15";
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    mUITxtPolicyNumberEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtPolicyNumberEdit;
            }
        }

        public HtmlEdit UITxtAutoLapseDateEdit1
        {
            get
            {
                if ((mUITxtAutoLapseDateEdit1 == null))
                {
                    mUITxtAutoLapseDateEdit1 = new HtmlEdit(this);

                    #region Search Criteria

                    mUITxtAutoLapseDateEdit1.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUITxtAutoLapseDateEdit1.SearchProperties[UITestControl.PropertyNames.Name] = "txtAutoLapseDate";
                    mUITxtAutoLapseDateEdit1.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtAutoLapseDateEdit1.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtAutoLapseDate maxLength=10 value";
                    mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "8";
                    mUITxtAutoLapseDateEdit1.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtAutoLapseDateEdit1;
            }
        }

        public HtmlInputButton UICreateRecordButton
        {
            get
            {
                if ((mUICreateRecordButton == null))
                {
                    mUICreateRecordButton = new HtmlInputButton(this);

                    #region Search Criteria

                    mUICreateRecordButton.SearchProperties[HtmlControl.PropertyNames.Id] = "buttonCreate";
                    mUICreateRecordButton.SearchProperties[UITestControl.PropertyNames.Name] = "buttonCreate";
                    mUICreateRecordButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "  Create Record  ";
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Type] = "button";
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Title] = "Click to create the new record";
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=buttonCreate title=\"Click to create t";
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "10";
                    mUICreateRecordButton.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUICreateRecordButton;
            }
        }

        public HtmlEdit UITxtRenewalDateEdit
        {
            get
            {
                if ((mUITxtRenewalDateEdit == null))
                {
                    mUITxtRenewalDateEdit = new HtmlEdit(this);

                    #region Search Criteria

                    mUITxtRenewalDateEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUITxtRenewalDateEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtRenewalDate";
                    mUITxtRenewalDateEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtRenewalDateEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtRenewalDate value=12/11/2012 siz";
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "6";
                    mUITxtRenewalDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtRenewalDateEdit;
            }
        }

        #endregion

        #region Fields

        private HtmlComboBox mUIInsurerIDComboBox;

        private HtmlEdit mUITxtPolicyNumberEdit;

        private HtmlEdit mUITxtAutoLapseDateEdit1;

        private HtmlInputButton mUICreateRecordButton;

        private HtmlEdit mUITxtRenewalDateEdit;

        private HtmlEdit mUITxtPremiumEdit;

        #endregion
    }
}