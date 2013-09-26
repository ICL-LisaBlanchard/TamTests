namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICheckBox : WinCheckBox
    {
        public UICheckBox(UITestControl uiItemWindow, string name)
            : base(uiItemWindow)
        {
            SearchProperties[UITestControl.PropertyNames.Name] = name;
            WindowTitles.Add(uiItemWindow.WindowTitles[0]);
        }
    }
}