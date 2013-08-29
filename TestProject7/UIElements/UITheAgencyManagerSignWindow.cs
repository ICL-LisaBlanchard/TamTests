namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITheAgencyManagerSignWindow : WinWindow
    {
        private const string WindowName = "The Agency Manager Signon";

        public UITheAgencyManagerSignWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("The Agency Manager Signon");

            #endregion
        }

        #region Properties

        public UIItemWindow TbxPassword
        {
            get
            {
                if ((this.mTbxPassword == null))
                {
                    this.mTbxPassword = new UIItemWindow(this, controlId: "7");
                }
                return this.mTbxPassword;
            }
        }

        public UIItemWindow TbxUsername
        {
            get
            {
                if ((this.mTbxUsername == null))
                {
                    this.mTbxUsername = new UIItemWindow(this, controlId: "1");
                }
                return this.mTbxUsername;
            }
        }

        public UIItemWindow BtnOk1
        {
            get
            {
                if ((this.mBtnOk1 == null))
                {
                    this.mBtnOk1 = new UIItemWindow(this, controlId: "2");
                }
                return this.mBtnOk1;
            }
        }

        public UIItemWindow BtnOk2
        {
            get
            {
                if ((this.mBtnOk2 == null))
                {
                    this.mBtnOk2 = new UIItemWindow(this, controlId: "2");
                }
                return this.mBtnOk2;
            }
        }

        public UIItemWindow TbxMonth
        {
            get
            {
                if ((this.mTbxMonth == null))
                {
                    this.mTbxMonth = new UIItemWindow(this, controlId: "2", instance: "2");
                }
                return this.mTbxMonth;
            }
        }

        public UIItemWindow TbxYear
        {
            get
            {
                if ((this.mTbxYear == null))
                {
                    this.mTbxYear = new UIItemWindow(this, controlId: "1");
                }
                return this.mTbxYear;
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