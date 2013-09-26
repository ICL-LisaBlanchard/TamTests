namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyAttachmentsWindow : WinWindow
    {
        public UIPolicyAttachmentsWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Policy Attachments";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Policy Attachments");

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow UIOptionsWindow
        {
            get
            {
                if ((mUIOptionsWindow == null))
                {
                    mUIOptionsWindow = new UIItemWindow(this, "5");
                }
                return mUIOptionsWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIOptionsWindow;

        #endregion
    }
}