namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIInsurEtamWindow : WinWindow
    {
        
        public UIInsurEtamWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            #endregion
        }
        
        #region Properties
        public UIMotorQuotesWindow UIMotorQuotesWindow
        {
            get
            {
                if ((this.mUIMotorQuotesWindow == null))
                {
                    this.mUIMotorQuotesWindow = new UIMotorQuotesWindow(this);
                }
                return this.mUIMotorQuotesWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIMotorQuotesWindow mUIMotorQuotesWindow;
        #endregion
    }
}