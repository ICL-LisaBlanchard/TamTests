namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
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
                SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            if (!string.IsNullOrEmpty(classname))
            {
                SearchProperties[UITestControl.PropertyNames.ClassName] = classname;
            }

            foreach (string w in uiItemWindow.WindowTitles)
            {
                WindowTitles.Add(w);
            }
        }
    }
}