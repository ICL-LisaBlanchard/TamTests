namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPrintDocumentsWindow : WinWindow
    {
        public UIPrintDocumentsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Print Documents";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Print Documents");

            #endregion
        }

        #region Properties

        public UIDeferPrintingWindow1 UIDeferPrintingWindow
        {
            get
            {
                if ((this.mUIDeferPrintingWindow == null))
                {
                    this.mUIDeferPrintingWindow = new UIDeferPrintingWindow1(this);
                }
                return this.mUIDeferPrintingWindow;
            }
        }

        public UIOKWindow31 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow31(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIDeferPrintingWindow1 mUIDeferPrintingWindow;

        private UIOKWindow31 mUIOKWindow;

        #endregion
    }
}