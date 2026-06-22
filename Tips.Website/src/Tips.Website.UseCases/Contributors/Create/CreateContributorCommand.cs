using Tips.Website.Core.ContributorAggregate;

namespace Tips.Website.UseCases.Contributors.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateContributorCommand(ContributorName Name, string? PhoneNumber) : ICommand<Result<ContributorId>>;
