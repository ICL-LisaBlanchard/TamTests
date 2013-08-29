namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVehicleLookupWindow : WinWindow
    {
        public UIVehicleLookupWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = WindowName;
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add(WindowName);

            #endregion
        }

        #region Properties

        private const string WindowName = "Vehicle Lookup";

        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "3");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow UIFilterWindow
        {
            get
            {
                if ((this.mUIFilterWindow == null))
                {
                    this.mUIFilterWindow = new UIItemWindow(this, controlId: "2");
                }
                return this.mUIFilterWindow;
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "18");
                }
                return this.mUIOKWindow;
            }
        }

        public UIItemWindow UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow(this, controlId: "9");
                }
                return this.mUIItemWindow1;
            }
        }

        public UIItemWindow UIItemWindow11
        {
            get
            {
                if ((this.mUIItemWindow11 == null))
                {
                    this.mUIItemWindow11 = new UIItemWindow(this, controlId: "10");
                }
                return this.mUIItemWindow11;
            }
        }

        public UIItemWindow UIFilterWindow1
        {
            get
            {
                if ((this.mUIFilterWindow1 == null))
                {
                    this.mUIFilterWindow1 = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIFilterWindow1;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIFilterWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mUIItemWindow1;

        private UIItemWindow mUIItemWindow11;

        private UIItemWindow mUIFilterWindow1;

        #endregion
    }
}