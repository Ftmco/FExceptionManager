using FTeam.Middlewar.Models;

namespace FTeam.Middlewar.StaticVarables
{
    /// <summary>
    /// Static Properties Class
    /// </summary>
    public class StaticVariables
    {
        /// <summary>
        /// Error Handelign Path To Redirect App
        /// </summary>
        public static string ErrorHandeligPath { get; set; }

        /// <summary>
        /// FTServerEmailOptions 
        /// </summary>
        public static FTServerEmailOptions FTServerEmailOptions { get; set; }

        /// <summary>
        /// FTExceptionHandlerOptions
        /// </summary>
        public static FTExceptionHandlerOptions FTExceptionHandlerOptions { get; set; }
    }

    public class StaticVariablesApi
    {
        /// <summary>
        /// Error Handelign Path To Redirect App
        /// </summary>
        public static string ErrorHandeligPathApi { get; set; }

        /// <summary>
        /// FTServerEmailOptions 
        /// </summary>
        public static FTServerEmailOptions FTServerEmailOptionsApi { get; set; }

        /// <summary>
        /// FTExceptionHandlerOptions
        /// </summary>
        public static FTExceptionHandlerOptions FTExceptionHandlerOptionsApi { get; set; }
    }
}
