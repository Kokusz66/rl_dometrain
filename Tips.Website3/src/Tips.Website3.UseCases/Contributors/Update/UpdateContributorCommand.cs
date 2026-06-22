using Tips.Website3.Core.ContributorAggregate;

namespace Tips.Website3.UseCases.Contributors.Update;

public record UpdateContributorCommand(ContributorId ContributorId, ContributorName NewName) : ICommand<Result<ContributorDto>>;
