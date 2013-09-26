namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAttatchmentsMenuWindow : WinWindow
    {
        public UIAttatchmentsMenuWindow()
        {
            #region Search Criteria

            SearchProperties[PropertyNames.AccessibleName] = "Context";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32768";

            #endregion
        }

        #region Properties

        public UIMenu UIContextMenu
        {
            get
            {
                if ((mUIContextMenu == null))
                {
                    mUIContextMenu = new UIMenu(this, "Context");
                }
                return mUIContextMenu;
            }
        }

        #endregion

        #region Fields

        private UIMenu mUIContextMenu;

        #endregion
    }
}