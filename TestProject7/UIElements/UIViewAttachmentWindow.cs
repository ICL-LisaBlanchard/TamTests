using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using AppliedSystems.Tam.Ui.Tests.BaseUIElements;

    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

    public class UIViewAttachmentWindow : WinWindow
    {

        public UIViewAttachmentWindow()
        {
            #region Search Criteria
            SearchProperties[UITestControl.PropertyNames.Name] = "View Attachment";
            SearchProperties[UITestControl.PropertyNames.ClassName] = "ThunderRT6FormDC";
            WindowTitles.Add("View Attachment");
            #endregion
        }

        #region Properties
        public UIItemWindow UIOKWindow
        {
            get
            {
                if ((mUIOKWindow == null))
                {
                    mUIOKWindow = new UIItemWindow(this, "2");
                }
                return mUIOKWindow;
            }
        }

        #endregion

        #region Fields
        private UIItemWindow mUIOKWindow;
        #endregion
    }
}
