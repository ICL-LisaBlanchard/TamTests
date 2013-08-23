namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITestProject7Window : WinWindow
    {
        public UITestProject7Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "TestProject7";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("TestProject7");

            #endregion
        }

        #region Properties

        public UIItemWindow58 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow58(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow58 mUIItemWindow;

        #endregion
    }
}