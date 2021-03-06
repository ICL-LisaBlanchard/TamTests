namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPane : WinPane
    {
        public UIPane(UITestControl uiWindow, string name)
            : base(uiWindow)
        {
            SearchProperties[UITestControl.PropertyNames.Name] = name;

            foreach (string w in uiWindow.WindowTitles)
            {
                WindowTitles.Add(w);
            }
        }

        public WinButton UIOKButton
        {
            get
            {
                return new UIButton(this, "Ok");
            }
        }
    }
}