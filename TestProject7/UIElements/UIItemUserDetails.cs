namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIItemUserDetails : WinListItem
    {
        public UIItemUserDetails(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
        }

        #region Properties

        public WinEdit UIUsernameEdit
        {
            get
            {
                return new UIItemEdit(this, "User name");
            }
        }

        public WinEdit UIPasswordEdit
        {
            get
            {
                return new UIItemEdit(this, "Password");
            }
        }

        public WinWindow UIUsernameEditEdit
        {
            get
            {
                return new UIItemWindow(this, className: "Edit", name: "User name");
            }
        }

        #endregion
    }
}