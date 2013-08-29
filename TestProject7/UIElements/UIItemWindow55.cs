namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow55 : WinWindow
    {
        public UIItemWindow55(UITestControl searchLimitContainer)
            : base(searchLimitContainer)
        {
            #region Search Criteria

            this.SearchProperties[WinControl.PropertyNames.ControlId] = "1";
            this.WindowTitles.Add("Mid Term Adjustments ");

            #endregion
        }

        #region Properties

        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);

                    #region Search Criteria

                    this.mUIItemComboBox.WindowTitles.Add("Mid Term Adjustments ");

                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }

        public WinButton UIBeforeButton 
        {
            get
            {
                if ((this.mUIBeforeButton == null))
                {
                    this.mUIBeforeButton = new WinButton(this);

                    #region Search Criteria

                    this.mUIBeforeButton.SearchProperties[UITestControl.PropertyNames.Name] = "Before";
                    this.mUIBeforeButton.WindowTitles.Add("Mid Term Adjustments ");

                    #endregion
                }
                return this.mUIBeforeButton;
            }
        }

        #endregion

        #region Fields

        private WinComboBox mUIItemComboBox;

        private WinButton mUIBeforeButton;

        #endregion
    }
}