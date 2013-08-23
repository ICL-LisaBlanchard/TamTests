namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow40 : WinWindow
    {
        public UIItemWindow40(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        #region Properties

        public WinTitleBar UIItemTitleBar
        {
            get
            {
                if ((this.mUIItemTitleBar == null))
                {
                    this.mUIItemTitleBar = new WinTitleBar(this);
                }
                return this.mUIItemTitleBar;
            }
        }

        #endregion

        #region Fields

        private WinTitleBar mUIItemTitleBar;

        #endregion
    }
}