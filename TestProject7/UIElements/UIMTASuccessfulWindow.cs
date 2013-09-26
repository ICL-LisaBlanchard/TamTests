namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIMTASuccessfulWindow : WinWindow
    {
        public UIMTASuccessfulWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "MTA Successful";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add("MTA Successful");

            #endregion
        }

        #region Properties

        public UIItemWindow UIMtaSuccessfullyProcessedWindow
        {
            get
            {
                if ((mUIMtaSuccessfullyProcessedWindow == null))
                {
                    mUIMtaSuccessfullyProcessedWindow = new UIItemWindow(this, "65535");
                }
                return mUIMtaSuccessfullyProcessedWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "2");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIMtaSuccessfullyProcessedWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}