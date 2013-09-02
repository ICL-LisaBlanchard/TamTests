namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIClient : WinClient
    {
        public UIClient(UITestControl searchLimitContainer, string name)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties.Add(new PropertyExpression(UITestControl.PropertyNames.Name, name, PropertyExpressionOperator.Contains));
            }

            this.WindowTitles.Add(searchLimitContainer.WindowTitles[0]);

            #endregion
        }

        public WinButton UIOKButton
        {
            get
            {
                return new UIButton(this, "OK");
            }
        }

        public WinButton UIRunButton
        {
            get
            {
                return new UIButton(this, "Run");
            }
        }

        public WinCheckBox UIAddActivityCheckBox
        {
            get
            {
                return new UICheckBox(this, "Add Activity");
            }
        }

        public WinWindow UIItemWindow
        {
            get
            {
                return new UIItemWindow(this);
            }
        }
    }
}