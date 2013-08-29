namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMTAEffectiveDatesWindow : WinWindow
    {
        private const string WindowName = "MTA Effective Dates ";

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

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((this.mUICancelWindow == null))
                {
                    this.mUICancelWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUICancelWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUICancelWindow;

        #endregion

        public UIMTAEffectiveDatesWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "MTA Effective Dates ";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowName);

            #endregion
        }
    }
}