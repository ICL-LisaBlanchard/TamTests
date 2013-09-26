namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UiautoWindow : WinWindow
    {
        public UiautoWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "AUTO230-1001";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("AUTO230-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((mUIRebrokeWindow == null))
                {
                    mUIRebrokeWindow = new UIItemWindow(this, "30");
                }
                return mUIRebrokeWindow;
            }
        }

        public UIItemWindow UILapsePolicyWindow
        {
            get
            {
                if ((mUILapsePolicyWindow == null))
                {
                    mUILapsePolicyWindow = new UIItemWindow(this, "26");
                }
                return mUILapsePolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        private UIItemWindow mUILapsePolicyWindow;

        #endregion
    }
}