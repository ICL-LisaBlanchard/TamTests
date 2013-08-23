namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuoteWindow1 : WinWindow
    {
        public UIQuoteWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "141";
            this.WindowTitles.Add("Household Renewals Amend Risk");

            #endregion
        }

        #region Properties

        public WinButton UIQuoteButton
        {
            get
            {
                if ((this.mUIQuoteButton == null))
                {
                    this.mUIQuoteButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIQuoteButton.SearchProperties[UITestControl.PropertyNames.Name] = "Quote";
                    this.mUIQuoteButton.WindowTitles.Add("Household Renewals Amend Risk");

                    #endregion
                }
                return this.mUIQuoteButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIQuoteButton;

        #endregion
    }
}