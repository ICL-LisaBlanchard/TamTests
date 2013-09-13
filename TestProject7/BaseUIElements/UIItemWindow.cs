namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemWindow : WinWindow
    {
        public UIItemWindow(
            UITestControl searchLimitContainer,
            string controlId = "",
            string instance = "",
            string className = "",
            string accessible = "",
            string name = "",
            string checkboxName = "")
            : base(searchLimitContainer)
        {
            #region Search Criteria

            if (searchLimitContainer.WindowTitles.Count > 0)
            {
                this.WindowName = searchLimitContainer.WindowTitles[0];
            }

            this.WindowTitles.Add(this.WindowName);

            if (!string.IsNullOrEmpty(controlId))
            {
                this.SearchProperties[WinControl.PropertyNames.ControlId] = controlId;
            }

            if (!string.IsNullOrEmpty(instance))
            {
                this.SearchProperties[UITestControl.PropertyNames.Instance] = instance;
            }

            if (!string.IsNullOrEmpty(className))
            {
                this.SearchProperties[UITestControl.PropertyNames.ClassName] = className;
            }

            if (!string.IsNullOrEmpty(accessible))
            {
                this.SearchProperties[PropertyNames.AccessibleName] = accessible;
            }

            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, name, PropertyExpressionOperator.Contains));
            }

            #endregion
        }

        public UIItemWindow(string controlId = "", string instance = "", string className = "", string accessible = "", string name = "")
        {
            #region Search Criteria

            this.WindowTitles.Add(this.WindowName);

            if (!string.IsNullOrEmpty(controlId))
            {
                this.SearchProperties[WinControl.PropertyNames.ControlId] = controlId;
            }

            if (!string.IsNullOrEmpty(instance))
            {
                this.SearchProperties[UITestControl.PropertyNames.Instance] = instance;
            }

            if (!string.IsNullOrEmpty(className))
            {
                this.SearchProperties[UITestControl.PropertyNames.ClassName] = className;
            }

            if (!string.IsNullOrEmpty(accessible))
            {
                this.SearchProperties[PropertyNames.AccessibleName] = accessible;
            }

            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            #endregion
        }

        public string WindowName { get; set; }

        #region Properties

        public UIItemList UIItemList
        {
            get
            {
                return new UIItemList(this, "");
            }
        }

        public UIItemList UIHHQuotehtmList
        {
            get
            {
                return new UIItemList(this, "HHQuote.htm");
            }
        }

        public UIItemWindow ItemWindow(
            UITestControl searchLimitContainer, string windowTitle, string controlId = "", string instance = "", string className = "", string accessibleName = "")
        {
            return new UIItemWindow(searchLimitContainer, controlId, instance, className);
        }

        #endregion

        #region "Buttons"

        public UIButton UIItemButton
        {
            get
            {
                return new UIButton(this, "");
            }
        }

        public UIButton UICloseButton
        {
            get
            {
                return new UIButton(this, "Close");
            }
        }

        public UIButton UIProposerDetailsButton
        {
            get
            {
                return new UIButton(this, "Proposer Details");
            }
        }

        public UIButton UICalculateQuoteButton
        {
            get
            {
                return new UIButton(this, "Calculate Quote");
            }
        }

        public UIButton UIClientsFilesButton
        {
            get
            {
                return new UIButton(this, "Clients & Files");
            }
        }

        public UIButton UIAddButton
        {
            get
            {
                return new UIButton(this, "Add");
            }
        }

        public UIButton UIYesButton
        {
            get
            {
                return new UIButton(this, "Yes");
            }
        }

        public UIButton UINoButton
        {
            get
            {
                return new UIButton(this, "No");
            }
        }

        public UIButton UILookupButton
        {
            get
            {
                return new UIButton(this, "Lookup");
            }
        }

        public UIButton UINextButton
        {
            get
            {
                return new UIButton(this, "Next");
            }
        }

        public UIButton UIOKButton
        {
            get
            {
                return new UIButton(this, "OK");
            }
        }

        public UIButton UICancelButton
        {
            get
            {
                return new UIButton(this, "Cancel");
            }
        }

        public UIButton UIOptionsButton
        {
            get
            {
                return new UIButton(this, "Options");
            }
        }

        public UIButton UIDetailButton
        {
            get
            {
                return new UIButton(this, "Detail");
            }
        }

        public UIButton UIAcceptButton
        {
            get
            {
                return new UIButton(this, "Accept");
            }
        }

        public UIButton UIExitButton
        {
            get
            {
                return new UIButton(this, "Exit");
            }
        }

        public UIButton UIPrintQuoteButton
        {
            get
            {
                return new UIButton(this, "Print Quote");
            }
        }

        public UIButton UIAWAPButton
        {
            get
            {
                return new UIButton(this, "AWAP");
            }
        }

        public UIButton UIDemandsNeedsButton
        {
            get
            {
                return new UIButton(this, "Demands & Needs");
            }
        }

        public UIButton UIPolicySummaryButton
        {
            get
            {
                return new UIButton(this, "Policy Summary");
            }
        }

        public UIButton UIPremiumButton
        {
            get
            {
                return new UIButton(this, "Premium");
            }
        }

        public UIButton UIFilterButton
        {
            get
            {
                return new UIButton(this, "Filter");
            }
        }

        public UIButton UIBeforeButton
        {
            get
            {
                return new UIButton(this, "Before");
            }
        }

        public UIButton UIAfterButton
        {
            get
            {
                return new UIButton(this, "After");
            }
        }

        public UIButton UIQuoteButton
        {
            get
            {
                return new UIButton(this, "Quote");
            }
        }

        public UIButton UIRegressButton
        {
            get
            {
                return new UIButton(this, "Regress");
            }
        }

        public UIButton UISelectAlternativeButton
        {
            get
            {
                return new UIButton(this, "Select Alternative");
            }
        }

        public UIButton UISaveButton
        {
            get
            {
                return new UIButton(this, "Save");
            }
        }

        public UIButton UIConfirmButton
        {
            get
            {
                return new UIButton(this, "Confirm");
            }
        }

        public UIButton UIInviteButton
        {
            get
            {
                return new UIButton(this, "Invite", false);
            }
        }

        public UIButton UIRenewPolicyButton
        {
            get
            {
                return new UIButton(this, "Renew Policy");
            }
        }

        public UIButton UIAmendRiskButton
        {
            get
            {
                return new UIButton(this, "Amend Risk");
            }
        }

        public UIButton UIRebrokeButton
        {
            get
            {
                return new UIButton(this, "Rebroke");
            }
        }

        public UIButton UIMTAButton
        {
            get
            {
                return new UIButton(this, "MTA");
            }
        }

        public UIButton UIEDIMatchButton
        {
            get
            {
                return new UIButton(this, "EDI Match");
            }
        }

        public UIButton UILogandClearButton
        {
            get
            {
                return new UIButton(this, "Log and Clear");
            }
        }

        public UIButton UIDisplayRecordButton
        {
            get
            {
                return new UIButton(this, "Display Record");
            }
        }

        public UIButton UIProceedButton
        {
            get
            {
                return new UIButton(this, "Proceed");
            }
        }

        public UIButton UINewButton
        {
            get
            {
                return new UIButton(this, "New");
            }
        }

        public UIButton UIButton(string name)
        {
            return new UIButton(this, name);
        }

        #endregion

        #region " Groups "

        public WinGroup UIQuoteDetailsGroup
        {
            get
            {
                return new UIGroup(this, "Quote Details");
            }
        }

        public WinGroup UIGroup(string name = "")
        {
            return new UIGroup(this, name);
        }

        #endregion

        #region " Radiobuttons "

        public WinRadioButton UIComprehensiveRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Comprehensive");
            }
        }

        public WinRadioButton UIPersonalLinesRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Personal Lines");
            }
        }

        public WinRadioButton UITitleRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Mr.");
            }
        }

        public WinRadioButton UISuffixRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Jr.");
            }
        }

        public WinRadioButton UIHouseholdRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Household");
            }
        }

        public WinRadioButton UIAlternativeRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Alternative");
            }
        }

        public WinRadioButton UIRadioButton(string name)
        {
            return new UIRadioButton(this, name);
        }

        #endregion

        #region " Title Bar "

        public WinTitleBar UIItemTitleBar
        {
            get
            {
                if ((this.mUIItemTitleBar == null))
                {
                    this.mUIItemTitleBar = new WinTitleBar(this);
                }
                return this.mUIItemTitleBar;
            }
        }

        #endregion

        #region " Clients "

        public UIClient UIClient(string name = "")
        {
            return new UIClient(this, name);
        }

        #endregion

        #region " Edit "

        public WinEdit UIItemEdit
        {
            get
            {
                return new UIItemEdit(this, string.Empty);
            }
        }

        public WinEdit UIOpenEdit
        {
            get

            {
                return new UIItemEdit(this, "Open:");
            }
        }

        public WinEdit UIFilenameEdit
        {
            get
            {
                return new UIItemEdit(this, "File name:");
            }
        }

        public WinEdit UIAddressandsearchusinEdit
        {
            get
            {
                return new UIItemEdit(this, "Address and search using Bing");
            }
        }

        public WinEdit UIEdit(string name)
        {
            return new UIItemEdit(this, name);
        }

        #endregion

        #region " Combo Box "

        public UIItemComboBox UIOpenComboBox
        {
            get
            {
                return new UIItemComboBox(this, "Open:");
            }
        }

        public UIItemComboBox UIItemComboBox
        {
            get
            {
                return new UIItemComboBox(this);
            }
        }

        #endregion

        #region " Checkboxes "

        public WinCheckBox UIDeferPrintingCheckBox
        {
            get
            {
                return new UICheckBox(this, "Defer Printing?");
            }
        }

        public WinCheckBox UIIstheapplicationinjoCheckBox
        {
            get
            {
                return new UICheckBox(this, "Is the application in joint names?");
            }
        }

        public WinCheckBox UICheckBox(string checkboxName)
        {
            return new UICheckBox(this, checkboxName);
        }

        #endregion

        #region " Text "

        public WinText UIMtaSuccessfullyProcessedText
        {
            get
            {
                return new UIText(
                    this,
                    "MTA successfully processed on a previously renewed policy.WARNING! - RENEWAL EDI "
                    + "HAS BEEN CANCELLEDThe renewal status has been stepped back to Due. You will need" + " to process the renewal again via the Amend Risk option.");
            }
        }

        #endregion

        #region Fields

        private WinList mUIItemList;

        private WinTitleBar mUIItemTitleBar;

        #endregion
    }
}