namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPane : WinPane
    {
        public UIPane(UITestControl uiWindow, string name)
            : base(uiWindow)
        {
            this.SearchProperties[UITestControl.PropertyNames.Name] = name;

            foreach (string w in uiWindow.WindowTitles)
            {
                this.WindowTitles.Add(w);
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