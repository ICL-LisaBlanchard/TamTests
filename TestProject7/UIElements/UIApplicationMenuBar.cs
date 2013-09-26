namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIApplicationMenuBar : WinMenuBar
    {
        public UIApplicationMenuBar(UITestControl searchLimitContainer, string name)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = name;
            foreach (string windowTitle in searchLimitContainer.WindowTitles)
            {
                WindowTitles.Add(windowTitle);
            }

            #endregion
        }

        #region Properties

        public UIMenuListItem UIOptionsMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Options");
            }
        }

        public UIMenuListItem UIFileMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "File");
            }
        }

        public UIMenuListItem UIEditMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Edit");
            }
        }

        #endregion
    }
}