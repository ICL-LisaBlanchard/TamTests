namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemListItem : WinListItem
    {
        public UIItemListItem(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.WindowTitles.Add("Windows Security");

            #endregion
        }

        #region Properties

        public WinEdit UIUsernameEdit
        {
            get
            {
                if ((this.mUIUsernameEdit == null))
                {
                    this.mUIUsernameEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIUsernameEdit.SearchProperties[UITestControl.PropertyNames.Name] = "User name";
                    this.mUIUsernameEdit.WindowTitles.Add("Windows Security");

                    #endregion
                }
                return this.mUIUsernameEdit;
            }
        }

        public WinWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new WinWindow(this);

                    #region Search Criteria

                    this.mUIItemWindow.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "User name";
                    this.mUIItemWindow.SearchProperties[UITestControl.PropertyNames.ClassName] = "Edit";
                    this.mUIItemWindow.WindowTitles.Add("Windows Security");

                    #endregion
                }
                return this.mUIItemWindow;
            }
        }

        public WinEdit UIPasswordEdit
        {
            get
            {
                if ((this.mUIPasswordEdit == null))
                {
                    this.mUIPasswordEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUIPasswordEdit.SearchProperties[UITestControl.PropertyNames.Name] = "Password";
                    this.mUIPasswordEdit.WindowTitles.Add("Windows Security");

                    #endregion
                }
                return this.mUIPasswordEdit;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUIUsernameEdit;

        private WinWindow mUIItemWindow;

        private WinEdit mUIPasswordEdit;

        #endregion
    }
}