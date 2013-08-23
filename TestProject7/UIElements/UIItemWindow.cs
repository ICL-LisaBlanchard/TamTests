namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemWindow : WinWindow
    {
        public UIItemWindow(UITestControl searchLimitContainer, string windowTitle, string controlId = "", string instance = "")
            : base(searchLimitContainer)
        {
            #region Search Criteria

            if (!string.IsNullOrEmpty(controlId))
            {
                this.SearchProperties[WinControl.PropertyNames.ControlId] = controlId;
            }

            if (!string.IsNullOrEmpty(instance))
            {
                this.SearchProperties[UITestControl.PropertyNames.Instance] = instance;
            }

            this.WindowTitles.Add(windowTitle);

            this.WindowName = windowTitle;

            #endregion
        }

        #region Properties

        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUiItemEdit == null))
                {
                    this.mUiItemEdit = new WinEdit(this);

                    #region Search Criteria

                    this.mUiItemEdit.WindowTitles.Add(this.WindowName);

                    #endregion
                }
                return this.mUiItemEdit;
            }
        }

        public WinComboBox UiItemComboBox
        {
            get
            {
                if ((this.mUiItemComboBox == null))
                {
                    this.mUiItemComboBox = new WinComboBox(this);

                    #region Search Criteria

                    this.mUiItemComboBox.WindowTitles.Add(this.WindowName);

                    #endregion
                }
                return this.mUiItemComboBox;
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
                    this.mUIOKButton.WindowTitles.Add(this.WindowName);

                    #endregion
                }
                return this.mUIOKButton;
            }
        }

        #endregion

        #region Fields

        private WinEdit mUiItemEdit;

        private WinComboBox mUiItemComboBox;

        private WinButton mUIOKButton;

        #endregion

        public string WindowName { get; set; }
    }
}