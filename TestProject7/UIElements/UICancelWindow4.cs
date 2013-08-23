namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICancelWindow4 : WinWindow
    {
        public UICancelWindow4(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Save the file as");

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
                    this.mUICancelButton.WindowTitles.Add("Save the file as");

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