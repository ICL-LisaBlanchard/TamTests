namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAcceptWindow3 : WinWindow
    {
        
        public UIAcceptWindow3(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Renewals: New Business Accept");
            #endregion
        }
        
        #region Properties
        public WinButton UIAcceptButton
        {
            get
            {
                if ((this.mUIAcceptButton == null))
                {
                    this.mUIAcceptButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAcceptButton.SearchProperties[WinButton.PropertyNames.Name] = "Accept";
                    this.mUIAcceptButton.WindowTitles.Add("Renewals: New Business Accept");
                    #endregion
                }
                return this.mUIAcceptButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAcceptButton;
        #endregion
    }
}