using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public record EmailViewModel
{
    public string From { get; set; }
    public bool IsBodyHtml { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string To { get; set; }

    public string SmtpServer { get; set; }
    public int Port { get; set; }
    public string DisplayName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public bool EnableSSL { get; set; }
}
