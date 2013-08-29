namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIClient : UIItemWindow
    {
        public UIClient(UITestControl searchLimitContainer, string windowName)
            : base(searchLimitContainer, windowName)
        {
            #region Search Criteria

            this.WindowTitles.Add(windowName);

            #endregion
        }
    }
}