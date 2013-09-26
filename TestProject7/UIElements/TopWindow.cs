namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class TopWindow : WinWindow
    {
        public TopWindow()
        {
            SearchProperties[UITestControl.PropertyNames.ClassName] = "TfSelectItem";
        }
    }
}