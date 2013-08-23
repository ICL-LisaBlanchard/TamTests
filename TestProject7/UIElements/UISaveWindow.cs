namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISaveWindow : WinWindow
    {
        public UISaveWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Save the file as");

            #endregion
        }

        #region Properties

        public WinButton UISaveButton
        {
            get
            {
                if ((this.mUISaveButton == null))
                {
                    this.mUISaveButton = new WinButton(this);

                    #region Search Criteria

                    this.mUISaveButton.SearchProperties[UITestControl.PropertyNames.Name] = "Save";
                    this.mUISaveButton.WindowTitles.Add("Save the file as");

                    #endregion
                }
                return this.mUISaveButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUISaveButton;

        #endregion
    }
}