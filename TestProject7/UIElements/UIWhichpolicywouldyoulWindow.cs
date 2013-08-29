namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIWhichpolicywouldyoulWindow : WinWindow
    {
        public UIWhichpolicywouldyoulWindow()
        {
            #region Search Criteria

            this.windowName = "Which policy would you like to take the risk details from?";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, className: "TPanel");
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        #endregion
    }
}