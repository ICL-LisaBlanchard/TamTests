namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UICommissionAdjustmentWindow : WinWindow
    {
        public UICommissionAdjustmentWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.Name] = "Commission Adjustment";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            WindowTitles.Add("Commission Adjustment");

            #endregion
        }

        #region Properties

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

        public WinControl UICommissionAdjustmentDialog
        {
            get
            {
                if ((mUICommissionAdjustmentDialog == null))
                {
                    mUICommissionAdjustmentDialog = new WinControl(this);

                    #region Search Criteria

                    mUICommissionAdjustmentDialog.SearchProperties[UITestControl.PropertyNames.Name] = "Commission Adjustment";
                    mUICommissionAdjustmentDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    mUICommissionAdjustmentDialog.WindowTitles.Add("Commission Adjustment");

                    #endregion
                }
                return mUICommissionAdjustmentDialog;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        private WinControl mUICommissionAdjustmentDialog;

        #endregion
    }
}