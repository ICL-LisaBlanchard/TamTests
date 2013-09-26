namespace AppliedSystems.Tam.Ui.Tests.UIElements
{
    using System;

    using Microsoft.VisualStudio.TestTools.UITesting;

    public class UIIEPolicyDocumentWindow : BrowserWindow
    {
        public UIIEPolicyDocumentWindow()
        {
            #region Search Criteria

            SearchProperties.Add(new PropertyExpression(PropertyNames.Name, "Quote", PropertyExpressionOperator.Contains));

            SearchProperties[PropertyNames.ClassName] = "IEFrame";
            //WindowTitles.Add("\\HHQuote.htm");

            #endregion
        }

        public void LaunchUrl(Uri url)
        {
            CopyFrom(Launch(url));
        }

        #region Properties

        public UIFileCUsersLisaBlanchDocument UIFileCUsersLisaBlanchDocument
        {
            get
            {
                if ((mUIFileCUsersLisaBlanchDocument == null))
                {
                    mUIFileCUsersLisaBlanchDocument = new UIFileCUsersLisaBlanchDocument(this);
                }
                return mUIFileCUsersLisaBlanchDocument;
            }
        }

        #endregion

        #region Fields

        private UIFileCUsersLisaBlanchDocument mUIFileCUsersLisaBlanchDocument;

        #endregion
    }
}