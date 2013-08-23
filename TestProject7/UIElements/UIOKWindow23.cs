namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIOKWindow23 : WinWindow
    {
        public UIOKWindow23(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Mid Term Adjustments ");

            #endregion
        }

        #region Properties

        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIOKButton.SearchProperties[UITestControl.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Mid Term Adjustments ");

                    #endregion
                }
                return this.mUIOKButton;
            }
        }

        public WinButton UIAfterButton
        {
            get
            {
                if ((this.mUIAfterButton == null))
                {
                    this.mUIAfterButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIAfterButton.SearchProperties[UITestControl.PropertyNames.Name] = "After";
                    this.mUIAfterButton.WindowTitles.Add("Mid Term Adjustments ");

                    #endregion
                }
                return this.mUIAfterButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIOKButton;

        private WinButton mUIAfterButton;

        #endregion
    }
}