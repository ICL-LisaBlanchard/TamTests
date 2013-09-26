namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIButton : WinButton
    {
        public UIButton(UITestControl uiItemWindow, string name, bool useContains = true)
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                if (useContains)
                {
                    SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, name, PropertyExpressionOperator.Contains));
                }
                else
                {
                    SearchProperties[UITestControl.PropertyNames.Name] = name;
                }
            }

            foreach (string w in uiItemWindow.WindowTitles)
            {
                WindowTitles.Add(w);
            }
        }
    }
}