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
            string agcy;
            string brch;

            switch (Configs.PlanName)
            {
                case "Ver. 10.2":
                    agcy = "7";
                    brch = "8";
                    break;
                case "Ver. 11.1":
                    agcy = "7";
                    brch = "8";
                    break;
                default:
                    agcy = "14";
                    brch = "15";
                    break;
            }

            WinControl uIClientsFilesButton = map.UITheAgencyManagerWindow1.UIClientsFilesWindow.UIClientsFilesButton;
            WinComboBox uIItemComboBox = map.UICustomerListWindow.UICustomersWindow.ItemWindow(map.UICustomerListWindow, "", "1").UIItemComboBox;
            WinControl uIAddButton = map.UICustomerListWindow.UIAddWindow.UIAddButton;
            //WinEdit uiFirstname = map.UIAssignClientNumberWindow.Firstname.UIItemEdit;
            WinEdit uiLastname = map.UIAssignClientNumberWindow.Lastname.UIItemEdit;
            //WinEdit uiIntial = map.UIAssignClientNumberWindow.Initial.UIItemEdit;
            //WinRadioButton rbTitle = map.UIAssignClientNumberWindow.Title.UITitleRadioButton;
            //WinRadioButton rbSuffix = map.UIAssignClientNumberWindow.Suffix.UISuffixRadioButton;
            WinControl uIOKButton = map.UIAssignClientNumberWindow.UIOKWindow.UIOKButton;
            WinControl uIYesButton = map.UIVerifyWindow.UIYesWindow.UIYesButton;
            WinEdit uIItemEdit1 = map.UICustomerListWindow.UINewCustomerDetailWindow.UIItemWindow(agcy).UIItemEdit;
            WinEdit uIItemEdit2 = map.UICustomerListWindow.UINewCustomerDetailWindow.UIItemWindow(brch).UIItemEdit;
            WinControl uIOKButton1 = map.UICustomerListWindow.UINewCustomerDetailWindow.UIOKWindow.UIOKButton;
            WinControl uIItemButton = map.UICustomerListWindow.UIPoliciesWindow.UIItemButton;
            WinControl uIOKButton2 = map.UISelectaPolicyNumberWindow.UIOKWindow.UIOKButton;
            WinEdit codeName = map.UIAssignClientNumberWindow.CodeName.UIItemEdit;

            Thread.Sleep(1000);

            Mouse.Click(uIClientsFilesButton);

            uIItemComboBox.SelectedItem = map.AddPolicyParams.SelectCustomers;

            Mouse.Click(uIAddButton);

            //uiFirstname.Text = map.AddPolicyParams.FirstName;

            uiLastname.Text = map.AddPolicyParams.LastName;

            //uiIntial.Text = "X";

            //rbTitle.Selected = true;

            //rbSuffix.Selected = true;

            Mouse.Click(codeName);

            string code = codeName.Text;

            Mouse.Click(uIOKButton);

            Mouse.Click(uIYesButton);

            uIItemEdit1.Text = map.AddPolicyParams.Agency;

            uIItemEdit2.Text = map.AddPolicyParams.Branch;

            Mouse.Click(uIOKButton1, new Point(24, 17));

            Mouse.Click(uIItemButton);

            Mouse.Click(uIAddButton);

            Mouse.Click(uIOKButton2, new Point(37, 13));

            return code;
        }
    }
}