namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICalculateQuoteWindow1 : WinWindow
    {
        public UICalculateQuoteWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "27";
            this.WindowTitles.Add("Amend Risk");

            #endregion
        }

        #region Properties

        public WinButton UICalculateQuoteButton
        {
            get
            {
                if ((this.mUICalculateQuoteButton == null))
                {
                    this.mUICalculateQuoteButton = new WinButton(this);

                    #region Search Criteria

                    this.mUICalculateQuoteButton.SearchProperties[UITestControl.PropertyNames.Name] = "Calculate Quote";
                    this.mUICalculateQuoteButton.WindowTitles.Add("Amend Risk");

                    #endregion
                }
                return this.mUICalculateQuoteButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUICalculateQuoteButton;

        #endregion
    }
}