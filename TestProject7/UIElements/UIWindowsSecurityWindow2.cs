namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIWindowsSecurityWindow2 : WinWindow
    {
        public UIWindowsSecurityWindow2()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Connect to www.insur-econnect.com";
            //this.WindowTitles.Add("Windows Security");

            #endregion
        }
    }
}