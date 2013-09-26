namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIConfirmWindow : WinWindow
    {
        public UIConfirmWindow()
        {
            #region Search Criteria

            windowTitle = "Confirm";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIYesWindow
        {
            get
            {
                return new UIItemWindow(this, "6");
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "1");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIYesWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}