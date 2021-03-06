﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIBillingScreenHomeTestWindow : WinWindow
    {
        public UIBillingScreenHomeTestWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            SearchProperties[WinControl.PropertyNames.ControlId] = "32770";
            windowName = "Policy: gdfhdf dfghgdf";
            WindowTitles.Add(windowName);

            #endregion
        }

        #region Properties

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "1", instance: "25");
                }
                return mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private readonly string windowName;

        private UIItemWindow mUIItemWindow;

        #endregion
    }
}