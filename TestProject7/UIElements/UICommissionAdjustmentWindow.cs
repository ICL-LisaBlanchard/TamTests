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

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Commission Adjustment";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Commission Adjustment");

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

        public WinControl UICommissionAdjustmentDialog
        {
            get
            {
                if ((this.mUICommissionAdjustmentDialog == null))
                {
                    this.mUICommissionAdjustmentDialog = new WinControl(this);

                    #region Search Criteria

                    this.mUICommissionAdjustmentDialog.SearchProperties[UITestControl.PropertyNames.Name] = "Commission Adjustment";
                    this.mUICommissionAdjustmentDialog.SearchProperties[UITestControl.PropertyNames.ControlType] = "Dialog";
                    this.mUICommissionAdjustmentDialog.WindowTitles.Add("Commission Adjustment");

                    #endregion
                }
                return this.mUICommissionAdjustmentDialog;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIOKWindow;

        private WinControl mUICommissionAdjustmentDialog;

        #endregion
    }
}