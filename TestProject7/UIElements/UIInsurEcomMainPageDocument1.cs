namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

    public class UIInsurEcomMainPageDocument1 : HtmlDocument
    {
        public UIInsurEcomMainPageDocument1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[HtmlControl.PropertyNames.Id] = null;
            SearchProperties[PropertyNames.RedirectingPage] = "False";
            SearchProperties[PropertyNames.FrameDocument] = "True";
            FilterProperties[HtmlControl.PropertyNames.Title] = "insurE-com - Main Page";
            FilterProperties[PropertyNames.AbsolutePath] = "/sysmaint/content/AddHouseholdTestRenewalNotice.asp";
            FilterProperties[PropertyNames.PageUrl] = "https://www.insur-econnect.com/sysmaint/content/AddHouseholdTestRenewalNotice.asp" + "";
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
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtPolicyN";
                    mUITxtPolicyNumberEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    mUITxtPolicyNumberEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtPolicyNumberEdit;
            }
        }

        public HtmlTextArea UITxtClientXmlEdit
        {
            get
            {
                if ((mUITxtClientXmlEdit == null))
                {
                    mUITxtClientXmlEdit = new HtmlTextArea(this);

                    #region Search Criteria

                    mUITxtClientXmlEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUITxtClientXmlEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtClientXml";
                    mUITxtClientXmlEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() wrap=off cols=5";
                    mUITxtClientXmlEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "1";
                    mUITxtClientXmlEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtClientXmlEdit;
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
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtPremium";
                    mUITxtPremiumEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "3";
                    mUITxtPremiumEdit.WindowTitles.Add("insurE-com System Maintenance");
                    #endregion
                }
                return mUITxtPremiumEdit;
            }
        }

        public HtmlInputButton UIGetXMLfromServerButton
        {
            get
            {
                if ((mUIGetXMLfromServerButton == null))
                {
                    mUIGetXMLfromServerButton = new HtmlInputButton(this);

                    #region Search Criteria

                    mUIGetXMLfromServerButton.SearchProperties[HtmlControl.PropertyNames.Id] = "getXmlButton";
                    mUIGetXMLfromServerButton.SearchProperties[UITestControl.PropertyNames.Name] = "getXmlButton";
                    mUIGetXMLfromServerButton.FilterProperties[HtmlButton.PropertyNames.DisplayText] = "Get XML from Server";
                    mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Type] = "button";
                    mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Title] = "Click to get xml from server";
                    mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "id=getXmlButton title=\"Click to get xml ";
                    mUIGetXMLfromServerButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "5";
                    mUIGetXMLfromServerButton.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUIGetXMLfromServerButton;
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
                    mUICreateRecordButton.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "6";
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
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtRenewal";
                    mUITxtRenewalDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "2";
                    mUITxtRenewalDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtRenewalDateEdit;
            }
        }

        public HtmlEdit UITxtAutoLapseDateEdit
        {
            get
            {
                if ((mUITxtAutoLapseDateEdit == null))
                {
                    mUITxtAutoLapseDateEdit = new HtmlEdit(this);

                    #region Search Criteria

                    mUITxtAutoLapseDateEdit.SearchProperties[HtmlControl.PropertyNames.Id] = null;
                    mUITxtAutoLapseDateEdit.SearchProperties[UITestControl.PropertyNames.Name] = "txtAutoLapseDate";
                    mUITxtAutoLapseDateEdit.SearchProperties[HtmlEdit.PropertyNames.LabeledBy] = null;
                    mUITxtAutoLapseDateEdit.SearchProperties[HtmlControl.PropertyNames.Type] = "SINGLELINE";
                    mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.Title] = null;
                    mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.Class] = null;
                    mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.ControlDefinition] = "onchange=enableButtons() name=txtAutoLap";
                    mUITxtAutoLapseDateEdit.FilterProperties[HtmlControl.PropertyNames.TagInstance] = "4";
                    mUITxtAutoLapseDateEdit.WindowTitles.Add("insurE-com System Maintenance");

                    #endregion
                }
                return mUITxtAutoLapseDateEdit;
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

        private HtmlEdit mUITxtPremiumEdit;

        #endregion
    }
}