using Tips.Website3.Core.ContributorAggregate;

namespace Tips.Website3.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
