﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIApplicationMenuBar : WinMenuBar
    {
        public UIApplicationMenuBar(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Application";
            this.WindowTitles.Add("Policy: autotest");

            #endregion
        }

        #region Properties

        public UIMenuListItem UIOptionsMenuItem
        {
            get
            {
                return new UIMenuListItem(this, "Options");
            }
        }

        #endregion
    }
}