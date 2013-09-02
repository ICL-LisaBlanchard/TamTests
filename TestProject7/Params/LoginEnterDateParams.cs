namespace AppliedSystems.Tam.Ui.Tests.Params
{
    using System;

    /// <summary>
    /// Parameters to be passed into 'LoginEnterDate'
    /// </summary>
    public class LoginEnterDateParams
    {
        #region Fields

        public string FullDateText = DateTime.Now.ToString("dd/MM/yyyy");

        public string MonthName = DateTime.Now.ToString("MMMM");

        public string Year = DateTime.Now.ToString("yyyy");

        #endregion
    }
}