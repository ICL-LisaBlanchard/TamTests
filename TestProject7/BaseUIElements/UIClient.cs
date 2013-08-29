namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIClient : WinClient
    {
        public UIClient(UITestControl searchLimitContainer, string name)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            if (!string.IsNullOrEmpty(name))
            {
                this.SearchProperties[UITestControl.PropertyNames.Name] = name;
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
    }
}