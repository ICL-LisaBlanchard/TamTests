namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

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

        public UIItemWindow UIMTADate
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

        public UIItemWindow UIMTATime
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow(this, controlId: "5");
                }
                return this.mUIItemWindow2;
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

        private UIItemWindow mUIItemWindow2;

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