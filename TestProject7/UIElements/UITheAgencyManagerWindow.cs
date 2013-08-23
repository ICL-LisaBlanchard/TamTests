namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheAgencyManagerWindow : WinWindow
    {
        
        public UITheAgencyManagerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "The Agency Manager";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("The Agency Manager");
            #endregion
        }
        
        #region Properties
        public UICloseWindow UICloseWindow
        {
            get
            {
                if ((this.mUICloseWindow == null))
                {
                    this.mUICloseWindow = new UICloseWindow(this);
                }
                return this.mUICloseWindow;
            }
        }
        #endregion
        
        #region Fields
        private UICloseWindow mUICloseWindow;
        #endregion
    }
}