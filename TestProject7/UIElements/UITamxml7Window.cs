namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UITamxml7Window : WinWindow
    {
        public UITamxml7Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Tamxml7";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TMessageForm";
            this.WindowTitles.Add("Tamxml7");

            #endregion
        }

        #region Properties

        public UITamxml7Client UITamxml7Client
        {
            get
            {
                if ((this.mUITamxml7Client == null))
                {
                    this.mUITamxml7Client = new UITamxml7Client(this);
                }
                return this.mUITamxml7Client;
            }
        }

        #endregion

        #region Fields

        private UITamxml7Client mUITamxml7Client;

        #endregion
    }
}