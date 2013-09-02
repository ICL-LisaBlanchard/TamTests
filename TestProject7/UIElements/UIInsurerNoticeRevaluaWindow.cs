namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIInsurerNoticeRevaluaWindow : WinWindow
    {
        public UIInsurerNoticeRevaluaWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Insurer Notice - Revaluation of Rebroked Quote Detail Required";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Insurer Notice - Revaluation of Rebroked Quote Detail Required");

            #endregion
        }

        #region Properties

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, "2");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}