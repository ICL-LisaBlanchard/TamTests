namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIQuoteWindow : WinWindow
    {
        public UIQuoteWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "12";
            this.WindowTitles.Add("insur-E.tam");

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
                    this.mUIQuoteButton.WindowTitles.Add("insur-E.tam");

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