﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIPersonalLinesWindow : WinWindow
    {
        public UIPersonalLinesWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Personal Lines";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6MDIForm";
            this.WindowTitles.Add("Personal Lines");

            #endregion
        }

        #region Properties

        public UIHouseholdQuoteWindow UIHouseholdQuoteWindow
        {
            get
            {
                if ((this.mUIHouseholdQuoteWindow == null))
                {
                    this.mUIHouseholdQuoteWindow = new UIHouseholdQuoteWindow(this);
                }
                return this.mUIHouseholdQuoteWindow;
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

        public UIItemWindow UIYesWindow
        {
            get
            {
                return new UIItemWindow(this, "6");
            }
        }

        #endregion

        #region Fields

        private UIHouseholdQuoteWindow mUIHouseholdQuoteWindow;

        private UIItemWindow mUIOKWindow;

        #endregion
    }
}