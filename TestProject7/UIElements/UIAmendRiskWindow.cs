﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAmendRiskWindow : WinWindow
    {
        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "2", instance: "4");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIProposerDetailsWindow
        {
            get
            {
                if ((this.mUIProposerDetailsWindow == null))
                {
                    this.mUIProposerDetailsWindow = new UIItemWindow(this, controlId: "41");
                }
                return this.mUIProposerDetailsWindow;
            }
        }

        public UIItemWindow UICalculateQuoteWindow
        {
            get
            {
                if ((this.mUICalculateQuoteWindow == null))
                {
                    this.mUICalculateQuoteWindow = new UIItemWindow(this, controlId: "27");
                }
                return this.mUICalculateQuoteWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIProposerDetailsWindow;

        private UIItemWindow mUICalculateQuoteWindow;

        #endregion

        public UIAmendRiskWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Amend Risk";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Amend Risk");

            #endregion
        }
    }
}