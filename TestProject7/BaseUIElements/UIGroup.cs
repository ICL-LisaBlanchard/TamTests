namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIGroup : WinGroup
    {
        public UIGroup(UITestControl uiWindow, string name)
            : base(uiWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            this.WindowTitles.Add(uiWindow.WindowTitles[0]);
        }
    }
}