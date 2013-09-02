namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyDetailConfirmationWindow : WinWindow
    {
        public UIPolicyDetailConfirmationWindow()
        {
            #region Search Criteria

            this.windowName = "Policy Detail Confirmation";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
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
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UILookupWindow
        {
            get
            {
                if ((this.mUILookupWindow == null))
                {
                    this.mUILookupWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUILookupWindow;
            }
        }

        public UIItemWindow UIConfirmWindow
        {
            get
            {
                if ((this.mUIConfirmWindow == null))
                {
                    this.mUIConfirmWindow = new UIItemWindow(this, controlId: "5", instance: "2");
                }
                return this.mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUILookupWindow;

        private UIItemWindow mUIConfirmWindow;

        #endregion
    }
}