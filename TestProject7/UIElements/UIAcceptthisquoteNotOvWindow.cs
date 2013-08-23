namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

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
                if ((this.mUIAcceptthisquoteNotOvText == null))
                {
                    this.mUIAcceptthisquoteNotOvText = new WinText(this);

                    #region Search Criteria

                    this.mUIAcceptthisquoteNotOvText.SearchProperties[UITestControl.PropertyNames.Name] =
                        "Accept this quote (Not Overridden) -  £3007.16, RA002050?  This is a TEST Account" + ", NO EDI message will be sent";
                    this.mUIAcceptthisquoteNotOvText.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIAcceptthisquoteNotOvText;
            }
        }

        public WinText UICoverCantBeBackDatedText
        {
            get
            {
                if ((this.mUICoverCantBeBackDatedText == null))
                {
                    this.mUICoverCantBeBackDatedText = new WinText(this);

                    #region Search Criteria

                    this.mUICoverCantBeBackDatedText.SearchProperties[UITestControl.PropertyNames.Name] = "Cover Cant Be Back Dated - Please enter Adjustment Date.";
                    this.mUICoverCantBeBackDatedText.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUICoverCantBeBackDatedText;
            }
        }

        public WinText UIDateBeforeCurrentMTAText
        {
            get
            {
                if ((this.mUIDateBeforeCurrentMTAText == null))
                {
                    this.mUIDateBeforeCurrentMTAText = new WinText(this);

                    #region Search Criteria

                    this.mUIDateBeforeCurrentMTAText.SearchProperties[UITestControl.PropertyNames.Name] = "Date Before Current MTA Effective Date - Please enter Adjustment Date.";
                    this.mUIDateBeforeCurrentMTAText.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIDateBeforeCurrentMTAText;
            }
        }

        public WinText UIAdjustmentdatetimecaText
        {
            get
            {
                if ((this.mUIAdjustmentdatetimecaText == null))
                {
                    this.mUIAdjustmentdatetimecaText = new WinText(this);

                    #region Search Criteria

                    this.mUIAdjustmentdatetimecaText.SearchProperties.Add(
                        new PropertyExpression(
                            UITestControl.PropertyNames.Name, "Adjustment date/time cannot be after the policy effective end date/time", PropertyExpressionOperator.Contains));
                    this.mUIAdjustmentdatetimecaText.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIAdjustmentdatetimecaText;
            }
        }

        public WinText UIDateBeforeInceptionDText
        {
            get
            {
                if ((this.mUIDateBeforeInceptionDText == null))
                {
                    this.mUIDateBeforeInceptionDText = new WinText(this);

                    #region Search Criteria

                    this.mUIDateBeforeInceptionDText.SearchProperties[UITestControl.PropertyNames.Name] = "Date Before Inception Date - Please enter Adjustment Date.";
                    this.mUIDateBeforeInceptionDText.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIDateBeforeInceptionDText;
            }
        }

        #endregion

        #region Fields

        private WinText mUIAcceptthisquoteNotOvText;

        private WinText mUICoverCantBeBackDatedText;

        private WinText mUIDateBeforeCurrentMTAText;

        private WinText mUIAdjustmentdatetimecaText;

        private WinText mUIDateBeforeInceptionDText;

        #endregion
    }
}