namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDisplayRecordWindow : WinWindow
    {
        public UIDisplayRecordWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "3";
            this.WindowTitles.Add("insur-E.tam");

            #endregion
        }

        #region Properties

        public WinButton UIDisplayRecordButton 
        {
            get
            {
                if ((this.mUIDisplayRecordButton == null))
                {
                    this.mUIDisplayRecordButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIDisplayRecordButton.SearchProperties[UITestControl.PropertyNames.Name] = "Display Record...";
                    this.mUIDisplayRecordButton.WindowTitles.Add("insur-E.tam");

                    #endregion
                }
                return this.mUIDisplayRecordButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIDisplayRecordButton;

        #endregion
    }
}