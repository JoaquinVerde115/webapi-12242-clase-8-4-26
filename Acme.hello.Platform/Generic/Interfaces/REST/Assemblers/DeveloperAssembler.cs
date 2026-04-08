using Acme.hello.Platform.Generic.Domain.Model.Entities;
using Acme.hello.Platform.Generic.Interfaces.REST.Resources;

namespace Acme.hello.Platform.Generic.Interfaces.REST.Assemblers;
/// <summary>
/// Converts a GreatDeveloperRequest into a Developer Entity
/// </summary>
public static class DeveloperAssembler
{
    public static Developer? ToEntityFromRequest(GreatDeveloperRequest? request)
    {
        if (request == null 
            || string.IsNullOrWhiteSpace(request.FirstName) 
            || string.IsNullOrWhiteSpace(request.LastName))
            return null;
        return new Developer (request.FirstName, request.LastName);
    }
}