namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPersonalLinesDialogWindow : WinWindow
    {
        public UIPersonalLinesDialogWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add("Personal Lines");

            #endregion
        }

        public UIItemWindow UIYesWindow
        {
            get
            {
                return new UIItemWindow(this, "6");
            }
        }

        public UIItemWindow UIPolicy1001PolicyNo81Window
        {
            get
            {
                return new UIItemWindow(this, controlId: "65535");
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "2");
                }
                return mUIOKWindow;
            }
        }

        private UIItemWindow mUIOKWindow;
    }
}