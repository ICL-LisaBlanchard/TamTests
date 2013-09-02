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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy Date / Time";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Policy Date / Time");

            #endregion
        }

        #region Properties

        public UIItemWindow UIConfirmWindow
        {
            get
            {
                if ((this.mUIConfirmWindow == null))
                {
                    this.mUIConfirmWindow = new UIItemWindow(this, "5");
                }
                return this.mUIConfirmWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIConfirmWindow;

        #endregion
    }
}