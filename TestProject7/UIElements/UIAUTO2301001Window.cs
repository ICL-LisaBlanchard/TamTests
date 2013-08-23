namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAUTO2301001Window : WinWindow
    {
        
        public UIAUTO2301001Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "AUTO230-1001";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("AUTO230-1001");
            #endregion
        }
        
        #region Properties
        public UIRebrokeWindow1 UIRebrokeWindow
        {
            get
            {
                if ((this.mUIRebrokeWindow == null))
                {
                    this.mUIRebrokeWindow = new UIRebrokeWindow1(this);
                }
                return this.mUIRebrokeWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIRebrokeWindow1 mUIRebrokeWindow;
        #endregion
    }
}