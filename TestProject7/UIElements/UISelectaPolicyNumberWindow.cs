namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UISelectaPolicyNumberWindow : WinWindow
    {
        private const string WindowTitle = "Select a Policy Number";

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "2");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        #endregion

        public UISelectaPolicyNumberWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = WindowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Select a Policy Number");

            #endregion
        }
    }
}