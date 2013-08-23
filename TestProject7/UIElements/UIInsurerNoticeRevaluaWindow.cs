namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
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

        public UIOKWindow36 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow36(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow36 mUIOKWindow;

        #endregion
    }
}