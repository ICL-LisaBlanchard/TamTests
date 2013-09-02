namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Drawing;

    using AppliedSystems.Tam.UI.Tests.Params;
    using AppliedSystems.Tam.Ui.Tests.Params;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class Login
    {
        private readonly UIMap map = new UIMap();

        private LoginParams mLoginParams;

        private LoginEnterDateParams mLoginEnterDateParams;

        public virtual LoginParams LoginParams
        {
            get
            {
                if ((this.mLoginParams == null))
                {
                    this.mLoginParams = new LoginParams();
                }
                return this.mLoginParams;
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

            WinEdit tbxPassword = this.map.UITheAgencyManagerSignWindow.TbxPassword.UIItemEdit;
            WinEdit tbxUserName = this.map.UITheAgencyManagerSignWindow.TbxUsername.UIItemEdit;
            WinControl btnOk = this.map.UITheAgencyManagerSignWindow.BtnOk1.UIOKButton;

            #endregion

            ApplicationUnderTest.Launch(this.LoginParams.ExePath, this.LoginParams.AlternateExePath);
            Mouse.Click(tbxUserName, new Point(33, 11));
            Keyboard.SendKeys(tbxUserName, this.LoginParams.Username);
            Mouse.Click(tbxPassword, new Point(33, 11));
            Keyboard.SendKeys(tbxPassword, this.LoginParams.Password, true);
            Mouse.Click(btnOk, new Point(67, 13));
        }

        public void LoginEnterDate()
        {
            #region Variable Declarations

            WinComboBox tbxMonth = this.map.UITheAgencyManagerSignWindow.TbxMonth.UIItemComboBox;
            WinEdit tbxYear = this.map.UITheAgencyManagerSignWindow.TbxYear.UIItemEdit;
            WinControl btnOk = this.map.UITheAgencyManagerSignWindow.BtnOk2.UIOKButton;

            #endregion

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
            //#region Variable Declarations

            //WinControl uIokButton = this.map.UIWarningWindow.UIOKWindow.UIOKButton;

            //#endregion

            //// Set flag to allow play back to continue if non-essential actions fail. (For example, if a mouse hover action fails.)
            ////Playback.PlaybackSettings.ContinueOnError = true;

            //// Click 'OK' button
            //Mouse.Click(uIokButton, new Point(50, 10));

            //// Reset flag to ensure that play back stops if there is an error.
            ////Playback.PlaybackSettings.ContinueOnError = false;
        }
    }
}