﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINOWindow : WinWindow
    {
        public UINOWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Credit Check");

            #endregion
        }

        #region Properties

        public WinButton UINOButton
        {
            get
            {
                if ((this.mUINOButton == null))
                {
                    this.mUINOButton = new WinButton(this);

                    #region Search Criteria

                    this.mUINOButton.SearchProperties[UITestControl.PropertyNames.Name] = "No";
                    this.mUINOButton.WindowTitles.Add("Credit Check");

                    #endregion
                }
                return this.mUINOButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUINOButton;

        #endregion
    }
}