namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAmendRiskResultsWindow : WinWindow
    {
        public UIAmendRiskResultsWindow()
        {
            #region Search Criteria

            windowTitle = "Amend Risk Results";
            SearchProperties[UITestControl.PropertyNames.Name] = windowTitle;
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add(windowTitle);

            #endregion
        }

        #region Properties

        public UIItemWindow UIRenewPolicyWindow
        {
            get
            {
                if ((mUIRenewPolicyWindow == null))
                {
                    mUIRenewPolicyWindow = new UIItemWindow(this, controlId: "12");
                }
                return mUIRenewPolicyWindow;
            }
        }

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, instance: "8", className: "ListView20WndClass");
                }
                return mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowTitle;

        private UIItemWindow mUIRenewPolicyWindow;

        private UIItemWindow mUIItemWindow;

        #endregion
    }
}