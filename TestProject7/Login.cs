namespace AppliedSystems.Tam.Ui.Tests
{
    using System;
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
                if ((mLoginParams == null))
                {
                    mLoginParams = new LoginParams();
                }
                return mLoginParams;
            }
        }

        public virtual LoginEnterDateParams LoginEnterDateParams
        {
            get
            {
                if ((mLoginEnterDateParams == null))
                {
                    mLoginEnterDateParams = new LoginEnterDateParams();
                }
                return mLoginEnterDateParams;
            }
        }

        public void DoLogin()
        {
            #region Variable Declarations

            WinEdit tbxPassword = map.UITheAgencyManagerSignWindow.TbxPassword.UIItemEdit;
            WinEdit tbxUserName = map.UITheAgencyManagerSignWindow.TbxUsername.UIItemEdit;
            WinControl btnOk = map.UITheAgencyManagerSignWindow.BtnOk1.UIOKButton;

            #endregion

            ApplicationUnderTest.Launch(Configs.ExePath, LoginParams.AlternateExePath);

            tbxUserName.Text = Configs.Username;
            tbxPassword.Text = Configs.Password;
            Mouse.Click(btnOk);
        }

        public void LoginEnterDate()
        {
            #region Variable Declarations

            WinComboBox tbxMonth = map.UITheAgencyManagerSignWindow.TbxMonth.UIItemComboBox;
            WinEdit tbxYear = map.UITheAgencyManagerSignWindow.TbxYear.UIItemEdit;
            WinControl btnOk = map.UITheAgencyManagerSignWindow.BtnOk2.UIOKButton;

            #endregion

            map.UITheAgencyManagerSignWindow.BtnOk2.UIItemEdit.Text = DateTime.Now.ToString("dd/MM/yyyy");

            tbxMonth.SelectedItem = LoginEnterDateParams.MonthName;

            // Type '2012' in text box
            tbxYear.Text = LoginEnterDateParams.Year;

            // Click '&OK' button
            Mouse.Click(btnOk, new Point(54, 5));

            this.WarningOk();
        }

        public void WarningOk()
        {

            WinControl uIokButton = map.UIWarningWindow.UIOKWindow.UIOKButton;
            Playback.PlaybackSettings.SearchTimeout = 2000;
            Playback.PlaybackSettings.ContinueOnError = true;
            Mouse.Click(uIokButton);
            Playback.PlaybackSettings.ContinueOnError = false;
            Playback.PlaybackSettings.SearchTimeout = Configs.SearchTimeout;
        }
    }
}