namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIConfirmWindow2 : WinWindow
    {
        public UIConfirmWindow2()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Confirm";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Confirm");

            #endregion
        }

        #region Properties

        public UIYesWindow3 UIYesWindow
        {
            get
            {
                if ((this.mUIYesWindow == null))
                {
                    this.mUIYesWindow = new UIYesWindow3(this);
                }
                return this.mUIYesWindow;
            }
        }

        public UIOKWindow32 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow32(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIYesWindow3 mUIYesWindow;

        private UIOKWindow32 mUIOKWindow;

        #endregion
    }
}