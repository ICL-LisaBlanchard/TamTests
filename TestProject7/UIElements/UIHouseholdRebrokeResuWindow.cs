namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIHouseholdRebrokeResuWindow : WinWindow
    {
        public UIHouseholdRebrokeResuWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Household Rebroke Results";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Household Rebroke Results");

            #endregion
        }

        #region Properties

        public UIOKWindow37 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow37(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow74 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow74(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UISelectAlternativeWindow1 UISelectAlternativeWindow
        {
            get
            {
                if ((this.mUISelectAlternativeWindow == null))
                {
                    this.mUISelectAlternativeWindow = new UISelectAlternativeWindow1(this);
                }
                return this.mUISelectAlternativeWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow37 mUIOKWindow;

        private UIItemWindow74 mUIItemWindow;

        private UISelectAlternativeWindow1 mUISelectAlternativeWindow;

        #endregion
    }
}