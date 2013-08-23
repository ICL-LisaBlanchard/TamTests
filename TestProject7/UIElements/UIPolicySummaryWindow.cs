namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPolicySummaryWindow : WinWindow
    {
        public UIPolicySummaryWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "9";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinButton UIPolicySummaryButton
        {
            get
            {
                if ((this.mUIPolicySummaryButton == null))
                {
                    this.mUIPolicySummaryButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIPolicySummaryButton.SearchProperties[UITestControl.PropertyNames.Name] = "Policy Summary";
                    this.mUIPolicySummaryButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIPolicySummaryButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIPolicySummaryButton;

        #endregion
    }
}