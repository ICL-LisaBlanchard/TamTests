namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System.CodeDom.Compiler;

    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIDriverDetailsWindow : WinWindow
    {
        
        public UIDriverDetailsWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Driver Details";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "ThunderRT6FormDC";
            this.WindowTitles.Add("Driver Details");
            #endregion
        }
        
        #region Properties
        public UIItemWindow9 UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow9(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow14 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow14(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow23 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow23(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIOKWindow10 UIOKWindow
        {
            get
            {
                if ((this.mUIOKWindow == null))
                {
                    this.mUIOKWindow = new UIOKWindow10(this);
                }
                return this.mUIOKWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow9 mUIItemWindow;
        
        private UIItemWindow14 mUIItemWindow1;
        
        private UIItemWindow23 mUIItemWindow2;
        
        private UIOKWindow10 mUIOKWindow;
        #endregion
    }
}