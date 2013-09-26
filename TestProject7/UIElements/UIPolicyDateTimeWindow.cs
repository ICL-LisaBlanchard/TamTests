namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyDateTimeWindow : WinWindow
    {
        public UIPolicyDateTimeWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Policy Date / Time";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Policy Date / Time");

            #endregion
        }

        #region Properties

        public UIItemWindow UIConfirmWindow
        {
            get
            {
                if ((mUIConfirmWindow == null))
                {
                    mUIConfirmWindow = new UIItemWindow(this, "5");
                }
                return mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIConfirmWindow;

        #endregion
    }
}