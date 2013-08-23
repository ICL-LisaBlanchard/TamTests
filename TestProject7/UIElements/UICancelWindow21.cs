namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICancelWindow21 : WinWindow
    {
        public UICancelWindow21(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "11";
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

        #endregion

        #region Fields

        private WinButton mUICancelButton;

        #endregion
    }
}