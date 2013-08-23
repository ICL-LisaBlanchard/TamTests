namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIErrorWindow : WinWindow
    {
        public UIErrorWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Public Credit Check";

            #endregion
        }

        #region Properties

        public UIOKWindow40 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow40(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIOKWindow40 mUIOKWindow;

        #endregion
    }
}