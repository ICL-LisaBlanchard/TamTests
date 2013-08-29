namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICheckBox : WinCheckBox
    {
        public UICheckBox(UITestControl uiItemWindow, string windowName, string name)
            : base(uiItemWindow)
        {
            this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            this.WindowTitles.Add(windowName);
        }
    }
}