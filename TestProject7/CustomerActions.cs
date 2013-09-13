namespace AppliedSystems.Tam.Ui.Tests
{
    using System.Drawing;
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class CustomerActions
    {
        private readonly UIMap map = new UIMap();

        /// <summary>
        ///     AddPolicy - Use 'AddPolicyParams' to pass parameters into this method.
        /// </summary>
        public string AddPolicy()
        {
            #region Variable Declarations

            WinControl uIClientsFilesButton = this.map.UITheAgencyManagerWindow1.UIClientsFilesWindow.UIClientsFilesButton;
            WinComboBox uIItemComboBox = this.map.UICustomertxt1tdsfsWindow.UICustomersWindow.ItemWindow(this.map.UICustomertxt1tdsfsWindow, "", "1").UIItemComboBox;
            WinControl uIAddButton = this.map.UICustomertxt1tdsfsWindow.UIAddWindow.UIAddButton;
            //WinEdit uiFirstname = this.map.UIAssignClientNumberWindow.Firstname.UIItemEdit;
            WinEdit uiLastname = this.map.UIAssignClientNumberWindow.Lastname.UIItemEdit;
            //WinEdit uiIntial = this.map.UIAssignClientNumberWindow.Initial.UIItemEdit;
            //WinRadioButton rbTitle = this.map.UIAssignClientNumberWindow.Title.UITitleRadioButton;
            //WinRadioButton rbSuffix = this.map.UIAssignClientNumberWindow.Suffix.UISuffixRadioButton;
            WinControl uIOKButton = this.map.UIAssignClientNumberWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = this.map.UIVerifyWindow.UIYesWindow.UIYesButton;
            WinEdit uIItemEdit1 = this.map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = this.map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton1 = this.map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIOKWindow.UIOKButton;
            WinControl uIItemButton = this.map.UICustomertxt1tdsfsWindow.UIItemWindow.UIItemButton;
            WinControl uIOKButton2 = this.map.UISelectaPolicyNumberWindow.UIOKWindow.UIOKButton;
            WinEdit codeName = this.map.UIAssignClientNumberWindow.CodeName.UIItemEdit;

            #endregion

            Thread.Sleep(1000);

            Mouse.Click(uIClientsFilesButton, new Point(38, 30));

            uIItemComboBox.SelectedItem = this.map.AddPolicyParams.SelectCustomers;

            Mouse.Click(uIAddButton, new Point(175, 7));

            //uiFirstname.Text = this.map.AddPolicyParams.FirstName;

            uiLastname.Text = this.map.AddPolicyParams.LastName;

            //uiIntial.Text = "X";

            //rbTitle.Selected = true;

            //rbSuffix.Selected = true;

            Mouse.Click(codeName);

            string code = codeName.Text;

            Mouse.Click(uIOKButton, new Point(41, 15));

            Mouse.Click(uIYesButton, new Point(44, 11));

            uIItemEdit1.Text = this.map.AddPolicyParams.Agency;

            uIItemEdit2.Text = this.map.AddPolicyParams.Branch;

            Mouse.Click(uIOKButton1, new Point(24, 17));

            Mouse.Click(uIItemButton, new Point(10, 15));

            Mouse.Click(uIAddButton, new Point(94, 10));

            Mouse.Click(uIOKButton2, new Point(37, 13));

            return code;
        }
    }
}