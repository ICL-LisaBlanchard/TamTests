﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAmendRiskWindow : WinWindow
    {
        public UIAmendRiskWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("AUTO208-1001");

            #endregion
        }

        #region Properties

        public WinButton UIAmendRiskButton
        {
            get
            {
                if ((this.mUIAmendRiskButton == null))
                {
                    this.mUIAmendRiskButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIAmendRiskButton.SearchProperties[UITestControl.PropertyNames.Name] = "Amend Risk...";
                    this.mUIAmendRiskButton.WindowTitles.Add("AUTO208-1001");

                    #endregion
                }
                return this.mUIAmendRiskButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIAmendRiskButton;

        #endregion
    }
}