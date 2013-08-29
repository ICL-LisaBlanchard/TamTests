namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRenewalsNewBusinessAWindow1 : WinWindow
    {
        public UIRenewalsNewBusinessAWindow1()
        {
            #region Search Criteria

            this.windowTitle = "Renewals: New Business Accept";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, instance: "2", className: "ListView20WndClass");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIAcceptWindow
        {
            get
            {
                if ((this.mUIAcceptWindow == null))
                {
                    this.mUIAcceptWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIAcceptWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIAcceptWindow;

        #endregion
    }
}