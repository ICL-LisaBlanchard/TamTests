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
                if ((mUIPersonalLinesWindow == null))
                {
                    mUIPersonalLinesWindow = new UIItemWindow(this, controlId: "11");
                }
                return mUIPersonalLinesWindow;
            }
        }

        public UIItemWindow Lastname
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "9");
                }
                return mUIItemWindow;
            }
        }

        public UIItemWindow Firstname
        {
            get
            {
                if ((mUIItemWindow == null))
                {
                    mUIItemWindow = new UIItemWindow(this, controlId: "8");
                }
                return mUIItemWindow;
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
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, controlId: "4");
                }
                return mUIOKWindow;
            }
        }

        public UIItemWindow CodeName
        {
            get
            {
                if ((mCodeName == null))
                {
                    mCodeName = new UIItemWindow(this, "1", instance: "3");
                }
                return mCodeName;
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

            SearchProperties[UITestControl.PropertyNames.Name] = "Assign Client Number";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("Assign Client Number");

            #endregion
        }
    }
}