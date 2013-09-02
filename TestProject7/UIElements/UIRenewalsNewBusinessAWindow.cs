namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRenewalsNewBusinessAWindow : WinWindow
    {
        public UIRenewalsNewBusinessAWindow()
        {
            #region Search Criteria

            this.windowTitle = "Renewals : New Business Accept";
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
                    this.mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
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
                    this.mUIAcceptWindow = new UIItemWindow(this, controlId: "6");
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