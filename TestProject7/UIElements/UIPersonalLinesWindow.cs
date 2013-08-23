namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPersonalLinesWindow : WinWindow
    {
        
        public UIPersonalLinesWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "11";
            this.WindowTitles.Add("Assign Client Number");
            #endregion
        }
        
        #region Properties
        public WinRadioButton UIPersonalLinesRadioButton
        {
            get
            {
                if ((this.mUIPersonalLinesRadioButton == null))
                {
                    this.mUIPersonalLinesRadioButton = new WinRadioButton(this);
                    #region Search Criteria
                    this.mUIPersonalLinesRadioButton.SearchProperties[WinRadioButton.PropertyNames.Name] = "Personal Lines";
                    this.mUIPersonalLinesRadioButton.WindowTitles.Add("Assign Client Number");
                    #endregion
                }
                return this.mUIPersonalLinesRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WinRadioButton mUIPersonalLinesRadioButton;
        #endregion
    }
}