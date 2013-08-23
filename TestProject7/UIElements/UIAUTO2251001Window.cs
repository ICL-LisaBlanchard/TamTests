﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2251001Window : WinWindow
    {
        public UIAUTO2251001Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "AUTO225-1001";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO225-1001");

            #endregion
        }

        #region Properties

        public UIAmendRiskWindow2 UIAmendRiskWindow
        {
            get
            {
                if ((this.mUIAmendRiskWindow == null))
                {
                    this.mUIAmendRiskWindow = new UIAmendRiskWindow2(this);
                }
                return this.mUIAmendRiskWindow;
            }
        }

        #endregion

        #region Fields

        private UIAmendRiskWindow2 mUIAmendRiskWindow;

        #endregion
    }
}