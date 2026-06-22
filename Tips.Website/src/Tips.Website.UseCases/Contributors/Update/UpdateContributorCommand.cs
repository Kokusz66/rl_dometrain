using Tips.Website.Core.ContributorAggregate;

namespace Tips.Website.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
