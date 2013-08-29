namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIClaimsWindow : WinWindow
    {
        public UIClaimsWindow()
        {
            #region Search Criteria

            this.windowTitle = "Claims";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UINoWindow
        {
            get
            {
                if ((this.mUINoWindow == null))
                {
                    this.mUINoWindow = new UIItemWindow(this, controlId: "7");
                }
                return this.mUINoWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUINoWindow;

        #endregion
    }
}