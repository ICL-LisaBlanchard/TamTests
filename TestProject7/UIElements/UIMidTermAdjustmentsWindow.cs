namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMidTermAdjustmentsWindow : WinWindow
    {
        public UIMidTermAdjustmentsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Mid Term Adjustments ";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Mid Term Adjustments ");

            #endregion
        }

        #region Properties

        public UIItemWindow55 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow55(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UIOKWindow23 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow23(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIOKWindow110 UIOKWindow1
        {
            get
            {
                if ((this.mUIOKWindow1 == null))
                {
                    this.mUIOKWindow1 = new UIOKWindow110(this);
                }
                return this.mUIOKWindow1;
            }
        }

        public UIItemWindow124 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow124(this);
                }
                return this.mUIItemWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow55 mUIItemWindow;

        private UIOKWindow23 mUIOKWindow;

        private UIOKWindow110 mUIOKWindow1;

        private UIItemWindow124 mUIItemWindow1;

        #endregion
    }
}