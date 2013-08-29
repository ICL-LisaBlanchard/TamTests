namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICancelWindow3 : WinWindow
    {
        public UICancelWindow3(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "83";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UICancelButton
        {
            get
            {
                if ((this.mUICancelButton == null))
                {
                    this.mUICancelButton = new WinButton(this);

                    #region Search Criteria

                    this.mUICancelButton.SearchProperties[UITestControl.PropertyNames.Name] = "Cancel";
                    this.mUICancelButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUICancelButton;
            }
        }

        public WinButton UICloseButton 
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);

                    #region Search Criteria

                    this.mUICloseButton.SearchProperties[UITestControl.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUICloseButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUICancelButton;

        private WinButton mUICloseButton;

        #endregion
    }
}