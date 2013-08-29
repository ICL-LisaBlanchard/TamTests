namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPrintQuoteWindow : WinWindow
    {
        public UIPrintQuoteWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Quote Results");

            #endregion
        }

        #region Properties

        public WinButton UIPrintQuoteButton 
        {
            get
            {
                if ((this.mUIPrintQuoteButton == null))
                {
                    this.mUIPrintQuoteButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIPrintQuoteButton.SearchProperties[UITestControl.PropertyNames.Name] = "Print Quote...";
                    this.mUIPrintQuoteButton.WindowTitles.Add("Quote Results");

                    #endregion
                }
                return this.mUIPrintQuoteButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIPrintQuoteButton;

        #endregion
    }
}