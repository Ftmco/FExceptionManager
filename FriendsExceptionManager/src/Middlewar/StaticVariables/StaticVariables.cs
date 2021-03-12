using Fteam.Middlewar.Models;

namespace Fteam.Middlewar.StaticVarables
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
}
