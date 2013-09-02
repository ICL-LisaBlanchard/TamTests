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

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Main Page";
            this.FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/AddTestRenewalNotice.asp";
            this.FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/AddTestRenewalNotice.asp";
            this.WindowTitles.Add("insurE-com System Maintenance");

            #endregion
        }

        #region Properties

        public HtmlComboBox UIInsurerIDComboBox
        {
            get
            {
                if ((this.mUIInsurerIDComboBox == null))
                {
                    this.mUIInsurerIDComboBox = new HtmlComboBox(this);

                    #region Search Criteria

                    this.mUIInsurerIDComboBox.SearchProperties[HtmlControl.PropertyNames.Id] = "InsurerID";
                    this.mUIInsurerIDComboBox.SearchProperties[UITestControl.PropertyNames.Name] = "InsurerID";
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.Size] = "0";
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.LabeledBy] = null;
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlComboBox.PropertyNames.ItemCount] = "54";
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=InsurerID onchange=selectInsurer() na";
                    this.mUIInsurerIDComboBox.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    this.mUIInsurerIDComboBox.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUIInsurerIDComboBox;
            }
        }

        public HtmlEdit UITxtPolicyNumberEdit
        {
            get
            {
                if ((this.mUITxtPolicyNumberEdit == null))
                {
                    this.mUITxtPolicyNumberEdit = new HtmlEdit(this);

                    #region Search Criteria

                    this.mUITxtPolicyNumberEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUITxtPolicyNumberEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtPolicyNumber";
                    this.mUITxtPolicyNumberEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtPolicyNumberEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtPolicyNumber align=left size=15";
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    this.mUITxtPolicyNumberEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtPolicyNumberEdit;
            }
        }

        public HtmlEdit UITxtAutoLapseDateEdit1
        {
            get
            {
                if ((this.mUITxtAutoLapseDateEdit1 == null))
                {
                    this.mUITxtAutoLapseDateEdit1 = new HtmlEdit(this);

                    #region Search Criteria

                    this.mUITxtAutoLapseDateEdit1.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUITxtAutoLapseDateEdit1.SearchProperties[UITestControl.PropertyNames.Name] = "txtAutoLapseDate";
                    this.mUITxtAutoLapseDateEdit1.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtAutoLapseDateEdit1.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtAutoLapseDate maxLength=10 value";
                    this.mUITxtAutoLapseDateEdit1.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "8";
                    this.mUITxtAutoLapseDateEdit1.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtAutoLapseDateEdit1;
            }
        }

        public HtmlInputButton UICreateRecordButton
        {
            get
            {
                if ((this.mUICreateRecordButton == null))
                {
                    this.mUICreateRecordButton = new HtmlInputButton(this);

                    #region Search Criteria

                    this.mUICreateRecordButton.SearchProperties[HtmlControl.PropertyNames.Id] = "buttonCreate";
                    this.mUICreateRecordButton.SearchProperties[UITestControl.PropertyNames.Name] = "buttonCreate";
                    this.mUICreateRecordButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "  Create Record  ";
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Type] = "button";
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Title] = "Click to create the new record";
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=buttonCreate title=\"Click to create t";
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "10";
                    this.mUICreateRecordButton.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUICreateRecordButton;
            }
        }

        public HtmlEdit UITxtRenewalDateEdit
        {
            get
            {
                if ((this.mUITxtRenewalDateEdit == null))
                {
                    this.mUITxtRenewalDateEdit = new HtmlEdit(this);

                    #region Search Criteria

                    this.mUITxtRenewalDateEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUITxtRenewalDateEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtRenewalDate";
                    this.mUITxtRenewalDateEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtRenewalDateEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "name=txtRenewalDate value=12/11/2012 siz";
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "6";
                    this.mUITxtRenewalDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtRenewalDateEdit;
            }
        }

        #endregion

        #region Fields

        private HtmlComboBox mUIInsurerIDComboBox;

        private HtmlEdit mUITxtPolicyNumberEdit;

        private HtmlEdit mUITxtAutoLapseDateEdit1;

        private HtmlInputButton mUICreateRecordButton;

        private HtmlEdit mUITxtRenewalDateEdit;

        #endregion
    }
}