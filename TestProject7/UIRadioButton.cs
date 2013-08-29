namespace AppliedSystems.Tam.Ui.Tests
{
    using AppliedSystems.Tam.Ui.Tests.UIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    internal class UIRadioButton : WinRadioButton
    {
        public UIRadioButton(UITestControl uiItemWindow, string name, string windowName)
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            this.WindowTitles.Add(windowName);
        }

        public UIItemWindow Type { get; set; }
    }
}