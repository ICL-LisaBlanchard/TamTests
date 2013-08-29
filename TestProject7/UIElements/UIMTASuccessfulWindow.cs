namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIMTASuccessfulWindow : WinWindow
    {
        public UIMTASuccessfulWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "MTA Successful";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("MTA Successful");

            #endregion
        }

        #region Properties

        public UIItemWindow UIMtaSuccessfullyProcessedWindow
        {
            get
            {
                if ((this.mUIMtaSuccessfullyProcessedWindow == null))
                {
                    this.mUIMtaSuccessfullyProcessedWindow = new UIItemWindow(this, "65535");
                }
                return this.mUIMtaSuccessfullyProcessedWindow;
            }
        }

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

        private UIItemWindow mUIMtaSuccessfullyProcessedWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}