namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIText : WinText
    {
        public UIText(UITestControl uiItemWindow, string name)
            : base(uiItemWindow)
        {
            if (!string.IsNullOrEmpty(name))
            {
                SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, name, PropertyExpressionOperator.Contains));
            }

            WindowTitles.Add(uiItemWindow.WindowTitles[0]);
        }
    }
}