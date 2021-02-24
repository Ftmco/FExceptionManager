using System;

/// <summary>
/// Exceptions
/// </summary>
public record Exceptions
{
    public Exceptions()
    {

    }

    /// <summary>
    /// Exception  Id
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Exception Message
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// InnerException Message
    /// </summary>
    public string InnerException { get; set; }

    /// <summary>
    /// Trace Back Exception 
    /// </summary>
    public string TraceBack { get; set; }

    /// <summary>
    /// Date Time
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// Exception Path
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Connection Ip Address
    /// </summary>
    public string RemoteConnectionIpAddress { get; set; }
}