﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDetailWindow3 : WinWindow
    {
        public UIDetailWindow3(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Transaction: autotest");

            #endregion
        }

        #region Properties

        public WinButton UIDetailButton
        {
            get
            {
                if ((this.mUIDetailButton == null))
                {
                    this.mUIDetailButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIDetailButton.SearchProperties[UITestControl.PropertyNames.Name] = "Detail";
                    this.mUIDetailButton.WindowTitles.Add("Transaction: autotest");

                    #endregion
                }
                return this.mUIDetailButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIDetailButton;

        #endregion
    }
}