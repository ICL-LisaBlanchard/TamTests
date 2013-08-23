namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProductSelectionWindow : WinWindow
    {
        public UIProductSelectionWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Product Selection";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Product Selection");

            #endregion
        }

        #region Properties

        public UIOKWindow22 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow22(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIHouseholdWindow UIHouseholdWindow
        {
            get
            {
                if ((this.mUIHouseholdWindow == null))
                {
                    this.mUIHouseholdWindow = new UIHouseholdWindow(this);
                }
                return this.mUIHouseholdWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow22 mUIOKWindow;

        private UIHouseholdWindow mUIHouseholdWindow;

        #endregion
    }
}