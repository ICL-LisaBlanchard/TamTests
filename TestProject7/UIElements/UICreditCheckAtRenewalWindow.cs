namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICreditCheckAtRenewalWindow : WinWindow
    {
        public UICreditCheckAtRenewalWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Credit Check At Renewal";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Credit Check At Renewal");

            #endregion
        }

        #region Properties

        public UIItemWindow UIProceedWindow
        {
            get
            {
                if ((mUIProceedWindow == null))
                {
                    mUIProceedWindow = new UIItemWindow(this, "1");
                }
                return mUIProceedWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIProceedWindow;

        #endregion
    }
}