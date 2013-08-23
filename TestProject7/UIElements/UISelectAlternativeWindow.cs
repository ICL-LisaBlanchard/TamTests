namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UISelectAlternativeWindow : WinWindow
    {
        public UISelectAlternativeWindow(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "6";
            this.WindowTitles.Add("Rebroke Results Screen");

            #endregion
        }

        #region Properties

        public WinButton UISelectAlternativeButton
        {
            get
            {
                if ((this.mUISelectAlternativeButton == null))
                {
                    this.mUISelectAlternativeButton = new WinButton(this);

                    #region Search Criteria

                    this.mUISelectAlternativeButton.SearchProperties[UITestControl.PropertyNames.Name] = "Select Alternative";
                    this.mUISelectAlternativeButton.WindowTitles.Add("Rebroke Results Screen");

                    #endregion
                }
                return this.mUISelectAlternativeButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUISelectAlternativeButton;

        #endregion
    }
}