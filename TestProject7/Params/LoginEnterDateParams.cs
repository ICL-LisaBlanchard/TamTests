namespace AppliedSystems.Tam.Ui.Tests.Params
{
    using System;
    using System.CodeDom.Compiler;

    /// <summary>
    /// Parameters to be passed into 'LoginEnterDate'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class LoginEnterDateParams
    {

        #region Fields

        public string FullDateText = DateTime.Now.ToString("dd/MM/yyyy");

        public string MonthName = DateTime.Now.ToString("MMMM");

        public string Year = DateTime.Now.ToString("yyyy");
        #endregion
    }
}