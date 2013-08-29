namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAcceptthisquoteNotOvWindow : WinWindow
    {
        public UIAcceptthisquoteNotOvWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "65535";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinText UIAcceptthisquoteNotOvText
        {
            get
            {
                return new UIText(this, "Accept this quote (Not Overridden) -  £3007.16, RA002050?  This is a TEST Account" + ", NO EDI message will be sent");
            }
        }

        public WinText UICoverCantBeBackDatedText
        {
            get
            {
                return new UIText(this, "Cover Cant Be Back Dated - Please enter Adjustment Date.");
            }
        }

        public WinText UIDateBeforeCurrentMTAText
        {
            get
            {
                return new UIText(this, "Date Before Current MTA Effective Date - Please enter Adjustment Date.");
            }
        }

        public WinText UIAdjustmentdatetimecaText
        {
            get
            {
                return new UIText(this, "Adjustment date/time cannot be after the policy effective end date/time");
            }
        }

        public WinText UIDateBeforeInceptionDText
        {
            get
            {
                return new UIText(this, "Date Before Inception Date - Please enter Adjustment Date.");
            }
        }

        #endregion
    }
}