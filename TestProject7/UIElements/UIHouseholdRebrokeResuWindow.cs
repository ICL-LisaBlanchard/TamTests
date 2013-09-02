namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIHouseholdRebrokeResuWindow : WinWindow
    {
        public UIHouseholdRebrokeResuWindow()
        {
            #region Search Criteria

            this.windowTitle = "Household Rebroke Results";
            this.SearchProperties[UITestControl.PropertyNames.Name] = this.windowTitle;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(this.windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIOKWindow;
            }
        }

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

        public UIItemWindow UISelectAlternativeWindow
        {
            get
            {
                if ((this.mUISelectAlternativeWindow == null))
                {
                    this.mUISelectAlternativeWindow = new UIItemWindow(this, controlId: "12");
                }
                return this.mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUISelectAlternativeWindow;

        #endregion
    }
}