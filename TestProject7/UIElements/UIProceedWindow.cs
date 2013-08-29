namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIProceedWindow : WinWindow
    {
        public UIProceedWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Credit Check At Renewal");

            #endregion
        }

        #region Properties

        public WinButton UIProceedButton 
        {
            get
            {
                if ((this.mUIProceedButton == null))
                {
                    this.mUIProceedButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIProceedButton.SearchProperties[UITestControl.PropertyNames.Name] = "Proceed";
                    this.mUIProceedButton.WindowTitles.Add("Credit Check At Renewal");

                    #endregion
                }
                return this.mUIProceedButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIProceedButton;

        #endregion
    }
}