namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIButton : WinButton
    {
        public UIButton(UITestControl uiItemWindow, string name)
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
            }

            foreach (string w in uiItemWindow.WindowTitles)
            {
                this.WindowTitles.Add(w);
            }
        }
    }
}