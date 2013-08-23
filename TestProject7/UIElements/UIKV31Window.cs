namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIKV31Window : WinWindow
    {
        public UIKV31Window()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "KV31";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "TConversationForm";
            this.WindowTitles.Add("KV31");

            #endregion
        }

        #region Properties

        public UIItemWindow45 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow45(this);
                }
                return this.mUIItemWindow;
            }
        }

        #endregion

        #region Fields

        private UIItemWindow45 mUIItemWindow;

        #endregion
    }
}