namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyWindow : WinWindow
    {
        public UIPolicyWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Policy";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add("Policy");

            #endregion
        }

        #region Properties

        public UIItemWindow UIYesWindow
        {
            get
            {
                if ((mUIYesWindow == null))
                {
                    mUIYesWindow = new UIItemWindow(this, "6");
                }
                return mUIYesWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIYesWindow;

        #endregion
    }
}