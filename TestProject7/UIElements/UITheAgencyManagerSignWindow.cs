namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UITheAgencyManagerSignWindow : WinWindow
    {
        private const string WindowName = "The Agency Manager Signon";

        public UITheAgencyManagerSignWindow()
        {
            #region Search Criteria

            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("The Agency Manager Signon");

            #endregion
        }

        #region Properties

        public UIItemWindow TbxPassword
        {
            get
            {
                if ((mTbxPassword == null))
                {
                    mTbxPassword = new UIItemWindow(this, controlId: "7");
                }
                return mTbxPassword;
            }
        }

        public UIItemWindow TbxUsername
        {
            get
            {
                if ((mTbxUsername == null))
                {
                    mTbxUsername = new UIItemWindow(this, controlId: "1");
                }
                return mTbxUsername;
            }
        }

        public UIItemWindow BtnOk1
        {
            get
            {
                if ((mBtnOk1 == null))
                {
                    mBtnOk1 = new UIItemWindow(this, controlId: "2");
                }
                return mBtnOk1;
            }
        }

        public UIItemWindow BtnOk2
        {
            get
            {
                if ((mBtnOk2 == null))
                {
                    mBtnOk2 = new UIItemWindow(this, controlId: "2");
                }
                return mBtnOk2;
            }
        }

        public UIItemWindow TbxMonth
        {
            get
            {
                if ((mTbxMonth == null))
                {
                    mTbxMonth = new UIItemWindow(this, controlId: "2", instance: "2");
                }
                return mTbxMonth;
            }
        }

        public UIItemWindow TbxYear
        {
            get
            {
                if ((mTbxYear == null))
                {
                    mTbxYear = new UIItemWindow(this, controlId: "1");
                }
                return mTbxYear;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow mTbxPassword;

        private UIItemWindow mTbxUsername;

        private UIItemWindow mBtnOk1;

        private UIItemWindow mBtnOk2;

        private UIItemWindow mTbxMonth;

        private UIItemWindow mTbxYear;

        #endregion
    }
}