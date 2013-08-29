namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemComboBox : WinComboBox
    {
        public UIItemComboBox(UIItemWindow uiItemWindow, string name = "")
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }
            this.WindowTitles.Add(uiItemWindow.WindowName);
        }
    }
}