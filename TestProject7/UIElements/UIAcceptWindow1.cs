namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAcceptWindow1 : WinWindow
    {
        public UIAcceptWindow1(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "2";
            this.WindowTitles.Add("Quotes Results");

            #endregion
        }

        #region Properties

        public WinButton UIAcceptButton
        {
            get
            {
                if ((this.mUIAcceptButton == null))
                {
                    this.mUIAcceptButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIAcceptButton.SearchProperties[UITestControl.PropertyNames.Name] = "Accept";
                    this.mUIAcceptButton.WindowTitles.Add("Quotes Results");

                    #endregion
                }
                return this.mUIAcceptButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIAcceptButton;

        #endregion
    }
}