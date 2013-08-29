namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIGroup : WinGroup
    {
        public UIGroup(UITestControl uiWindow, string name, string windowName)
            : base(uiWindow)
        {
            this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            this.WindowTitles.Add(windowName);
        }
    }
}