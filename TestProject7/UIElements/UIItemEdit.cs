namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemEdit : WinEdit
    {
        public UIItemEdit(UITestControl uiItemWindow, string name, string classname = "")
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            if (!string.IsNullOrEmpty(classname))
            {
                this.SearchProperties[UITestControl.PropertyNames.ClassName] = classname;
            }

            foreach (string w in uiItemWindow.WindowTitles)
            {
                this.WindowTitles.Add(w);
            }
        }
    }
}