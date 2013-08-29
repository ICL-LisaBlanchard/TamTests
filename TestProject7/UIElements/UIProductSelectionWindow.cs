namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProductSelectionWindow : WinWindow
    {
        public UIProductSelectionWindow()
        {
            #region Search Criteria

            this.windowTitle = "Product Selection";
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
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "1");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UIHouseholdWindow
        {
            get
            {
                if ((this.mUIHouseholdWindow == null))
                {
                    this.mUIHouseholdWindow = new UIItemWindow(this, controlId: "7");
                }
                return this.mUIHouseholdWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIHouseholdWindow;

        #endregion
    }
}