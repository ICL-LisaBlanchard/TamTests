namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEcomMainPageDocument1 : HtmlDocument
    {
        public UIInsurEcomMainPageDocument1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[HtmlControl.PropertyNames.Id] = null;
            this.SearchProperties[PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[PropertyNames.FrameDocument] = "True";
            this.FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Main Page";
            this.FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/AddHouseholdTestRenewalNotice.asp";
            this.FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/AddHouseholdTestRenewalNotice.asp" + "";
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
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtPolicyN";
                    this.mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    this.mUITxtPolicyNumberEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtPolicyNumberEdit;
            }
        }

        public HtmlTextArea UITxtClientXmlEdit
        {
            get
            {
                if ((this.mUITxtClientXmlEdit == null))
                {
                    this.mUITxtClientXmlEdit = new HtmlTextArea(this);

                    #region Search Criteria

                    this.mUITxtClientXmlEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUITxtClientXmlEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtClientXml";
                    this.mUITxtClientXmlEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() wrap=off cols=5";
                    this.mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    this.mUITxtClientXmlEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtClientXmlEdit;
            }
        }

        public HtmlInputButton UIGetXMLfromServerButton
        {
            get
            {
                if ((this.mUIGetXMLfromServerButton == null))
                {
                    this.mUIGetXMLfromServerButton = new HtmlInputButton(this);

                    #region Search Criteria

                    this.mUIGetXMLfromServerButton.SearchProperties[HtmlControl.PropertyNames.Id] = "getXmlButton";
                    this.mUIGetXMLfromServerButton.SearchProperties[UITestControl.PropertyNames.Name] = "getXmlButton";
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Get XML from Server";
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Type] = "button";
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Title] = "Click to get xml from server";
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=getXmlButton title=\"Click to get xml ";
                    this.mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "5";
                    this.mUIGetXMLfromServerButton.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUIGetXMLfromServerButton;
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
                    this.mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "6";
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
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtRenewal";
                    this.mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
                    this.mUITxtRenewalDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtRenewalDateEdit;
            }
        }

        public HtmlEdit UITxtAutoLapseDateEdit
        {
            get
            {
                if ((this.mUITxtAutoLapseDateEdit == null))
                {
                    this.mUITxtAutoLapseDateEdit = new HtmlEdit(this);

                    #region Search Criteria

                    this.mUITxtAutoLapseDateEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    this.mUITxtAutoLapseDateEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtAutoLapseDate";
                    this.mUITxtAutoLapseDateEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    this.mUITxtAutoLapseDateEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    this.mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    this.mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    this.mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtAutoLap";
                    this.mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "4";
                    this.mUITxtAutoLapseDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return this.mUITxtAutoLapseDateEdit;
            }
        }

        #endregion

        #region Fields

        private HtmlComboBox mUIInsurerIDComboBox;

        private HtmlEdit mUITxtPolicyNumberEdit;

        private HtmlTextArea mUITxtClientXmlEdit;

        private HtmlInputButton mUIGetXMLfromServerButton;

        private HtmlInputButton mUICreateRecordButton;

        private HtmlEdit mUITxtRenewalDateEdit;

        private HtmlEdit mUITxtAutoLapseDateEdit;

        #endregion
    }
}