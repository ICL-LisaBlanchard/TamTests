namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICalculateQuoteWindow : WinWindow
    {
        
        public UICalculateQuoteWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "21";
            this.WindowTitles.Add("insur-E.tam");
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
                    this.mUICalculateQuoteButton.SearchProperties[WinButton.PropertyNames.Name] = "Calculate Quote";
                    this.mUICalculateQuoteButton.WindowTitles.Add("insur-E.tam");
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