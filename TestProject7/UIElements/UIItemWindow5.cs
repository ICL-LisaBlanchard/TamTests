namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow5 : WinWindow
    {
        
        public UIItemWindow5(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "32";
            this.WindowTitles.Add("Customer: autotest autotest");
            #endregion
        }
        
        #region Properties
        public WinButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIItemButton.WindowTitles.Add("Customer: autotest autotest");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItemButton;
        #endregion
    }
}