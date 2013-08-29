namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAssignClientNumberWindow : WinWindow
    {
        private const string WindowTitle = "Assign Client Number";

        #region Properties

        public UIItemWindow UIPersonalLinesWindow
        {
            get
            {
                if ((this.mUIPersonalLinesWindow == null))
                {
                    this.mUIPersonalLinesWindow = new UIItemWindow(this, controlId: "11");
                }
                return this.mUIPersonalLinesWindow;
            }
        }

        public UIItemWindow Lastname
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "9");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow Firstname
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this, controlId: "8");
                }
                return this.mUIItemWindow;
            }
        }

        public UIItemWindow Initial
        {
            get
            {
                return new UIItemWindow(this, controlId: "1", instance: "2");
            }
        }

        public UIItemWindow Title
        {
            get
            {
                return new UIItemWindow(this, controlId: "30");
            }
        }

        public UIItemWindow Suffix
        {
            get
            {
                return new UIItemWindow(this, controlId: "18");
            }
        }

        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIItemWindow(this, controlId: "4");
                }
                return this.mUIOKWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mUIPersonalLinesWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIOKWindow;

        #endregion

        public UIAssignClientNumberWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Assign Client Number";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Assign Client Number");

            #endregion
        }
    }
}