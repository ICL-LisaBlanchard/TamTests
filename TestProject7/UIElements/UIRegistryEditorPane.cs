namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIRegistryEditorPane : WinPane
    {
        public UIRegistryEditorPane(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Registry Editor";
            this.WindowTitles.Add("Registry Editor");

            #endregion
        }

        #region Properties

        public WinButton UIYesButton
        {
            get
            {
                if ((this.mUIYesButton == null))
                {
                    this.mUIYesButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIYesButton.SearchProperties[UITestControl.PropertyNames.Name] = "Yes";
                    this.mUIYesButton.WindowTitles.Add("Registry Editor");

                    #endregion
                }
                return this.mUIYesButton;
            }
        }

        public WinButton UIOKButton
        {
            get
            {
                if ((this.mUIOKButton == null))
                {
                    this.mUIOKButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIOKButton.SearchProperties[UITestControl.PropertyNames.Name] = "OK";
                    this.mUIOKButton.WindowTitles.Add("Registry Editor");

                    #endregion
                }
                return this.mUIOKButton;
            }
        }

        #endregion

        #region Fields

        private WinButton mUIYesButton;

        private WinButton mUIOKButton;

        #endregion
    }
}