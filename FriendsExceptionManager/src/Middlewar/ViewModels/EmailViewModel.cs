namespace FTeam.Middlewar.Models
{
    /// <summary>
    /// Send Log Email Modell
    /// </summary>
    public record FTSnedEmailModel
    {
        /// <summary>
        /// Send From email  
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Has Email Html
        /// </summary>
        public bool IsBodyHtml { get; set; }

        /// <summary>
        /// Email Subject
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Email Body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Send Email To 
        /// </summary>
        public string To { get; set; }
    }

    /// <summary>
    /// Send Email Options
    /// </summary>
    public record FTServerEmailOptions
    {
        /// <summary>
        /// Send From email  
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Smtp Email 
        /// </summary>
        public string SmtpServer { get; set; }

        /// <summary>
        /// Smtp Email Port
        /// Like 25
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Email Display Name
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Email Username 
        /// Likke Username@exam.com
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Email Password For login
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Enable  SSL For Send Email 
        /// Secure Email
        /// </summary>
        public bool EnableSSL { get; set; }
    }

    /// <summary>
    /// Exception Handler Options
    /// </summary>
    public record FTExceptionHandlerOptions
    {
        /// <summary>
        /// Error Handeling Path To Redirect When Error Occerrud 
        /// </summary>
        public string ErrorHandelingPath { get; set; }

        /// <summary>
        /// Send Email Options 
        /// </summary>
        public FTServerEmailOptions SendEmailOptions { get; set; }
    }

    /// <summary>
    /// Send Email Model
    /// </summary>
    public record EmailModel 
    {
        /// <summary>
        /// Email Content
        /// </summary>
        public FTSnedEmailModel SendEmail { get; set; }

        /// <summary>
        /// Email Server 
        /// </summary>
        public FTServerEmailOptions EmailServerOptions { get; set; }
    }
}
