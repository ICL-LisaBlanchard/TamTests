namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIRebrokeResultsScreenWindow : WinWindow
    {
        public UIRebrokeResultsScreenWindow()
        {
            #region Search Criteria

            this.windowName = "Rebroke Results Screen";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowName);

            #endregion
        }

        #region Properties

        public UITestControl UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, instance: "8", className: "msvb_lib_header");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, instance: "8", className: "ListView20WndClass");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UISelectAlternativeWindow
        {
            get
            {
                if ((this.mUISelectAlternativeWindow == null))
                {
                    this.mUISelectAlternativeWindow = new UIItemWindow(this, controlId: "6");
                }
                return this.mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UITestControl mUIItemWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUISelectAlternativeWindow;

        #endregion
    }
}