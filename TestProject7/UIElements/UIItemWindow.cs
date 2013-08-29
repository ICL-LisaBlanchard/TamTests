namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow : WinWindow
    {
        public UIItemWindow(UITestControl searchLimitContainer, string controlId = "", string instance = "", string className = "", string accessible = "", string name = "")
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
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            #endregion
        }

        public string WindowName { get; set; }

        #region Properties

        public WinList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new WinList(this);

                    #region Search Criteria

                    this.mUIItemList.WindowTitles.Add(this.WindowName);

                    #endregion
                }
                return this.mUIItemList;
            }
        }

        public UIItemWindow ItemWindow(
            UITestControl searchLimitContainer, string windowTitle, string controlId = "", string instance = "", string className = "", string accessibleName = "")
        {
            return new UIItemWindow(searchLimitContainer, controlId, instance, className);
        }

        #endregion

        #region "Buttons"

        public WinButton UIItemButton
        {
            get
            {
                return new UIButton(this, "");
            }
        }

        public WinButton UIProposerDetailsButton
        {
            get
            {
                return new UIButton(this, "Proposer Details...");
            }
        }

        public WinButton UICalculateQuoteButton
        {
            get
            {
                return new UIButton(this, "Calculate Quote");
            }
        }

        public WinButton UIClientsFilesButton
        {
            get
            {
                return new UIButton(this, "Clients & Files");
            }
        }

        public WinButton UIAddButton
        {
            get
            {
                return new UIButton(this, "Add");
            }
        }

        public WinButton UIYesButton
        {
            get
            {
                return new UIButton(this, "Yes");
            }
        }

        public WinButton UINoButton
        {
            get
            {
                return new UIButton(this, "No");
            }
        }

        public WinButton UILookupButton
        {
            get
            {
                return new UIButton(this, "Lookup...");
            }
        }

        public WinButton UINextButton
        {
            get
            {
                return new UIButton(this, "Next >");
            }
        }

        public WinButton UIOKButton
        {
            get
            {
                return new UIButton(this, "OK");
            }
        }

        public WinButton UICancelButton
        {
            get
            {
                return new UIButton(this, "Cancel");
            }
        }

        public WinButton UIOptionsButton
        {
            get
            {
                return new UIButton(this, "Options");
            }
        }

        public WinButton UIDetailButton
        {
            get
            {
                return new UIButton(this, "Detail");
            }
        }

        public WinButton UIAcceptButton
        {
            get
            {
                return new UIButton(this, "Accept");
            }
        }

        public WinButton UIExitButton
        {
            get
            {
                return new UIButton(this, "Exit");
            }
        }

        public WinButton UIPrintQuoteButton
        {
            get
            {
                return new UIButton(this, "Print Quote...");
            }
        }

        public WinButton UIAWAPButton
        {
            get
            {
                return new UIButton(this, "AWAP");
            }
        }

        public WinButton UIDemandsNeedsButton
        {
            get
            {
                return new UIButton(this, "Demands & Needs");
            }
        }

        public WinButton UIPolicySummaryButton
        {
            get
            {
                return new UIButton(this, "Policy Summary");
            }
        }

        public WinButton UIPremiumButton
        {
            get
            {
                return new UIButton(this, "Premium");
            }
        }

        public WinButton UIFilterButton
        {
            get
            {
                return new UIButton(this, "Filter");
            }
        }

        public WinButton UIBeforeButton
        {
            get
            {
                return new UIButton(this, "Before");
            }
        }

        public WinButton UIAfterButton
        {
            get
            {
                return new UIButton(this, "After");
            }
        }

        public WinButton UIQuoteButton
        {
            get
            {
                return new UIButton(this, "Quote");
            }
        }

        public WinButton UIRegressButton
        {
            get
            {
                return new UIButton(this, "Regress");
            }
        }

        public WinButton UISelectAlternativeButton
        {
            get
            {
                return new UIButton(this, "Select Alternative");
            }
        }

        public WinButton UISaveButton
        {
            get
            {
                return new UIButton(this, "Save");
            }
        }

        public WinButton UIConfirmButton
        {
            get
            {
                return new UIButton(this, "Confirm");
            }
        }

        public WinButton UIInviteButton
        {
            get
            {
                return new UIButton(this, "Invite");
            }
        }

        public WinButton UIRenewPolicyButton
        {
            get
            {
                return new UIButton(this, "Renew Policy");
            }
        }

        public WinButton UIAmendRiskButton
        {
            get
            {
                return new UIButton(this, "Amend Risk...");
            }
        }

        public WinButton UIRebrokeButton
        {
            get
            {
                return new UIButton(this, "Rebroke...");
            }
        }

        #endregion

        #region " Groups "

        public WinGroup UIQuoteDetailsGroup
        {
            get
            {
                return new UIGroup(this, "Quote Details", "Quote Results");
            }
        }

        #endregion

        #region " Radiobuttons "

        public WinRadioButton UIComprehensiveRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Comprehensive", this.WindowName);
            }
        }

        public WinRadioButton UIPersonalLinesRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Personal Lines", this.WindowName);
            }
        }

        public WinRadioButton UITitleRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Mr.", this.WindowName);
            }
        }

        public WinRadioButton UISuffixRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Jr.", this.WindowName);
            }
        }

        public WinRadioButton UIHouseholdRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Household", this.WindowName);
            }
        }

        public WinRadioButton UIAlternativeRadioButton
        {
            get
            {
                return new UIRadioButton(this, "Alternative", this.WindowName);
            }
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

        public UIClient UIClient
        {
            get
            {
                return new UIClient(this, this.WindowName, string.Empty);
            }
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

        #endregion

        #region " Combo Box "

        public WinComboBox UIOpenComboBox
        {
            get
            {
                return new UIItemComboBox(this, "Open:");
            }
        }

        public WinComboBox UIItemComboBox
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
                return new UICheckBox(this, this.WindowName, "Defer Printing?");
            }
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