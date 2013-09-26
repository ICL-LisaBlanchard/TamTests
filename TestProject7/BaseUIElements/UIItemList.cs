namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemList : WinList
    {
        public UIItemList(UITestControl uiItemWindow, string name)
            : base(uiItemWindow)
        {
            SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, name, PropertyExpressionOperator.Contains));
            WindowTitles.Add(uiItemWindow.WindowTitles[0]);
        }
    }
}