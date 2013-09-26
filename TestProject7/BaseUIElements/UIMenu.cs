namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIMenu : WinMenu
    {
        public UIMenu(UITestControl searchLimitContainer, string name)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = name;

            #endregion
        }

        public WinMenuItem UIMenuItem(string name)
        {
            return new UIMenuListItem(this, name);
        }
    }
}