namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIClaimsWindow : WinWindow
    {
        public UIClaimsWindow()
        {
            #region Search Criteria

            this.SearchProperties[UITestControl.PropertyNames.Name] = "Claims";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "#32770";
            this.WindowTitles.Add("Claims");

            #endregion
        }

        #region Properties

        public UINOWindow2 UINOWindow
        {
            get
            {
                if ((this.mUINOWindow == null))
                {
                    this.mUINOWindow = new UINOWindow2(this);
                }
                return this.mUINOWindow;
            }
        }

        #endregion

        #region Fields

        private UINOWindow2 mUINOWindow;

        #endregion
    }
}