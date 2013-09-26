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

            WinControl uIClientsFilesButton = map.UITheAgencyManagerWindow1.UIClientsFilesWindow.UIClientsFilesButton;
            WinComboBox uIItemComboBox = map.UICustomertxt1tdsfsWindow.UICustomersWindow.ItemWindow(map.UICustomertxt1tdsfsWindow, "", "1").UIItemComboBox;
            WinControl uIAddButton = map.UICustomertxt1tdsfsWindow.UIAddWindow.UIAddButton;
            //WinEdit uiFirstname = map.UIAssignClientNumberWindow.Firstname.UIItemEdit;
            WinEdit uiLastname = map.UIAssignClientNumberWindow.Lastname.UIItemEdit;
            //WinEdit uiIntial = map.UIAssignClientNumberWindow.Initial.UIItemEdit;
            //WinRadioButton rbTitle = map.UIAssignClientNumberWindow.Title.UITitleRadioButton;
            //WinRadioButton rbSuffix = map.UIAssignClientNumberWindow.Suffix.UISuffixRadioButton;
            WinControl uIOKButton = map.UIAssignClientNumberWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = map.UIVerifyWindow.UIYesWindow.UIYesButton;
            WinEdit uIItemEdit1 = map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit2 = map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIItemWindow1.UIItemEdit;
            WinControl uIOKButton1 = map.UICustomertxt1tdsfsWindow.UINewCustomerDetailWindow.UIOKWindow.UIOKButton;
            WinControl uIItemButton = map.UICustomertxt1tdsfsWindow.UIItemWindow.UIItemButton;
            WinControl uIOKButton2 = map.UISelectaPolicyNumberWindow.UIOKWindow.UIOKButton;
            WinEdit codeName = map.UIAssignClientNumberWindow.CodeName.UIItemEdit;

            #endregion

            Thread.Sleep(1000);

            Mouse.Click(uIClientsFilesButton, new Point(38, 30));

            uIItemComboBox.SelectedItem = map.AddPolicyParams.SelectCustomers;

            Mouse.Click(uIAddButton, new Point(175, 7));

            //uiFirstname.Text = map.AddPolicyParams.FirstName;

            uiLastname.Text = map.AddPolicyParams.LastName;

            //uiIntial.Text = "X";

            //rbTitle.Selected = true;

            //rbSuffix.Selected = true;

            Mouse.Click(codeName);

            string code = codeName.Text;

            Mouse.Click(uIOKButton, new Point(41, 15));

            Mouse.Click(uIYesButton, new Point(44, 11));

            uIItemEdit1.Text = map.AddPolicyParams.Agency;

            uIItemEdit2.Text = map.AddPolicyParams.Branch;

            Mouse.Click(uIOKButton1, new Point(24, 17));

            Mouse.Click(uIItemButton, new Point(10, 15));

            Mouse.Click(uIAddButton, new Point(94, 10));

            Mouse.Click(uIOKButton2, new Point(37, 13));

            return code;
        }
    }
}