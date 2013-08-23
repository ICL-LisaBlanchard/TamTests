namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAssignClientNumberWindow : WinWindow
    {
        
        public UIAssignClientNumberWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Assign Client Number";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Assign Client Number");
            #endregion
        }
        
        #region Properties
        public UIPersonalLinesWindow UIPersonalLinesWindow
        {
            get
            {
                if ((this.mUIPersonalLinesWindow == null))
                {
                    this.mUIPersonalLinesWindow = new UIPersonalLinesWindow(this);
                }
                return this.mUIPersonalLinesWindow;
            }
        }
        
        public UIItemWindow7 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow7(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIOKWindow5 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow5(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIPersonalLinesWindow mUIPersonalLinesWindow;
        
        private UIItemWindow7 mUIItemWindow;
        
        private UIOKWindow5 mUIOKWindow;
        #endregion
    }
}