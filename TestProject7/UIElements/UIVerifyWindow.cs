namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVerifyWindow : WinWindow
    {
        
        public UIVerifyWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Verify";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Verify");
            #endregion
        }

        private const string WindowName = "Verify";
        #region Properties
        public UIItemWindow UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUIYesWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIYesWindow;
        #endregion
    }
}