using Microsoft.Office.Interop.Word;
using System.Runtime.InteropServices;

namespace AppliedSystems.Tam.Ui.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class Documents
    {
        public void CheckWordDoc(string fileName, double premium, double originalPremium)
        {
            BaseUiTest.CloseProcess("letter32");
            BaseUiTest.CloseProcess("WINWORD");

            var application = new Application();
            var document = application.Documents.Open(fileName);

            var body = document.Content.Text;

            var b = false;
            b = body.Contains(premium.ToString()) || body.Contains((premium - 0.01).ToString()) || body.Contains((premium + 0.01).ToString());
            if(!b)
            {
                b = body.Contains(originalPremium.ToString()) || body.Contains((originalPremium - 0.01).ToString()) || body.Contains((originalPremium + 0.01).ToString());
           
            }


            Assert.IsTrue(b, "Body does not contain premium " + premium + ": " + body);
            Marshal.ReleaseComObject(document);

            application.Quit();

            BaseUiTest.CloseProcess("letter32");
            BaseUiTest.CloseProcess("WINWORD");
        }
    }
}
