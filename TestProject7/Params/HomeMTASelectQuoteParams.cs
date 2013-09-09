﻿namespace AppliedSystems.Tam.Ui.Tests.Params
{
    /// <summary>
    /// Parameters to be passed into 'HomeMTASelectQuote'
    /// </summary>
    public class HomeMTASelectQuoteParams
    {
        #region Fields

        /// <summary>
        /// Type '{Home}' in 'Quotes Results' client
        /// </summary>
        public string SendHomeKeys = "{Home}";

        /// <summary>
        /// Select '&Defer Printing?' check box
        /// </summary>
        public bool UIDeferPrintingCheckBoxChecked = true;

        /// <summary>
        /// Clear 'Add Activity' check box
        /// </summary>
        public bool UIAddActivityCheckBoxChecked = false;

        #endregion
    }
}