namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICancelWindow : WinWindow
    {
        
        public UICancelWindow(UITestControl searchLimitContainer) : 
            base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "5";
            this.WindowTitles.Add("Customer: autotest autotest");
            #endregion
        }
        
        #region Properties
        public WinButton UICancelButton
        {
            get
            {
                if ((this.mUICancelButton == null))
                {
                    this.mUICancelButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICancelButton.SearchProperties[WinButton.PropertyNames.Name] = "Cancel";
                    this.mUICancelButton.WindowTitles.Add("Customer: autotest autotest");
                    #endregion
                }
                return this.mUICancelButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICancelButton;
        #endregion
    }
}