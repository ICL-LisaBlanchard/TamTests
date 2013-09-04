﻿namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITamxml7Window : WinWindow
    {
        public UITamxml7Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Tamxml7";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TMessageForm";
            this.WindowTitles.Add("Tamxml7");

            #endregion
        }

        #region Properties

        public UIClient UITamxml7Client
        {
            get
            {
                if ((this.mUITamxml7Client == null))
                {
                    this.mUITamxml7Client = new UIClient(this, "Tamxml7");
                }
                return this.mUITamxml7Client;
            }
        }

        #endregion

        #region Fields

        private UIClient mUITamxml7Client;

        #endregion
    }
}