namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISelectAlternativeWindow1 : WinWindow
    {
        
        public UISelectAlternativeWindow1(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "12";
            this.WindowTitles.Add("Household Rebroke Results");
            #endregion
        }
        
        #region Properties
        public WinButton UISelectAlternativeButton
        {
            get
            {
                if ((this.mUISelectAlternativeButton == null))
                {
                    this.mUISelectAlternativeButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISelectAlternativeButton.SearchProperties[WinButton.PropertyNames.Name] = "Select Alternative";
                    this.mUISelectAlternativeButton.WindowTitles.Add("Household Rebroke Results");
                    #endregion
                }
                return this.mUISelectAlternativeButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISelectAlternativeButton;
        #endregion
    }
}