namespace AppliedSystems.Tam.Ui.Tests.BaseUIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITitleBar : WinTitleBar
    {
        public UITitleBar(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        public UIButton UICloseButton
        {
            get
            {
                return new UIButton(this, "Close");
            }
        }
    }
}