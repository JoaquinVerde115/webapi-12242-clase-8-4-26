namespace Acme.hello.Platform.Generic.Interfaces.REST.Resources;
/// <summary>
/// A record representing a request to great a developer
/// </summary>
/// <param name="FirstName">The developer first name, may be null</param>
/// <param name="LastName">The developer last name, may be null</param>
public record GreatDeveloperRequest(string FirstName, string LastName);