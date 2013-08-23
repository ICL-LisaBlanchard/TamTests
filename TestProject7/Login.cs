namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Drawing;

    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class Login
    {
        private readonly UIMap map = new UIMap();

        private UI.Tests.Params.LoginParamsNew mLoginParamsNew;

        private LoginEnterDateParams mLoginEnterDateParams;

        public virtual UI.Tests.Params.LoginParamsNew LoginParamsNew
        {
            get
            {
                if ((this.mLoginParamsNew == null))
                {
                    this.mLoginParamsNew = new UI.Tests.Params.LoginParamsNew();
                }
                return this.mLoginParamsNew;
            }
        }

        public virtual LoginEnterDateParams LoginEnterDateParams
        {
            get
            {
                if ((this.mLoginEnterDateParams == null))
                {
                    this.mLoginEnterDateParams = new LoginEnterDateParams();
                }
                return this.mLoginEnterDateParams;
            }
        }

        public void DoLogin()
        {
            #region Variable Declarations

            WinEdit tbxPassword = this.map.UITheAgencyManagerSignWindow.UIItemWindow.UIItemEdit;
            WinEdit tbxUserName = this.map.UITheAgencyManagerSignWindow.UIItemWindow.UIItemEdit;
            WinButton btnOk = this.map.UITheAgencyManagerSignWindow.UIOKWindow.UIOKButton;

            #endregion

            ApplicationUnderTest.Launch(this.LoginParamsNew.ExePath, this.LoginParamsNew.AlternateExePath);
            Mouse.Click(tbxUserName, new Point(33, 11));
            Keyboard.SendKeys(tbxUserName, this.LoginParamsNew.Username);
            Mouse.Click(tbxPassword, new Point(33, 11));
            Keyboard.SendKeys(tbxPassword, this.LoginParamsNew.Password, true);
            Mouse.Click(btnOk, new Point(67, 13));
        }

        public void LoginEnterDate()
        {
            #region Variable Declarations

            WinEdit tbxDate = this.map.UITheAgencyManagerSignWindow.UIOKWindow.UIItemEdit;
            WinComboBox tbxMonth = this.map.UITheAgencyManagerSignWindow.UIItemWindow1.UIItemComboBox;
            WinEdit tbxYear = this.map.UITheAgencyManagerSignWindow.UIItemWindow2.UIItemEdit;
            WinButton btnOk = this.map.UITheAgencyManagerSignWindow.UIOKWindow1.UIOKButton;

            #endregion

            tbxDate.Text = this.LoginEnterDateParams.FullDateText;

            // Select 'November' in combo box
            tbxMonth.SelectedItem = this.LoginEnterDateParams.MonthName;

            // Type '2012' in text box
            tbxYear.Text = this.LoginEnterDateParams.Year;

            // Click '&OK' button
            Mouse.Click(btnOk, new Point(54, 5));
        }

        /// <summary>
        /// WarningOk
        /// </summary>
        public void WarningOk()
        {
            #region Variable Declarations

            WinButton uIokButton = this.map.UIWarningWindow.UIOKWindow.UIOKButton;

            #endregion

            // Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            Playback.PlaybackSettings.ContinueOnError = true;

            // Click 'OK' button
            Mouse.Click(uIokButton, new Point(50, 10));

            // Reset flag to ensure that play back stops if there is an error.
            Playback.PlaybackSettings.ContinueOnError = false;
        }
    }
}