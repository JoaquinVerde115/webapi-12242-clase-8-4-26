using Acme.hello.Platform.Generic.Domain.Model.Entities;
using Acme.hello.Platform.Generic.Interfaces.REST.Resources;
namespace Acme.hello.Platform.Generic.Interfaces.REST.Assemblers;
/// <summary>
/// Assembler class to convert a Developer entity into a GreatDeveloperResponse
/// </summary>
public static class GreatDeveloperAssembler
{
    /// <summary>
    /// Converts a developer entity into a GreatDeveloperResponse.
    /// Returns an anonymous gretting 
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static GreatDeveloperResponse ToResponseFromEntity(Developer? entity)
    {
        if (entity == null || entity.IsAnyNameEmpty())
            return new GreatDeveloperResponse("Welcome, anonymous ASP.NET developer!");
        return new GreatDeveloperResponse(entity.Id, entity.GetFullName(),
            $"Hello, {entity.GetFullName()}! Your are an ASP.NET Developer");
    }
}