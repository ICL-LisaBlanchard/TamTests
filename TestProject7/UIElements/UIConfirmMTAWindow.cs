namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmMTAWindow : WinWindow
    {
        public UIConfirmMTAWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm MTA";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Confirm MTA");

            #endregion
        }

        #region Properties

        public UIOKWindow25 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow25(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow25 mUIOKWindow;

        #endregion
    }
}