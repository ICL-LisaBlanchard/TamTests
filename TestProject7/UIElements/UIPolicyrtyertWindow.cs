﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPolicyrtyertWindow : WinWindow
    {
        public UIPolicyrtyertWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Policy: rty ert";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Policy: rty ert");

            #endregion
        }

        #region Properties

        public UIBillingScreenMotoTestWindow UIBillingScreenMotoTestWindow
        {
            get
            {
                if ((this.mUIBillingScreenMotoTestWindow == null))
                {
                    this.mUIBillingScreenMotoTestWindow = new UIBillingScreenMotoTestWindow(this);
                }
                return this.mUIBillingScreenMotoTestWindow;
            }
        }

        #endregion

        #region Fields

        private UIBillingScreenMotoTestWindow mUIBillingScreenMotoTestWindow;

        #endregion
    }
}