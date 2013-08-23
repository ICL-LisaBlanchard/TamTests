namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMTAEffectiveDatesWindow : WinWindow
    {
        public UIMTAEffectiveDatesWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "MTA Effective Dates ";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("MTA Effective Dates ");

            #endregion
        }

        #region Properties

        public UIOKWindow24 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow24(this);
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow56 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow56(this);
                }
                return this.mUIItemWindow;
            }
        }

        public UICancelWindow10 UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UICancelWindow10(this);
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow24 mUIOKWindow;

        private UIItemWindow56 mUIItemWindow;

        private UICancelWindow10 mUICancelWindow;

        #endregion
    }
}