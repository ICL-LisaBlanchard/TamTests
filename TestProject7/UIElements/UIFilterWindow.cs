namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIFilterWindow : WinWindow
    {
        
        public UIFilterWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Vehicle Lookup");
            #endregion
        }
        
        #region Properties
        public WinButton UIFilterButton
        {
            get
            {
                if ((this.mUIFilterButton == null))
                {
                    this.mUIFilterButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIFilterButton.SearchProperties[WinButton.PropertyNames.Name] = "Filter";
                    this.mUIFilterButton.WindowTitles.Add("Vehicle Lookup");
                    #endregion
                }
                return this.mUIFilterButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIFilterButton;
        #endregion
    }
}