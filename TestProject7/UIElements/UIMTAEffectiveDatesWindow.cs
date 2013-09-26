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
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "1");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow UIMTADate
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "2");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIMTATime
        {
            get
            {
                if ((mUIItemWindow2 == null))
                {
                    mUIItemWindow2 = new UIItemWindow(this, controlId: "5");
                }
                return mUIItemWindow2;
            }
        }

        public UIItemWindow UICancelWindow
        {
            get
            {
                if ((mUICancelWindow == null))
                {
                    mUICancelWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUICancelWindow;
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

            SearchProperties[UITestControl.PropertyNames.Name] = "MTA Effective Dates ";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(WindowName);

            #endregion
        }
    }
}