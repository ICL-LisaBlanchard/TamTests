namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegressWindow : WinWindow
    {
        public UIRegressWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "10";
            this.WindowTitles.Add("Regress IETam Policy");

            #endregion
        }

        #region Properties

        public WinButton UIRegressButton 
        {
            get
            {
                if ((this.mUIRegressButton == null))
                {
                    this.mUIRegressButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIRegressButton.SearchProperties[UITestControl.PropertyNames.Name] = "Regress";
                    this.mUIRegressButton.WindowTitles.Add("Regress IETam Policy");

                    #endregion
                }
                return this.mUIRegressButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIRegressButton;

        #endregion
    }
}