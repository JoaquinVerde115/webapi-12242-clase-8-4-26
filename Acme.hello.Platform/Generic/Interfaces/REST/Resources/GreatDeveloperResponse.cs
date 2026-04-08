namespace Acme.hello.Platform.Generic.Interfaces.REST.Resources;
/// <summary>
/// A record representing the response for a gretting request
/// </summary>
/// <param name="Id">The unique identifier for the gretting, may be null.</param>
/// <param name="FullName">The full name of the developer, may be null</param>
/// <param name="Message">The gretting message</param>
public record GreatDeveloperResponse(Guid Id, string? FullName, string Message)
{
    /// <summary>
    /// Constructs a response with only a message, used for anonymous grettings.
    /// </summary>
    /// <param name="message">The gretting message</param>
    public GreatDeveloperResponse(string message) : this(Guid.Empty, null, message)
    {
    }
}