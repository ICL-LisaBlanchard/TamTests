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

        public UIMTAsuccessfullyproceWindow UIMTAsuccessfullyproceWindow
        {
            get
            {
                if ((this.mUIMTAsuccessfullyproceWindow == null))
                {
                    this.mUIMTAsuccessfullyproceWindow = new UIMTAsuccessfullyproceWindow(this);
                }
                return this.mUIMTAsuccessfullyproceWindow;
            }
        }

        public UIOKWindow33 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow33(this);
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIMTAsuccessfullyproceWindow mUIMTAsuccessfullyproceWindow;

        private UIOKWindow33 mUIOKWindow;

        #endregion
    }
}