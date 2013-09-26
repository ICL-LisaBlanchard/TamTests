namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    internal class UIRadioButton : WinRadioButton
    {
        public UIRadioButton(UITestControl uiItemWindow, string name)
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            WindowTitles.Add(uiItemWindow.WindowTitles[0]);
        }

        public UITestControl Type { get; set; }
    }
}