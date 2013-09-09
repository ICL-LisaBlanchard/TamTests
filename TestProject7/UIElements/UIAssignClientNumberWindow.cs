namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIAssignClientNumberWindow : WinWindow
    {
        private const string WindowTitle = "Assign Client Number";

        #region Properties

        public UITestControl UIPersonalLinesWindow
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

        public UITestControl Title
        {
            get
            {
                return new UIItemWindow(this, controlId: "30");
            }
        }

        public UITestControl Suffix
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

        public UIItemWindow CodeName
        {
            get
            {
                if ((this.mCodeName == null))
                {
                    this.mCodeName = new UIItemWindow(this, "1", instance: "3");
                }
                return this.mCodeName;
            }
        }

        #endregion

        #region Fields

        private UITestControl mUIPersonalLinesWindow;

        private UIItemWindow mUIItemWindow;

        private UIItemWindow mUIOKWindow;

        private UIItemWindow mCodeName;

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