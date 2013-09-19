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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO230-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO230-1001");

            #endregion
        }

        #region Properties

        public UIItemWindow UIRebrokeWindow
        {
            get
            {
                if ((this.mUIRebrokeWindow == null))
                {
                    this.mUIRebrokeWindow = new UIItemWindow(this, "30");
                }
                return this.mUIRebrokeWindow;
            }
        }

        public UIItemWindow UILapsePolicyWindow
        {
            get
            {
                if ((this.mUILapsePolicyWindow == null))
                {
                    this.mUILapsePolicyWindow = new UIItemWindow(this, "26");
                }
                return this.mUILapsePolicyWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIRebrokeWindow;

        private UIItemWindow mUILapsePolicyWindow;

        #endregion
    }
}